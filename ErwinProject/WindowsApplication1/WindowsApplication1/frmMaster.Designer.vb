<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Dim KODEOBATLabel As System.Windows.Forms.Label
        Dim NAMAOBATLabel As System.Windows.Forms.Label
        Dim PABRIKLabel As System.Windows.Forms.Label
        Dim SATUANLabel As System.Windows.Forms.Label
        Dim HARGALabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ObatDataSet = New WindowsApplication1.obatDataSet()
        Me.TOBATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TOBATTableAdapter = New WindowsApplication1.obatDataSetTableAdapters.TOBATTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.obatDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAwal = New System.Windows.Forms.Button()
        Me.btnSebelumnya = New System.Windows.Forms.Button()
        Me.btnSesudahnya = New System.Windows.Forms.Button()
        Me.btnAkhir = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.KODEOBATTextBox = New System.Windows.Forms.TextBox()
        Me.NAMAOBATTextBox = New System.Windows.Forms.TextBox()
        Me.SATUANTextBox = New System.Windows.Forms.TextBox()
        Me.PABRIKTextBox = New System.Windows.Forms.TextBox()
        Me.HARGATextBox = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        KODEOBATLabel = New System.Windows.Forms.Label()
        NAMAOBATLabel = New System.Windows.Forms.Label()
        PABRIKLabel = New System.Windows.Forms.Label()
        SATUANLabel = New System.Windows.Forms.Label()
        HARGALabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ObatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOBATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KODEOBATLabel
        '
        KODEOBATLabel.AutoSize = True
        KODEOBATLabel.Location = New System.Drawing.Point(84, 196)
        KODEOBATLabel.Name = "KODEOBATLabel"
        KODEOBATLabel.Size = New System.Drawing.Size(69, 13)
        KODEOBATLabel.TabIndex = 10
        KODEOBATLabel.Text = "KODEOBAT:"
        '
        'NAMAOBATLabel
        '
        NAMAOBATLabel.AutoSize = True
        NAMAOBATLabel.Location = New System.Drawing.Point(212, 196)
        NAMAOBATLabel.Name = "NAMAOBATLabel"
        NAMAOBATLabel.Size = New System.Drawing.Size(70, 13)
        NAMAOBATLabel.TabIndex = 12
        NAMAOBATLabel.Text = "NAMAOBAT:"
        '
        'PABRIKLabel
        '
        PABRIKLabel.AutoSize = True
        PABRIKLabel.Location = New System.Drawing.Point(371, 196)
        PABRIKLabel.Name = "PABRIKLabel"
        PABRIKLabel.Size = New System.Drawing.Size(49, 13)
        PABRIKLabel.TabIndex = 14
        PABRIKLabel.Text = "PABRIK:"
        '
        'SATUANLabel
        '
        SATUANLabel.AutoSize = True
        SATUANLabel.Location = New System.Drawing.Point(497, 196)
        SATUANLabel.Name = "SATUANLabel"
        SATUANLabel.Size = New System.Drawing.Size(54, 13)
        SATUANLabel.TabIndex = 16
        SATUANLabel.Text = "SATUAN:"
        '
        'HARGALabel
        '
        HARGALabel.AutoSize = True
        HARGALabel.Location = New System.Drawing.Point(606, 196)
        HARGALabel.Name = "HARGALabel"
        HARGALabel.Size = New System.Drawing.Size(48, 13)
        HARGALabel.TabIndex = 18
        HARGALabel.Text = "HARGA:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(76, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedagang Besar Farmasi ""HEALTHY"""
        '
        'ObatDataSet
        '
        Me.ObatDataSet.DataSetName = "obatDataSet"
        Me.ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOBATBindingSource
        '
        Me.TOBATBindingSource.DataMember = "TOBAT"
        Me.TOBATBindingSource.DataSource = Me.ObatDataSet
        '
        'TOBATTableAdapter
        '
        Me.TOBATTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TNORESEPTableAdapter = Nothing
        Me.TableAdapterManager.TOBATTableAdapter = Me.TOBATTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.obatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataGridView1.DataSource = Me.TOBATBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(110, 282)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 220)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "KODEOBAT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "KODEOBAT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAMAOBAT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMAOBAT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PABRIK"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PABRIK"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SATUAN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SATUAN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HARGA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HARGA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(45, 535)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 40)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(154, 535)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 40)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "UPDATE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(257, 535)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 40)
        Me.btnDel.TabIndex = 5
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAwal
        '
        Me.btnAwal.Image = Global.WindowsApplication1.My.Resources.Resources.AWAL
        Me.btnAwal.Location = New System.Drawing.Point(486, 535)
        Me.btnAwal.Name = "btnAwal"
        Me.btnAwal.Size = New System.Drawing.Size(75, 40)
        Me.btnAwal.TabIndex = 6
        Me.btnAwal.UseVisualStyleBackColor = True
        '
        'btnSebelumnya
        '
        Me.btnSebelumnya.Image = Global.WindowsApplication1.My.Resources.Resources.sebelum
        Me.btnSebelumnya.Location = New System.Drawing.Point(567, 535)
        Me.btnSebelumnya.Name = "btnSebelumnya"
        Me.btnSebelumnya.Size = New System.Drawing.Size(75, 40)
        Me.btnSebelumnya.TabIndex = 7
        Me.btnSebelumnya.UseVisualStyleBackColor = True
        '
        'btnSesudahnya
        '
        Me.btnSesudahnya.Image = Global.WindowsApplication1.My.Resources.Resources.sesudah
        Me.btnSesudahnya.Location = New System.Drawing.Point(648, 535)
        Me.btnSesudahnya.Name = "btnSesudahnya"
        Me.btnSesudahnya.Size = New System.Drawing.Size(75, 40)
        Me.btnSesudahnya.TabIndex = 8
        Me.btnSesudahnya.UseVisualStyleBackColor = True
        '
        'btnAkhir
        '
        Me.btnAkhir.Image = Global.WindowsApplication1.My.Resources.Resources.akhir
        Me.btnAkhir.Location = New System.Drawing.Point(729, 535)
        Me.btnAkhir.Name = "btnAkhir"
        Me.btnAkhir.Size = New System.Drawing.Size(75, 40)
        Me.btnAkhir.TabIndex = 9
        Me.btnAkhir.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(837, 535)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'KODEOBATTextBox
        '
        Me.KODEOBATTextBox.Location = New System.Drawing.Point(76, 229)
        Me.KODEOBATTextBox.Name = "KODEOBATTextBox"
        Me.KODEOBATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KODEOBATTextBox.TabIndex = 19
        '
        'NAMAOBATTextBox
        '
        Me.NAMAOBATTextBox.Location = New System.Drawing.Point(206, 229)
        Me.NAMAOBATTextBox.Name = "NAMAOBATTextBox"
        Me.NAMAOBATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMAOBATTextBox.TabIndex = 20
        '
        'SATUANTextBox
        '
        Me.SATUANTextBox.Location = New System.Drawing.Point(466, 229)
        Me.SATUANTextBox.Name = "SATUANTextBox"
        Me.SATUANTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SATUANTextBox.TabIndex = 22
        '
        'PABRIKTextBox
        '
        Me.PABRIKTextBox.Location = New System.Drawing.Point(336, 229)
        Me.PABRIKTextBox.Name = "PABRIKTextBox"
        Me.PABRIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PABRIKTextBox.TabIndex = 21
        '
        'HARGATextBox
        '
        Me.HARGATextBox.Location = New System.Drawing.Point(583, 229)
        Me.HARGATextBox.Name = "HARGATextBox"
        Me.HARGATextBox.Size = New System.Drawing.Size(100, 20)
        Me.HARGATextBox.TabIndex = 23
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(154, 605)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 40)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(969, 691)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.HARGATextBox)
        Me.Controls.Add(Me.SATUANTextBox)
        Me.Controls.Add(Me.PABRIKTextBox)
        Me.Controls.Add(Me.NAMAOBATTextBox)
        Me.Controls.Add(Me.KODEOBATTextBox)
        Me.Controls.Add(HARGALabel)
        Me.Controls.Add(SATUANLabel)
        Me.Controls.Add(PABRIKLabel)
        Me.Controls.Add(NAMAOBATLabel)
        Me.Controls.Add(KODEOBATLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAkhir)
        Me.Controls.Add(Me.btnSesudahnya)
        Me.Controls.Add(Me.btnSebelumnya)
        Me.Controls.Add(Me.btnAwal)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMaster"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ObatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOBATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ObatDataSet As WindowsApplication1.obatDataSet
    Friend WithEvents TOBATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOBATTableAdapter As WindowsApplication1.obatDataSetTableAdapters.TOBATTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.obatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAwal As System.Windows.Forms.Button
    Friend WithEvents btnSebelumnya As System.Windows.Forms.Button
    Friend WithEvents btnSesudahnya As System.Windows.Forms.Button
    Friend WithEvents btnAkhir As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents KODEOBATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMAOBATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SATUANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PABRIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HARGATextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
