Option Explicit On
Option Strict On

' Name:        frmHome.vb
' Description: To open one of three forms
' Author:      Nguyen Thanh Trung
' Date:        30/03/2017

Public Class Home

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim BookingForm As New frmBooking
        BookingForm.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim CustomerForm As New frmCustomer
        CustomerForm.Show()
        Me.Hide()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim RoomForm As New frmRoom
        RoomForm.Show()
        Me.Hide()
    End Sub
End Class