Option Explicit On
Option Strict On

' Name:        frmCustomer.vb
' Description: Capture data from Customer table
' Author:      Nguyen Thanh Trung
' Date:        17/03/2017

Imports System.Data.OleDb
Imports System.IO


Public Class frmCustomer

    

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

       

        bIsValid = oValidation.isAlphaNumericVal(txttitle.Text)
        If bIsValid Then
            picerror1.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror1.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtgender.Text)
        If bIsValid Then
            picerror2.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror2.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

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

        bIsValid = IsNumeric(txtphone.Text)
        If bIsValid Then
            picerror5.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror5.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtaddress.Text)
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

        Return True
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
        txttitle.Text = CStr(htdata("title"))
        txtgender.Text = CStr(htdata("gender"))
        txtfname.Text = CStr(htdata("firstname"))
        txtlname.Text = CStr(htdata("lastname"))
        txtphone.Text = CStr(htdata("phone"))
        txtaddress.Text = CStr(htdata("address"))
        txtemail.Text = CStr(htdata("email"))
        txtdob.Text = CStr(CDate(htdata("dob")))
    End Sub

End Class
