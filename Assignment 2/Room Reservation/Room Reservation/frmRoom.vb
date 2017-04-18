﻿Option Explicit On
Option Strict On

' Name:        frmRoom.vb
' Description: Capture data from Room table
' Author:      Nguyen Thanh Trung
' Date:        17/03/2017

Imports System.Data.OleDb
Imports System.IO
Public Class frmRoom

    Public Const CONNECTION_STRING As String = _
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RoomReservationDB.accdb"

    Dim lsData2 As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    Private Sub txtcusid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtroomid.TextChanged

    End Sub

    Private Sub frmRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim CustomerForm As New frmCustomer
        CustomerForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBooking.Click
        Dim BookingForm As New frmBooking
        BookingForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        Dim btnValid2 = ValidationForm()
        Dim htData1 As Hashtable = New Hashtable

        htData1("room_number") = txtroomnum.Text
        htData1("type") = txttype.Text
        htData1("price") = txtprice.Text
        htData1("num_beds") = txtnumbed.Text
        htData1("availability") = txtavailability.Text
        htData1("floor") = txtfloor.Text
        htData1("description") = txtdescription.Text


        Dim RoomInsert As RoomDataController = New RoomDataController
        RoomInsert.insertRoom(htData1)




    End Sub

    Private Function ValidationForm() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True


        bIsValid = IsNumeric(txtroomnum.Text)
        If bIsValid Then
            picerror1.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror1.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txttype.Text)
        If bIsValid Then
            picerror2.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror2.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtprice.Text)
        If bIsValid Then
            picerror3.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror3.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtnumbed.Text)
        If bIsValid Then
            picerror4.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror4.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtavailability.Text)
        If bIsValid Then
            picerror5.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror5.Visible = True
            Debug.Print(" Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtfloor.Text)
        If bIsValid Then
            picerror6.Visible = False
            Debug.Print("Value is numeric")
        Else
            picerror6.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtdescription.Text)
        If bIsValid Then
            picerror7.Visible = False
            Debug.Print("Value is  alphanumeric ")
        Else
            picerror7.Visible = True
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

    Private Sub btnFindRoomId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindRoomId.Click
        Dim oController As RoomDataController = New RoomDataController

        Dim sId = txtroomid.Text
        Dim lsData = oController.findByRoomId(sId)

        If lsData.Count = 1 Then
            populateFormFields(lsData.Item(0))
        Else
            Debug.Print("No records were found")
        End If
    End Sub

    Private Sub populateFormFields(ByVal htdata1 As Hashtable)
        txtroomnum.Text = CStr(CInt(htdata1("room_number")))
        txttype.Text = CStr(htdata1("type"))
        txtprice.Text = CStr(CInt(htdata1("price")))
        txtnumbed.Text = CStr(CInt(htdata1("num_beds")))
        txtavailability.Text = CStr(htdata1("availability"))
        txtfloor.Text = CStr(CInt(htdata1("floor")))
        txtdescription.Text = CStr(htdata1("description"))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfloor.SelectedIndexChanged

    End Sub

    Private Sub txttype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttype.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomUpdate.Click
        Dim oController1 As RoomDataController = New RoomDataController
        Dim iNumRows = oController1.updateRoomId(getFormData1)

        If iNumRows = 1 Then
            Debug.Print("The record was updated. Use the find button to check ...")
        Else
            Debug.Print("The record was not updated!")
        End If
    End Sub
    Private Function getFormData1() As Hashtable
        Dim htData As Hashtable = New Hashtable

        htData("room_id") = txtroomid.Text
        htData("room_number") = txtroomnum.Text
        htData("type") = txttype.Text
        htData("price") = txtprice.Text
        htData("num_beds") = txtnumbed.Text
        htData("availability") = txtavailability.Text
        htData("floor") = txtfloor.Text
        htData("description") = txtdescription.Text



        Return htData
    End Function

    Private Sub btnDeleteRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRoom.Click
        Dim DeleteController As RoomDataController = New RoomDataController
        Dim sId = txtroomid.Text

        'Choose Yes or No to confirm that you wan to delete the record
        Select Case MsgBox("Are you sure to delete the record ?", MsgBoxStyle.YesNo, "Delete")
            Case MsgBoxResult.Yes
                Dim iNumRows = DeleteController.deleteRoom(sId)
                If iNumRows = 1 Then
                    clearForm3()
                    Debug.Print("The Room record was deleted. To check use Find button")
                End If
            Case MsgBoxResult.No
                Debug.Print("The Room record was not deleted!")
        End Select
    End Sub
    Private Sub clearForm3()
        txtroomid.Clear()
        txtroomnum.Clear()
        txttype.Items.Clear()
        txtprice.Clear()
        txtnumbed.Clear()
        txtavailability.Items.Clear()
        txtfloor.Items.Clear()
        txtdescription.Clear()


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = iCurrentIndex + 1
            iCurrentIndex = iIndex
            htData = lsData2.Item(iIndex)

            populateFormFields(htData)

            Dim RoomDetails As String
            RoomDetails = CStr(htData("room_id"))
            RoomDetails = RoomDetails & " | " & CInt(htData("room_number"))
            RoomDetails = RoomDetails & " | " & CStr(htData("type"))
            RoomDetails = RoomDetails & " | " & CInt(htData("price"))
            RoomDetails = RoomDetails & " | " & CInt(htData("numb_beds"))
            RoomDetails = RoomDetails & " | " & CStr(htData("availability"))
            RoomDetails = RoomDetails & " | " & CInt(htData("floor"))
            RoomDetails = RoomDetails & " | " & CStr(htData("description"))
            Debug.Print("RoomDetails: " & vbCrLf & RoomDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")
        End Try
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = 0
            iCurrentIndex = iIndex
            htData = lsData2.Item(iIndex)

            populateFormFields(htData)

            Dim RoomDetails As String
            RoomDetails = CStr(htData("room_id"))
            RoomDetails = RoomDetails & " | " & CInt(htData("room_number"))
            RoomDetails = RoomDetails & " | " & CStr(htData("type"))
            RoomDetails = RoomDetails & " | " & CInt(htData("price"))
            RoomDetails = RoomDetails & " | " & CInt(htData("numb_beds"))
            RoomDetails = RoomDetails & " | " & CStr(htData("availability"))
            RoomDetails = RoomDetails & " | " & CInt(htData("floor"))
            RoomDetails = RoomDetails & " | " & CStr(htData("description"))
            Debug.Print("RoomDetails: " & vbCrLf & RoomDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")
        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = lsData2.Count - 1
            iCurrentIndex = iIndex
            htData = lsData2.Item(iIndex)

            populateFormFields(htData)

            Dim RoomDetails As String
            RoomDetails = CStr(htData("room_id"))
            RoomDetails = RoomDetails & " | " & CInt(htData("room_number"))
            RoomDetails = RoomDetails & " | " & CStr(htData("type"))
            RoomDetails = RoomDetails & " | " & CInt(htData("price"))
            RoomDetails = RoomDetails & " | " & CInt(htData("numb_beds"))
            RoomDetails = RoomDetails & " | " & CStr(htData("availability"))
            RoomDetails = RoomDetails & " | " & CInt(htData("floor"))
            RoomDetails = RoomDetails & " | " & CStr(htData("description"))
            Debug.Print("RoomDetails: " & vbCrLf & RoomDetails)
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
            htData = lsData2.Item(iIndex)

            populateFormFields(htData)

            Dim RoomDetails As String
            RoomDetails = CStr(htData("room_id"))
            RoomDetails = RoomDetails & " | " & CInt(htData("room_number"))
            RoomDetails = RoomDetails & " | " & CStr(htData("type"))
            RoomDetails = RoomDetails & " | " & CInt(htData("price"))
            RoomDetails = RoomDetails & " | " & CInt(htData("numb_beds"))
            RoomDetails = RoomDetails & " | " & CStr(htData("availability"))
            RoomDetails = RoomDetails & " | " & CInt(htData("floor"))
            RoomDetails = RoomDetails & " | " & CStr(htData("description"))
            Debug.Print("RoomDetails: " & vbCrLf & RoomDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class