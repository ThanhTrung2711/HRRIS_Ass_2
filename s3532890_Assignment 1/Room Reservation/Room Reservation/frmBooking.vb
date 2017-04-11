Option Explicit On
Option Strict On

' Name:        frmBooking.vb
' Description: Capture data from Booking table
' Author:      Nguyen Thanh Trung
' Date:        17/03/2017

Imports System.Data.OleDb
Imports System.IO
Public Class frmBooking

    Public Const CONNECTION_STRING As String = _
     "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RoomReservationDB.accdb"
    Dim lsData As List(Of Hashtable)

    Private Sub lblcusid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcusid.Click

    End Sub

    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboRoomid.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController As DataController = New DataController
        ' Dim lsData = oController.findAll() 
        lsData = oController.findAll()


        For Each room In lsData
            cboRoomid.Items.Add(CInt(room("room_id")))
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim CustomerForm As New frmCustomer
        CustomerForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoom.Click
        Dim RoomForm As New frmRoom
        RoomForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim btnValid2 = ValidationForm()
        Dim htData2 As Hashtable = New Hashtable

        htData2("booking_date") = txtdate.Text
        htData2("room_id") = cboRoomid.Text
        htData2("customer_id") = txtcusid.Text
        htData2("num_days") = txtnumday.Text
        htData2("num_guests") = txtnumguest.Text
        htData2("checkin_date") = txtcheckinday.Text
        htData2("total_price") = txttotalprice.Text
        htData2("comments") = txtcomment.Text


        Dim oDataController As DataController = New DataController
        oDataController.insertBooking(htData2)
        Dim lsData = oDataController.findAll()
        

    End Sub


    Private Function ValidationForm() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

       

        bIsValid = IsDate(txtdate.Text)
        If bIsValid Then
            picerror1.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror1.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(cboRoomid.Text)
        If bIsValid Then
            picerror2.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror2.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtcusid.Text)
        If bIsValid Then
            picerror3.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror3.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtnumday.Text)
        If bIsValid Then
            picerror4.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror4.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtnumguest.Text)
        If bIsValid Then
            picerror5.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror5.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsDate(txtcheckinday.Text)
        If bIsValid Then
            picerror6.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror6.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txttotalprice.Text)
        If bIsValid Then
            picerror7.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror7.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtcomment.Text)
        If bIsValid Then
            picerror8.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror8.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
            MsgBox("All field are valid")
        Else
            MsgBox("All field are invalid, please type again")
        End If

        Return True

    End Function

    Private Sub txtroomid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoomid.SelectedIndexChanged
        Dim selectedIndex As Integer = cboRoomid.SelectedIndex
        Dim selectedItem As Object = cboRoomid.SelectedItem

        Debug.Print("Selected product: " & selectedItem.ToString())
        Debug.Print("Selected product index: " & selectedIndex.ToString())

        Dim htData = lsData.Item(selectedIndex)

    End Sub

    Private Sub txtcheckinday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.ValueChanged

    End Sub
End Class