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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPASSWORD = New System.Windows.Forms.TextBox()
        Me.cmbDEPARTMENT = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPASSWORD = New System.Windows.Forms.Button()
        Me.btnRESET = New System.Windows.Forms.Button()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.txtUSERNAME = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CUSTOMER_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMER_DETAILSTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.CUSTOMER_DETAILSTableAdapter()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LASTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.CONTACT_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMER_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_DETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCT_DETAILSTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.PRODUCT_DETAILSTableAdapter()
        Me.PRODUCT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ORDER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT_DETAILSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_ORDERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCT_ORDERTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.PRODUCT_ORDERTableAdapter()
        Me.CUSTOMER_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.ORDER_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DISPATCHEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.PAYEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.PRODUCT_ORDERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PRODUCT_CATALOGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCT_CATALOGTableAdapter = New REFILOE_SHOP_INVENTORY.SHOPDataSetTableAdapters.PRODUCT_CATALOGTableAdapter()
        Me.PRODUCT_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.PRODUCT_CATEGORYTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT__NAMETextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT_SIZETextBox = New System.Windows.Forms.TextBox()
        Me.LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.MAXIMUM_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT_CATALOGDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.CUSTOMER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMER_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_ORDERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_ORDERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_CATALOGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCT_CATALOGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEPARTMENT"
        '
        'txtPASSWORD
        '
        Me.txtPASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPASSWORD.Location = New System.Drawing.Point(120, 123)
        Me.txtPASSWORD.Name = "txtPASSWORD"
        Me.txtPASSWORD.Size = New System.Drawing.Size(142, 21)
        Me.txtPASSWORD.TabIndex = 1
        '
        'cmbDEPARTMENT
        '
        Me.cmbDEPARTMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDEPARTMENT.FormattingEnabled = True
        Me.cmbDEPARTMENT.Location = New System.Drawing.Point(120, 56)
        Me.cmbDEPARTMENT.Name = "cmbDEPARTMENT"
        Me.cmbDEPARTMENT.Size = New System.Drawing.Size(142, 23)
        Me.cmbDEPARTMENT.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUSERNAME)
        Me.GroupBox1.Controls.Add(Me.btnEXIT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnRESET)
        Me.GroupBox1.Controls.Add(Me.txtPASSWORD)
        Me.GroupBox1.Controls.Add(Me.btnPASSWORD)
        Me.GroupBox1.Controls.Add(Me.cmbDEPARTMENT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 228)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN SCREEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PASSWORD"
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
        'txtUSERNAME
        '
        Me.txtUSERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSERNAME.Location = New System.Drawing.Point(120, 96)
        Me.txtUSERNAME.Name = "txtUSERNAME"
        Me.txtUSERNAME.Size = New System.Drawing.Size(142, 21)
        Me.txtUSERNAME.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 257)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(778, 401)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
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
        'CUSTOMER_DETAILSBindingSource
        '
        Me.CUSTOMER_DETAILSBindingSource.DataMember = "CUSTOMER DETAILS"
        Me.CUSTOMER_DETAILSBindingSource.DataSource = Me.SHOPDataSet
        '
        'CUSTOMER_DETAILSTableAdapter
        '
        Me.CUSTOMER_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(6, 26)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(85, 13)
        CUSTOMER_IDLabel.TabIndex = 0
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(123, 23)
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 1
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Location = New System.Drawing.Point(6, 52)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(40, 13)
        TITLELabel.TabIndex = 2
        TITLELabel.Text = "TITLE:"
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "TITLE", True))
        Me.TITLETextBox.Location = New System.Drawing.Point(123, 49)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.TITLETextBox.TabIndex = 3
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Location = New System.Drawing.Point(6, 78)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(75, 13)
        FIRST_NAMELabel.TabIndex = 4
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "FIRST NAME", True))
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(123, 75)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.FIRST_NAMETextBox.TabIndex = 5
        '
        'LASTNAMELabel
        '
        LASTNAMELabel.AutoSize = True
        LASTNAMELabel.Location = New System.Drawing.Point(6, 104)
        LASTNAMELabel.Name = "LASTNAMELabel"
        LASTNAMELabel.Size = New System.Drawing.Size(68, 13)
        LASTNAMELabel.TabIndex = 6
        LASTNAMELabel.Text = "LASTNAME:"
        '
        'LASTNAMETextBox
        '
        Me.LASTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "LASTNAME", True))
        Me.LASTNAMETextBox.Location = New System.Drawing.Point(123, 101)
        Me.LASTNAMETextBox.Name = "LASTNAMETextBox"
        Me.LASTNAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.LASTNAMETextBox.TabIndex = 7
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Location = New System.Drawing.Point(6, 130)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(62, 13)
        ADDRESSLabel.TabIndex = 8
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(123, 127)
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ADDRESSTextBox.TabIndex = 9
        '
        'CONTACT_NUMBERLabel
        '
        CONTACT_NUMBERLabel.AutoSize = True
        CONTACT_NUMBERLabel.Location = New System.Drawing.Point(6, 156)
        CONTACT_NUMBERLabel.Name = "CONTACT_NUMBERLabel"
        CONTACT_NUMBERLabel.Size = New System.Drawing.Size(111, 13)
        CONTACT_NUMBERLabel.TabIndex = 10
        CONTACT_NUMBERLabel.Text = "CONTACT NUMBER:"
        '
        'CONTACT_NUMBERTextBox
        '
        Me.CONTACT_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMER_DETAILSBindingSource, "CONTACT NUMBER", True))
        Me.CONTACT_NUMBERTextBox.Location = New System.Drawing.Point(123, 153)
        Me.CONTACT_NUMBERTextBox.Name = "CONTACT_NUMBERTextBox"
        Me.CONTACT_NUMBERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CONTACT_NUMBERTextBox.TabIndex = 11
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
        'PRODUCT_DETAILSBindingSource
        '
        Me.PRODUCT_DETAILSBindingSource.DataMember = "PRODUCT DETAILS"
        Me.PRODUCT_DETAILSBindingSource.DataSource = Me.SHOPDataSet
        '
        'PRODUCT_DETAILSTableAdapter
        '
        Me.PRODUCT_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'PRODUCT_IDLabel
        '
        PRODUCT_IDLabel.AutoSize = True
        PRODUCT_IDLabel.Location = New System.Drawing.Point(8, 22)
        PRODUCT_IDLabel.Name = "PRODUCT_IDLabel"
        PRODUCT_IDLabel.Size = New System.Drawing.Size(77, 13)
        PRODUCT_IDLabel.TabIndex = 0
        PRODUCT_IDLabel.Text = "PRODUCT ID:"
        '
        'PRODUCT_IDTextBox
        '
        Me.PRODUCT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox.Location = New System.Drawing.Point(91, 19)
        Me.PRODUCT_IDTextBox.Name = "PRODUCT_IDTextBox"
        Me.PRODUCT_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_IDTextBox.TabIndex = 1
        '
        'ORDER_IDLabel
        '
        ORDER_IDLabel.AutoSize = True
        ORDER_IDLabel.Location = New System.Drawing.Point(8, 48)
        ORDER_IDLabel.Name = "ORDER_IDLabel"
        ORDER_IDLabel.Size = New System.Drawing.Size(63, 13)
        ORDER_IDLabel.TabIndex = 2
        ORDER_IDLabel.Text = "ORDER ID:"
        '
        'ORDER_IDTextBox
        '
        Me.ORDER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox.Location = New System.Drawing.Point(91, 45)
        Me.ORDER_IDTextBox.Name = "ORDER_IDTextBox"
        Me.ORDER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ORDER_IDTextBox.TabIndex = 3
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(8, 74)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(65, 13)
        QUANTITYLabel.TabIndex = 4
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_DETAILSBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(91, 71)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITYTextBox.TabIndex = 5
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
        'PRODUCT_ORDERBindingSource
        '
        Me.PRODUCT_ORDERBindingSource.DataMember = "PRODUCT ORDER"
        Me.PRODUCT_ORDERBindingSource.DataSource = Me.SHOPDataSet
        '
        'PRODUCT_ORDERTableAdapter
        '
        Me.PRODUCT_ORDERTableAdapter.ClearBeforeFill = True
        '
        'CUSTOMER_IDLabel1
        '
        CUSTOMER_IDLabel1.AutoSize = True
        CUSTOMER_IDLabel1.Location = New System.Drawing.Point(6, 20)
        CUSTOMER_IDLabel1.Name = "CUSTOMER_IDLabel1"
        CUSTOMER_IDLabel1.Size = New System.Drawing.Size(85, 13)
        CUSTOMER_IDLabel1.TabIndex = 0
        CUSTOMER_IDLabel1.Text = "CUSTOMER ID:"
        '
        'CUSTOMER_IDTextBox1
        '
        Me.CUSTOMER_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_ORDERBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox1.Location = New System.Drawing.Point(97, 17)
        Me.CUSTOMER_IDTextBox1.Name = "CUSTOMER_IDTextBox1"
        Me.CUSTOMER_IDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.CUSTOMER_IDTextBox1.TabIndex = 1
        '
        'ORDER_IDLabel1
        '
        ORDER_IDLabel1.AutoSize = True
        ORDER_IDLabel1.Location = New System.Drawing.Point(6, 46)
        ORDER_IDLabel1.Name = "ORDER_IDLabel1"
        ORDER_IDLabel1.Size = New System.Drawing.Size(63, 13)
        ORDER_IDLabel1.TabIndex = 2
        ORDER_IDLabel1.Text = "ORDER ID:"
        '
        'ORDER_IDTextBox1
        '
        Me.ORDER_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_ORDERBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox1.Location = New System.Drawing.Point(97, 43)
        Me.ORDER_IDTextBox1.Name = "ORDER_IDTextBox1"
        Me.ORDER_IDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.ORDER_IDTextBox1.TabIndex = 3
        '
        'DATELabel
        '
        DATELabel.AutoSize = True
        DATELabel.Location = New System.Drawing.Point(6, 73)
        DATELabel.Name = "DATELabel"
        DATELabel.Size = New System.Drawing.Size(39, 13)
        DATELabel.TabIndex = 4
        DATELabel.Text = "DATE:"
        '
        'DATEDateTimePicker
        '
        Me.DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PRODUCT_ORDERBindingSource, "DATE", True))
        Me.DATEDateTimePicker.Location = New System.Drawing.Point(97, 69)
        Me.DATEDateTimePicker.Name = "DATEDateTimePicker"
        Me.DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATEDateTimePicker.TabIndex = 5
        '
        'DISPATCHEDLabel
        '
        DISPATCHEDLabel.AutoSize = True
        DISPATCHEDLabel.Location = New System.Drawing.Point(6, 100)
        DISPATCHEDLabel.Name = "DISPATCHEDLabel"
        DISPATCHEDLabel.Size = New System.Drawing.Size(79, 13)
        DISPATCHEDLabel.TabIndex = 6
        DISPATCHEDLabel.Text = "DISPATCHED:"
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
        'PAYEDLabel
        '
        PAYEDLabel.AutoSize = True
        PAYEDLabel.Location = New System.Drawing.Point(6, 130)
        PAYEDLabel.Name = "PAYEDLabel"
        PAYEDLabel.Size = New System.Drawing.Size(46, 13)
        PAYEDLabel.TabIndex = 8
        PAYEDLabel.Text = "PAYED:"
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
        'PRODUCT_CATALOGBindingSource
        '
        Me.PRODUCT_CATALOGBindingSource.DataMember = "PRODUCT CATALOG"
        Me.PRODUCT_CATALOGBindingSource.DataSource = Me.SHOPDataSet
        '
        'PRODUCT_CATALOGTableAdapter
        '
        Me.PRODUCT_CATALOGTableAdapter.ClearBeforeFill = True
        '
        'PRODUCT_IDLabel1
        '
        PRODUCT_IDLabel1.AutoSize = True
        PRODUCT_IDLabel1.Location = New System.Drawing.Point(12, 23)
        PRODUCT_IDLabel1.Name = "PRODUCT_IDLabel1"
        PRODUCT_IDLabel1.Size = New System.Drawing.Size(77, 13)
        PRODUCT_IDLabel1.TabIndex = 0
        PRODUCT_IDLabel1.Text = "PRODUCT ID:"
        '
        'PRODUCT_IDTextBox1
        '
        Me.PRODUCT_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox1.Location = New System.Drawing.Point(143, 20)
        Me.PRODUCT_IDTextBox1.Name = "PRODUCT_IDTextBox1"
        Me.PRODUCT_IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_IDTextBox1.TabIndex = 1
        '
        'PRODUCT_CATEGORYLabel
        '
        PRODUCT_CATEGORYLabel.AutoSize = True
        PRODUCT_CATEGORYLabel.Location = New System.Drawing.Point(12, 49)
        PRODUCT_CATEGORYLabel.Name = "PRODUCT_CATEGORYLabel"
        PRODUCT_CATEGORYLabel.Size = New System.Drawing.Size(125, 13)
        PRODUCT_CATEGORYLabel.TabIndex = 2
        PRODUCT_CATEGORYLabel.Text = "PRODUCT CATEGORY:"
        '
        'PRODUCT_CATEGORYTextBox
        '
        Me.PRODUCT_CATEGORYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT CATEGORY", True))
        Me.PRODUCT_CATEGORYTextBox.Location = New System.Drawing.Point(143, 46)
        Me.PRODUCT_CATEGORYTextBox.Name = "PRODUCT_CATEGORYTextBox"
        Me.PRODUCT_CATEGORYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_CATEGORYTextBox.TabIndex = 3
        '
        'PRODUCT__NAMELabel
        '
        PRODUCT__NAMELabel.AutoSize = True
        PRODUCT__NAMELabel.Location = New System.Drawing.Point(12, 75)
        PRODUCT__NAMELabel.Name = "PRODUCT__NAMELabel"
        PRODUCT__NAMELabel.Size = New System.Drawing.Size(100, 13)
        PRODUCT__NAMELabel.TabIndex = 4
        PRODUCT__NAMELabel.Text = "PRODUCT  NAME:"
        '
        'PRODUCT__NAMETextBox
        '
        Me.PRODUCT__NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT  NAME", True))
        Me.PRODUCT__NAMETextBox.Location = New System.Drawing.Point(143, 72)
        Me.PRODUCT__NAMETextBox.Name = "PRODUCT__NAMETextBox"
        Me.PRODUCT__NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT__NAMETextBox.TabIndex = 5
        '
        'PRODUCT_SIZELabel
        '
        PRODUCT_SIZELabel.AutoSize = True
        PRODUCT_SIZELabel.Location = New System.Drawing.Point(12, 101)
        PRODUCT_SIZELabel.Name = "PRODUCT_SIZELabel"
        PRODUCT_SIZELabel.Size = New System.Drawing.Size(90, 13)
        PRODUCT_SIZELabel.TabIndex = 6
        PRODUCT_SIZELabel.Text = "PRODUCT SIZE:"
        '
        'PRODUCT_SIZETextBox
        '
        Me.PRODUCT_SIZETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "PRODUCT SIZE", True))
        Me.PRODUCT_SIZETextBox.Location = New System.Drawing.Point(143, 98)
        Me.PRODUCT_SIZETextBox.Name = "PRODUCT_SIZETextBox"
        Me.PRODUCT_SIZETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_SIZETextBox.TabIndex = 7
        '
        'LEVELLabel
        '
        LEVELLabel.AutoSize = True
        LEVELLabel.Location = New System.Drawing.Point(12, 127)
        LEVELLabel.Name = "LEVELLabel"
        LEVELLabel.Size = New System.Drawing.Size(43, 13)
        LEVELLabel.TabIndex = 8
        LEVELLabel.Text = "LEVEL:"
        '
        'LEVELTextBox
        '
        Me.LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "LEVEL", True))
        Me.LEVELTextBox.Location = New System.Drawing.Point(143, 124)
        Me.LEVELTextBox.Name = "LEVELTextBox"
        Me.LEVELTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LEVELTextBox.TabIndex = 9
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.Location = New System.Drawing.Point(12, 153)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(71, 13)
        UNIT_PRICELabel.TabIndex = 10
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(143, 150)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.UNIT_PRICETextBox.TabIndex = 11
        '
        'MAXIMUM_LEVELLabel
        '
        MAXIMUM_LEVELLabel.AutoSize = True
        MAXIMUM_LEVELLabel.Location = New System.Drawing.Point(12, 179)
        MAXIMUM_LEVELLabel.Name = "MAXIMUM_LEVELLabel"
        MAXIMUM_LEVELLabel.Size = New System.Drawing.Size(98, 13)
        MAXIMUM_LEVELLabel.TabIndex = 12
        MAXIMUM_LEVELLabel.Text = "MAXIMUM LEVEL:"
        '
        'MAXIMUM_LEVELTextBox
        '
        Me.MAXIMUM_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCT_CATALOGBindingSource, "MAXIMUM LEVEL", True))
        Me.MAXIMUM_LEVELTextBox.Location = New System.Drawing.Point(143, 176)
        Me.MAXIMUM_LEVELTextBox.Name = "MAXIMUM_LEVELTextBox"
        Me.MAXIMUM_LEVELTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MAXIMUM_LEVELTextBox.TabIndex = 13
        '
        'PRODUCT_CATALOGDataGridView
        '
        Me.PRODUCT_CATALOGDataGridView.AutoGenerateColumns = False
        Me.PRODUCT_CATALOGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCT_CATALOGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.PRODUCT_CATALOGDataGridView.DataSource = Me.PRODUCT_CATALOGBindingSource
        Me.PRODUCT_CATALOGDataGridView.Location = New System.Drawing.Point(6, 202)
        Me.PRODUCT_CATALOGDataGridView.Name = "PRODUCT_CATALOGDataGridView"
        Me.PRODUCT_CATALOGDataGridView.Size = New System.Drawing.Size(743, 170)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 661)
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.CUSTOMER_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMER_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_DETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_DETAILSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_ORDERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_ORDERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_CATALOGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCT_CATALOGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SHOPDataSet As SHOPDataSet
    Friend WithEvents SHOPBindingSource As BindingSource
    Friend WithEvents SHOPTableAdapter As SHOPDataSetTableAdapters.SHOPTableAdapter
    Friend WithEvents TableAdapterManager As SHOPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPASSWORD As TextBox
    Friend WithEvents cmbDEPARTMENT As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUSERNAME As TextBox
    Friend WithEvents btnEXIT As Button
    Friend WithEvents btnRESET As Button
    Friend WithEvents btnPASSWORD As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
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
End Class
