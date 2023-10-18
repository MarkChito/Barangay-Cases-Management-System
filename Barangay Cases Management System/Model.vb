Imports System.IO
Imports MongoDB.Driver
Imports MongoDB.Bson
Imports BCrypt
Imports MySql.Data.MySqlClient
Imports System.Net.Http
Imports System.Net

Module Model
    Public connection As New MySqlConnection
    Public command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public table As New DataTable

    Public host_name As String = Dns.GetHostName()
    Public host_entry As IPHostEntry = Dns.GetHostEntry(host_name)
    Public ip_address As IPAddress = host_entry.AddressList(host_entry.AddressList.Length - 1)

    Public online_connection As String = "https://"
    Public offline_connection As String = "http://" & ip_address.ToString() & "/"
    'Public offline_connection As String = "http://localhost/"

    ' CHANGE THIS WHEN CONNECTING ONLINE
    Public ReadOnly connection_type = offline_connection

    Public url As String = connection_type & "barangaycasesmanagement.ssystem.online/"
    Public primary_key As String = ""
    Public is_edit_pending_case As Boolean = False

    Private tbl_barangaycasesmanagement_announcements As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_barangaycasesmanagement_announcements")
    Private tbl_barangaycasesmanagement_barangaycases As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_barangaycasesmanagement_barangaycases")
    Private tbl_barangaycasesmanagement_barangaynews As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_barangaycasesmanagement_barangaynews")
    Private tbl_barangaycasesmanagement_citizens As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_barangaycasesmanagement_citizens")
    Private tbl_barangaycasesmanagement_useraccounts As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_barangaycasesmanagement_useraccounts")

    '====================== MongoDB Functions ======================
    Public Function MongoDB_Database_Name()
        Dim online_connectionString As String = "mongodb+srv://admin:admin123@cluster0.aw3fjxd.mongodb.net"
        Dim offline_connectionString As String = "mongodb://localhost:27017"
        Dim connectionString As String

        If connection_type = online_connection Then
            connectionString = online_connectionString
        Else
            connectionString = offline_connectionString
        End If

        Dim client As New MongoClient(connectionString)
        Dim database_name As IMongoDatabase = client.GetDatabase("barangaycasesmanagement")

        Return database_name
    End Function

    Public Function MongoDB_Table_Name(string_table_name As String)
        Dim database_name As IMongoDatabase = MongoDB_Database_Name()
        Dim table_name As IMongoCollection(Of BsonDocument) = database_name.GetCollection(Of BsonDocument)(string_table_name)

        Return table_name
    End Function

    Public Sub MongoDB_Initialize()
        Dim filter = Builders(Of BsonDocument).Filter.And(Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", "1"))
        Dim existingDocument = tbl_barangaycasesmanagement_useraccounts.Find(filter).FirstOrDefault()

        If existingDocument Is Nothing Then
            Dim password = Password_Hash("admin123")

            Dim admin_data As New BsonDocument From {
                    {"_id", ObjectId.GenerateNewId()},
                    {"primary_key", "1"},
                    {"rfid_number", ""},
                    {"first_name", "Super"},
                    {"middle_name", ""},
                    {"last_name", "Administrator"},
                    {"position", "Barangay Captain"},
                    {"mobile_number", ""},
                    {"email", ""},
                    {"address", ""},
                    {"username", "admin"},
                    {"password", password.ToString},
                    {"image", "default_user_image.png"},
                    {"user_type", "admin"}
                }

            tbl_barangaycasesmanagement_useraccounts.InsertOne(admin_data)
        End If
    End Sub

    '====================== MySQL Functions ======================
    Public Sub Database_Open()
        ' Database Configuration
        Dim localhost_server = "localhost"
        Dim online_server = "184.168.101.160"
        Dim server As String

        If connection_type = online_connection Then
            server = online_server
        Else
            server = localhost_server
        End If

        Dim port = ""
        Dim username = "all_system_user"
        Dim password = "admin123"
        Dim database = "all_system_database"

        ' Optional Parameters
        Dim pooling = "true"
        Dim connection_timeout = "1000"
        Dim old_guids = "true"

        connection.ConnectionString =
            "server=" & server & ";" &
            "port=" & port & ";" &
            "username=" & username & ";" &
            "password=" & password & ";" &
            "database=" & database & ";" &
            "pooling=" & pooling & ";" &
            "connect timeout=" & connection_timeout & ";" &
            "old guids=" & old_guids & ";"
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            Splash_Screen.Timer1.Stop()

            If connection_type = online_connection Then
                MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
            Else
                MsgBox("Please run Apache and MySQL connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
            End If

            Splash_Screen.Close()

            Application.Exit()
        End Try
    End Sub

    Public Sub Database_Close()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Public Sub Initialize()
        MongoDB_Initialize()
        Database_Open()
        Database_Close()

        With Splash_Screen
            .Timer1.Stop()
            .Hide()
        End With

        Login.Show()
    End Sub

    '====================== Select Queries ======================
    Public Function Authenticate(username As String, password As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""
        Dim db_password = ""

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `username`='" & username & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            db_username = row("username").ToString()
            db_password = row("password").ToString()
        Next

        If db_username = username Then
            Dim isPasswordValid As Boolean = Password_Verify(password, db_password)

            If isPasswordValid Then
                For Each row As DataRow In table.Rows
                    results.Add("response_code", 200)
                    results.Add("primary_key", row("primary_key").ToString())
                Next
            Else
                results.Add("response_code", 404)
            End If
        Else
            results.Add("response_code", 404)
        End If

        Database_Close()

        Return results
    End Function

    Public Function RFID_Authenticate(rfid_number As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_rfid_number = ""

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `rfid_number`='" & rfid_number & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            db_rfid_number = row("rfid_number").ToString()
        Next

        If db_rfid_number = rfid_number Then
            For Each row As DataRow In table.Rows
                results.Add("response_code", 200)
                results.Add("primary_key", row("primary_key").ToString())
            Next
        Else
            results.Add("response_code", 404)
        End If

        Database_Close()

        Return results
    End Function

    Private Async Function Get_All_User_Data() As Task(Of Dictionary(Of String, String))
        Dim results As New Dictionary(Of String, String)()
        Dim httpClient As New HttpClient()

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            Dim user_image = row("image").ToString()

            If String.IsNullOrWhiteSpace(user_image) Then
                user_image = "default_user_image.png"
            End If

            Dim imageUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/dist/img/user_upload/" & user_image
            Dim localImagePath As String = "dist/img/user_upload/" & user_image

            If Not File.Exists(localImagePath) Then
                Try
                    Dim imageBytes As Byte() = Await httpClient.GetByteArrayAsync(imageUrl)
                    File.WriteAllBytes(localImagePath, imageBytes)
                Catch ex As Exception
                    MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

        Database_Close()

        Return results
    End Function

    Private Async Function Get_All_Citizen_Data() As Task(Of Dictionary(Of String, String))
        Dim results As New Dictionary(Of String, String)()
        Dim httpClient As New HttpClient()

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_citizens` ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            Dim user_image = row("image").ToString()

            If String.IsNullOrWhiteSpace(user_image) Then
                user_image = "default_user_image.png"
            End If

            Dim imageUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/dist/img/user_upload/" & user_image
            Dim localImagePath As String = "dist/img/user_upload/" & user_image

            If Not File.Exists(localImagePath) Then
                Try
                    Dim imageBytes As Byte() = Await httpClient.GetByteArrayAsync(imageUrl)
                    File.WriteAllBytes(localImagePath, imageBytes)
                Catch ex As Exception
                    MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

        Database_Close()

        Return results
    End Function

    Private Async Function Get_All_News_Data() As Task(Of Dictionary(Of String, String))
        Dim results As New Dictionary(Of String, String)()
        Dim httpClient As New HttpClient()

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_barangaynews` ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            Dim user_image = row("image").ToString()

            If String.IsNullOrWhiteSpace(user_image) Then
                user_image = "default_user_image.png"
            End If

            Dim imageUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/dist/img/user_upload/" & user_image
            Dim localImagePath As String = "dist/img/user_upload/" & user_image

            If Not File.Exists(localImagePath) Then
                Try
                    Dim imageBytes As Byte() = Await httpClient.GetByteArrayAsync(imageUrl)
                    File.WriteAllBytes(localImagePath, imageBytes)
                Catch ex As Exception
                    MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

        Database_Close()

        Return results
    End Function

    Private Async Function Get_All_Cases_Data() As Task(Of Dictionary(Of String, String))
        Dim results As New Dictionary(Of String, String)()
        Dim httpClient As New HttpClient()

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_barangaycases` ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            Dim user_image = row("image").ToString()

            If String.IsNullOrWhiteSpace(user_image) Then
                user_image = "default_user_image.png"
            End If

            Dim imageUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/dist/img/user_upload/" & user_image
            Dim localImagePath As String = "dist/img/user_upload/" & user_image

            If Not File.Exists(localImagePath) Then
                Try
                    Dim imageBytes As Byte() = Await httpClient.GetByteArrayAsync(imageUrl)
                    File.WriteAllBytes(localImagePath, imageBytes)
                Catch ex As Exception
                    'MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
                    MsgBox(ex.ToString(), MsgBoxStyle.Critical, "Connection Failed")

                    Login.Close()
                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

        Database_Close()

        Return results
    End Function

    Public Function Get_User_Data(primary_key As String)
        Dim results As New Dictionary(Of String, String)()

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            results.Add("primary_key", row("primary_key").ToString())
            results.Add("rfid_number", row("rfid_number").ToString())
            results.Add("first_name", row("first_name").ToString())
            results.Add("middle_name", row("middle_name").ToString())
            results.Add("last_name", row("last_name").ToString())
            results.Add("mobile_number", row("mobile_number").ToString())
            results.Add("email", row("email").ToString())
            results.Add("address", row("address").ToString())
            results.Add("position", row("position").ToString())
            results.Add("username", row("username").ToString())
            results.Add("password", row("password").ToString())
            results.Add("image", row("image").ToString())
            results.Add("user_type", row("user_type").ToString())
        Next

        Database_Close()

        Return results
    End Function

    Public Function Get_Employee_Data(primary_key As String)
        Dim results As New DataTable

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `primary_key`!='" & primary_key & "' ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        results = table

        Database_Close()

        Return results
    End Function

    Public Function Get_Pending_Cases_Data()
        Dim results As New DataTable

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_barangaycases` WHERE `status`='1' ORDER BY `date` DESC , `time` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        results = table

        Database_Close()

        Return results
    End Function

    Public Function Get_Barangay_Cases_Data()
        Dim results As New DataTable

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_barangaycases` WHERE `status`='0' OR `status`='4' ORDER BY `date` DESC , `time` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        results = table

        Database_Close()

        Return results
    End Function

    Public Function Get_Barangay_News_Data()
        Dim results As New DataTable

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_barangaynews` ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        results = table

        Database_Close()

        Return results
    End Function

    Public Function Get_Search_Barangay_News_Data(inputted_data As String)
        Dim results As New DataTable

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_barangaynews` WHERE `title` LIKE '%" & inputted_data & "%' OR `body` LIKE '%" & inputted_data & "%' ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        results = table

        Database_Close()

        Return results
    End Function

    Public Function Get_Announcements_Data()
        Dim results As New DataTable

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_announcements` ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        results = table

        Database_Close()

        Return results
    End Function

    Public Function Get_Search_Announcements_Data(inputted_data As String)
        Dim results As New DataTable

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_announcements` WHERE `title` LIKE '%" & inputted_data & "%' OR `body` LIKE '%" & inputted_data & "%' ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        results = table

        Database_Close()

        Return results
    End Function

    Public Async Sub Load_All_Images()
        Dim result = Await Get_All_User_Data()
        Dim result_2 = Await Get_All_Citizen_Data()
        Dim result_3 = Await Get_All_News_Data()
        Dim result_4 = Await Get_All_Cases_Data()

        Dim response_ok As Integer = 0

        If result("response_code") = 200 Then
            response_ok += 1
        End If

        If result_2("response_code") = 200 Then
            response_ok += 1
        End If

        If result_3("response_code") = 200 Then
            response_ok += 1
        End If

        If result_4("response_code") = 200 Then
            response_ok += 1
        End If

        If response_ok = 4 Then
            With Login
                .Hide()
                .Timer1.Stop()
            End With

            With RFID_Login
                .img_rfid.Image = Image.FromFile("dist/img/scan_rfid_gif.gif")
                .Close()
            End With

            With Main
                .Show()
                .WindowState = FormWindowState.Maximized
                .Load_User_Data()
                .btn_dashboard.PerformClick()
            End With
        End If
    End Sub

    Public Function Check_Username(username As String, old_username As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `username`='" & username & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            db_username = row("username").ToString()
        Next

        Database_Close()

        If Not old_username = username And db_username = username Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Check_RFID_Number(rfid_number As String, old_rfid_number As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_rfid_number = ""

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `rfid_number`='" & rfid_number & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            db_rfid_number = row("rfid_number").ToString()
        Next

        Database_Close()

        If Not old_rfid_number = rfid_number And db_rfid_number = rfid_number Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Add_Employee_Check_Username(username As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `username`='" & username & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        Dim rowCount As Integer = CInt(command.ExecuteScalar())

        Database_Close()

        If rowCount > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Add_Employee_Check_RFID_Number(rfid_number As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `rfid_number`='" & rfid_number & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        Dim rowCount As Integer = CInt(command.ExecuteScalar())

        Database_Close()

        If rowCount > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    '====================== Insert Queries ======================
    Public Sub Add_An_Employee(first_name As String, middle_name As String, last_name As String, rfid_number As String, position As String, mobile_number As String, email As String, address As String, username As String, password As String, image As String)
        Database_Open()

        password = Password_Hash(password)

        With command
            .CommandText = "INSERT INTO `tbl_barangaycasesmanagement_useraccounts` (`first_name`, `middle_name`, `last_name`, `rfid_number`, `mobile_number`, `email`, `position`, `address`, `username`, `password`, `image`, `user_type`) VALUES ('" & first_name & "', '" & middle_name & "', '" & last_name & "', '" & rfid_number & "', '" & mobile_number & "', '" & email & "', '" & position & "', '" & address & "', '" & username & "', '" & password & "',  '" & image & "',  'user')"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Dim primary_key As String = ""

        table.Clear()

        With command
            .CommandText = "SELECT `primary_key` FROM `tbl_barangaycasesmanagement_useraccounts` WHERE `primary_key` = LAST_INSERT_ID()"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            primary_key = row("primary_key").ToString()
        Next

        Database_Close()

        Dim Document As New BsonDocument() From {
            {"primary_key", primary_key},
            {"first_name", first_name},
            {"middle_name", middle_name},
            {"last_name", last_name},
            {"rfid_number", rfid_number},
            {"mobile_number", mobile_number},
            {"email", email},
            {"position", position},
            {"address", address},
            {"username", username},
            {"password", password},
            {"image", image},
            {"user_type", "user"}
        }

        tbl_barangaycasesmanagement_useraccounts.InsertOne(Document)
    End Sub

    Public Sub Add_An_Announcement(announcement_title As String, announcement_body As String)
        Database_Open()

        Dim date_and_time As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        With command
            .CommandText = "INSERT INTO `tbl_barangaycasesmanagement_announcements` (`date_and_time`, `title`, `body`) VALUES ('" & date_and_time & "', '" & announcement_title & "', '" & announcement_body & "')"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Dim primary_key As String = ""

        table.Clear()

        With command
            .CommandText = "SELECT `primary_key` FROM `tbl_barangaycasesmanagement_announcements` WHERE `primary_key` = LAST_INSERT_ID()"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            primary_key = row("primary_key").ToString()
        Next

        Database_Close()

        Dim Document As New BsonDocument() From {
            {"primary_key", primary_key},
            {"date_and_time", date_and_time},
            {"title", announcement_title},
            {"body", announcement_body}
        }

        tbl_barangaycasesmanagement_announcements.InsertOne(Document)
    End Sub

    Public Sub Add_A_Barangay_News(title As String, body As String, image As String)
        Database_Open()

        Dim current_date As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim current_time As String = DateTime.Now.ToString("HH:mm:ss")

        With command
            .CommandText = "INSERT INTO `tbl_barangaycasesmanagement_barangaynews` (`date`, `time`, `title`, `body`, `image`) VALUES ('" & current_date & "', '" & current_time & "', '" & title & "', '" & body & "', '" & image & "')"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Dim primary_key As String = ""

        table.Clear()

        With command
            .CommandText = "SELECT `primary_key` FROM `tbl_barangaycasesmanagement_barangaynews` WHERE `primary_key` = LAST_INSERT_ID()"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            primary_key = row("primary_key").ToString()
        Next

        Database_Close()

        Dim Document As New BsonDocument() From {
            {"primary_key", primary_key},
            {"date", current_date},
            {"time", current_time},
            {"title", title},
            {"body", body},
            {"image", image}
        }

        tbl_barangaycasesmanagement_barangaynews.InsertOne(Document)
    End Sub

    Public Sub Add_A_Barangay_Case(name As String, mobile_number As String, address As String, nature_of_complaint As String, description As String, image As String)
        Database_Open()

        Dim current_date As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim current_time As String = DateTime.Now.ToString("HH:mm:ss")

        With command
            .CommandText = "INSERT INTO `tbl_barangaycasesmanagement_barangaycases` (`date`, `time`, `name`, `mobile_number`, `address`, `nature_of_complaint`, `description`, `image`) VALUES ('" & current_date & "', '" & current_time & "', '" & name & "', '" & mobile_number & "', '" & address & "', '" & nature_of_complaint & "', '" & description & "', '" & image & "')"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Dim primary_key As String = ""

        table.Clear()

        With command
            .CommandText = "SELECT `primary_key` FROM `tbl_barangaycasesmanagement_barangaycases` WHERE `primary_key` = LAST_INSERT_ID()"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            primary_key = row("primary_key").ToString()
        Next

        Database_Close()

        Dim Document As New BsonDocument() From {
            {"primary_key", primary_key},
            {"date", current_date},
            {"time", current_time},
            {"name", name},
            {"mobile_number", mobile_number},
            {"address", address},
            {"nature_of_complaint", nature_of_complaint},
            {"description", description},
            {"image", image}
        }

        tbl_barangaycasesmanagement_barangaycases.InsertOne(Document)
    End Sub

    '====================== Update Queries ======================
    Public Sub Update_Account(rfid_number As String, username As String, password As String, primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_barangaycasesmanagement_useraccounts` SET `rfid_number`='" & rfid_number & "', `username`='" & username & "', `password`='" & password & "' WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("rfid_number", rfid_number).Set(Of String)("username", username).Set(Of String)("password", password)

        tbl_barangaycasesmanagement_useraccounts.UpdateOne(filter, update)
    End Sub

    Public Sub Update_Profile_Information(first_name As String, middle_name As String, last_name As String, position As String, mobile_number As String, email As String, address As String, image_name As String, primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_barangaycasesmanagement_useraccounts` SET `first_name`='" & first_name & "', `middle_name`='" & middle_name & "', `last_name`='" & last_name & "', `position`='" & position & "', `mobile_number`='" & mobile_number & "', `email`='" & email & "', `address`='" & address & "', `image`='" & image_name & "' WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("first_name", first_name).Set(Of String)("middle_name", middle_name).Set(Of String)("last_name", last_name).Set(Of String)("position", position).Set(Of String)("mobile_number", mobile_number).Set(Of String)("email", email).Set(Of String)("address", address).Set(Of String)("image", image_name)

        tbl_barangaycasesmanagement_useraccounts.UpdateOne(filter, update)
    End Sub

    Public Sub Update_A_Barangay_Case(name As String, mobile_number As String, address As String, nature_of_complaint As String, description As String, image As String, status As String, primary_key As String)
        Database_Open()

        Dim current_date As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim current_time As String = DateTime.Now.ToString("HH:mm:ss")

        With command
            .CommandText = "UPDATE `tbl_barangaycasesmanagement_barangaycases` SET `name` = '" & name & "', `mobile_number` = '" & mobile_number & "', `address` = '" & address & "', `nature_of_complaint` = '" & nature_of_complaint & "', `description` = '" & description & "', `image` = '" & image & "', `status` = '" & status & "' WHERE `primary_key` = '" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("name", name).Set(Of String)("mobile_number", mobile_number).Set(Of String)("address", address).Set(Of String)("nature_of_complaint", nature_of_complaint).Set(Of String)("description", description).Set(Of String)("image", image).Set(Of String)("status", status)

        tbl_barangaycasesmanagement_barangaycases.UpdateOne(filter, update)
    End Sub

    '====================== Password Functions ======================
    Private Function Password_Verify(plainTextPassword As String, storedHashedPassword As String) As Boolean
        Dim fixedHashedPassword As String = storedHashedPassword.Replace("$2y$", "$2a$")

        Return Net.BCrypt.Verify(plainTextPassword, fixedHashedPassword)
    End Function

    Public Function Password_Hash(password As String)
        Dim salt As String = Net.BCrypt.GenerateSalt()
        Dim hashedPassword As String = Net.BCrypt.HashPassword(password, salt)

        Return hashedPassword
    End Function
End Module
