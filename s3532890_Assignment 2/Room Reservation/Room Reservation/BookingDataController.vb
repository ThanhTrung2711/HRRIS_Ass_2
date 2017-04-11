Option Explicit On
Option Strict On

'Name: Nguyen Thanh Trung
' Description: Class to control all data for Booking Form
' Author:      Nguyen Thanh Trung
' Date:        11/04/2017

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
                htTempData2("date") = CStr(oDataReader("date"))
                htTempData2("room_id") = CStr(oDataReader("room_id"))
                htTempData2("customer_id") = CStr(oDataReader("customer_id"))
                htTempData2("num_days") = CStr(oDataReader("num_days"))
                htTempData2("num_guests") = CInt(oDataReader("num_guests"))
                htTempData2("checkin_date") = CStr(oDataReader("checkin_date"))
                htTempData2("total_price") = CStr(oDataReader("total_price"))
                htTempData2("comments") = CDate(oDataReader("comments"))
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
End Class
