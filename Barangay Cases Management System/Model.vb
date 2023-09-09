Imports System.IO
Imports System.Net
Imports MongoDB.Driver
Imports MongoDB.Bson
Imports BCrypt
Imports MySql.Data.MySqlClient
Imports MongoDB.Driver.Core.Configuration

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

    Private Function MongoDB_Database_Name()
        Dim connectionString As String = "mongodb+srv://admin:admin123@cluster0.aw3fjxd.mongodb.net/?retryWrites=true&w=majority"
        Dim client As New MongoClient(connectionString)

        Dim database_name As IMongoDatabase = client.GetDatabase("barangaycasesmanagement")

        Return database_name
    End Function

    Public Sub Database_Open()
        ' Database Configuration
        Dim localhost_server = "localhost"
        Dim online_server = "184.168.101.160"
        Dim server = ""

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

    Public Function Authenticate(username As String, password As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""
        Dim db_password = ""

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

        Return results
    End Function

    Public Function RFID_Authenticate(rfid_number As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_rfid_number = ""

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

        Return results
    End Function

    Public Sub Load_All_Images()
        Dim result = Get_All_User_Data()
        Dim result_2 = Get_All_Citizen_Data()
        Dim result_3 = Get_All_News_Data()
        Dim result_4 = Get_All_Cases_Data()

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

    Private Function Get_All_User_Data()
        Dim results As New Dictionary(Of String, String)()
        Dim webClient As New WebClient()

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
            Else
                user_image = row("image")
            End If

            Dim imageUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/dist/img/user_upload/" & user_image
            Dim localImagePath As String = "dist/img/user_upload/" & user_image

            If Not File.Exists(localImagePath) Then
                Try
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

                    webClient.DownloadFile(imageUrl, localImagePath)
                Catch ex As Exception
                    MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")

                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

        Return results
    End Function

    Private Function Get_All_Citizen_Data()
        Dim results As New Dictionary(Of String, String)()
        Dim webClient As New WebClient()

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
            Else
                user_image = row("image")
            End If

            Dim imageUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/dist/img/user_upload/" & user_image
            Dim localImagePath As String = "dist/img/user_upload/" & user_image

            If Not File.Exists(localImagePath) Then
                Try
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

                    webClient.DownloadFile(imageUrl, localImagePath)
                Catch ex As Exception
                    MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")

                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

        Return results
    End Function

    Private Function Get_All_News_Data()
        Dim results As New Dictionary(Of String, String)()
        Dim webClient As New WebClient()

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
            Else
                user_image = row("image")
            End If

            Dim imageUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/dist/img/user_upload/" & user_image
            Dim localImagePath As String = "dist/img/user_upload/" & user_image

            If Not File.Exists(localImagePath) Then
                Try
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

                    webClient.DownloadFile(imageUrl, localImagePath)
                Catch ex As Exception
                    MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")

                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

        Return results
    End Function

    Private Function Get_All_Cases_Data()
        Dim results As New Dictionary(Of String, String)()
        Dim webClient As New WebClient()

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
            Else
                user_image = row("image")
            End If

            Dim imageUrl As String = connection_type & "barangaycasesmanagement.ssystem.online/dist/img/user_upload/" & user_image
            Dim localImagePath As String = "dist/img/user_upload/" & user_image

            If Not File.Exists(localImagePath) Then
                Try
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

                    webClient.DownloadFile(imageUrl, localImagePath)
                Catch ex As Exception
                    MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")

                    Application.Exit()
                End Try
            End If
        Next

        results.Add("response_code", 200)

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

        Return results
    End Function

    Public Sub Update_Account(username As String, password As String, primary_key As String)
        With command
            .CommandText = "UPDATE `tbl_barangaycasesmanagement_useraccounts` SET `username`='" & username & "', `password`='" & password & "' WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With
    End Sub
End Module
