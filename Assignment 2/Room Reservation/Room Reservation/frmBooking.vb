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
        Dim oController As RoomDataController = New RoomDataController
        Dim lsData = oController.findAll()
        lsData = oController.findAll()


        For Each frmRoom In lsData
            cboRoomid.Items.Add(CInt(frmRoom("room_id")))
        Next

        txtcusid.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As CustomerDataController = New CustomerDataController
        Dim lsData1 = oController1.findAllCusId()



        For Each frmcustomer In lsData1
            txtcusid.Items.Add(CInt(frmcustomer("customer_id")))
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


        Dim oDataController As BookingDataController = New BookingDataController
        oDataController.insertBooking(htData2)
        'Dim lsData = oDataController.findAll()
        

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



    End Sub

    Private Sub txtcheckinday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.ValueChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CustomerFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerFormToolStripMenuItem.Click
        frmCustomer.Show()
    End Sub

    Private Sub RoomFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomFormToolStripMenuItem.Click
        frmRoom.Show()
    End Sub

    Private Sub txtbookid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbookid.TextChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBookId.Click
        Dim oController As BookingDataController = New BookingDataController

        Dim sId = txtbookid.Text
        Dim lsData = oController.findByBookId(sId)

        If lsData.Count = 1 Then
            populateFormFields(lsData.Item(0))
        Else
            Debug.Print("No records were found")
        End If
    End Sub
    Private Sub populateFormFields(ByVal htdata As Hashtable)
        txtdate.Text = CStr(CDate(htdata("booking_date")))
        cboRoomid.Text = CStr(CInt(htdata("room_id")))
        txtcusid.Text = CStr(CInt(htdata("customer_id")))
        txtnumday.Text = CStr(CInt(htdata("num_days")))
        txtnumguest.Text = CStr(CInt(htdata("num_guests")))
        txtcheckinday.Text = CStr(CDate(htdata("checkin_date")))
        txttotalprice.Text = CStr(CInt(htdata("total_price")))
        txtcomment.Text = CStr(htdata("comments"))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcusid.SelectedIndexChanged
        Dim selectedIndex As Integer = txtcusid.SelectedIndex
        Dim selectedItem As Object = txtcusid.SelectedItem

        Debug.Print("Selected : " & selectedItem.ToString())
        Debug.Print("Selected product index: " & selectedIndex.ToString())


    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookUpdate.Click
        Dim oController3 As BookingDataController = New BookingDataController
        Dim iNumRows = oController3.updateBookId(getFormData3)

        If iNumRows = 1 Then
            Debug.Print("The record was updated. Use the find button to check ...")
        Else
            Debug.Print("The record was not updated!")
        End If
    End Sub
    Private Function getFormData3() As Hashtable
        Dim htData3 As Hashtable = New Hashtable

        htData3("booking_id") = txtbookid.Text
        htData3("booking_date") = txtdate.Text
        htData3("room_id") = cboRoomid.Text
        htData3("customer_id") = txtcusid.Text
        htData3("num_days") = txtnumday.Text
        htData3("num_guests") = txtnumguest.Text
        htData3("checkin_date") = txtcheckinday.Text
        htData3("total_price") = txttotalprice.Text
        htData3("comments") = txtcomment.Text



        Return htData3
    End Function

    Private Sub btnDeleteBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteBook.Click
        Dim DeleteController As BookingDataController = New BookingDataController
        Dim sId = txtbookid.Text

        'Choose Yes or No to confirm that you wan to delete the record
        Select Case MsgBox("Are you sure to delete the record ?", MsgBoxStyle.YesNo, "Delete")
            Case MsgBoxResult.Yes
                Dim iNumRows = DeleteController.deleteBooking(sId)
                If iNumRows = 1 Then
                    clearForm1()
                    Debug.Print("The Booking record was deleted.")
                End If
            Case MsgBoxResult.No
                Debug.Print("The Booking record was not deleted!")
        End Select
    End Sub
    Private Sub clearForm1()
        txtbookid.Clear()
        cboRoomid.Items.Clear()
        txtcusid.Items.Clear()
        txtnumday.Clear()
        txtnumguest.Clear()
        txttotalprice.Clear()
        txtcomment.Clear()


    End Sub

    
    Private Sub lblgender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblgender.Click

    End Sub

  
   
End Class