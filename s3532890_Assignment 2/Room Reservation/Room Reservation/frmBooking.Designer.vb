<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txttotalprice = New System.Windows.Forms.TextBox()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.txtnumguest = New System.Windows.Forms.TextBox()
        Me.txtnumday = New System.Windows.Forms.TextBox()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.txtbookid = New System.Windows.Forms.TextBox()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblcusid = New System.Windows.Forms.Label()
        Me.picerror8 = New System.Windows.Forms.PictureBox()
        Me.picerror7 = New System.Windows.Forms.PictureBox()
        Me.picerror6 = New System.Windows.Forms.PictureBox()
        Me.picerror4 = New System.Windows.Forms.PictureBox()
        Me.picerror5 = New System.Windows.Forms.PictureBox()
        Me.picerror3 = New System.Windows.Forms.PictureBox()
        Me.picerror2 = New System.Windows.Forms.PictureBox()
        Me.picerror1 = New System.Windows.Forms.PictureBox()
        Me.picerror = New System.Windows.Forms.PictureBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.cboRoomid = New System.Windows.Forms.ComboBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.txtcheckinday = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFindBookId = New System.Windows.Forms.Button()
        CType(Me.picerror8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(120, 392)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(96, 29)
        Me.btnadd.TabIndex = 46
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(120, 283)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(257, 20)
        Me.txttotalprice.TabIndex = 45
        '
        'txtcomment
        '
        Me.txtcomment.Location = New System.Drawing.Point(120, 315)
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.Size = New System.Drawing.Size(257, 20)
        Me.txtcomment.TabIndex = 44
        '
        'txtnumguest
        '
        Me.txtnumguest.Location = New System.Drawing.Point(120, 220)
        Me.txtnumguest.Name = "txtnumguest"
        Me.txtnumguest.Size = New System.Drawing.Size(257, 20)
        Me.txtnumguest.TabIndex = 42
        '
        'txtnumday
        '
        Me.txtnumday.Location = New System.Drawing.Point(120, 186)
        Me.txtnumday.Name = "txtnumday"
        Me.txtnumday.Size = New System.Drawing.Size(257, 20)
        Me.txtnumday.TabIndex = 41
        '
        'txtcusid
        '
        Me.txtcusid.Location = New System.Drawing.Point(120, 148)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(257, 20)
        Me.txtcusid.TabIndex = 40
        '
        'txtbookid
        '
        Me.txtbookid.Enabled = False
        Me.txtbookid.Location = New System.Drawing.Point(120, 39)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(257, 20)
        Me.txtbookid.TabIndex = 37
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(33, 315)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(56, 13)
        Me.lbldob.TabIndex = 36
        Me.lbldob.Text = "Comments"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(33, 251)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(72, 13)
        Me.lbladdress.TabIndex = 35
        Me.lbladdress.Text = "Checkin Date"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(33, 283)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(58, 13)
        Me.lblemail.TabIndex = 34
        Me.lblemail.Text = "Total Price"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Location = New System.Drawing.Point(33, 220)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(65, 13)
        Me.lblphone.TabIndex = 33
        Me.lblphone.Text = "Num Guests"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(33, 186)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(56, 13)
        Me.lbllname.TabIndex = 32
        Me.lbllname.Text = "Num Days"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(33, 148)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(65, 13)
        Me.lblfname.TabIndex = 31
        Me.lblfname.Text = "Customer ID"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(33, 107)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(49, 13)
        Me.lblgender.TabIndex = 30
        Me.lblgender.Text = "Room ID"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(33, 72)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(30, 13)
        Me.lbltitle.TabIndex = 29
        Me.lbltitle.Text = "Date"
        '
        'lblcusid
        '
        Me.lblcusid.AutoSize = True
        Me.lblcusid.Location = New System.Drawing.Point(33, 39)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(60, 13)
        Me.lblcusid.TabIndex = 28
        Me.lblcusid.Text = "Booking ID"
        '
        'picerror8
        '
        Me.picerror8.Image = Global.customer.My.Resources.Resources._error
        Me.picerror8.Location = New System.Drawing.Point(394, 315)
        Me.picerror8.Name = "picerror8"
        Me.picerror8.Size = New System.Drawing.Size(18, 20)
        Me.picerror8.TabIndex = 55
        Me.picerror8.TabStop = False
        Me.picerror8.Visible = False
        '
        'picerror7
        '
        Me.picerror7.Image = Global.customer.My.Resources.Resources._error
        Me.picerror7.Location = New System.Drawing.Point(394, 283)
        Me.picerror7.Name = "picerror7"
        Me.picerror7.Size = New System.Drawing.Size(18, 20)
        Me.picerror7.TabIndex = 54
        Me.picerror7.TabStop = False
        Me.picerror7.Visible = False
        '
        'picerror6
        '
        Me.picerror6.Image = Global.customer.My.Resources.Resources._error
        Me.picerror6.Location = New System.Drawing.Point(394, 251)
        Me.picerror6.Name = "picerror6"
        Me.picerror6.Size = New System.Drawing.Size(18, 20)
        Me.picerror6.TabIndex = 53
        Me.picerror6.TabStop = False
        Me.picerror6.Visible = False
        '
        'picerror4
        '
        Me.picerror4.Image = Global.customer.My.Resources.Resources._error
        Me.picerror4.Location = New System.Drawing.Point(394, 186)
        Me.picerror4.Name = "picerror4"
        Me.picerror4.Size = New System.Drawing.Size(18, 20)
        Me.picerror4.TabIndex = 52
        Me.picerror4.TabStop = False
        Me.picerror4.Visible = False
        '
        'picerror5
        '
        Me.picerror5.Image = Global.customer.My.Resources.Resources._error
        Me.picerror5.Location = New System.Drawing.Point(394, 220)
        Me.picerror5.Name = "picerror5"
        Me.picerror5.Size = New System.Drawing.Size(18, 20)
        Me.picerror5.TabIndex = 51
        Me.picerror5.TabStop = False
        Me.picerror5.Visible = False
        '
        'picerror3
        '
        Me.picerror3.Image = Global.customer.My.Resources.Resources._error
        Me.picerror3.Location = New System.Drawing.Point(394, 148)
        Me.picerror3.Name = "picerror3"
        Me.picerror3.Size = New System.Drawing.Size(18, 20)
        Me.picerror3.TabIndex = 50
        Me.picerror3.TabStop = False
        Me.picerror3.Visible = False
        '
        'picerror2
        '
        Me.picerror2.Image = Global.customer.My.Resources.Resources._error
        Me.picerror2.Location = New System.Drawing.Point(394, 107)
        Me.picerror2.Name = "picerror2"
        Me.picerror2.Size = New System.Drawing.Size(18, 20)
        Me.picerror2.TabIndex = 49
        Me.picerror2.TabStop = False
        Me.picerror2.Visible = False
        '
        'picerror1
        '
        Me.picerror1.Image = Global.customer.My.Resources.Resources._error
        Me.picerror1.Location = New System.Drawing.Point(394, 72)
        Me.picerror1.Name = "picerror1"
        Me.picerror1.Size = New System.Drawing.Size(18, 20)
        Me.picerror1.TabIndex = 48
        Me.picerror1.TabStop = False
        Me.picerror1.Visible = False
        '
        'picerror
        '
        Me.picerror.Image = Global.customer.My.Resources.Resources._error
        Me.picerror.Location = New System.Drawing.Point(394, 39)
        Me.picerror.Name = "picerror"
        Me.picerror.Size = New System.Drawing.Size(18, 20)
        Me.picerror.TabIndex = 47
        Me.picerror.TabStop = False
        Me.picerror.Visible = False
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(479, 39)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(98, 33)
        Me.btnCustomer.TabIndex = 56
        Me.btnCustomer.Text = "Customer Form"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(479, 87)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(98, 33)
        Me.btnRoom.TabIndex = 58
        Me.btnRoom.Text = "Room Form"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'cboRoomid
        '
        Me.cboRoomid.FormattingEnabled = True
        Me.cboRoomid.Location = New System.Drawing.Point(120, 104)
        Me.cboRoomid.Name = "cboRoomid"
        Me.cboRoomid.Size = New System.Drawing.Size(257, 21)
        Me.cboRoomid.TabIndex = 59
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(120, 72)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(257, 20)
        Me.txtdate.TabIndex = 60
        '
        'txtcheckinday
        '
        Me.txtcheckinday.Location = New System.Drawing.Point(120, 251)
        Me.txtcheckinday.Name = "txtcheckinday"
        Me.txtcheckinday.Size = New System.Drawing.Size(257, 20)
        Me.txtcheckinday.TabIndex = 61
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataCaptureToolStripMenuItem, Me.ReportingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(605, 24)
        Me.MenuStrip1.TabIndex = 62
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataCaptureToolStripMenuItem
        '
        Me.DataCaptureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerFormToolStripMenuItem, Me.RoomFormToolStripMenuItem})
        Me.DataCaptureToolStripMenuItem.Name = "DataCaptureToolStripMenuItem"
        Me.DataCaptureToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.DataCaptureToolStripMenuItem.Text = "Data Capture"
        '
        'CustomerFormToolStripMenuItem
        '
        Me.CustomerFormToolStripMenuItem.Name = "CustomerFormToolStripMenuItem"
        Me.CustomerFormToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CustomerFormToolStripMenuItem.Text = "Customer Form"
        '
        'RoomFormToolStripMenuItem
        '
        Me.RoomFormToolStripMenuItem.Name = "RoomFormToolStripMenuItem"
        Me.RoomFormToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RoomFormToolStripMenuItem.Text = "Room Form"
        '
        'ReportingToolStripMenuItem
        '
        Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
        Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ReportingToolStripMenuItem.Text = "Reporting"
        '
        'btnFindBookId
        '
        Me.btnFindBookId.Location = New System.Drawing.Point(281, 392)
        Me.btnFindBookId.Name = "btnFindBookId"
        Me.btnFindBookId.Size = New System.Drawing.Size(96, 29)
        Me.btnFindBookId.TabIndex = 63
        Me.btnFindBookId.Text = "Find"
        Me.btnFindBookId.UseVisualStyleBackColor = True
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 453)
        Me.Controls.Add(Me.btnFindBookId)
        Me.Controls.Add(Me.txtcheckinday)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.cboRoomid)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.picerror8)
        Me.Controls.Add(Me.picerror7)
        Me.Controls.Add(Me.picerror6)
        Me.Controls.Add(Me.picerror4)
        Me.Controls.Add(Me.picerror5)
        Me.Controls.Add(Me.picerror3)
        Me.Controls.Add(Me.picerror2)
        Me.Controls.Add(Me.picerror1)
        Me.Controls.Add(Me.picerror)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txttotalprice)
        Me.Controls.Add(Me.txtcomment)
        Me.Controls.Add(Me.txtnumguest)
        Me.Controls.Add(Me.txtnumday)
        Me.Controls.Add(Me.txtcusid)
        Me.Controls.Add(Me.txtbookid)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblphone)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.lblcusid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBooking"
        Me.Text = "Booking"
        CType(Me.picerror8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picerror8 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror7 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror6 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror4 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror5 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror3 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror2 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror1 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror As System.Windows.Forms.PictureBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txttotalprice As System.Windows.Forms.TextBox
    Friend WithEvents txtcomment As System.Windows.Forms.TextBox
    Friend WithEvents txtnumguest As System.Windows.Forms.TextBox
    Friend WithEvents txtnumday As System.Windows.Forms.TextBox
    Friend WithEvents txtcusid As System.Windows.Forms.TextBox
    Friend WithEvents txtbookid As System.Windows.Forms.TextBox
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblphone As System.Windows.Forms.Label
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblcusid As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnRoom As System.Windows.Forms.Button
    Friend WithEvents cboRoomid As System.Windows.Forms.ComboBox
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcheckinday As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnFindBookId As System.Windows.Forms.Button
End Class
