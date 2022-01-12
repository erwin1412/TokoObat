<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtransaksi
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
        Dim TOTALLabel As System.Windows.Forms.Label
        Dim DISCOUNTLabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim KODEOBATLabel As System.Windows.Forms.Label
        Dim TGLRESEPLabel As System.Windows.Forms.Label
        Dim NORESEPLabel As System.Windows.Forms.Label
        Dim KODEOBATLabel1 As System.Windows.Forms.Label
        Dim NAMAOBATLabel As System.Windows.Forms.Label
        Dim PABRIKLabel As System.Windows.Forms.Label
        Dim HARGALabel As System.Windows.Forms.Label
        Dim SATUANLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KODEOBATComboBox = New System.Windows.Forms.ComboBox()
        Me.TGLRESEPDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.TOTALTextBox = New System.Windows.Forms.TextBox()
        Me.DISCOUNTTextBox = New System.Windows.Forms.TextBox()
        Me.NORESEPTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HARGATextBox = New System.Windows.Forms.TextBox()
        Me.SATUANTextBox = New System.Windows.Forms.TextBox()
        Me.PABRIKTextBox = New System.Windows.Forms.TextBox()
        Me.NAMAOBATTextBox = New System.Windows.Forms.TextBox()
        Me.KODEOBATTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNORESEPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObatDataSet = New WindowsApplication1.obatDataSet()
        Me.btnAwal = New System.Windows.Forms.Button()
        Me.btnSebelumnya = New System.Windows.Forms.Button()
        Me.btnSesudahnya = New System.Windows.Forms.Button()
        Me.btnAkhir = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TOBATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TNORESEPTableAdapter = New WindowsApplication1.obatDataSetTableAdapters.TNORESEPTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.obatDataSetTableAdapters.TableAdapterManager()
        Me.TOBATTableAdapter = New WindowsApplication1.obatDataSetTableAdapters.TOBATTableAdapter()
        Me.View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View1TableAdapter = New WindowsApplication1.obatDataSetTableAdapters.View1TableAdapter()
        TOTALLabel = New System.Windows.Forms.Label()
        DISCOUNTLabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        KODEOBATLabel = New System.Windows.Forms.Label()
        TGLRESEPLabel = New System.Windows.Forms.Label()
        NORESEPLabel = New System.Windows.Forms.Label()
        KODEOBATLabel1 = New System.Windows.Forms.Label()
        NAMAOBATLabel = New System.Windows.Forms.Label()
        PABRIKLabel = New System.Windows.Forms.Label()
        HARGALabel = New System.Windows.Forms.Label()
        SATUANLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TNORESEPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOBATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TOTALLabel
        '
        TOTALLabel.AutoSize = True
        TOTALLabel.Location = New System.Drawing.Point(51, 226)
        TOTALLabel.Name = "TOTALLabel"
        TOTALLabel.Size = New System.Drawing.Size(45, 13)
        TOTALLabel.TabIndex = 10
        TOTALLabel.Text = "TOTAL:"
        '
        'DISCOUNTLabel
        '
        DISCOUNTLabel.AutoSize = True
        DISCOUNTLabel.Location = New System.Drawing.Point(51, 200)
        DISCOUNTLabel.Name = "DISCOUNTLabel"
        DISCOUNTLabel.Size = New System.Drawing.Size(66, 13)
        DISCOUNTLabel.TabIndex = 8
        DISCOUNTLabel.Text = "DISCOUNT:"
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(51, 174)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(65, 13)
        QUANTITYLabel.TabIndex = 6
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'KODEOBATLabel
        '
        KODEOBATLabel.AutoSize = True
        KODEOBATLabel.Location = New System.Drawing.Point(51, 148)
        KODEOBATLabel.Name = "KODEOBATLabel"
        KODEOBATLabel.Size = New System.Drawing.Size(69, 13)
        KODEOBATLabel.TabIndex = 4
        KODEOBATLabel.Text = "KODEOBAT:"
        '
        'TGLRESEPLabel
        '
        TGLRESEPLabel.AutoSize = True
        TGLRESEPLabel.Location = New System.Drawing.Point(51, 123)
        TGLRESEPLabel.Name = "TGLRESEPLabel"
        TGLRESEPLabel.Size = New System.Drawing.Size(60, 13)
        TGLRESEPLabel.TabIndex = 2
        TGLRESEPLabel.Text = "TGL.BON :"
        '
        'NORESEPLabel
        '
        NORESEPLabel.AutoSize = True
        NORESEPLabel.Location = New System.Drawing.Point(51, 96)
        NORESEPLabel.Name = "NORESEPLabel"
        NORESEPLabel.Size = New System.Drawing.Size(58, 13)
        NORESEPLabel.TabIndex = 0
        NORESEPLabel.Text = "NO. BON :"
        '
        'KODEOBATLabel1
        '
        KODEOBATLabel1.AutoSize = True
        KODEOBATLabel1.Location = New System.Drawing.Point(42, 127)
        KODEOBATLabel1.Name = "KODEOBATLabel1"
        KODEOBATLabel1.Size = New System.Drawing.Size(69, 13)
        KODEOBATLabel1.TabIndex = 10
        KODEOBATLabel1.Text = "KODEOBAT:"
        '
        'NAMAOBATLabel
        '
        NAMAOBATLabel.AutoSize = True
        NAMAOBATLabel.Location = New System.Drawing.Point(41, 158)
        NAMAOBATLabel.Name = "NAMAOBATLabel"
        NAMAOBATLabel.Size = New System.Drawing.Size(70, 13)
        NAMAOBATLabel.TabIndex = 11
        NAMAOBATLabel.Text = "NAMAOBAT:"
        '
        'PABRIKLabel
        '
        PABRIKLabel.AutoSize = True
        PABRIKLabel.Location = New System.Drawing.Point(41, 185)
        PABRIKLabel.Name = "PABRIKLabel"
        PABRIKLabel.Size = New System.Drawing.Size(49, 13)
        PABRIKLabel.TabIndex = 12
        PABRIKLabel.Text = "PABRIK:"
        '
        'HARGALabel
        '
        HARGALabel.AutoSize = True
        HARGALabel.Location = New System.Drawing.Point(41, 237)
        HARGALabel.Name = "HARGALabel"
        HARGALabel.Size = New System.Drawing.Size(48, 13)
        HARGALabel.TabIndex = 13
        HARGALabel.Text = "HARGA:"
        '
        'SATUANLabel
        '
        SATUANLabel.AutoSize = True
        SATUANLabel.Location = New System.Drawing.Point(42, 211)
        SATUANLabel.Name = "SATUANLabel"
        SATUANLabel.Size = New System.Drawing.Size(54, 13)
        SATUANLabel.TabIndex = 14
        SATUANLabel.Text = "SATUAN:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.KODEOBATComboBox)
        Me.Panel1.Controls.Add(Me.TGLRESEPDateTimePicker)
        Me.Panel1.Controls.Add(Me.QUANTITYTextBox)
        Me.Panel1.Controls.Add(Me.TOTALTextBox)
        Me.Panel1.Controls.Add(Me.DISCOUNTTextBox)
        Me.Panel1.Controls.Add(Me.NORESEPTextBox)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(NORESEPLabel)
        Me.Panel1.Controls.Add(TGLRESEPLabel)
        Me.Panel1.Controls.Add(KODEOBATLabel)
        Me.Panel1.Controls.Add(QUANTITYLabel)
        Me.Panel1.Controls.Add(DISCOUNTLabel)
        Me.Panel1.Controls.Add(TOTALLabel)
        Me.Panel1.Location = New System.Drawing.Point(72, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 322)
        Me.Panel1.TabIndex = 0
        '
        'KODEOBATComboBox
        '
        Me.KODEOBATComboBox.FormattingEnabled = True
        Me.KODEOBATComboBox.Items.AddRange(New Object() {"PB500", "PH500", "PM500", "DECOL", "FLUDA", "DEXYN", "ALPAR"})
        Me.KODEOBATComboBox.Location = New System.Drawing.Point(126, 148)
        Me.KODEOBATComboBox.Name = "KODEOBATComboBox"
        Me.KODEOBATComboBox.Size = New System.Drawing.Size(200, 21)
        Me.KODEOBATComboBox.TabIndex = 20
        '
        'TGLRESEPDateTimePicker
        '
        Me.TGLRESEPDateTimePicker.Location = New System.Drawing.Point(126, 123)
        Me.TGLRESEPDateTimePicker.Name = "TGLRESEPDateTimePicker"
        Me.TGLRESEPDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TGLRESEPDateTimePicker.TabIndex = 19
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(126, 172)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QUANTITYTextBox.TabIndex = 14
        '
        'TOTALTextBox
        '
        Me.TOTALTextBox.Enabled = False
        Me.TOTALTextBox.Location = New System.Drawing.Point(126, 227)
        Me.TOTALTextBox.Name = "TOTALTextBox"
        Me.TOTALTextBox.Size = New System.Drawing.Size(203, 20)
        Me.TOTALTextBox.TabIndex = 11
        '
        'DISCOUNTTextBox
        '
        Me.DISCOUNTTextBox.Location = New System.Drawing.Point(126, 198)
        Me.DISCOUNTTextBox.Name = "DISCOUNTTextBox"
        Me.DISCOUNTTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DISCOUNTTextBox.TabIndex = 12
        '
        'NORESEPTextBox
        '
        Me.NORESEPTextBox.Location = New System.Drawing.Point(126, 93)
        Me.NORESEPTextBox.Name = "NORESEPTextBox"
        Me.NORESEPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NORESEPTextBox.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(44, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(414, 49)
        Me.Panel4.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DATA ENTRY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA ENTRY"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(350, 262)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 40)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(350, 210)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 40)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "CETAK"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(350, 164)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(108, 40)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(350, 118)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 40)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "UPDATE DATA"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(350, 69)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 40)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "TAMBAH DATA"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.HARGATextBox)
        Me.Panel2.Controls.Add(Me.SATUANTextBox)
        Me.Panel2.Controls.Add(Me.PABRIKTextBox)
        Me.Panel2.Controls.Add(Me.NAMAOBATTextBox)
        Me.Panel2.Controls.Add(Me.KODEOBATTextBox1)
        Me.Panel2.Controls.Add(SATUANLabel)
        Me.Panel2.Controls.Add(HARGALabel)
        Me.Panel2.Controls.Add(PABRIKLabel)
        Me.Panel2.Controls.Add(NAMAOBATLabel)
        Me.Panel2.Controls.Add(KODEOBATLabel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(601, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 304)
        Me.Panel2.TabIndex = 2
        '
        'HARGATextBox
        '
        Me.HARGATextBox.Enabled = False
        Me.HARGATextBox.Location = New System.Drawing.Point(117, 237)
        Me.HARGATextBox.Name = "HARGATextBox"
        Me.HARGATextBox.Size = New System.Drawing.Size(100, 20)
        Me.HARGATextBox.TabIndex = 20
        '
        'SATUANTextBox
        '
        Me.SATUANTextBox.Enabled = False
        Me.SATUANTextBox.Location = New System.Drawing.Point(117, 211)
        Me.SATUANTextBox.Name = "SATUANTextBox"
        Me.SATUANTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SATUANTextBox.TabIndex = 19
        '
        'PABRIKTextBox
        '
        Me.PABRIKTextBox.Enabled = False
        Me.PABRIKTextBox.Location = New System.Drawing.Point(117, 185)
        Me.PABRIKTextBox.Name = "PABRIKTextBox"
        Me.PABRIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PABRIKTextBox.TabIndex = 18
        '
        'NAMAOBATTextBox
        '
        Me.NAMAOBATTextBox.Enabled = False
        Me.NAMAOBATTextBox.Location = New System.Drawing.Point(117, 155)
        Me.NAMAOBATTextBox.Name = "NAMAOBATTextBox"
        Me.NAMAOBATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMAOBATTextBox.TabIndex = 17
        '
        'KODEOBATTextBox1
        '
        Me.KODEOBATTextBox1.Enabled = False
        Me.KODEOBATTextBox1.Location = New System.Drawing.Point(117, 121)
        Me.KODEOBATTextBox1.Name = "KODEOBATTextBox1"
        Me.KODEOBATTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.KODEOBATTextBox1.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(45, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 54)
        Me.Panel3.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MASTER PRODUK"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView1.DataSource = Me.TNORESEPBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(181, 513)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 220)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NORESEP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No. BON"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TGLRESEP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TGL. BON"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KODEOBAT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "KODEOBAT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DISCOUNT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DISCOUNT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TOTAL"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TNORESEPBindingSource
        '
        Me.TNORESEPBindingSource.DataMember = "TNORESEP"
        Me.TNORESEPBindingSource.DataSource = Me.ObatDataSet
        '
        'ObatDataSet
        '
        Me.ObatDataSet.DataSetName = "obatDataSet"
        Me.ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAwal
        '
        Me.btnAwal.Location = New System.Drawing.Point(84, 467)
        Me.btnAwal.Name = "btnAwal"
        Me.btnAwal.Size = New System.Drawing.Size(108, 40)
        Me.btnAwal.TabIndex = 16
        Me.btnAwal.Text = "TOP"
        Me.btnAwal.UseVisualStyleBackColor = True
        '
        'btnSebelumnya
        '
        Me.btnSebelumnya.Location = New System.Drawing.Point(250, 467)
        Me.btnSebelumnya.Name = "btnSebelumnya"
        Me.btnSebelumnya.Size = New System.Drawing.Size(108, 40)
        Me.btnSebelumnya.TabIndex = 17
        Me.btnSebelumnya.Text = "PREV"
        Me.btnSebelumnya.UseVisualStyleBackColor = True
        '
        'btnSesudahnya
        '
        Me.btnSesudahnya.Location = New System.Drawing.Point(422, 467)
        Me.btnSesudahnya.Name = "btnSesudahnya"
        Me.btnSesudahnya.Size = New System.Drawing.Size(108, 40)
        Me.btnSesudahnya.TabIndex = 18
        Me.btnSesudahnya.Text = "NEXT"
        Me.btnSesudahnya.UseVisualStyleBackColor = True
        '
        'btnAkhir
        '
        Me.btnAkhir.Location = New System.Drawing.Point(630, 467)
        Me.btnAkhir.Name = "btnAkhir"
        Me.btnAkhir.Size = New System.Drawing.Size(108, 40)
        Me.btnAkhir.TabIndex = 19
        Me.btnAkhir.Text = "END"
        Me.btnAkhir.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(798, 467)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 40)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TOBATBindingSource
        '
        Me.TOBATBindingSource.DataMember = "TOBAT"
        Me.TOBATBindingSource.DataSource = Me.ObatDataSet
        '
        'TNORESEPTableAdapter
        '
        Me.TNORESEPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TNORESEPTableAdapter = Me.TNORESEPTableAdapter
        Me.TableAdapterManager.TOBATTableAdapter = Me.TOBATTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.obatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TOBATTableAdapter
        '
        Me.TOBATTableAdapter.ClearBeforeFill = True
        '
        'View1BindingSource
        '
        Me.View1BindingSource.DataMember = "View1"
        Me.View1BindingSource.DataSource = Me.ObatDataSet
        '
        'View1TableAdapter
        '
        Me.View1TableAdapter.ClearBeforeFill = True
        '
        'frmtransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(996, 818)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAkhir)
        Me.Controls.Add(Me.btnSesudahnya)
        Me.Controls.Add(Me.btnSebelumnya)
        Me.Controls.Add(Me.btnAwal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmtransaksi"
        Me.Text = "frmtransaksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TNORESEPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOBATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ObatDataSet As WindowsApplication1.obatDataSet
    Friend WithEvents TNORESEPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TNORESEPTableAdapter As WindowsApplication1.obatDataSetTableAdapters.TNORESEPTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.obatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents KODEOBATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TOBATTableAdapter As WindowsApplication1.obatDataSetTableAdapters.TOBATTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TOBATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAwal As System.Windows.Forms.Button
    Friend WithEvents btnSebelumnya As System.Windows.Forms.Button
    Friend WithEvents btnSesudahnya As System.Windows.Forms.Button
    Friend WithEvents btnAkhir As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TGLRESEPDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents QUANTITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TOTALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DISCOUNTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NORESEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents View1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View1TableAdapter As WindowsApplication1.obatDataSetTableAdapters.View1TableAdapter
    Friend WithEvents KODEOBATComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HARGATextBox As System.Windows.Forms.TextBox
    Friend WithEvents SATUANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PABRIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMAOBATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KODEOBATTextBox1 As System.Windows.Forms.TextBox
End Class
