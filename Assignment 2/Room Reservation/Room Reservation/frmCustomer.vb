Option Explicit On
Option Strict On

' Name:        frmCustomer.vb
' Description: Capture data from Customer table
' Author:      Nguyen Thanh Trung
' Date:        17/03/2017

Imports System.Data.OleDb
Imports System.IO


Public Class frmCustomer
    Dim lsData1 As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        Dim bisValid1 = ValidationForm()
        Dim htData As Hashtable = New Hashtable

        htData("title") = txttitle.Text
        htData("gender") = txtgender.Text
        htData("firstname") = txtfname.Text
        htData("lastname") = txtlname.Text
        htData("phone") = txtphone.Text
        htData("address") = txtaddress.Text
        htData("email") = txtemail.Text
        htData("dob") = txtdob.Text

        Dim CusInsert As CustomerDataController = New CustomerDataController
        CusInsert.insertCustomer(htData)
        

    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBooking.Click
        Dim BookingForm As New frmBooking
        BookingForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoom.Click
        Dim RoomForm As New frmRoom
        RoomForm.Show()
        Me.Hide()
    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub
    ''' <summary>
    ''' This function will validate values for Customer Form  
    ''' </summary>
    ''' <returns>If all fiels match, will pop a message box "All field are valid" </returns>
    ''' <remarks></remarks>
    Private Function ValidationForm() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

       

        bIsValid = oValidation.isNameVal(txtfname.Text)
        If bIsValid Then
            picerror3.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror3.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isNameVal(txtlname.Text)
        If bIsValid Then
            picerror4.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror4.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isPhoneVal(txtphone.Text)
        If bIsValid Then
            picerror5.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror5.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAddressVal(txtaddress.Text)
        If bIsValid Then
            picerror6.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror6.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isEmailVal(txtemail.Text)
        If bIsValid Then
            picerror7.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror7.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsDate(txtdob.Text)
        If bIsValid Then
            picerror8.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror8.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
            MsgBox("All field are valid")
        Else
            MsgBox("All field are invalid, please type again")
        End If

        Return bAllFieldsValid

    End Function

    Private Sub txtcusid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcusid.TextChanged

    End Sub

    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdob.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfindID.Click
        Dim oController As CustomerDataController = New CustomerDataController

        Dim sId = txtcusid.Text
        Dim lsData = oController.findByCusId(sId)

        If lsData.Count = 1 Then
            populateFormFields(lsData.Item(0))
        Else
            Debug.Print("No records were found")
        End If

    End Sub
    Private Sub populateFormFields(ByVal htdata As Hashtable)
        txtcusid.Text = CStr(CInt(htdata("customer_id")))
        txttitle.Text = CStr(htdata("title"))
        txtgender.Text = CStr(htdata("gender"))
        txtfname.Text = CStr(htdata("firstname"))
        txtlname.Text = CStr(htdata("lastname"))
        txtphone.Text = CStr(htdata("phone"))
        txtaddress.Text = CStr(htdata("address"))
        txtemail.Text = CStr(htdata("email"))
        txtdob.Text = CStr(CDate(htdata("dob")))
    End Sub

    Private Sub txttitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txttitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttitle.SelectedIndexChanged

    End Sub

    Private Sub txtaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim oController As CustomerDataController = New CustomerDataController
        Dim iNumRows = oController.updateCusId(getFormData)

        If iNumRows = 1 Then
            Debug.Print("The record was updated. Use the find button to check ...")
        Else
            Debug.Print("The record was not updated!")
        End If



    End Sub
    Private Function getFormData() As Hashtable
        Dim htData As Hashtable = New Hashtable

        htData("customer_id") = txtcusid.Text
        htData("title") = txttitle.Text
        htData("gender") = txtgender.Text
        htData("firstname") = txtfname.Text
        htData("lastname") = txtlname.Text
        htData("phone") = txtphone.Text
        htData("address") = txtaddress.Text
        htData("email") = txtemail.Text
        htData("dob") = txtdob.Text

        

        Return htData
    End Function

    Private Sub btnDeleteCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCus.Click
        Dim DeleteController As CustomerDataController = New CustomerDataController
        Dim sId = txtcusid.Text


        'Choose Yes or No to confirm that you wan to delete the record
        Select Case MsgBox("Are you sure to delete the record ?", MsgBoxStyle.YesNo, "Delete")
            Case MsgBoxResult.Yes
                Dim iNumRows = DeleteController.deleteCus(sId)
                If iNumRows = 1 Then
                    clearForm()
                    Debug.Print("The Customer record was deleted.")
                End If
            Case MsgBoxResult.No
                Debug.Print("The Customer record was not deleted!")
        End Select

    End Sub
    Private Sub clearForm()
        txtcusid.Clear()
        txttitle.Items.Clear()
        txtgender.Items.Clear()
        txtfname.Clear()
        txtlname.Clear()
        txtphone.Clear()
        txtaddress.Clear()
        txtemail.Clear()


    End Sub

    Private Sub txtgender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtgender.SelectedIndexChanged

    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oController As CustomerDataController = New CustomerDataController
        lsData1 = oController.findAllCusId()


    End Sub
    'First and last may not need to Try catch function
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = 0
            iCurrentIndex = iIndex
            htData = lsData1.Item(iIndex)

            populateFormFields(htData)

            Dim CustomerDetails As String
            CustomerDetails = CStr(htData("customer_id"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("title"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("gender"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("firstname"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("lastname"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("phone"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("address"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("email"))
            CustomerDetails = CustomerDetails & " | " & CDate(htData("dob"))
            Debug.Print("CustomerDetails: " & vbCrLf & CustomerDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")
        End Try
        

    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = lsData1.Count - 1
            iCurrentIndex = iIndex
            htData = lsData1.Item(iIndex)

            populateFormFields(htData)

            Dim CustomerDetails As String
            CustomerDetails = CStr(htData("customer_id"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("title"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("gender"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("firstname"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("lastname"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("phone"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("address"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("email"))
            CustomerDetails = CustomerDetails & " | " & CDate(htData("dob"))
            Debug.Print("CustomerDetails: " & vbCrLf & CustomerDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")
        End Try
        
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = iCurrentIndex - 1
            iCurrentIndex = iIndex
            htData = lsData1.Item(iIndex)

            populateFormFields(htData)

            Dim CustomerDetails As String
            CustomerDetails = CStr(htData("customer_id"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("title"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("gender"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("firstname"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("lastname"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("phone"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("address"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("email"))
            CustomerDetails = CustomerDetails & " | " & CDate(htData("dob"))
            Debug.Print("CustomerDetails: " & vbCrLf & CustomerDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")
        End Try
        
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsData1.Item(iIndex)

            populateFormFields(htData)

            Dim CustomerDetails As String
            CustomerDetails = CStr(htData("customer_id"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("title"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("gender"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("firstname"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("lastname"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("phone"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("address"))
            CustomerDetails = CustomerDetails & " | " & CStr(htData("email"))
            CustomerDetails = CustomerDetails & " | " & CDate(htData("dob"))
            Debug.Print("CustomerDetails: " & vbCrLf & CustomerDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")

        End Try
        
    End Sub
End Class
