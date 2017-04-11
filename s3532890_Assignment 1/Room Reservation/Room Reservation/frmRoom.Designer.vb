<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtfloor = New System.Windows.Forms.TextBox()
        Me.txtavailability = New System.Windows.Forms.TextBox()
        Me.txtnumbed = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.txtroomnum = New System.Windows.Forms.TextBox()
        Me.txtroomid = New System.Windows.Forms.TextBox()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblcusid = New System.Windows.Forms.Label()
        Me.picerror7 = New System.Windows.Forms.PictureBox()
        Me.picerror6 = New System.Windows.Forms.PictureBox()
        Me.picerror4 = New System.Windows.Forms.PictureBox()
        Me.picerror5 = New System.Windows.Forms.PictureBox()
        Me.picerror3 = New System.Windows.Forms.PictureBox()
        Me.picerror2 = New System.Windows.Forms.PictureBox()
        Me.picerror1 = New System.Windows.Forms.PictureBox()
        Me.picerror = New System.Windows.Forms.PictureBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(72, 363)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(174, 29)
        Me.btnadd.TabIndex = 46
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(120, 281)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(257, 20)
        Me.txtdescription.TabIndex = 45
        '
        'txtfloor
        '
        Me.txtfloor.Location = New System.Drawing.Point(120, 249)
        Me.txtfloor.Name = "txtfloor"
        Me.txtfloor.Size = New System.Drawing.Size(257, 20)
        Me.txtfloor.TabIndex = 43
        '
        'txtavailability
        '
        Me.txtavailability.Location = New System.Drawing.Point(120, 218)
        Me.txtavailability.Name = "txtavailability"
        Me.txtavailability.Size = New System.Drawing.Size(257, 20)
        Me.txtavailability.TabIndex = 42
        '
        'txtnumbed
        '
        Me.txtnumbed.Location = New System.Drawing.Point(120, 184)
        Me.txtnumbed.Name = "txtnumbed"
        Me.txtnumbed.Size = New System.Drawing.Size(257, 20)
        Me.txtnumbed.TabIndex = 41
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(120, 146)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(257, 20)
        Me.txtprice.TabIndex = 40
        '
        'txttype
        '
        Me.txttype.Location = New System.Drawing.Point(120, 105)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(257, 20)
        Me.txttype.TabIndex = 39
        '
        'txtroomnum
        '
        Me.txtroomnum.Location = New System.Drawing.Point(120, 70)
        Me.txtroomnum.Name = "txtroomnum"
        Me.txtroomnum.Size = New System.Drawing.Size(257, 20)
        Me.txtroomnum.TabIndex = 38
        '
        'txtroomid
        '
        Me.txtroomid.Enabled = False
        Me.txtroomid.Location = New System.Drawing.Point(120, 37)
        Me.txtroomid.Name = "txtroomid"
        Me.txtroomid.Size = New System.Drawing.Size(257, 20)
        Me.txtroomid.TabIndex = 37
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(33, 249)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(30, 13)
        Me.lbladdress.TabIndex = 35
        Me.lbladdress.Text = "Floor"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(33, 281)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(60, 13)
        Me.lblemail.TabIndex = 34
        Me.lblemail.Text = "Description"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Location = New System.Drawing.Point(33, 218)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(56, 13)
        Me.lblphone.TabIndex = 33
        Me.lblphone.Text = "Availability"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(33, 184)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(56, 13)
        Me.lbllname.TabIndex = 32
        Me.lbllname.Text = "Num Beds"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(33, 146)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(31, 13)
        Me.lblfname.TabIndex = 31
        Me.lblfname.Text = "Price"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(33, 105)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(31, 13)
        Me.lblgender.TabIndex = 30
        Me.lblgender.Text = "Type"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(33, 70)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(75, 13)
        Me.lbltitle.TabIndex = 29
        Me.lbltitle.Text = "Room Number"
        '
        'lblcusid
        '
        Me.lblcusid.AutoSize = True
        Me.lblcusid.Location = New System.Drawing.Point(33, 37)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(49, 13)
        Me.lblcusid.TabIndex = 28
        Me.lblcusid.Text = "Room ID"
        '
        'picerror7
        '
        Me.picerror7.Image = Global.customer.My.Resources.Resources._error
        Me.picerror7.Location = New System.Drawing.Point(394, 281)
        Me.picerror7.Name = "picerror7"
        Me.picerror7.Size = New System.Drawing.Size(18, 20)
        Me.picerror7.TabIndex = 54
        Me.picerror7.TabStop = False
        Me.picerror7.Visible = False
        '
        'picerror6
        '
        Me.picerror6.Image = Global.customer.My.Resources.Resources._error
        Me.picerror6.Location = New System.Drawing.Point(394, 249)
        Me.picerror6.Name = "picerror6"
        Me.picerror6.Size = New System.Drawing.Size(18, 20)
        Me.picerror6.TabIndex = 53
        Me.picerror6.TabStop = False
        Me.picerror6.Visible = False
        '
        'picerror4
        '
        Me.picerror4.Image = Global.customer.My.Resources.Resources._error
        Me.picerror4.Location = New System.Drawing.Point(394, 184)
        Me.picerror4.Name = "picerror4"
        Me.picerror4.Size = New System.Drawing.Size(18, 20)
        Me.picerror4.TabIndex = 52
        Me.picerror4.TabStop = False
        Me.picerror4.Visible = False
        '
        'picerror5
        '
        Me.picerror5.Image = Global.customer.My.Resources.Resources._error
        Me.picerror5.Location = New System.Drawing.Point(394, 218)
        Me.picerror5.Name = "picerror5"
        Me.picerror5.Size = New System.Drawing.Size(18, 20)
        Me.picerror5.TabIndex = 51
        Me.picerror5.TabStop = False
        Me.picerror5.Visible = False
        '
        'picerror3
        '
        Me.picerror3.Image = Global.customer.My.Resources.Resources._error
        Me.picerror3.Location = New System.Drawing.Point(394, 146)
        Me.picerror3.Name = "picerror3"
        Me.picerror3.Size = New System.Drawing.Size(18, 20)
        Me.picerror3.TabIndex = 50
        Me.picerror3.TabStop = False
        Me.picerror3.Visible = False
        '
        'picerror2
        '
        Me.picerror2.Image = Global.customer.My.Resources.Resources._error
        Me.picerror2.Location = New System.Drawing.Point(394, 105)
        Me.picerror2.Name = "picerror2"
        Me.picerror2.Size = New System.Drawing.Size(18, 20)
        Me.picerror2.TabIndex = 49
        Me.picerror2.TabStop = False
        Me.picerror2.Visible = False
        '
        'picerror1
        '
        Me.picerror1.Image = Global.customer.My.Resources.Resources._error
        Me.picerror1.Location = New System.Drawing.Point(394, 70)
        Me.picerror1.Name = "picerror1"
        Me.picerror1.Size = New System.Drawing.Size(18, 20)
        Me.picerror1.TabIndex = 48
        Me.picerror1.TabStop = False
        Me.picerror1.Visible = False
        '
        'picerror
        '
        Me.picerror.Image = Global.customer.My.Resources.Resources._error
        Me.picerror.Location = New System.Drawing.Point(394, 37)
        Me.picerror.Name = "picerror"
        Me.picerror.Size = New System.Drawing.Size(18, 20)
        Me.picerror.TabIndex = 47
        Me.picerror.TabStop = False
        Me.picerror.Visible = False
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(470, 37)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCustomer.Size = New System.Drawing.Size(98, 33)
        Me.btnCustomer.TabIndex = 56
        Me.btnCustomer.Text = "Customer Form"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(470, 85)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(98, 33)
        Me.btnBooking.TabIndex = 57
        Me.btnBooking.Text = "Booking Form"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 423)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.picerror7)
        Me.Controls.Add(Me.picerror6)
        Me.Controls.Add(Me.picerror4)
        Me.Controls.Add(Me.picerror5)
        Me.Controls.Add(Me.picerror3)
        Me.Controls.Add(Me.picerror2)
        Me.Controls.Add(Me.picerror1)
        Me.Controls.Add(Me.picerror)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txtfloor)
        Me.Controls.Add(Me.txtavailability)
        Me.Controls.Add(Me.txtnumbed)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtroomnum)
        Me.Controls.Add(Me.txtroomid)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblphone)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.lblcusid)
        Me.Name = "frmRoom"
        Me.Text = "Room Form"
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picerror7 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror6 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror4 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror5 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror3 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror2 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror1 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror As System.Windows.Forms.PictureBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtfloor As System.Windows.Forms.TextBox
    Friend WithEvents txtavailability As System.Windows.Forms.TextBox
    Friend WithEvents txtnumbed As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents txtroomnum As System.Windows.Forms.TextBox
    Friend WithEvents txtroomid As System.Windows.Forms.TextBox
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblphone As System.Windows.Forms.Label
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblcusid As System.Windows.Forms.Label
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnBooking As System.Windows.Forms.Button
End Class
