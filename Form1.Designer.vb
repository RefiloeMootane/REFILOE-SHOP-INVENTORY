<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim CUSTOMER_IDLabel As System.Windows.Forms.Label
        Dim TITLELabel As System.Windows.Forms.Label
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Dim LASTNAMELabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim CONTACT_NUMBERLabel As System.Windows.Forms.Label
        Dim PRODUCT_IDLabel As System.Windows.Forms.Label
        Dim ORDER_IDLabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim CUSTOMER_IDLabel1 As System.Windows.Forms.Label
        Dim ORDER_IDLabel1 As System.Windows.Forms.Label
        Dim DATELabel As System.Windows.Forms.Label
        Dim DISPATCHEDLabel As System.Windows.Forms.Label
        Dim PAYEDLabel As System.Windows.Forms.Label
        Dim PRODUCT_IDLabel1 As System.Windows.Forms.Label
        Dim PRODUCT_CATEGORYLabel As System.Windows.Forms.Label
        Dim PRODUCT__NAMELabel As System.Windows.Forms.Label
        Dim PRODUCT_SIZELabel As System.Windows.Forms.Label
        Dim LEVELLabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim MAXIMUM_LEVELLabel As System.Windows.Forms.Label
        Me.SHOPDataSet = New REFILOE_SHOP_INVENTORY.SHOPDataSet()
        Me.SHOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SHOPTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.SHOPTableAdapter()
        Me.TableAdapterManager = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.TableAdapterManager()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtPASSWORD = New System.Windows.Forms.TextBox()
        Me.cmbUsername = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.btnRESET = New System.Windows.Forms.Button()
        Me.btnPASSWORD = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.CUSTOMER_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMER_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LASTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.CONTACT_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PRODUCT_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ORDER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PRODUCT_ORDERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PRODUCT_ORDERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMER_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.ORDER_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DISPATCHEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.PAYEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PRODUCT_CATALOGDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_CATALOGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCT_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.PRODUCT_CATEGORYTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT__NAMETextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT_SIZETextBox = New System.Windows.Forms.TextBox()
        Me.LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.MAXIMUM_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMER_DETAILSTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.CUSTOMER_DETAILSTableAdapter()
        Me.PRODUCT_DETAILSTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.PRODUCT_DETAILSTableAdapter()
        Me.PRODUCT_ORDERTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.PRODUCT_ORDERTableAdapter()
        Me.PRODUCT_CATALOGTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.PRODUCT_CATALOGTableAdapter()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        TITLELabel = New System.Windows.Forms.Label()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        LASTNAMELabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        CONTACT_NUMBERLabel = New System.Windows.Forms.Label()
        PRODUCT_IDLabel = New System.Windows.Forms.Label()
        ORDER_IDLabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        CUSTOMER_IDLabel1 = New System.Windows.Forms.Label()
        ORDER_IDLabel1 = New System.Windows.Forms.Label()
        DATELabel = New System.Windows.Forms.Label()
        DISPATCHEDLabel = New System.Windows.Forms.Label()
        PAYEDLabel = New System.Windows.Forms.Label()
        PRODUCT_IDLabel1 = New System.Windows.Forms.Label()
        PRODUCT_CATEGORYLabel = New System.Windows.Forms.Label()
        PRODUCT__NAMELabel = New System.Windows.Forms.Label()
        PRODUCT_SIZELabel = New System.Windows.Forms.Label()
        LEVELLabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        MAXIMUM_LEVELLabel = New System.Windows.Forms.Label()
        CType(Me.SHOPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CUSTOMER_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PRODUCT_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PRODUCT_ORDERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_ORDERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PRODUCT_CATALOGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_CATALOGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(6, 26)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(97, 13)
        CUSTOMER_IDLabel.TabIndex = 0
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Location = New System.Drawing.Point(6, 52)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(46, 13)
        TITLELabel.TabIndex = 2
        TITLELabel.Text = "TITLE:"
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Location = New System.Drawing.Point(6, 78)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(86, 13)
        FIRST_NAMELabel.TabIndex = 4
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'LASTNAMELabel
        '
        LASTNAMELabel.AutoSize = True
        LASTNAMELabel.Location = New System.Drawing.Point(6, 104)
        LASTNAMELabel.Name = "LASTNAMELabel"
        LASTNAMELabel.Size = New System.Drawing.Size(77, 13)
        LASTNAMELabel.TabIndex = 6
        LASTNAMELabel.Text = "LASTNAME:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Location = New System.Drawing.Point(6, 130)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(70, 13)
        ADDRESSLabel.TabIndex = 8
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'CONTACT_NUMBERLabel
        '
        CONTACT_NUMBERLabel.AutoSize = True
        CONTACT_NUMBERLabel.Location = New System.Drawing.Point(6, 156)
        CONTACT_NUMBERLabel.Name = "CONTACT_NUMBERLabel"
        CONTACT_NUMBERLabel.Size = New System.Drawing.Size(126, 13)
        CONTACT_NUMBERLabel.TabIndex = 10
        CONTACT_NUMBERLabel.Text = "CONTACT NUMBER:"
        '
        'PRODUCT_IDLabel
        '
        PRODUCT_IDLabel.AutoSize = True
        PRODUCT_IDLabel.Location = New System.Drawing.Point(8, 22)
        PRODUCT_IDLabel.Name = "PRODUCT_IDLabel"
        PRODUCT_IDLabel.Size = New System.Drawing.Size(88, 13)
        PRODUCT_IDLabel.TabIndex = 0
        PRODUCT_IDLabel.Text = "PRODUCT ID:"
        '
        'ORDER_IDLabel
        '
        ORDER_IDLabel.AutoSize = True
        ORDER_IDLabel.Location = New System.Drawing.Point(8, 48)
        ORDER_IDLabel.Name = "ORDER_IDLabel"
        ORDER_IDLabel.Size = New System.Drawing.Size(72, 13)
        ORDER_IDLabel.TabIndex = 2
        ORDER_IDLabel.Text = "ORDER ID:"
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(8, 74)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(74, 13)
        QUANTITYLabel.TabIndex = 4
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'CUSTOMER_IDLabel1
        '
        CUSTOMER_IDLabel1.AutoSize = True
        CUSTOMER_IDLabel1.Location = New System.Drawing.Point(6, 20)
        CUSTOMER_IDLabel1.Name = "CUSTOMER_IDLabel1"
        CUSTOMER_IDLabel1.Size = New System.Drawing.Size(97, 13)
        CUSTOMER_IDLabel1.TabIndex = 0
        CUSTOMER_IDLabel1.Text = "CUSTOMER ID:"
        '
        'ORDER_IDLabel1
        '
        ORDER_IDLabel1.AutoSize = True
        ORDER_IDLabel1.Location = New System.Drawing.Point(6, 46)
        ORDER_IDLabel1.Name = "ORDER_IDLabel1"
        ORDER_IDLabel1.Size = New System.Drawing.Size(72, 13)
        ORDER_IDLabel1.TabIndex = 2
        ORDER_IDLabel1.Text = "ORDER ID:"
        '
        'DATELabel
        '
        DATELabel.AutoSize = True
        DATELabel.Location = New System.Drawing.Point(6, 73)
        DATELabel.Name = "DATELabel"
        DATELabel.Size = New System.Drawing.Size(44, 13)
        DATELabel.TabIndex = 4
        DATELabel.Text = "DATE:"
        '
        'DISPATCHEDLabel
        '
        DISPATCHEDLabel.AutoSize = True
        DISPATCHEDLabel.Location = New System.Drawing.Point(6, 100)
        DISPATCHEDLabel.Name = "DISPATCHEDLabel"
        DISPATCHEDLabel.Size = New System.Drawing.Size(90, 13)
        DISPATCHEDLabel.TabIndex = 6
        DISPATCHEDLabel.Text = "DISPATCHED:"
        '
        'PAYEDLabel
        '
        PAYEDLabel.AutoSize = True
        PAYEDLabel.Location = New System.Drawing.Point(6, 130)
        PAYEDLabel.Name = "PAYEDLabel"
        PAYEDLabel.Size = New System.Drawing.Size(52, 13)
        PAYEDLabel.TabIndex = 8
        PAYEDLabel.Text = "PAYED:"
        '
        'PRODUCT_IDLabel1
        '
        PRODUCT_IDLabel1.AutoSize = True
        PRODUCT_IDLabel1.Location = New System.Drawing.Point(12, 23)
        PRODUCT_IDLabel1.Name = "PRODUCT_IDLabel1"
        PRODUCT_IDLabel1.Size = New System.Drawing.Size(88, 13)
        PRODUCT_IDLabel1.TabIndex = 0
        PRODUCT_IDLabel1.Text = "PRODUCT ID:"
        '
        'PRODUCT_CATEGORYLabel
        '
        PRODUCT_CATEGORYLabel.AutoSize = True
        PRODUCT_CATEGORYLabel.Location = New System.Drawing.Point(12, 49)
        PRODUCT_CATEGORYLabel.Name = "PRODUCT_CATEGORYLabel"
        PRODUCT_CATEGORYLabel.Size = New System.Drawing.Size(142, 13)
        PRODUCT_CATEGORYLabel.TabIndex = 2
        PRODUCT_CATEGORYLabel.Text = "PRODUCT CATEGORY:"
        '
        'PRODUCT__NAMELabel
        '
        PRODUCT__NAMELabel.AutoSize = True
        PRODUCT__NAMELabel.Location = New System.Drawing.Point(12, 75)
        PRODUCT__NAMELabel.Name = "PRODUCT__NAMELabel"
        PRODUCT__NAMELabel.Size = New System.Drawing.Size(114, 13)
        PRODUCT__NAMELabel.TabIndex = 4
        PRODUCT__NAMELabel.Text = "PRODUCT  NAME:"
        '
        'PRODUCT_SIZELabel
        '
        PRODUCT_SIZELabel.AutoSize = True
        PRODUCT_SIZELabel.Location = New System.Drawing.Point(12, 101)
        PRODUCT_SIZELabel.Name = "PRODUCT_SIZELabel"
        PRODUCT_SIZELabel.Size = New System.Drawing.Size(103, 13)
        PRODUCT_SIZELabel.TabIndex = 6
        PRODUCT_SIZELabel.Text = "PRODUCT SIZE:"
        '
        'LEVELLabel
        '
        LEVELLabel.AutoSize = True
        LEVELLabel.Location = New System.Drawing.Point(12, 127)
        LEVELLabel.Name = "LEVELLabel"
        LEVELLabel.Size = New System.Drawing.Size(49, 13)
        LEVELLabel.TabIndex = 8
        LEVELLabel.Text = "LEVEL:"
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.Location = New System.Drawing.Point(12, 153)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(82, 13)
        UNIT_PRICELabel.TabIndex = 10
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'MAXIMUM_LEVELLabel
        '
        MAXIMUM_LEVELLabel.AutoSize = True
        MAXIMUM_LEVELLabel.Location = New System.Drawing.Point(12, 179)
        MAXIMUM_LEVELLabel.Name = "MAXIMUM_LEVELLabel"
        MAXIMUM_LEVELLabel.Size = New System.Drawing.Size(112, 13)
        MAXIMUM_LEVELLabel.TabIndex = 12
        MAXIMUM_LEVELLabel.Text = "MAXIMUM LEVEL:"
        '
        'SHOPDataSet
        '
        Me.SHOPDataSet.DataSetName = "SHOPDataSet"
        Me.SHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SHOPBindingSource
        '
        Me.SHOPBindingSource.DataMember = "SHOP"
        Me.SHOPBindingSource.DataSource = Me.SHOPDataSet
        '
        'SHOPTableAdapter
        '
        Me.SHOPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CUSTOMER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_CATALOGTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_ORDERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(18, 59)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(100, 15)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "DEPARTMENT"
        '
        'txtPASSWORD
        '
        Me.txtPASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPASSWORD.Location = New System.Drawing.Point(120, 123)
        Me.txtPASSWORD.Name = "txtPASSWORD"
        Me.txtPASSWORD.Size = New System.Drawing.Size(142, 21)
        Me.txtPASSWORD.TabIndex = 1
        '
        'cmbUsername
        '
        Me.cmbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsername.FormattingEnabled = True
        Me.cmbUsername.Location = New System.Drawing.Point(120, 56)
        Me.cmbUsername.Name = "cmbUsername"
        Me.cmbUsername.Size = New System.Drawing.Size(142, 23)
        Me.cmbUsername.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.btnEXIT)
        Me.GroupBox1.Controls.Add(Me.lblDepartment)
        Me.GroupBox1.Controls.Add(Me.btnRESET)
        Me.GroupBox1.Controls.Add(Me.txtPASSWORD)
        Me.GroupBox1.Controls.Add(Me.btnPASSWORD)
        Me.GroupBox1.Controls.Add(Me.cmbUsername)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 210)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN SCREEN"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(120, 90)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(142, 27)
        Me.txtUsername.TabIndex = 2
        '
        'btnEXIT
        '
        Me.btnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.Location = New System.Drawing.Point(256, 180)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(75, 23)
        Me.btnEXIT.TabIndex = 8
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'btnRESET
        '
        Me.btnRESET.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRESET.Location = New System.Drawing.Point(138, 180)
        Me.btnRESET.Name = "btnRESET"
        Me.btnRESET.Size = New System.Drawing.Size(75, 23)
        Me.btnRESET.TabIndex = 7
        Me.btnRESET.Text = "RESET"
        Me.btnRESET.UseVisualStyleBackColor = True
        '
        'btnPASSWORD
        '
        Me.btnPASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPASSWORD.Location = New System.Drawing.Point(21, 180)
        Me.btnPASSWORD.Name = "btnPASSWORD"
        Me.btnPASSWORD.Size = New System.Drawing.Size(97, 23)
        Me.btnPASSWORD.TabIndex = 6
        Me.btnPASSWORD.Text = "PASSWORD"
        Me.btnPASSWORD.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(18, 123)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(84, 15)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "PASSWORD"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(18, 94)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(84, 15)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "USERNAME"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 304)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(778, 401)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.btnClose)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnPrevious)
        Me.TabPage1.Controls.Add(Me.btnNext)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.CUSTOMER_DETAILSDataGridView)
        Me.TabPage1.Controls.Add(CUSTOMER_IDLabel)
        Me.TabPage1.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.TabPage1.Controls.Add(TITLELabel)
        Me.TabPage1.Controls.Add(Me.TITLETextBox)
        Me.TabPage1.Controls.Add(FIRST_NAMELabel)
        Me.TabPage1.Controls.Add(Me.FIRST_NAMETextBox)
        Me.TabPage1.Controls.Add(LASTNAMELabel)
        Me.TabPage1.Controls.Add(Me.LASTNAMETextBox)
        Me.TabPage1.Controls.Add(ADDRESSLabel)
        Me.TabPage1.Controls.Add(Me.ADDRESSTextBox)
        Me.TabPage1.Controls.Add(CONTACT_NUMBERLabel)
        Me.TabPage1.Controls.Add(Me.CONTACT_NUMBERTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(770, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CUSTOMER DETAILS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(490, 156)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "EXIT"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(490, 99)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(490, 46)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(313, 156)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(92, 23)
        Me.btnPrevious.TabIndex = 15
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(313, 104)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(92, 23)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(313, 45)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'CUSTOMER_DETAILSDataGridView
        '
        Me.CUSTOMER_DETAILSDataGridView.AutoGenerateColumns = False
        Me.CUSTOMER_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CUSTOMER_DETAILSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CUSTOMER_DETAILSDataGridView.DataSource = Me.CUSTOMER_DETAILSBindingSource
        Me.CUSTOMER_DETAILSDataGridView.Location = New System.Drawing.Point(0, 198)
        Me.CUSTOMER_DETAILSDataGridView.Name = "CUSTOMER_DETAILSDataGridView"
        Me.CUSTOMER_DETAILSDataGridView.Size = New System.Drawing.Size(643, 171)
        Me.CUSTOMER_DETAILSDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TITLE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TITLE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FIRST NAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FIRST NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LASTNAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LASTNAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CONTACT NUMBER"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CONTACT NUMBER"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'CUSTOMER_DETAILSBindingSource
        '
        Me.CUSTOMER_DETAILSBindingSource.DataMember = "CUSTOMER DETAILS"
        Me.CUSTOMER_DETAILSBindingSource.DataSource = Me.SHOPDataSet
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(123, 23)
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 1
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "TITLE", True))
        Me.TITLETextBox.Location = New System.Drawing.Point(123, 49)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TITLETextBox.TabIndex = 3
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "FIRST NAME", True))
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(123, 75)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.FIRST_NAMETextBox.TabIndex = 5
        '
        'LASTNAMETextBox
        '
        Me.LASTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "LASTNAME", True))
        Me.LASTNAMETextBox.Location = New System.Drawing.Point(123, 101)
        Me.LASTNAMETextBox.Name = "LASTNAMETextBox"
        Me.LASTNAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.LASTNAMETextBox.TabIndex = 7
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(123, 127)
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ADDRESSTextBox.TabIndex = 9
        '
        'CONTACT_NUMBERTextBox
        '
        Me.CONTACT_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "CONTACT NUMBER", True))
        Me.CONTACT_NUMBERTextBox.Location = New System.Drawing.Point(123, 153)
        Me.CONTACT_NUMBERTextBox.Name = "CONTACT_NUMBERTextBox"
        Me.CONTACT_NUMBERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CONTACT_NUMBERTextBox.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.PRODUCT_DETAILSDataGridView)
        Me.TabPage2.Controls.Add(PRODUCT_IDLabel)
        Me.TabPage2.Controls.Add(Me.PRODUCT_IDTextBox)
        Me.TabPage2.Controls.Add(ORDER_IDLabel)
        Me.TabPage2.Controls.Add(Me.ORDER_IDTextBox)
        Me.TabPage2.Controls.Add(QUANTITYLabel)
        Me.TabPage2.Controls.Add(Me.QUANTITYTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PRODUCT DETAILS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PRODUCT_DETAILSDataGridView
        '
        Me.PRODUCT_DETAILSDataGridView.AutoGenerateColumns = False
        Me.PRODUCT_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_DETAILSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PRODUCT_DETAILSDataGridView.DataSource = Me.PRODUCT_DETAILSBindingSource
        Me.PRODUCT_DETAILSDataGridView.Location = New System.Drawing.Point(0, 126)
        Me.PRODUCT_DETAILSDataGridView.Name = "PRODUCT_DETAILSDataGridView"
        Me.PRODUCT_DETAILSDataGridView.Size = New System.Drawing.Size(350, 220)
        Me.PRODUCT_DETAILSDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ORDER ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ORDER ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn9.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'PRODUCT_DETAILSBindingSource
        '
        Me.PRODUCT_DETAILSBindingSource.DataMember = "PRODUCT DETAILS"
        Me.PRODUCT_DETAILSBindingSource.DataSource = Me.SHOPDataSet
        '
        'PRODUCT_IDTextBox
        '
        Me.PRODUCT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox.Location = New System.Drawing.Point(91, 19)
        Me.PRODUCT_IDTextBox.Name = "PRODUCT_IDTextBox"
        Me.PRODUCT_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_IDTextBox.TabIndex = 1
        '
        'ORDER_IDTextBox
        '
        Me.ORDER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox.Location = New System.Drawing.Point(91, 45)
        Me.ORDER_IDTextBox.Name = "ORDER_IDTextBox"
        Me.ORDER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ORDER_IDTextBox.TabIndex = 3
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(91, 71)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITYTextBox.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.PRODUCT_ORDERDataGridView)
        Me.TabPage3.Controls.Add(CUSTOMER_IDLabel1)
        Me.TabPage3.Controls.Add(Me.CUSTOMER_IDTextBox1)
        Me.TabPage3.Controls.Add(ORDER_IDLabel1)
        Me.TabPage3.Controls.Add(Me.ORDER_IDTextBox1)
        Me.TabPage3.Controls.Add(DATELabel)
        Me.TabPage3.Controls.Add(Me.DATEDateTimePicker)
        Me.TabPage3.Controls.Add(DISPATCHEDLabel)
        Me.TabPage3.Controls.Add(Me.DISPATCHEDCheckBox)
        Me.TabPage3.Controls.Add(PAYEDLabel)
        Me.TabPage3.Controls.Add(Me.PAYEDCheckBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(770, 375)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PRODUCT ORDER"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PRODUCT_ORDERDataGridView
        '
        Me.PRODUCT_ORDERDataGridView.AutoGenerateColumns = False
        Me.PRODUCT_ORDERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_ORDERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.PRODUCT_ORDERDataGridView.DataSource = Me.PRODUCT_ORDERBindingSource
        Me.PRODUCT_ORDERDataGridView.Location = New System.Drawing.Point(6, 165)
        Me.PRODUCT_ORDERDataGridView.Name = "PRODUCT_ORDERDataGridView"
        Me.PRODUCT_ORDERDataGridView.Size = New System.Drawing.Size(507, 204)
        Me.PRODUCT_ORDERDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ORDER ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ORDER ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DATE"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "DISPATCHED"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "DISPATCHED"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "PAYED"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "PAYED"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'PRODUCT_ORDERBindingSource
        '
        Me.PRODUCT_ORDERBindingSource.DataMember = "PRODUCT ORDER"
        Me.PRODUCT_ORDERBindingSource.DataSource = Me.SHOPDataSet
        '
        'CUSTOMER_IDTextBox1
        '
        Me.CUSTOMER_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_ORDERBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox1.Location = New System.Drawing.Point(97, 17)
        Me.CUSTOMER_IDTextBox1.Name = "CUSTOMER_IDTextBox1"
        Me.CUSTOMER_IDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.CUSTOMER_IDTextBox1.TabIndex = 1
        '
        'ORDER_IDTextBox1
        '
        Me.ORDER_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_ORDERBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox1.Location = New System.Drawing.Point(97, 43)
        Me.ORDER_IDTextBox1.Name = "ORDER_IDTextBox1"
        Me.ORDER_IDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.ORDER_IDTextBox1.TabIndex = 3
        '
        'DATEDateTimePicker
        '
        Me.DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRODUCT_ORDERBindingSource, "DATE", True))
        Me.DATEDateTimePicker.Location = New System.Drawing.Point(97, 69)
        Me.DATEDateTimePicker.Name = "DATEDateTimePicker"
        Me.DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATEDateTimePicker.TabIndex = 5
        '
        'DISPATCHEDCheckBox
        '
        Me.DISPATCHEDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PRODUCT_ORDERBindingSource, "DISPATCHED", True))
        Me.DISPATCHEDCheckBox.Location = New System.Drawing.Point(97, 95)
        Me.DISPATCHEDCheckBox.Name = "DISPATCHEDCheckBox"
        Me.DISPATCHEDCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.DISPATCHEDCheckBox.TabIndex = 7
        Me.DISPATCHEDCheckBox.Text = "CheckBox1"
        Me.DISPATCHEDCheckBox.UseVisualStyleBackColor = True
        '
        'PAYEDCheckBox
        '
        Me.PAYEDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PRODUCT_ORDERBindingSource, "PAYED", True))
        Me.PAYEDCheckBox.Location = New System.Drawing.Point(97, 125)
        Me.PAYEDCheckBox.Name = "PAYEDCheckBox"
        Me.PAYEDCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.PAYEDCheckBox.TabIndex = 9
        Me.PAYEDCheckBox.Text = "CheckBox1"
        Me.PAYEDCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.PRODUCT_CATALOGDataGridView)
        Me.TabPage4.Controls.Add(PRODUCT_IDLabel1)
        Me.TabPage4.Controls.Add(Me.PRODUCT_IDTextBox1)
        Me.TabPage4.Controls.Add(PRODUCT_CATEGORYLabel)
        Me.TabPage4.Controls.Add(Me.PRODUCT_CATEGORYTextBox)
        Me.TabPage4.Controls.Add(PRODUCT__NAMELabel)
        Me.TabPage4.Controls.Add(Me.PRODUCT__NAMETextBox)
        Me.TabPage4.Controls.Add(PRODUCT_SIZELabel)
        Me.TabPage4.Controls.Add(Me.PRODUCT_SIZETextBox)
        Me.TabPage4.Controls.Add(LEVELLabel)
        Me.TabPage4.Controls.Add(Me.LEVELTextBox)
        Me.TabPage4.Controls.Add(UNIT_PRICELabel)
        Me.TabPage4.Controls.Add(Me.UNIT_PRICETextBox)
        Me.TabPage4.Controls.Add(MAXIMUM_LEVELLabel)
        Me.TabPage4.Controls.Add(Me.MAXIMUM_LEVELTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(770, 375)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "PRODUCT CATALOG"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PRODUCT_CATALOGDataGridView
        '
        Me.PRODUCT_CATALOGDataGridView.AutoGenerateColumns = False
        Me.PRODUCT_CATALOGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_CATALOGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.PRODUCT_CATALOGDataGridView.DataSource = Me.PRODUCT_CATALOGBindingSource
        Me.PRODUCT_CATALOGDataGridView.Location = New System.Drawing.Point(6, 212)
        Me.PRODUCT_CATALOGDataGridView.Name = "PRODUCT_CATALOGDataGridView"
        Me.PRODUCT_CATALOGDataGridView.Size = New System.Drawing.Size(743, 136)
        Me.PRODUCT_CATALOGDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PRODUCT CATEGORY"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PRODUCT CATEGORY"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "PRODUCT  NAME"
        Me.DataGridViewTextBoxColumn15.HeaderText = "PRODUCT  NAME"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "PRODUCT SIZE"
        Me.DataGridViewTextBoxColumn16.HeaderText = "PRODUCT SIZE"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "LEVEL"
        Me.DataGridViewTextBoxColumn17.HeaderText = "LEVEL"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn18.HeaderText = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "MAXIMUM LEVEL"
        Me.DataGridViewTextBoxColumn19.HeaderText = "MAXIMUM LEVEL"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'PRODUCT_CATALOGBindingSource
        '
        Me.PRODUCT_CATALOGBindingSource.DataMember = "PRODUCT CATALOG"
        Me.PRODUCT_CATALOGBindingSource.DataSource = Me.SHOPDataSet
        '
        'PRODUCT_IDTextBox1
        '
        Me.PRODUCT_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox1.Location = New System.Drawing.Point(143, 20)
        Me.PRODUCT_IDTextBox1.Name = "PRODUCT_IDTextBox1"
        Me.PRODUCT_IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_IDTextBox1.TabIndex = 1
        '
        'PRODUCT_CATEGORYTextBox
        '
        Me.PRODUCT_CATEGORYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT CATEGORY", True))
        Me.PRODUCT_CATEGORYTextBox.Location = New System.Drawing.Point(143, 46)
        Me.PRODUCT_CATEGORYTextBox.Name = "PRODUCT_CATEGORYTextBox"
        Me.PRODUCT_CATEGORYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_CATEGORYTextBox.TabIndex = 3
        '
        'PRODUCT__NAMETextBox
        '
        Me.PRODUCT__NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT  NAME", True))
        Me.PRODUCT__NAMETextBox.Location = New System.Drawing.Point(143, 72)
        Me.PRODUCT__NAMETextBox.Name = "PRODUCT__NAMETextBox"
        Me.PRODUCT__NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT__NAMETextBox.TabIndex = 5
        '
        'PRODUCT_SIZETextBox
        '
        Me.PRODUCT_SIZETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT SIZE", True))
        Me.PRODUCT_SIZETextBox.Location = New System.Drawing.Point(143, 98)
        Me.PRODUCT_SIZETextBox.Name = "PRODUCT_SIZETextBox"
        Me.PRODUCT_SIZETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_SIZETextBox.TabIndex = 7
        '
        'LEVELTextBox
        '
        Me.LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "LEVEL", True))
        Me.LEVELTextBox.Location = New System.Drawing.Point(143, 124)
        Me.LEVELTextBox.Name = "LEVELTextBox"
        Me.LEVELTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LEVELTextBox.TabIndex = 9
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(143, 150)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.UNIT_PRICETextBox.TabIndex = 11
        '
        'MAXIMUM_LEVELTextBox
        '
        Me.MAXIMUM_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "MAXIMUM LEVEL", True))
        Me.MAXIMUM_LEVELTextBox.Location = New System.Drawing.Point(143, 176)
        Me.MAXIMUM_LEVELTextBox.Name = "MAXIMUM_LEVELTextBox"
        Me.MAXIMUM_LEVELTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MAXIMUM_LEVELTextBox.TabIndex = 13
        '
        'CUSTOMER_DETAILSTableAdapter
        '
        Me.CUSTOMER_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'PRODUCT_DETAILSTableAdapter
        '
        Me.PRODUCT_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'PRODUCT_ORDERTableAdapter
        '
        Me.PRODUCT_ORDERTableAdapter.ClearBeforeFill = True
        '
        'PRODUCT_CATALOGTableAdapter
        '
        Me.PRODUCT_CATALOGTableAdapter.ClearBeforeFill = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(22, 244)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(768, 44)
        Me.TabControl2.TabIndex = 5
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(760, 18)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "PRODUCT DETAILS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(760, 18)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "PRODUCTCATALOG"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 661)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SHOPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.CUSTOMER_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PRODUCT_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PRODUCT_ORDERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_ORDERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PRODUCT_CATALOGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_CATALOGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SHOPDataSet As SHOPDataSet
    Friend WithEvents SHOPBindingSource As BindingSource
    Friend WithEvents SHOPTableAdapter As SHOPDataSetTableAdapters.SHOPTableAdapter
    Friend WithEvents TableAdapterManager As SHOPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtPASSWORD As TextBox
    Friend WithEvents cmbUsername As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEXIT As Button
    Friend WithEvents btnRESET As Button
    Friend WithEvents btnPASSWORD As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CUSTOMER_DETAILSBindingSource As BindingSource
    Friend WithEvents CUSTOMER_DETAILSTableAdapter As SHOPDataSetTableAdapters.CUSTOMER_DETAILSTableAdapter
    Friend WithEvents CUSTOMER_DETAILSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_IDTextBox As TextBox
    Friend WithEvents TITLETextBox As TextBox
    Friend WithEvents FIRST_NAMETextBox As TextBox
    Friend WithEvents LASTNAMETextBox As TextBox
    Friend WithEvents ADDRESSTextBox As TextBox
    Friend WithEvents CONTACT_NUMBERTextBox As TextBox
    Friend WithEvents PRODUCT_DETAILSBindingSource As BindingSource
    Friend WithEvents PRODUCT_DETAILSTableAdapter As SHOPDataSetTableAdapters.PRODUCT_DETAILSTableAdapter
    Friend WithEvents PRODUCT_DETAILSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_IDTextBox As TextBox
    Friend WithEvents ORDER_IDTextBox As TextBox
    Friend WithEvents QUANTITYTextBox As TextBox
    Friend WithEvents PRODUCT_ORDERBindingSource As BindingSource
    Friend WithEvents PRODUCT_ORDERTableAdapter As SHOPDataSetTableAdapters.PRODUCT_ORDERTableAdapter
    Friend WithEvents PRODUCT_ORDERDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents CUSTOMER_IDTextBox1 As TextBox
    Friend WithEvents ORDER_IDTextBox1 As TextBox
    Friend WithEvents DATEDateTimePicker As DateTimePicker
    Friend WithEvents DISPATCHEDCheckBox As CheckBox
    Friend WithEvents PAYEDCheckBox As CheckBox
    Friend WithEvents PRODUCT_CATALOGBindingSource As BindingSource
    Friend WithEvents PRODUCT_CATALOGTableAdapter As SHOPDataSetTableAdapters.PRODUCT_CATALOGTableAdapter
    Friend WithEvents PRODUCT_CATALOGDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_IDTextBox1 As TextBox
    Friend WithEvents PRODUCT_CATEGORYTextBox As TextBox
    Friend WithEvents PRODUCT__NAMETextBox As TextBox
    Friend WithEvents PRODUCT_SIZETextBox As TextBox
    Friend WithEvents LEVELTextBox As TextBox
    Friend WithEvents UNIT_PRICETextBox As TextBox
    Friend WithEvents MAXIMUM_LEVELTextBox As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtUsername As TextBox
End Class
