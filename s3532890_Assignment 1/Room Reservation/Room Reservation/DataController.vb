Option Explicit On
Option Strict On

'Name: Nguyen Thanh Trung
' Description: Class to control all data 
' Author:      Nguyen Thanh Trung
' Date:        28/03/2017

Imports System.Data.OleDb
Imports System.IO

Public Class DataController
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RoomReservationDB.accdb"

    Public Sub insertCustomer(ByRef htData As Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)



        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
               "INSERT INTO customer (title, gender , firstname, lastname, phone, address, email, dob) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

            oCommand.Parameters.Add("title", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("gender", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("firstname", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("lastname", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("phone", OleDbType.VarChar, 13)
            oCommand.Parameters.Add("address", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("email", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("dob", OleDbType.Date, 15)

            oCommand.Parameters("title").Value = CStr(htData("title"))
            oCommand.Parameters("gender").Value = CStr(htData("gender"))
            oCommand.Parameters("firstname").Value = CStr(htData("firstname"))
            oCommand.Parameters("lastname").Value = CStr(htData("lastname"))
            oCommand.Parameters("phone").Value = CStr(htData("phone"))
            oCommand.Parameters("address").Value = CStr(htData("address"))
            oCommand.Parameters("email").Value = CStr(htData("email"))
            oCommand.Parameters("dob").Value = CDate(htData("dob"))

            oCommand.Prepare()




            Debug.Print("SQL: " & oCommand.CommandText)

            oCommand.ExecuteNonQuery()

            Debug.Print("The record was inserted.")
            MsgBox("The record was inserted")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occured. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try





    End Sub


    Public Sub insertRoom(ByRef htData1 As Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)



        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
               "INSERT INTO room (room_number , type , price , num_beds, availability , floor, description) VALUES (?, ?, ?, ?, ?, ?, ?);"

            oCommand.Parameters.Add("room_number", OleDbType.Integer, 20)
            oCommand.Parameters.Add("type", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("price", OleDbType.Currency, 20)
            oCommand.Parameters.Add("num_beds", OleDbType.Integer, 20)
            oCommand.Parameters.Add("availability", OleDbType.VarChar, 20)
            oCommand.Parameters.Add("floor", OleDbType.Integer, 20)
            oCommand.Parameters.Add("description", OleDbType.VarChar, 255)

            oCommand.Parameters("room_number").Value = CInt(htData1("room_number"))
            oCommand.Parameters("type").Value = CStr(htData1("type"))
            oCommand.Parameters("price").Value = CInt(htData1("price"))
            oCommand.Parameters("num_beds").Value = CInt(htData1("num_beds"))
            oCommand.Parameters("availability").Value = CStr(htData1("availability"))
            oCommand.Parameters("floor").Value = CInt(htData1("floor"))
            oCommand.Parameters("description").Value = CStr(htData1("description"))


            oCommand.Prepare()




            Debug.Print("SQL: " & oCommand.CommandText)

            oCommand.ExecuteNonQuery()

            Debug.Print("The record was inserted.")
            MsgBox("The record was inserted")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occured. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try





    End Sub

    Public Sub insertBooking(ByRef htData2 As Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
               "INSERT INTO booking (booking_date, room_id, customer_id, num_days , num_guests, checkin_date , total_price , comments) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

            oCommand.Parameters.Add("booking_date", OleDbType.Date, 10)
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 20)
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 20)
            oCommand.Parameters.Add("num_days", OleDbType.Integer, 20)
            oCommand.Parameters.Add("num_guests", OleDbType.Integer, 20)
            oCommand.Parameters.Add("checkin_date", OleDbType.Date, 20)
            oCommand.Parameters.Add("total_price", OleDbType.Currency, 30)
            oCommand.Parameters.Add("comments", OleDbType.VarChar, 255)

            oCommand.Parameters("booking_date").Value = CDate(htData2("booking_date"))
            oCommand.Parameters("room_id").Value = CInt(htData2("room_id"))
            oCommand.Parameters("customer_id").Value = CInt(htData2("customer_id"))
            oCommand.Parameters("num_days").Value = CInt(htData2("num_days"))
            oCommand.Parameters("num_guests").Value = CInt(htData2("num_guests"))
            oCommand.Parameters("checkin_date").Value = CDate(htData2("checkin_date"))
            oCommand.Parameters("total_price").Value = CInt(htData2("total_price"))
            oCommand.Parameters("comments").Value = CStr(htData2("comments"))


            oCommand.Prepare()




            Debug.Print("SQL: " & oCommand.CommandText)

            oCommand.ExecuteNonQuery()

            Debug.Print("The record was inserted.")
            MsgBox("The record was inserted")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occured. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try





    End Sub

    Public Function findAll() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
                    "SELECT * FROM room ORDER BY room_id;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("room_number") = CInt(oDataReader("room_number"))
                htTempData("type") = CStr(oDataReader("type"))
                htTempData("price") = CStr(oDataReader("price"))
                htTempData("num_beds") = CInt(oDataReader("num_beds"))
                htTempData("availability") = CStr(oDataReader("availability"))
                htTempData("description") = CStr(oDataReader("description"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("The records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function



    



End Class
