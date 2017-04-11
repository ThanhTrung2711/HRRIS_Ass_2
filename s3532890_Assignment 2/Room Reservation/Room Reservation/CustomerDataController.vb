Option Explicit On
Option Strict On

'Name: Nguyen Thanh Trung
' Description: Class to control all data for Customer Form
' Author:      Nguyen Thanh Trung
' Date:        11/04/2017

Imports System.Data.OleDb
Imports System.IO
Public Class CustomerDataController
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
    Public Function findByCusId(ByVal sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
                "SELECT * FROM customer WHERE customer_id = ?;"
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 8)
            oCommand.Parameters("customer_id").Value = CInt(sId)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("customer_id") = CInt(oDataReader("customer_id"))
                htTempData("title") = CStr(oDataReader("title"))
                htTempData("gender") = CStr(oDataReader("gender"))
                htTempData("firstname") = CStr(oDataReader("firstname"))
                htTempData("lastname") = CStr(oDataReader("lastname"))
                htTempData("phone") = CInt(oDataReader("phone"))
                htTempData("address") = CStr(oDataReader("address"))
                htTempData("email") = CStr(oDataReader("email"))
                htTempData("dob") = CDate(oDataReader("dob"))
                lsData.Add(htTempData)
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
