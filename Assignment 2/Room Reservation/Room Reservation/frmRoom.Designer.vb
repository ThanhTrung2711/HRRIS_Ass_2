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
        Me.components = New System.ComponentModel.Container()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
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
        Me.picerror1 = New System.Windows.Forms.PictureBox()
        Me.picerror = New System.Windows.Forms.PictureBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnFindRoomId = New System.Windows.Forms.Button()
        Me.txttype = New System.Windows.Forms.ComboBox()
        Me.txtavailability = New System.Windows.Forms.ComboBox()
        Me.txtfloor = New System.Windows.Forms.ComboBox()
        Me.btnRoomUpdate = New System.Windows.Forms.Button()
        Me.btnDeleteRoom = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumbedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailabilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomReservationDBDataSet3 = New customer.RoomReservationDBDataSet3()
        Me.RoomTableAdapter = New customer.RoomReservationDBDataSet3TableAdapters.roomTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picerror2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.txtnumbed = New System.Windows.Forms.ComboBox()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomReservationDBDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(30, 109)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(98, 33)
        Me.btnadd.TabIndex = 46
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(114, 286)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(257, 20)
        Me.txtdescription.TabIndex = 45
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(114, 151)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(257, 20)
        Me.txtprice.TabIndex = 40
        '
        'txtroomnum
        '
        Me.txtroomnum.Location = New System.Drawing.Point(114, 75)
        Me.txtroomnum.Name = "txtroomnum"
        Me.txtroomnum.Size = New System.Drawing.Size(257, 20)
        Me.txtroomnum.TabIndex = 38
        '
        'txtroomid
        '
        Me.txtroomid.Location = New System.Drawing.Point(114, 42)
        Me.txtroomid.Name = "txtroomid"
        Me.txtroomid.Size = New System.Drawing.Size(257, 20)
        Me.txtroomid.TabIndex = 37
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(27, 254)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(30, 13)
        Me.lbladdress.TabIndex = 35
        Me.lbladdress.Text = "Floor"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(27, 286)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(60, 13)
        Me.lblemail.TabIndex = 34
        Me.lblemail.Text = "Description"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Location = New System.Drawing.Point(27, 223)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(56, 13)
        Me.lblphone.TabIndex = 33
        Me.lblphone.Text = "Availability"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(27, 189)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(56, 13)
        Me.lbllname.TabIndex = 32
        Me.lbllname.Text = "Num Beds"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(27, 151)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(31, 13)
        Me.lblfname.TabIndex = 31
        Me.lblfname.Text = "Price"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(27, 110)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(31, 13)
        Me.lblgender.TabIndex = 30
        Me.lblgender.Text = "Type"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(27, 75)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(75, 13)
        Me.lbltitle.TabIndex = 29
        Me.lbltitle.Text = "Room Number"
        '
        'lblcusid
        '
        Me.lblcusid.AutoSize = True
        Me.lblcusid.Location = New System.Drawing.Point(27, 42)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(49, 13)
        Me.lblcusid.TabIndex = 28
        Me.lblcusid.Text = "Room ID"
        '
        'picerror7
        '
        Me.picerror7.Image = Global.customer.My.Resources.Resources._error
        Me.picerror7.Location = New System.Drawing.Point(388, 286)
        Me.picerror7.Name = "picerror7"
        Me.picerror7.Size = New System.Drawing.Size(18, 20)
        Me.picerror7.TabIndex = 54
        Me.picerror7.TabStop = False
        Me.picerror7.Visible = False
        '
        'picerror6
        '
        Me.picerror6.Image = Global.customer.My.Resources.Resources._error
        Me.picerror6.Location = New System.Drawing.Point(388, 254)
        Me.picerror6.Name = "picerror6"
        Me.picerror6.Size = New System.Drawing.Size(18, 20)
        Me.picerror6.TabIndex = 53
        Me.picerror6.TabStop = False
        Me.picerror6.Visible = False
        '
        'picerror4
        '
        Me.picerror4.Image = Global.customer.My.Resources.Resources._error
        Me.picerror4.Location = New System.Drawing.Point(388, 189)
        Me.picerror4.Name = "picerror4"
        Me.picerror4.Size = New System.Drawing.Size(18, 20)
        Me.picerror4.TabIndex = 52
        Me.picerror4.TabStop = False
        Me.picerror4.Visible = False
        '
        'picerror5
        '
        Me.picerror5.Image = Global.customer.My.Resources.Resources._error
        Me.picerror5.Location = New System.Drawing.Point(388, 223)
        Me.picerror5.Name = "picerror5"
        Me.picerror5.Size = New System.Drawing.Size(18, 20)
        Me.picerror5.TabIndex = 51
        Me.picerror5.TabStop = False
        Me.picerror5.Visible = False
        '
        'picerror3
        '
        Me.picerror3.Image = Global.customer.My.Resources.Resources._error
        Me.picerror3.Location = New System.Drawing.Point(388, 151)
        Me.picerror3.Name = "picerror3"
        Me.picerror3.Size = New System.Drawing.Size(18, 20)
        Me.picerror3.TabIndex = 50
        Me.picerror3.TabStop = False
        Me.picerror3.Visible = False
        '
        'picerror1
        '
        Me.picerror1.Image = Global.customer.My.Resources.Resources._error
        Me.picerror1.Location = New System.Drawing.Point(388, 75)
        Me.picerror1.Name = "picerror1"
        Me.picerror1.Size = New System.Drawing.Size(18, 20)
        Me.picerror1.TabIndex = 48
        Me.picerror1.TabStop = False
        Me.picerror1.Visible = False
        '
        'picerror
        '
        Me.picerror.Image = Global.customer.My.Resources.Resources._error
        Me.picerror.Location = New System.Drawing.Point(388, 42)
        Me.picerror.Name = "picerror"
        Me.picerror.Size = New System.Drawing.Size(18, 20)
        Me.picerror.TabIndex = 47
        Me.picerror.TabStop = False
        Me.picerror.Visible = False
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(16, 24)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCustomer.Size = New System.Drawing.Size(98, 33)
        Me.btnCustomer.TabIndex = 56
        Me.btnCustomer.Text = "Customer Form"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.Location = New System.Drawing.Point(16, 88)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(98, 33)
        Me.btnBooking.TabIndex = 57
        Me.btnBooking.Text = "Booking Form"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnFindRoomId
        '
        Me.btnFindRoomId.Location = New System.Drawing.Point(30, 331)
        Me.btnFindRoomId.Name = "btnFindRoomId"
        Me.btnFindRoomId.Size = New System.Drawing.Size(98, 33)
        Me.btnFindRoomId.TabIndex = 58
        Me.btnFindRoomId.Text = "Find"
        Me.btnFindRoomId.UseVisualStyleBackColor = True
        '
        'txttype
        '
        Me.txttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txttype.FormattingEnabled = True
        Me.txttype.Items.AddRange(New Object() {"Luxury", "Economy" & Global.Microsoft.VisualBasic.ChrW(9), "Family" & Global.Microsoft.VisualBasic.ChrW(9), "Single"})
        Me.txttype.Location = New System.Drawing.Point(114, 110)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(257, 21)
        Me.txttype.TabIndex = 59
        '
        'txtavailability
        '
        Me.txtavailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtavailability.FormattingEnabled = True
        Me.txtavailability.Items.AddRange(New Object() {"Yes ", "No"})
        Me.txtavailability.Location = New System.Drawing.Point(114, 223)
        Me.txtavailability.Name = "txtavailability"
        Me.txtavailability.Size = New System.Drawing.Size(257, 21)
        Me.txtavailability.TabIndex = 60
        '
        'txtfloor
        '
        Me.txtfloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtfloor.FormattingEnabled = True
        Me.txtfloor.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "6", "7", "8", "9", "10"})
        Me.txtfloor.Location = New System.Drawing.Point(114, 254)
        Me.txtfloor.Name = "txtfloor"
        Me.txtfloor.Size = New System.Drawing.Size(257, 21)
        Me.txtfloor.TabIndex = 61
        '
        'btnRoomUpdate
        '
        Me.btnRoomUpdate.Location = New System.Drawing.Point(30, 181)
        Me.btnRoomUpdate.Name = "btnRoomUpdate"
        Me.btnRoomUpdate.Size = New System.Drawing.Size(98, 33)
        Me.btnRoomUpdate.TabIndex = 62
        Me.btnRoomUpdate.Text = "Update"
        Me.btnRoomUpdate.UseVisualStyleBackColor = True
        '
        'btnDeleteRoom
        '
        Me.btnDeleteRoom.Location = New System.Drawing.Point(30, 254)
        Me.btnDeleteRoom.Name = "btnDeleteRoom"
        Me.btnDeleteRoom.Size = New System.Drawing.Size(98, 33)
        Me.btnDeleteRoom.TabIndex = 63
        Me.btnDeleteRoom.Text = "Delete"
        Me.btnDeleteRoom.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(252, 341)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 67
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(374, 341)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 66
        Me.btnLast.Text = "<|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(134, 341)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 65
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(17, 341)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 64
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomidDataGridViewTextBoxColumn, Me.RoomnumberDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.NumbedsDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn, Me.FloorDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RoomBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 432)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(849, 239)
        Me.DataGridView1.TabIndex = 68
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        '
        'RoomnumberDataGridViewTextBoxColumn
        '
        Me.RoomnumberDataGridViewTextBoxColumn.DataPropertyName = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.HeaderText = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.Name = "RoomnumberDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'NumbedsDataGridViewTextBoxColumn
        '
        Me.NumbedsDataGridViewTextBoxColumn.DataPropertyName = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.HeaderText = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.Name = "NumbedsDataGridViewTextBoxColumn"
        '
        'AvailabilityDataGridViewTextBoxColumn
        '
        Me.AvailabilityDataGridViewTextBoxColumn.DataPropertyName = "availability"
        Me.AvailabilityDataGridViewTextBoxColumn.HeaderText = "availability"
        Me.AvailabilityDataGridViewTextBoxColumn.Name = "AvailabilityDataGridViewTextBoxColumn"
        '
        'FloorDataGridViewTextBoxColumn
        '
        Me.FloorDataGridViewTextBoxColumn.DataPropertyName = "floor"
        Me.FloorDataGridViewTextBoxColumn.HeaderText = "floor"
        Me.FloorDataGridViewTextBoxColumn.Name = "FloorDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me.RoomReservationDBDataSet3
        '
        'RoomReservationDBDataSet3
        '
        Me.RoomReservationDBDataSet3.DataSetName = "RoomReservationDBDataSet3"
        Me.RoomReservationDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.txtnumbed)
        Me.GroupBox1.Controls.Add(Me.picerror2)
        Me.GroupBox1.Controls.Add(Me.txttype)
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
        Me.GroupBox1.Controls.Add(Me.txtfloor)
        Me.GroupBox1.Controls.Add(Me.lbladdress)
        Me.GroupBox1.Controls.Add(Me.txtavailability)
        Me.GroupBox1.Controls.Add(Me.txtroomid)
        Me.GroupBox1.Controls.Add(Me.txtroomnum)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.picerror7)
        Me.GroupBox1.Controls.Add(Me.picerror)
        Me.GroupBox1.Controls.Add(Me.picerror6)
        Me.GroupBox1.Controls.Add(Me.picerror1)
        Me.GroupBox1.Controls.Add(Me.picerror4)
        Me.GroupBox1.Controls.Add(Me.picerror5)
        Me.GroupBox1.Controls.Add(Me.picerror3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 410)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Data Section"
        '
        'picerror2
        '
        Me.picerror2.Image = Global.customer.My.Resources.Resources._error
        Me.picerror2.Location = New System.Drawing.Point(388, 111)
        Me.picerror2.Name = "picerror2"
        Me.picerror2.Size = New System.Drawing.Size(18, 20)
        Me.picerror2.TabIndex = 68
        Me.picerror2.TabStop = False
        Me.picerror2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(505, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 410)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buttons"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox3.Controls.Add(Me.btnCustomer)
        Me.GroupBox3.Controls.Add(Me.btnBooking)
        Me.GroupBox3.Location = New System.Drawing.Point(202, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 145)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transition Buttons"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox4.Controls.Add(Me.btnclear)
        Me.GroupBox4.Controls.Add(Me.btnFindRoomId)
        Me.GroupBox4.Controls.Add(Me.btnadd)
        Me.GroupBox4.Controls.Add(Me.btnRoomUpdate)
        Me.GroupBox4.Controls.Add(Me.btnDeleteRoom)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(167, 382)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Functions Buttons"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(30, 28)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(98, 33)
        Me.btnclear.TabIndex = 64
        Me.btnclear.Text = "New Record"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'txtnumbed
        '
        Me.txtnumbed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtnumbed.FormattingEnabled = True
        Me.txtnumbed.Items.AddRange(New Object() {"1", "2", "3"})
        Me.txtnumbed.Location = New System.Drawing.Point(114, 186)
        Me.txtnumbed.Name = "txtnumbed"
        Me.txtnumbed.Size = New System.Drawing.Size(257, 21)
        Me.txtnumbed.TabIndex = 69
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 681)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Form"
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomReservationDBDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picerror7 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror6 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror4 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror5 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror3 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror1 As System.Windows.Forms.PictureBox
    Friend WithEvents picerror As System.Windows.Forms.PictureBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
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
    Friend WithEvents btnFindRoomId As System.Windows.Forms.Button
    Friend WithEvents txttype As System.Windows.Forms.ComboBox
    Friend WithEvents txtavailability As System.Windows.Forms.ComboBox
    Friend WithEvents txtfloor As System.Windows.Forms.ComboBox
    Friend WithEvents btnRoomUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDeleteRoom As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RoomReservationDBDataSet3 As customer.RoomReservationDBDataSet3
    Friend WithEvents RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTableAdapter As customer.RoomReservationDBDataSet3TableAdapters.roomTableAdapter
    Friend WithEvents RoomidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumbedsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FloorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents picerror2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtnumbed As System.Windows.Forms.ComboBox
End Class
