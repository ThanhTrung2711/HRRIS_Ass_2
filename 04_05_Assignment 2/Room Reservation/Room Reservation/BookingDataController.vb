Option Explicit On
Option Strict On

'Name: Nguyen Thanh Trung
' Description: Class to control all data for Booking Form
' Author:      Nguyen Thanh Trung
' Date:        11/04/2017
' Subject name: ISYS2116 –Information Systems Solutions and Design
' Semester 1 of 2017
' Tutor: Mr.Ashish Das

Imports System.Data.OleDb
Imports System.IO
Public Class BookingDataController
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RoomReservationDB.accdb"

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
   
    

    Public Function findByBookId(ByVal sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
                "SELECT * FROM booking WHERE booking_id = ?;"
            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 8)
            oCommand.Parameters("booking_id").Value = CInt(sId)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData2 As Hashtable
            Do While oDataReader.Read() = True
                htTempData2 = New Hashtable
                htTempData2("booking_id") = CInt(oDataReader("booking_id"))
                htTempData2("booking_date") = CDate(oDataReader("booking_date"))
                htTempData2("room_id") = CInt(oDataReader("room_id"))
                htTempData2("customer_id") = CInt(oDataReader("customer_id"))
                htTempData2("num_days") = CInt(oDataReader("num_days"))
                htTempData2("num_guests") = CInt(oDataReader("num_guests"))
                htTempData2("checkin_date") = CDate(oDataReader("checkin_date"))
                htTempData2("total_price") = CInt(oDataReader("total_price"))
                htTempData2("comments") = CStr(oDataReader("comments"))
                lsData.Add(htTempData2)
            Loop

            Debug.Print("The record was found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("The record(s) could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function
    Public Function updateBookId(ByVal htData1 As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
                "UPDATE booking SET booking_date = ?, room_id = ?, customer_id = ?, num_days = ?, num_guests = ?, checkin_date = ?, total_price = ?, comments = ? WHERE booking_id = ?;"

            oCommand.Parameters.Add("booking_date", OleDbType.Date, 10)
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 20)
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 20)
            oCommand.Parameters.Add("num_days", OleDbType.Integer, 20)
            oCommand.Parameters.Add("num_guests", OleDbType.Integer, 20)
            oCommand.Parameters.Add("checkin_date", OleDbType.Date, 20)
            oCommand.Parameters.Add("total_price", OleDbType.Currency, 30)
            oCommand.Parameters.Add("comments", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 10)

            oCommand.Parameters("booking_date").Value = CDate(htData1("booking_date"))
            oCommand.Parameters("room_id").Value = CInt(htData1("room_id"))
            oCommand.Parameters("customer_id").Value = CInt(htData1("customer_id"))
            oCommand.Parameters("num_days").Value = CInt(htData1("num_days"))
            oCommand.Parameters("num_guests").Value = CInt(htData1("num_guests"))
            oCommand.Parameters("checkin_date").Value = CDate(htData1("checkin_date"))
            oCommand.Parameters("total_price").Value = CInt(htData1("total_price"))
            oCommand.Parameters("comments").Value = CStr(htData1("comments"))
            oCommand.Parameters("booking_id").Value = CInt(htData1("booking_id"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was updated.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The record was not updated!")
        Finally
            oConnection.Close()
        End Try

        Return iNumRows
    End Function
    Public Function deleteBooking(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
             "DELETE FROM booking WHERE booking_id = ?;"
            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 10)
            oCommand.Parameters("booking_id").Value = CInt(sId)

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was deleted.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("You cannot delete because the invoice has been generated!")
        Finally
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    Public Function findAllBookId() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection


            oCommand.CommandText = _
                    "SELECT * FROM booking ORDER BY booking_id;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim BookingData As Hashtable

            Do While oDataReader.Read() = True
                BookingData = New Hashtable
                BookingData("booking_id") = CInt(oDataReader("booking_id"))
                BookingData("booking_date") = CDate(oDataReader("booking_date"))
                BookingData("room_id") = CInt(oDataReader("room_id"))
                BookingData("customer_id") = CInt(oDataReader("customer_id"))
                BookingData("num_days") = CInt(oDataReader("num_days"))
                BookingData("num_guests") = CInt(oDataReader("num_guests"))
                BookingData("checkin_date") = CDate(oDataReader("checkin_date"))
                BookingData("total_price") = CInt(oDataReader("total_price"))
                BookingData("comments") = CStr(oDataReader("comments"))
                lsData.Add(BookingData)
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
