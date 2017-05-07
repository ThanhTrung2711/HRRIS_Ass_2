Option Explicit On
Option Strict On

' Name:        frmBooking.vb
' Description: Capture data from Booking table
' Author:      Nguyen Thanh Trung
' Date:        17/03/2017
' Subject name: ISYS2116 –Information Systems Solutions and Design
' Semester 1 of 2017
' Tutor: Mr.Ashish Das

Imports System.Data.OleDb
Imports System.IO
Public Class frmBooking

    Public Const CONNECTION_STRING As String = _
     "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RoomReservationDB.accdb"
    'Dim lsData As List(Of Hashtable)
    Dim lsData3 As New List(Of Hashtable)
    Dim iCurrentIndex As Integer


    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RoomReservationDBDataSet2.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.RoomReservationDBDataSet2.booking)

        'Load all dropdown box
        LoadDropdownBox()

    'Use for navigation buttons control
    Dim oController2 As BookingDataController = New BookingDataController
        lsData3 = oController2.findAllBookId()

    Dim htData As Hashtable
    Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData3.Item(iIndex)
    'Populate the first record when debugging
        populateFormFields(htData)


    Dim BookTips As New ToolTip
        BookTips.SetToolTip(txtbookid, "Type ID to find all record")
        BookTips.SetToolTip(btnadd, "Click to Insert data to Database")
        BookTips.SetToolTip(btnBookUpdate, "Update New change to Database")
        BookTips.SetToolTip(btnDeleteBook, " Delete Record (Click Find first)")
        BookTips.SetToolTip(btnFindBookId, "Choose ID to find record")
        BookTips.SetToolTip(btnInvoice, "Click to generate the receipt")
        BookTips.SetToolTip(btnCustomer, "Go to Customer Form")
        BookTips.SetToolTip(btnRoom, "Go to Room Form")
        BookTips.SetToolTip(btnFirst, "Go to First record")
        BookTips.SetToolTip(btnLast, "Go to Last record")
        BookTips.SetToolTip(btnNext, " Go to Next record")
        BookTips.SetToolTip(btnPrev, "Go to Previous record")
        BookTips.SetToolTip(btnClear, "Clear all to add new record")

    End Sub
    Private Sub LoadDropdownBox()
        'Show the room_id list in the Booking form as dropdown box
        cboRoomid.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController As RoomDataController = New RoomDataController
        Dim lsData = oController.findAll()

        For Each frmRoom In lsData
            cboRoomid.Items.Add(CInt(frmRoom("room_id")))
        Next

        'Show the customer_id list in the Booking form as dropdown box
        txtcusid.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController1 As CustomerDataController = New CustomerDataController
        Dim lsData1 = oController1.findAllCusId()

        For Each frmcustomer In lsData1
            txtcusid.Items.Add(CInt(frmcustomer("customer_id")))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        Dim CustomerForm As New frmCustomer
        Me.Hide()
        CustomerForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoom.Click
        Dim RoomForm As New frmRoom
        Me.Hide()
        RoomForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim btnValid2 = ValidationForm()
        Dim htData2 As Hashtable = New Hashtable


        If btnValid2 Then
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
        End If


        Me.BookingTableAdapter.Fill(Me.RoomReservationDBDataSet2.booking)

    End Sub


    Private Function ValidationForm() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True



        bIsValid = IsDate(txtdate.Text)
        If bIsValid Then
            picerror1.Visible = False
            Debug.Print("Value is Date")
            'Check Booking date cannot be the past
            If txtdate.Value < DateTime.Today Then
                picerror1.Visible = True
                Debug.Print("Booking Date cannot be the past")
                bAllFieldsValid = False
            Else
                picerror1.Visible = False
            End If
        Else
            picerror1.Visible = True
            Debug.Print(" Value is not Date")
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
            'Check staying day if user type 0
            If CStr(txtnumday.Text) = "0" Then
                picerror4.Visible = True
                Debug.Print(" Cannot be 0")
                bAllFieldsValid = False
            Else
                picerror4.Visible = False
            End If
        Else
            picerror4.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isNumGuestVal(txtnumguest.Text)
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
            If txtcheckinday.Value < DateTime.Today Then
                picerror6.Visible = True
                MsgBox("Checking date cannot be the past")
                bAllFieldsValid = False

            ElseIf txtcheckinday.Value < txtdate.Value Then

                picerror6.Visible = True
                MsgBox("Booking date cannot be bigger than checking date")
                bAllFieldsValid = False
                'Else
                '    picerror6.Visible = False
                'End If

            Else
                picerror6.Visible = False
            End If

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

        Return bAllFieldsValid = True

    End Function



    Private Sub cboRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoomid.SelectedIndexChanged
        Dim selectedIndex As Integer = cboRoomid.SelectedIndex
        Dim selectedItem As Object = cboRoomid.SelectedItem

        Debug.Print("Selected product: " & selectedItem.ToString())
        Debug.Print("Selected product index: " & selectedIndex.ToString())



    End Sub



    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CustomerFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerFormToolStripMenuItem.Click
        frmCustomer.Show()
        Me.Hide()

    End Sub

    Private Sub RoomFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomFormToolStripMenuItem.Click
        frmRoom.Show()
        Me.Hide()
    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBookId.Click
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        Dim oController As BookingDataController = New BookingDataController
        Dim sId = txtbookid.Text

        'Validate Booking ID if users type wrong date type of Booking ID
        'Must be only Numeric
        bIsValid = IsNumeric(txtbookid.Text)
        If bIsValid Then
            picerror.Visible = False
            Debug.Print("Value is numeric")
            If bIsValid Then
                Dim lsData = oController.findByBookId(sId)
                If lsData.Count = 1 Then
                    populateFormFields(lsData.Item(0))
                Else
                    Debug.Print("No records were found")
                End If
            End If
        Else
            picerror.Visible = True
            Debug.Print(" Value is not numeric")
            bAllFieldsValid = False
        End If


    End Sub
    Private Sub populateFormFields(ByVal htdata As Hashtable)
        txtbookid.Text = CStr(CInt(htdata("booking_id")))
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

        Dim btnValid2 = ValidationForm()

        If btnValid2 Then
            Dim iNumRows = oController3.updateBookId(getFormData3)
            If iNumRows = 1 Then
                Debug.Print("The record was updated. Use the find button to check ...")

            Else
                Debug.Print("The record was not updated!")
            End If
        End If

        Me.BookingTableAdapter.Fill(Me.RoomReservationDBDataSet2.booking)

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



        Me.BookingTableAdapter.Fill(Me.RoomReservationDBDataSet2.booking)
    End Sub
    Private Sub clearForm1()
        txtbookid.Clear()
        cboRoomid.Items.Clear()
        txtcusid.Items.Clear()
        txtnumday.Clear()
        txtnumguest.Clear()
        txttotalprice.Clear()
        txtcomment.Clear()
        cbotype.ResetText()
        cboprice.ResetText()
        txtdate.ResetText()
        txtcheckinday.ResetText()

    End Sub
#Region "Navigation Buttons"
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = 0
            iCurrentIndex = iIndex
            htData = lsData3.Item(iIndex)

            populateFormFields(htData)

            Dim BookingDetails As String
            BookingDetails = CStr(htData("booking_id"))
            BookingDetails = BookingDetails & " | " & CDate(htData("booking_date"))
            BookingDetails = BookingDetails & " | " & CInt(htData("room_id"))
            BookingDetails = BookingDetails & " | " & CInt(htData("customer_id"))
            BookingDetails = BookingDetails & " | " & CInt(htData("num_days"))
            BookingDetails = BookingDetails & " | " & CInt(htData("num_guests"))
            BookingDetails = BookingDetails & " | " & CDate(htData("checkin_day"))
            BookingDetails = BookingDetails & " | " & CInt(htData("total_price"))
            BookingDetails = BookingDetails & " | " & CStr(htData("comments"))
            Debug.Print("BookingDetails: " & vbCrLf & BookingDetails)
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
            htData = lsData3.Item(iIndex)

            populateFormFields(htData)

            Dim BookingDetails As String
            BookingDetails = CStr(htData("booking_id"))
            BookingDetails = BookingDetails & " | " & CDate(htData("booking_date"))
            BookingDetails = BookingDetails & " | " & CInt(htData("room_id"))
            BookingDetails = BookingDetails & " | " & CInt(htData("customer_id"))
            BookingDetails = BookingDetails & " | " & CInt(htData("num_days"))
            BookingDetails = BookingDetails & " | " & CInt(htData("num_guests"))
            BookingDetails = BookingDetails & " | " & CDate(htData("checkin_day"))
            BookingDetails = BookingDetails & " | " & CInt(htData("total_price"))
            BookingDetails = BookingDetails & " | " & CStr(htData("comments"))
            Debug.Print("BookingDetails: " & vbCrLf & BookingDetails)
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
            htData = lsData3.Item(iIndex)

            populateFormFields(htData)

            Dim BookingDetails As String
            BookingDetails = CStr(htData("booking_id"))
            BookingDetails = BookingDetails & " | " & CDate(htData("booking_date"))
            BookingDetails = BookingDetails & " | " & CInt(htData("room_id"))
            BookingDetails = BookingDetails & " | " & CInt(htData("customer_id"))
            BookingDetails = BookingDetails & " | " & CInt(htData("num_days"))
            BookingDetails = BookingDetails & " | " & CInt(htData("num_guests"))
            BookingDetails = BookingDetails & " | " & CDate(htData("checkin_day"))
            BookingDetails = BookingDetails & " | " & CInt(htData("total_price"))
            BookingDetails = BookingDetails & " | " & CStr(htData("comments"))
            Debug.Print("BookingDetails: " & vbCrLf & BookingDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")
        End Try
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        Try
            iIndex = lsData3.Count - 1
            iCurrentIndex = iIndex
            htData = lsData3.Item(iIndex)

            populateFormFields(htData)

            Dim BookingDetails As String
            BookingDetails = CStr(htData("booking_id"))
            BookingDetails = BookingDetails & " | " & CDate(htData("booking_date"))
            BookingDetails = BookingDetails & " | " & CInt(htData("room_id"))
            BookingDetails = BookingDetails & " | " & CInt(htData("customer_id"))
            BookingDetails = BookingDetails & " | " & CInt(htData("num_days"))
            BookingDetails = BookingDetails & " | " & CInt(htData("num_guests"))
            BookingDetails = BookingDetails & " | " & CDate(htData("checkin_day"))
            BookingDetails = BookingDetails & " | " & CInt(htData("total_price"))
            BookingDetails = BookingDetails & " | " & CStr(htData("comments"))
            Debug.Print("BookingDetails: " & vbCrLf & BookingDetails)
        Catch ex As Exception
            MsgBox("Out of record, Please do not click anymore", MsgBoxStyle.OkOnly, "Stop")
        End Try
    End Sub
#End Region


    'Show Price and Type as dropdown box 
    Private Sub populatePriceType(ByVal htdata As Hashtable)
        cbotype.Text = CStr(htdata("type"))
        cboprice.Text = CStr(CInt(htdata("price")))
    End Sub
    'Calculate total price
    ''When users mouse out the field then the price will be automatically calculated.
    Private Sub txttotalprice_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttotalprice.Leave
        txttotalprice.Text = CStr(CInt(txtnumday.Text) * CInt(cboprice.Text))
    End Sub
    Private Sub cboRoomid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRoomid.TextChanged
        Dim oCalculation As RoomDataController = New RoomDataController
        Dim room_id = cboRoomid.Text
        Dim lsData = oCalculation.PriceCal(room_id)

        If lsData.Count = 1 Then
            populatePriceType(lsData.Item(0))
        Else
            Debug.Print("No records were found")
        End If
    End Sub
    'This will capture the current Booking ID on the Booking then Show on the Invoice form
    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        Dim InvoiceForm As New frmInvoice
        'Click then Invoice will capture the current ID
        InvoiceForm.IntegerPass = txtbookid.Text
        Me.Hide()
        InvoiceForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ReportingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportingToolStripMenuItem.Click
        Dim frmReport As New frmReport
        Me.Hide()
        frmReport.ShowDialog()
        Me.Close()

    End Sub


    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        'This will show up the Help page as HTML
        Dim helpPage As String = "HelpPage.html"
        Process.Start(helpPage)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'This will show up the About page as HTML
        Dim AboutPage As String = "AboutPage.html"
        Process.Start(AboutPage)
    End Sub
    'Clear all existing data to add new record
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearForm1()
        'Load all dropdown box
        LoadDropdownBox()
    End Sub

   

End Class