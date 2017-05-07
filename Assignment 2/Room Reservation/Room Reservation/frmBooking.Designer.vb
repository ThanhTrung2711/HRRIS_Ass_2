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
        Me.components = New System.ComponentModel.Container()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txttotalprice = New System.Windows.Forms.TextBox()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.txtnumguest = New System.Windows.Forms.TextBox()
        Me.txtnumday = New System.Windows.Forms.TextBox()
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
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFindBookId = New System.Windows.Forms.Button()
        Me.txtcusid = New System.Windows.Forms.ComboBox()
        Me.btnBookUpdate = New System.Windows.Forms.Button()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookingidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumguestsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckindateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomReservationDBDataSet2 = New customer.RoomReservationDBDataSet()
        Me.BookingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomReservationDBDataSet1 = New customer.RoomReservationDBDataSet1()
        Me.BookingTableAdapter1 = New customer.RoomReservationDBDataSet1TableAdapters.bookingTableAdapter()
        Me.RoomReservationDBDataSet = New customer.RoomReservationDBDataSet()
        Me.BookingTableAdapter = New customer.RoomReservationDBDataSetTableAdapters.bookingTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboprice = New System.Windows.Forms.ComboBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lbltype = New System.Windows.Forms.Label()
        Me.picerror = New System.Windows.Forms.PictureBox()
        Me.picerror8 = New System.Windows.Forms.PictureBox()
        Me.picerror1 = New System.Windows.Forms.PictureBox()
        Me.picerror7 = New System.Windows.Forms.PictureBox()
        Me.picerror2 = New System.Windows.Forms.PictureBox()
        Me.picerror6 = New System.Windows.Forms.PictureBox()
        Me.picerror3 = New System.Windows.Forms.PictureBox()
        Me.picerror4 = New System.Windows.Forms.PictureBox()
        Me.picerror5 = New System.Windows.Forms.PictureBox()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomReservationDBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomReservationDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomReservationDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(28, 88)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(98, 33)
        Me.btnadd.TabIndex = 46
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txttotalprice
        '
        Me.txttotalprice.Location = New System.Drawing.Point(107, 262)
        Me.txttotalprice.Name = "txttotalprice"
        Me.txttotalprice.Size = New System.Drawing.Size(257, 20)
        Me.txttotalprice.TabIndex = 45
        '
        'txtcomment
        '
        Me.txtcomment.Location = New System.Drawing.Point(107, 294)
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.Size = New System.Drawing.Size(257, 20)
        Me.txtcomment.TabIndex = 44
        '
        'txtnumguest
        '
        Me.txtnumguest.Location = New System.Drawing.Point(107, 199)
        Me.txtnumguest.Name = "txtnumguest"
        Me.txtnumguest.Size = New System.Drawing.Size(257, 20)
        Me.txtnumguest.TabIndex = 42
        '
        'txtnumday
        '
        Me.txtnumday.Location = New System.Drawing.Point(107, 165)
        Me.txtnumday.Name = "txtnumday"
        Me.txtnumday.Size = New System.Drawing.Size(257, 20)
        Me.txtnumday.TabIndex = 41
        '
        'txtbookid
        '
        Me.txtbookid.Location = New System.Drawing.Point(107, 18)
        Me.txtbookid.Name = "txtbookid"
        Me.txtbookid.Size = New System.Drawing.Size(257, 20)
        Me.txtbookid.TabIndex = 37
        Me.txtbookid.Text = " "
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(20, 301)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(56, 13)
        Me.lbldob.TabIndex = 36
        Me.lbldob.Text = "Comments"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(20, 236)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(72, 13)
        Me.lbladdress.TabIndex = 35
        Me.lbladdress.Text = "Checkin Date"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(20, 269)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(58, 13)
        Me.lblemail.TabIndex = 34
        Me.lblemail.Text = "Total Price"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Location = New System.Drawing.Point(20, 206)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(65, 13)
        Me.lblphone.TabIndex = 33
        Me.lblphone.Text = "Num Guests"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Location = New System.Drawing.Point(20, 172)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(56, 13)
        Me.lbllname.TabIndex = 32
        Me.lbllname.Text = "Num Days"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(20, 132)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(65, 13)
        Me.lblfname.TabIndex = 31
        Me.lblfname.Text = "Customer ID"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(20, 90)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(49, 13)
        Me.lblgender.TabIndex = 30
        Me.lblgender.Text = "Room ID"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(20, 58)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(30, 13)
        Me.lbltitle.TabIndex = 29
        Me.lbltitle.Text = "Date"
        '
        'lblcusid
        '
        Me.lblcusid.AutoSize = True
        Me.lblcusid.Location = New System.Drawing.Point(20, 21)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(60, 13)
        Me.lblcusid.TabIndex = 28
        Me.lblcusid.Text = "Booking ID"
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(17, 38)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(98, 33)
        Me.btnCustomer.TabIndex = 56
        Me.btnCustomer.Text = "Customer Form"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(17, 88)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(98, 33)
        Me.btnRoom.TabIndex = 58
        Me.btnRoom.Text = "Room Form"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'cboRoomid
        '
        Me.cboRoomid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomid.FormattingEnabled = True
        Me.cboRoomid.Location = New System.Drawing.Point(107, 83)
        Me.cboRoomid.Name = "cboRoomid"
        Me.cboRoomid.Size = New System.Drawing.Size(92, 21)
        Me.cboRoomid.TabIndex = 59
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(107, 51)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(257, 20)
        Me.txtdate.TabIndex = 60
        '
        'txtcheckinday
        '
        Me.txtcheckinday.Location = New System.Drawing.Point(107, 230)
        Me.txtcheckinday.Name = "txtcheckinday"
        Me.txtcheckinday.Size = New System.Drawing.Size(257, 20)
        Me.txtcheckinday.TabIndex = 61
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataCaptureToolStripMenuItem, Me.ReportingToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(998, 24)
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnFindBookId
        '
        Me.btnFindBookId.Location = New System.Drawing.Point(28, 272)
        Me.btnFindBookId.Name = "btnFindBookId"
        Me.btnFindBookId.Size = New System.Drawing.Size(98, 33)
        Me.btnFindBookId.TabIndex = 63
        Me.btnFindBookId.Text = "Find"
        Me.btnFindBookId.UseVisualStyleBackColor = True
        '
        'txtcusid
        '
        Me.txtcusid.FormattingEnabled = True
        Me.txtcusid.Location = New System.Drawing.Point(107, 124)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(257, 21)
        Me.txtcusid.TabIndex = 64
        '
        'btnBookUpdate
        '
        Me.btnBookUpdate.Location = New System.Drawing.Point(28, 150)
        Me.btnBookUpdate.Name = "btnBookUpdate"
        Me.btnBookUpdate.Size = New System.Drawing.Size(98, 33)
        Me.btnBookUpdate.TabIndex = 65
        Me.btnBookUpdate.Text = "Update"
        Me.btnBookUpdate.UseVisualStyleBackColor = True
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.Location = New System.Drawing.Point(28, 214)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(98, 33)
        Me.btnDeleteBook.TabIndex = 66
        Me.btnDeleteBook.Text = "Delete"
        Me.btnDeleteBook.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(262, 364)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 70
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(381, 364)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 69
        Me.btnLast.Text = "<|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(134, 364)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 68
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(13, 364)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 67
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingidDataGridViewTextBoxColumn, Me.BookingdateDataGridViewTextBoxColumn, Me.RoomidDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.NumdaysDataGridViewTextBoxColumn, Me.NumguestsDataGridViewTextBoxColumn, Me.CheckindateDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 473)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(952, 222)
        Me.DataGridView1.TabIndex = 83
        '
        'BookingidDataGridViewTextBoxColumn
        '
        Me.BookingidDataGridViewTextBoxColumn.DataPropertyName = "booking_id"
        Me.BookingidDataGridViewTextBoxColumn.HeaderText = "booking_id"
        Me.BookingidDataGridViewTextBoxColumn.Name = "BookingidDataGridViewTextBoxColumn"
        '
        'BookingdateDataGridViewTextBoxColumn
        '
        Me.BookingdateDataGridViewTextBoxColumn.DataPropertyName = "booking_date"
        Me.BookingdateDataGridViewTextBoxColumn.HeaderText = "booking_date"
        Me.BookingdateDataGridViewTextBoxColumn.Name = "BookingdateDataGridViewTextBoxColumn"
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'NumdaysDataGridViewTextBoxColumn
        '
        Me.NumdaysDataGridViewTextBoxColumn.DataPropertyName = "num_days"
        Me.NumdaysDataGridViewTextBoxColumn.HeaderText = "num_days"
        Me.NumdaysDataGridViewTextBoxColumn.Name = "NumdaysDataGridViewTextBoxColumn"
        '
        'NumguestsDataGridViewTextBoxColumn
        '
        Me.NumguestsDataGridViewTextBoxColumn.DataPropertyName = "num_guests"
        Me.NumguestsDataGridViewTextBoxColumn.HeaderText = "num_guests"
        Me.NumguestsDataGridViewTextBoxColumn.Name = "NumguestsDataGridViewTextBoxColumn"
        '
        'CheckindateDataGridViewTextBoxColumn
        '
        Me.CheckindateDataGridViewTextBoxColumn.DataPropertyName = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.HeaderText = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.Name = "CheckindateDataGridViewTextBoxColumn"
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "booking"
        Me.BookingBindingSource.DataSource = Me.RoomReservationDBDataSet2
        '
        'RoomReservationDBDataSet2
        '
        Me.RoomReservationDBDataSet2.DataSetName = "RoomReservationDBDataSet"
        Me.RoomReservationDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingBindingSource1
        '
        Me.BookingBindingSource1.DataMember = "booking"
        Me.BookingBindingSource1.DataSource = Me.RoomReservationDBDataSet1
        '
        'RoomReservationDBDataSet1
        '
        Me.RoomReservationDBDataSet1.DataSetName = "RoomReservationDBDataSet1"
        Me.RoomReservationDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'RoomReservationDBDataSet
        '
        Me.RoomReservationDBDataSet.DataSetName = "RoomReservationDBDataSet"
        Me.RoomReservationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.cboprice)
        Me.GroupBox2.Controls.Add(Me.cbotype)
        Me.GroupBox2.Controls.Add(Me.lblprice)
        Me.GroupBox2.Controls.Add(Me.lbltype)
        Me.GroupBox2.Controls.Add(Me.txtdate)
        Me.GroupBox2.Controls.Add(Me.lblcusid)
        Me.GroupBox2.Controls.Add(Me.lbltitle)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.lblgender)
        Me.GroupBox2.Controls.Add(Me.btnLast)
        Me.GroupBox2.Controls.Add(Me.lblfname)
        Me.GroupBox2.Controls.Add(Me.btnPrev)
        Me.GroupBox2.Controls.Add(Me.btnFirst)
        Me.GroupBox2.Controls.Add(Me.lbllname)
        Me.GroupBox2.Controls.Add(Me.lblphone)
        Me.GroupBox2.Controls.Add(Me.lblemail)
        Me.GroupBox2.Controls.Add(Me.lbladdress)
        Me.GroupBox2.Controls.Add(Me.txtcusid)
        Me.GroupBox2.Controls.Add(Me.lbldob)
        Me.GroupBox2.Controls.Add(Me.txtbookid)
        Me.GroupBox2.Controls.Add(Me.txtcheckinday)
        Me.GroupBox2.Controls.Add(Me.txtnumday)
        Me.GroupBox2.Controls.Add(Me.txtnumguest)
        Me.GroupBox2.Controls.Add(Me.cboRoomid)
        Me.GroupBox2.Controls.Add(Me.txtcomment)
        Me.GroupBox2.Controls.Add(Me.txttotalprice)
        Me.GroupBox2.Controls.Add(Me.picerror)
        Me.GroupBox2.Controls.Add(Me.picerror8)
        Me.GroupBox2.Controls.Add(Me.picerror1)
        Me.GroupBox2.Controls.Add(Me.picerror7)
        Me.GroupBox2.Controls.Add(Me.picerror2)
        Me.GroupBox2.Controls.Add(Me.picerror6)
        Me.GroupBox2.Controls.Add(Me.picerror3)
        Me.GroupBox2.Controls.Add(Me.picerror4)
        Me.GroupBox2.Controls.Add(Me.picerror5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 410)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Data Section"
        '
        'cboprice
        '
        Me.cboprice.Enabled = False
        Me.cboprice.FormattingEnabled = True
        Me.cboprice.Location = New System.Drawing.Point(396, 84)
        Me.cboprice.Name = "cboprice"
        Me.cboprice.Size = New System.Drawing.Size(76, 21)
        Me.cboprice.TabIndex = 76
        '
        'cbotype
        '
        Me.cbotype.Enabled = False
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(277, 84)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(76, 21)
        Me.cbotype.TabIndex = 75
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(359, 87)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(31, 13)
        Me.lblprice.TabIndex = 74
        Me.lblprice.Text = "Price"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Location = New System.Drawing.Point(239, 87)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(31, 13)
        Me.lbltype.TabIndex = 72
        Me.lbltype.Text = "Type"
        '
        'picerror
        '
        Me.picerror.Image = Global.customer.My.Resources.Resources._error
        Me.picerror.Location = New System.Drawing.Point(381, 18)
        Me.picerror.Name = "picerror"
        Me.picerror.Size = New System.Drawing.Size(18, 20)
        Me.picerror.TabIndex = 47
        Me.picerror.TabStop = False
        Me.picerror.Visible = False
        '
        'picerror8
        '
        Me.picerror8.Image = Global.customer.My.Resources.Resources._error
        Me.picerror8.Location = New System.Drawing.Point(381, 294)
        Me.picerror8.Name = "picerror8"
        Me.picerror8.Size = New System.Drawing.Size(18, 20)
        Me.picerror8.TabIndex = 55
        Me.picerror8.TabStop = False
        Me.picerror8.Visible = False
        '
        'picerror1
        '
        Me.picerror1.Image = Global.customer.My.Resources.Resources._error
        Me.picerror1.Location = New System.Drawing.Point(381, 51)
        Me.picerror1.Name = "picerror1"
        Me.picerror1.Size = New System.Drawing.Size(18, 20)
        Me.picerror1.TabIndex = 48
        Me.picerror1.TabStop = False
        Me.picerror1.Visible = False
        '
        'picerror7
        '
        Me.picerror7.Image = Global.customer.My.Resources.Resources._error
        Me.picerror7.Location = New System.Drawing.Point(381, 262)
        Me.picerror7.Name = "picerror7"
        Me.picerror7.Size = New System.Drawing.Size(18, 20)
        Me.picerror7.TabIndex = 54
        Me.picerror7.TabStop = False
        Me.picerror7.Visible = False
        '
        'picerror2
        '
        Me.picerror2.Image = Global.customer.My.Resources.Resources._error
        Me.picerror2.Location = New System.Drawing.Point(205, 84)
        Me.picerror2.Name = "picerror2"
        Me.picerror2.Size = New System.Drawing.Size(18, 20)
        Me.picerror2.TabIndex = 49
        Me.picerror2.TabStop = False
        Me.picerror2.Visible = False
        '
        'picerror6
        '
        Me.picerror6.Image = Global.customer.My.Resources.Resources._error
        Me.picerror6.Location = New System.Drawing.Point(381, 230)
        Me.picerror6.Name = "picerror6"
        Me.picerror6.Size = New System.Drawing.Size(18, 20)
        Me.picerror6.TabIndex = 53
        Me.picerror6.TabStop = False
        Me.picerror6.Visible = False
        '
        'picerror3
        '
        Me.picerror3.Image = Global.customer.My.Resources.Resources._error
        Me.picerror3.Location = New System.Drawing.Point(381, 127)
        Me.picerror3.Name = "picerror3"
        Me.picerror3.Size = New System.Drawing.Size(18, 20)
        Me.picerror3.TabIndex = 50
        Me.picerror3.TabStop = False
        Me.picerror3.Visible = False
        '
        'picerror4
        '
        Me.picerror4.Image = Global.customer.My.Resources.Resources._error
        Me.picerror4.Location = New System.Drawing.Point(381, 165)
        Me.picerror4.Name = "picerror4"
        Me.picerror4.Size = New System.Drawing.Size(18, 20)
        Me.picerror4.TabIndex = 52
        Me.picerror4.TabStop = False
        Me.picerror4.Visible = False
        '
        'picerror5
        '
        Me.picerror5.Image = Global.customer.My.Resources.Resources._error
        Me.picerror5.Location = New System.Drawing.Point(381, 199)
        Me.picerror5.Name = "picerror5"
        Me.picerror5.Size = New System.Drawing.Size(18, 20)
        Me.picerror5.TabIndex = 51
        Me.picerror5.TabStop = False
        Me.picerror5.Visible = False
        '
        'btnInvoice
        '
        Me.btnInvoice.Location = New System.Drawing.Point(28, 332)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(98, 33)
        Me.btnInvoice.TabIndex = 86
        Me.btnInvoice.Text = "Generate Invoice"
        Me.btnInvoice.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.btnCustomer)
        Me.GroupBox1.Controls.Add(Me.btnRoom)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 145)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transition Buttons"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.btnFindBookId)
        Me.GroupBox3.Controls.Add(Me.btnBookUpdate)
        Me.GroupBox3.Controls.Add(Me.btnInvoice)
        Me.GroupBox3.Controls.Add(Me.btnDeleteBook)
        Me.GroupBox3.Controls.Add(Me.btnadd)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 382)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Functions Buttons"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(28, 25)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 33)
        Me.btnClear.TabIndex = 87
        Me.btnClear.Text = "New Record"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(568, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(406, 410)
        Me.GroupBox4.TabIndex = 89
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buttons"
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 715)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomReservationDBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomReservationDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomReservationDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
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
    Friend WithEvents txtcusid As System.Windows.Forms.ComboBox
    Friend WithEvents btnBookUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBook As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RoomReservationDBDataSet As customer.RoomReservationDBDataSet
    Friend WithEvents BookingTableAdapter As customer.RoomReservationDBDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents BookingidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumdaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumguestsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckindateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomReservationDBDataSet1 As customer.RoomReservationDBDataSet1
    Friend WithEvents BookingBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter1 As customer.RoomReservationDBDataSet1TableAdapters.bookingTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RoomReservationDBDataSet2 As customer.RoomReservationDBDataSet
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents cboprice As System.Windows.Forms.ComboBox
    Friend WithEvents cbotype As System.Windows.Forms.ComboBox
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnInvoice As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
