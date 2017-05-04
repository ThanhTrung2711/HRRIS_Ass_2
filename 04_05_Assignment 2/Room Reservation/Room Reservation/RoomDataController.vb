Option Explicit On
Option Strict On

'Name: Nguyen Thanh Trung
' Description: Class to control all data for Room Form
' Author:      Nguyen Thanh Trung
' Date:        11/04/2017

Imports System.Data.OleDb
Imports System.IO

Public Class RoomDataController
    Public Const CONNECTION_STRING As String = _
   "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RoomReservationDB.accdb"

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

    Public Function findByRoomId(ByVal sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
                "SELECT * FROM room WHERE room_id = ?;"
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
            oCommand.Parameters("room_id").Value = CInt(sId)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData1 As Hashtable
            Do While oDataReader.Read() = True
                htTempData1 = New Hashtable
                htTempData1("room_id") = CInt(oDataReader("room_id"))
                htTempData1("room_number") = CStr(oDataReader("room_number"))
                htTempData1("type") = CStr(oDataReader("type"))
                htTempData1("price") = CStr(oDataReader("price"))
                htTempData1("num_beds") = CInt(oDataReader("num_beds"))
                htTempData1("availability") = CStr(oDataReader("availability"))
                htTempData1("floor") = CInt(oDataReader("floor"))
                htTempData1("description") = CStr(oDataReader("description"))
                lsData.Add(htTempData1)
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

    Public Function updateRoomId(ByVal htData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
                "UPDATE room SET room_number = ?, type = ?, price = ?, num_beds = ?, availability = ?, floor = ?, description = ? WHERE room_id = ?;"

            oCommand.Parameters.Add("room_number", OleDbType.Integer, 20)
            oCommand.Parameters.Add("type", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("price", OleDbType.Currency, 20)
            oCommand.Parameters.Add("num_beds", OleDbType.Integer, 20)
            oCommand.Parameters.Add("availability", OleDbType.VarChar, 20)
            oCommand.Parameters.Add("floor", OleDbType.Integer, 20)
            oCommand.Parameters.Add("description", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 10)

            oCommand.Parameters("room_number").Value = CInt(htData("room_number"))
            oCommand.Parameters("type").Value = CStr(htData("type"))
            oCommand.Parameters("price").Value = CInt(htData("price"))
            oCommand.Parameters("num_beds").Value = CInt(htData("num_beds"))
            oCommand.Parameters("availability").Value = CStr(htData("availability"))
            oCommand.Parameters("floor").Value = CInt(htData("floor"))
            oCommand.Parameters("description").Value = CStr(htData("description"))
            oCommand.Parameters("room_id").Value = CInt(htData("room_id"))

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

    Public Function deleteRoom(ByVal sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
           "DELETE FROM room WHERE room_id = ?;"
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 10)
            oCommand.Parameters("room_id").Value = CInt(sId)

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The Room record was deleted.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox(" Please Delete Record on Booking Form first")

        Finally
            oConnection.Close()
        End Try

        Return iNumRows
    End Function

    'This will pop up Type and Price in Booking form
    Public Function PriceCal(ByVal room_id As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'TODO
            oCommand.CommandText = _
                    "SELECT type, price FROM room WHERE room_id = ? ORDER BY room_id;"
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 10)
            oCommand.Parameters("room_id").Value = CInt(room_id)
            oCommand.Prepare()

            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("type") = CStr(oDataReader("type"))
                htTempData("price") = CStr(oDataReader("price"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("The Type and Price were found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)

        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function
End Class


