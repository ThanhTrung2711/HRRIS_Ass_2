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
    ''' <summary>
    ''' Find customer by their ids, each record must have data then function will run  
    ''' </summary>
    ''' <param name="sId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
                htTempData("phone") = CStr(oDataReader("phone"))
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
    ''' <summary>
    ''' This function will read customer_id in customer table then display in Booking form as dropdown list
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function findAllCusId() As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection


            oCommand.CommandText = _
                    "SELECT * FROM customer ORDER BY customer_id;"
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
                htTempData("phone") = CStr(oDataReader("phone"))
                htTempData("address") = CStr(oDataReader("address"))
                htTempData("email") = CStr(oDataReader("email"))
                htTempData("dob") = CDate(oDataReader("dob"))
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
    ''' <summary>
    ''' This function will update the record of customer by using "Find" button following each specific id 
    ''' </summary>
    ''' <param name="htData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function updateCusId(ByVal htData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
                "UPDATE customer SET title = ?, gender = ?, firstname = ?, lastname = ?, phone = ?, address = ?, email = ?, dob = ? WHERE customer_id = ?;"

            oCommand.Parameters.Add("title", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("gender", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("firstname", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("lastname", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("phone", OleDbType.VarChar, 13)
            oCommand.Parameters.Add("address", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("email", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("dob", OleDbType.Date, 15)
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 10)


            oCommand.Parameters("title").Value = CStr(htData("title"))
            oCommand.Parameters("gender").Value = CStr(htData("gender"))
            oCommand.Parameters("firstname").Value = CStr(htData("firstname"))
            oCommand.Parameters("lastname").Value = CStr(htData("lastname"))
            oCommand.Parameters("phone").Value = CStr(htData("phone"))
            oCommand.Parameters("address").Value = CStr(htData("address"))
            oCommand.Parameters("email").Value = CStr(htData("email"))
            oCommand.Parameters("dob").Value = CDate(htData("dob"))
            oCommand.Parameters("customer_id").Value = CInt(htData("customer_id"))

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
    ''' <summary>
    ''' To delete Customer, you have to check the Booking form first, if there are some record, you should delete them first then delete customer.
    ''' </summary>
    ''' <param name="sId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function deleteCus(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
           "DELETE FROM customer WHERE customer_id = ?;"
            oCommand.Parameters.Add("customer_id", OleDbType.Integer, 10)
            oCommand.Parameters("customer_id").Value = CInt(sId)

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was deleted.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The record was not deleted!")
        Finally
            oConnection.Close()
        End Try

        Return iNumRows
    End Function
End Class
