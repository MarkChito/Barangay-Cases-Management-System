Imports System.IO
Imports MongoDB.Driver
Imports MongoDB.Bson
Imports BCrypt
Imports MySql.Data.MySqlClient
Imports System.Net.Http
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Module Model
    Public connection As New MySqlConnection
    Public command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public table As New DataTable

    Public ReadOnly online_connection = "https://"
    Public ReadOnly localhost_connection = "http://localhost/"

    ' Change this when connecting online
    Public ReadOnly connection_type = online_connection

    Public url As String = connection_type & "barangaycasesmanagement.ssystem.online/"
    Public primary_key As String = ""

    Public Function MongoDB_Database_Name()
        Dim connectionString As String = "mongodb+srv://admin:admin123@cluster0.aw3fjxd.mongodb.net/?retryWrites=true&w=majority"
        Dim client As New MongoClient(connectionString)
        Dim database_name As IMongoDatabase = client.GetDatabase("barangaycasesmanagement")

        Return database_name
    End Function

    Public Sub Insert_Admin_Data()
        Dim database_name As IMongoDatabase = MongoDB_Database_Name()
        Dim tbl_barangaycasesmanagement_useraccounts As IMongoCollection(Of BsonDocument) = database_name.GetCollection(Of BsonDocument)("tbl_barangaycasesmanagement_useraccounts")
        Dim filter = Builders(Of BsonDocument).Filter.And(Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", "1"))
        Dim existingDocument = tbl_barangaycasesmanagement_useraccounts.Find(filter).FirstOrDefault()

        If existingDocument Is Nothing Then
            Dim password = Password_Hash("admin123")

            Dim admin_data As New BsonDocument From {
                    {"_id", ObjectId.GenerateNewId()},
                    {"primary_key", "1"},
                    {"rfid_number", "12345"},
                    {"first_name", "Super"},
                    {"middle_name", ""},
                    {"last_name", "Administrator"},
                    {"position", "Barangay Captain"},
                    {"mobile_number", ""},
                    {"email", ""},
                    {"address", ""},
                    {"username", "admin"},
                    {"password", password.ToString},
                    {"image", "64fc5e92a2bf4_1694260882.jpg"},
                    {"user_type", "admin"}
                }

            tbl_barangaycasesmanagement_useraccounts.InsertOne(admin_data)
        End If
    End Sub

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
            connection.Open()
        Catch ex As Exception
            MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")

            Application.Exit()
        End Try
    End Sub

    Public Sub Database_Close()
        connection.Close()
    End Sub

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
            With Main
                .Show()
                .btn_dashboard.PerformClick()
            End With
        End If
    End Sub

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
                    MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

        Database_Close()

        Return results
    End Function

    Private Function Password_Verify(plainTextPassword As String, storedHashedPassword As String) As Boolean
        Dim fixedHashedPassword As String = storedHashedPassword.Replace("$2y$", "$2a$")

        Return Net.BCrypt.Verify(plainTextPassword, fixedHashedPassword)
    End Function

    Public Function Password_Hash(password As String)
        Dim salt As String = Net.BCrypt.GenerateSalt()
        Dim hashedPassword As String = Net.BCrypt.HashPassword(password, salt)

        Return hashedPassword
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

    Public Sub Update_Account(rfid_number As String, username As String, password As String, primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_barangaycasesmanagement_useraccounts` SET `rfid_number`='" & rfid_number & "', `username`='" & username & "', `password`='" & password & "' WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Dim database As IMongoDatabase = MongoDB_Database_Name()
        Dim tbl_barangaycasesmanagement_useraccounts As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("tbl_barangaycasesmanagement_useraccounts")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("rfid_number", rfid_number).Set(Of String)("username", username).Set(Of String)("password", password)

        tbl_barangaycasesmanagement_useraccounts.UpdateOne(filter, update)

        Database_Close()
    End Sub

    Public Sub Update_Profile_Information(first_name As String, middle_name As String, last_name As String, position As String, mobile_number As String, email As String, address As String, primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_barangaycasesmanagement_useraccounts` SET `first_name`='" & first_name & "', `middle_name`='" & middle_name & "', `last_name`='" & last_name & "', `position`='" & position & "', `mobile_number`='" & mobile_number & "', `email`='" & email & "', `address`='" & address & "' WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Dim database As IMongoDatabase = MongoDB_Database_Name()
        Dim tbl_barangaycasesmanagement_useraccounts As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("tbl_barangaycasesmanagement_useraccounts")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("first_name", first_name).Set(Of String)("middle_name", middle_name).Set(Of String)("last_name", last_name).Set(Of String)("position", position).Set(Of String)("mobile_number", mobile_number).Set(Of String)("email", email).Set(Of String)("address", address)

        tbl_barangaycasesmanagement_useraccounts.UpdateOne(filter, update)

        Database_Close()
    End Sub
End Module
