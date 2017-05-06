Option Explicit On
Option Strict On

'Name: Nguyen Thanh Trung
' Description: Class to control all data for Invoice Form
' Author:      Nguyen Thanh Trung
' Date:        26/04/2017

Imports System.Data.OleDb
Imports System.IO

Public Class InvoiceDataController
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RoomReservationDB.accdb"

    Public Sub insertInvoice(ByRef htData2 As Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)


        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
               "INSERT INTO invoice (booking_id, invoice_date, amount) VALUES (?, ?, ?);"

            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 10)
            oCommand.Parameters.Add("invoice_date", OleDbType.Date, 20)
            oCommand.Parameters.Add("amount", OleDbType.Integer, 20)
           

            oCommand.Parameters("booking_id").Value = CInt(htData2("booking_id"))
            oCommand.Parameters("invoice_date").Value = CDate(htData2("invoice_date"))
            oCommand.Parameters("amount").Value = CInt(htData2("amount"))
            


            oCommand.Prepare()




            Debug.Print("SQL: " & oCommand.CommandText)

            oCommand.ExecuteNonQuery()

            Debug.Print("The Invoice record was inserted.")
            MsgBox("The  Invoice record was inserted")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occured. The Invoice record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try





    End Sub
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

            Debug.Print("The Booking ID records were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The Booking ID records could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function
    Public Function showAmount(ByVal book_id As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
                    "SELECT total_price FROM booking WHERE booking_id = ? ORDER BY booking_id;"
            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 10)
            oCommand.Parameters("booking_id").Value = CInt(book_id)
            oCommand.Prepare()

            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("total_price") = CInt(oDataReader("total_price"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("The Amount were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function
    Public Function findAllInvoice() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection


            oCommand.CommandText = _
                    "SELECT * FROM invoice ORDER BY booking_id;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim InvoiceData As Hashtable

            Do While oDataReader.Read() = True
                InvoiceData = New Hashtable
                InvoiceData("booking_id") = CInt(oDataReader("booking_id"))
                InvoiceData("invoice_date") = CDate(oDataReader("invoice_date"))
                InvoiceData("amount") = CInt(oDataReader("amount"))
                lsData.Add(InvoiceData)
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
