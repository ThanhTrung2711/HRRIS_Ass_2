<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.lblcusid = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.picerror = New System.Windows.Forms.PictureBox()
        Me.picerror1 = New System.Windows.Forms.PictureBox()
        Me.picerror2 = New System.Windows.Forms.PictureBox()
        Me.picerror3 = New System.Windows.Forms.PictureBox()
        Me.picerror5 = New System.Windows.Forms.PictureBox()
        Me.picerror4 = New System.Windows.Forms.PictureBox()
        Me.picerror6 = New System.Windows.Forms.PictureBox()
        Me.picerror7 = New System.Windows.Forms.PictureBox()
        Me.picerror8 = New System.Windows.Forms.PictureBox()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.txtdob = New System.Windows.Forms.DateTimePicker()
        Me.btnfindID = New System.Windows.Forms.Button()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcusid
        '
        Me.lblcusid.AutoSize = True
        Me.lblcusid.Location = New System.Drawing.Point(24, 33)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(65, 13)
        Me.lblcusid.TabIndex = 0
        Me.lblcusid.Text = "Customer ID"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(24, 66)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(27, 13)
        Me.lbltitle.TabIndex = 1
        Me.lbltitle.Text = "Title"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(24, 101)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(42, 13)
        Me.lblgender.TabIndex = 2
        Me.lblgender.Text = "Gender"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(24, 142)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(52, 13)
        Me.lblfname.TabIndex = 3
        Me.lblfname.Text = "Firstname"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(24, 180)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(53, 13)
        Me.lbllname.TabIndex = 4
        Me.lbllname.Text = "Lastname"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Location = New System.Drawing.Point(24, 214)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(38, 13)
        Me.lblphone.TabIndex = 5
        Me.lblphone.Text = "Phone"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(24, 277)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(32, 13)
        Me.lblemail.TabIndex = 6
        Me.lblemail.Text = "Email"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(24, 245)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(45, 13)
        Me.lbladdress.TabIndex = 7
        Me.lbladdress.Text = "Address"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(24, 309)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(30, 13)
        Me.lbldob.TabIndex = 8
        Me.lbldob.Text = "DOB"
        '
        'txtcusid
        '
        Me.txtcusid.Enabled = False
        Me.txtcusid.Location = New System.Drawing.Point(111, 33)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(257, 20)
        Me.txtcusid.TabIndex = 9
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(111, 66)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(257, 20)
        Me.txttitle.TabIndex = 10
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(111, 101)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(257, 20)
        Me.txtgender.TabIndex = 11
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(111, 142)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(257, 20)
        Me.txtfname.TabIndex = 12
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(111, 180)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(257, 20)
        Me.txtlname.TabIndex = 13
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(111, 214)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(257, 20)
        Me.txtphone.TabIndex = 14
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(111, 245)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(257, 20)
        Me.txtaddress.TabIndex = 15
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(111, 277)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(257, 20)
        Me.txtemail.TabIndex = 17
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(76, 386)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(174, 29)
        Me.btnadd.TabIndex = 18
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'picerror
        '
        Me.picerror.Image = Global.customer.My.Resources.Resources._error
        Me.picerror.Location = New System.Drawing.Point(385, 33)
        Me.picerror.Name = "picerror"
        Me.picerror.Size = New System.Drawing.Size(18, 20)
        Me.picerror.TabIndex = 19
        Me.picerror.TabStop = False
        Me.picerror.Visible = False
        '
        'picerror1
        '
        Me.picerror1.Image = Global.customer.My.Resources.Resources._error
        Me.picerror1.Location = New System.Drawing.Point(385, 66)
        Me.picerror1.Name = "picerror1"
        Me.picerror1.Size = New System.Drawing.Size(18, 20)
        Me.picerror1.TabIndex = 20
        Me.picerror1.TabStop = False
        Me.picerror1.Visible = False
        '
        'picerror2
        '
        Me.picerror2.Image = Global.customer.My.Resources.Resources._error
        Me.picerror2.Location = New System.Drawing.Point(385, 101)
        Me.picerror2.Name = "picerror2"
        Me.picerror2.Size = New System.Drawing.Size(18, 20)
        Me.picerror2.TabIndex = 21
        Me.picerror2.TabStop = False
        Me.picerror2.Visible = False
        '
        'picerror3
        '
        Me.picerror3.Image = Global.customer.My.Resources.Resources._error
        Me.picerror3.Location = New System.Drawing.Point(385, 142)
        Me.picerror3.Name = "picerror3"
        Me.picerror3.Size = New System.Drawing.Size(18, 20)
        Me.picerror3.TabIndex = 22
        Me.picerror3.TabStop = False
        Me.picerror3.Visible = False
        '
        'picerror5
        '
        Me.picerror5.Image = Global.customer.My.Resources.Resources._error
        Me.picerror5.Location = New System.Drawing.Point(385, 214)
        Me.picerror5.Name = "picerror5"
        Me.picerror5.Size = New System.Drawing.Size(18, 20)
        Me.picerror5.TabIndex = 23
        Me.picerror5.TabStop = False
        Me.picerror5.Visible = False
        '
        'picerror4
        '
        Me.picerror4.Image = Global.customer.My.Resources.Resources._error
        Me.picerror4.Location = New System.Drawing.Point(385, 180)
        Me.picerror4.Name = "picerror4"
        Me.picerror4.Size = New System.Drawing.Size(18, 20)
        Me.picerror4.TabIndex = 24
        Me.picerror4.TabStop = False
        Me.picerror4.Visible = False
        '
        'picerror6
        '
        Me.picerror6.Image = Global.customer.My.Resources.Resources._error
        Me.picerror6.Location = New System.Drawing.Point(385, 245)
        Me.picerror6.Name = "picerror6"
        Me.picerror6.Size = New System.Drawing.Size(18, 20)
        Me.picerror6.TabIndex = 25
        Me.picerror6.TabStop = False
        Me.picerror6.Visible = False
        '
        'picerror7
        '
        Me.picerror7.Image = Global.customer.My.Resources.Resources._error
        Me.picerror7.Location = New System.Drawing.Point(385, 277)
        Me.picerror7.Name = "picerror7"
        Me.picerror7.Size = New System.Drawing.Size(18, 20)
        Me.picerror7.TabIndex = 26
        Me.picerror7.TabStop = False
        Me.picerror7.Visible = False
        '
        'picerror8
        '
        Me.picerror8.Image = Global.customer.My.Resources.Resources._error
        Me.picerror8.Location = New System.Drawing.Point(385, 309)
        Me.picerror8.Name = "picerror8"
        Me.picerror8.Size = New System.Drawing.Size(18, 20)
        Me.picerror8.TabIndex = 27
        Me.picerror8.TabStop = False
        Me.picerror8.Visible = False
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(460, 33)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(98, 33)
        Me.btnBooking.TabIndex = 28
        Me.btnBooking.Text = "Booking Form"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(460, 81)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(98, 33)
        Me.btnRoom.TabIndex = 29
        Me.btnRoom.Text = "Room Form"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(111, 309)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(257, 20)
        Me.txtdob.TabIndex = 30
        '
        'btnfindID
        '
        Me.btnfindID.Location = New System.Drawing.Point(303, 386)
        Me.btnfindID.Name = "btnfindID"
        Me.btnfindID.Size = New System.Drawing.Size(118, 29)
        Me.btnfindID.TabIndex = 31
        Me.btnfindID.Text = "Find"
        Me.btnfindID.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 446)
        Me.Controls.Add(Me.btnfindID)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnBooking)
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
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.txtcusid)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblphone)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.lblcusid)
        Me.Name = "frmCustomer"
        Me.Text = "Customer Form"
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcusid As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblphone As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents txtcusid As System.Windows.Forms.TextBox
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents picerror As System.Windows.Forms.PictureBox
    Friend WithEvents picerror1 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror2 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror3 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror5 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror4 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror6 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror7 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror8 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBooking As System.Windows.Forms.Button
    Friend WithEvents btnRoom As System.Windows.Forms.Button
    Friend WithEvents txtdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnfindID As System.Windows.Forms.Button

End Class
