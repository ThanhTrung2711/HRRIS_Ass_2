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
        Me.components = New System.ComponentModel.Container()
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
        Me.txttitle = New System.Windows.Forms.ComboBox()
        Me.txtgender = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDeleteCus = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomReservationDBDataSet2 = New customer.RoomReservationDBDataSet2()
        Me.CustomerTableAdapter = New customer.RoomReservationDBDataSet2TableAdapters.customerTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnedit = New System.Windows.Forms.Button()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomReservationDBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcusid
        '
        Me.lblcusid.AutoSize = True
        Me.lblcusid.Location = New System.Drawing.Point(19, 37)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(65, 13)
        Me.lblcusid.TabIndex = 0
        Me.lblcusid.Text = "Customer ID"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(19, 70)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(27, 13)
        Me.lbltitle.TabIndex = 1
        Me.lbltitle.Text = "Title"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(19, 105)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(42, 13)
        Me.lblgender.TabIndex = 2
        Me.lblgender.Text = "Gender"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(19, 146)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(52, 13)
        Me.lblfname.TabIndex = 3
        Me.lblfname.Text = "Firstname"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(19, 184)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(53, 13)
        Me.lbllname.TabIndex = 4
        Me.lbllname.Text = "Lastname"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Location = New System.Drawing.Point(19, 218)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(38, 13)
        Me.lblphone.TabIndex = 5
        Me.lblphone.Text = "Phone"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(19, 281)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(32, 13)
        Me.lblemail.TabIndex = 6
        Me.lblemail.Text = "Email"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(19, 249)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(45, 13)
        Me.lbladdress.TabIndex = 7
        Me.lbladdress.Text = "Address"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(19, 313)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(30, 13)
        Me.lbldob.TabIndex = 8
        Me.lbldob.Text = "DOB"
        '
        'txtcusid
        '
        Me.txtcusid.Location = New System.Drawing.Point(106, 37)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(257, 20)
        Me.txtcusid.TabIndex = 9
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(106, 146)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(257, 20)
        Me.txtfname.TabIndex = 12
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(106, 184)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(257, 20)
        Me.txtlname.TabIndex = 13
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(106, 218)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(257, 20)
        Me.txtphone.TabIndex = 14
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(106, 249)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(257, 20)
        Me.txtaddress.TabIndex = 15
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(106, 281)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(257, 20)
        Me.txtemail.TabIndex = 17
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(33, 107)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(98, 33)
        Me.btnadd.TabIndex = 18
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'picerror
        '
        Me.picerror.Image = Global.customer.My.Resources.Resources._error
        Me.picerror.Location = New System.Drawing.Point(380, 37)
        Me.picerror.Name = "picerror"
        Me.picerror.Size = New System.Drawing.Size(18, 20)
        Me.picerror.TabIndex = 19
        Me.picerror.TabStop = False
        Me.picerror.Visible = False
        '
        'picerror1
        '
        Me.picerror1.Image = Global.customer.My.Resources.Resources._error
        Me.picerror1.Location = New System.Drawing.Point(380, 70)
        Me.picerror1.Name = "picerror1"
        Me.picerror1.Size = New System.Drawing.Size(18, 20)
        Me.picerror1.TabIndex = 20
        Me.picerror1.TabStop = False
        Me.picerror1.Visible = False
        '
        'picerror2
        '
        Me.picerror2.Image = Global.customer.My.Resources.Resources._error
        Me.picerror2.Location = New System.Drawing.Point(380, 105)
        Me.picerror2.Name = "picerror2"
        Me.picerror2.Size = New System.Drawing.Size(18, 20)
        Me.picerror2.TabIndex = 21
        Me.picerror2.TabStop = False
        Me.picerror2.Visible = False
        '
        'picerror3
        '
        Me.picerror3.Image = Global.customer.My.Resources.Resources._error
        Me.picerror3.Location = New System.Drawing.Point(380, 146)
        Me.picerror3.Name = "picerror3"
        Me.picerror3.Size = New System.Drawing.Size(18, 20)
        Me.picerror3.TabIndex = 22
        Me.picerror3.TabStop = False
        Me.picerror3.Visible = False
        '
        'picerror5
        '
        Me.picerror5.Image = Global.customer.My.Resources.Resources._error
        Me.picerror5.Location = New System.Drawing.Point(380, 218)
        Me.picerror5.Name = "picerror5"
        Me.picerror5.Size = New System.Drawing.Size(18, 20)
        Me.picerror5.TabIndex = 23
        Me.picerror5.TabStop = False
        Me.picerror5.Visible = False
        '
        'picerror4
        '
        Me.picerror4.Image = Global.customer.My.Resources.Resources._error
        Me.picerror4.Location = New System.Drawing.Point(380, 184)
        Me.picerror4.Name = "picerror4"
        Me.picerror4.Size = New System.Drawing.Size(18, 20)
        Me.picerror4.TabIndex = 24
        Me.picerror4.TabStop = False
        Me.picerror4.Visible = False
        '
        'picerror6
        '
        Me.picerror6.Image = Global.customer.My.Resources.Resources._error
        Me.picerror6.Location = New System.Drawing.Point(380, 249)
        Me.picerror6.Name = "picerror6"
        Me.picerror6.Size = New System.Drawing.Size(18, 20)
        Me.picerror6.TabIndex = 25
        Me.picerror6.TabStop = False
        Me.picerror6.Visible = False
        '
        'picerror7
        '
        Me.picerror7.Image = Global.customer.My.Resources.Resources._error
        Me.picerror7.Location = New System.Drawing.Point(380, 281)
        Me.picerror7.Name = "picerror7"
        Me.picerror7.Size = New System.Drawing.Size(18, 20)
        Me.picerror7.TabIndex = 26
        Me.picerror7.TabStop = False
        Me.picerror7.Visible = False
        '
        'picerror8
        '
        Me.picerror8.Image = Global.customer.My.Resources.Resources._error
        Me.picerror8.Location = New System.Drawing.Point(380, 313)
        Me.picerror8.Name = "picerror8"
        Me.picerror8.Size = New System.Drawing.Size(18, 20)
        Me.picerror8.TabIndex = 27
        Me.picerror8.TabStop = False
        Me.picerror8.Visible = False
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(19, 28)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(98, 33)
        Me.btnBooking.TabIndex = 28
        Me.btnBooking.Text = "Booking Form"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(19, 86)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(98, 33)
        Me.btnRoom.TabIndex = 29
        Me.btnRoom.Text = "Room Form"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(106, 313)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(257, 20)
        Me.txtdob.TabIndex = 30
        '
        'btnfindID
        '
        Me.btnfindID.Location = New System.Drawing.Point(33, 328)
        Me.btnfindID.Name = "btnfindID"
        Me.btnfindID.Size = New System.Drawing.Size(98, 33)
        Me.btnfindID.TabIndex = 31
        Me.btnfindID.Text = "Find"
        Me.btnfindID.UseVisualStyleBackColor = True
        '
        'txttitle
        '
        Me.txttitle.FormattingEnabled = True
        Me.txttitle.Items.AddRange(New Object() {"Mr." & Global.Microsoft.VisualBasic.ChrW(9), "Ms.", "Mrs."})
        Me.txttitle.Location = New System.Drawing.Point(106, 70)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(257, 21)
        Me.txttitle.TabIndex = 32
        '
        'txtgender
        '
        Me.txtgender.FormattingEnabled = True
        Me.txtgender.Items.AddRange(New Object() {"Male" & Global.Microsoft.VisualBasic.ChrW(9), "Female "})
        Me.txtgender.Location = New System.Drawing.Point(106, 105)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(257, 21)
        Me.txtgender.TabIndex = 33
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(33, 179)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 33)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDeleteCus
        '
        Me.btnDeleteCus.Location = New System.Drawing.Point(33, 255)
        Me.btnDeleteCus.Name = "btnDeleteCus"
        Me.btnDeleteCus.Size = New System.Drawing.Size(98, 33)
        Me.btnDeleteCus.TabIndex = 35
        Me.btnDeleteCus.Text = "Delete"
        Me.btnDeleteCus.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(11, 367)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 36
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(134, 367)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 37
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(394, 367)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 38
        Me.btnLast.Text = "<|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(264, 367)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 39
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomeridDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 450)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(945, 220)
        Me.DataGridView1.TabIndex = 40
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.RoomReservationDBDataSet2
        '
        'RoomReservationDBDataSet2
        '
        Me.RoomReservationDBDataSet2.DataSetName = "RoomReservationDBDataSet2"
        Me.RoomReservationDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.lblcusid)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.lbltitle)
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.lblgender)
        Me.GroupBox1.Controls.Add(Me.btnPrev)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.lblfname)
        Me.GroupBox1.Controls.Add(Me.lbllname)
        Me.GroupBox1.Controls.Add(Me.lblphone)
        Me.GroupBox1.Controls.Add(Me.lblemail)
        Me.GroupBox1.Controls.Add(Me.txtgender)
        Me.GroupBox1.Controls.Add(Me.lbladdress)
        Me.GroupBox1.Controls.Add(Me.txttitle)
        Me.GroupBox1.Controls.Add(Me.lbldob)
        Me.GroupBox1.Controls.Add(Me.txtcusid)
        Me.GroupBox1.Controls.Add(Me.txtdob)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.picerror8)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.picerror7)
        Me.GroupBox1.Controls.Add(Me.picerror)
        Me.GroupBox1.Controls.Add(Me.picerror6)
        Me.GroupBox1.Controls.Add(Me.picerror1)
        Me.GroupBox1.Controls.Add(Me.picerror4)
        Me.GroupBox1.Controls.Add(Me.picerror2)
        Me.GroupBox1.Controls.Add(Me.picerror5)
        Me.GroupBox1.Controls.Add(Me.picerror3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 406)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Insert Section"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(542, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 410)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buttons"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox4.Controls.Add(Me.btnBooking)
        Me.GroupBox4.Controls.Add(Me.btnRoom)
        Me.GroupBox4.Location = New System.Drawing.Point(240, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(136, 145)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Transitions"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox3.Controls.Add(Me.btnedit)
        Me.GroupBox3.Controls.Add(Me.btnDeleteCus)
        Me.GroupBox3.Controls.Add(Me.btnadd)
        Me.GroupBox3.Controls.Add(Me.btnfindID)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 382)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Functions Buttons"
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(33, 31)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(98, 33)
        Me.btnedit.TabIndex = 36
        Me.btnedit.Text = "New Record"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 692)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomReservationDBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents txttitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtgender As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCus As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RoomReservationDBDataSet2 As customer.RoomReservationDBDataSet2
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As customer.RoomReservationDBDataSet2TableAdapters.customerTableAdapter
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnedit As System.Windows.Forms.Button

End Class
