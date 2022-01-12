Public Class frmtransaksi
    Dim Con As New SqlClient.SqlConnection
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As SqlClient.SqlDataAdapter

    Dim sql As String
    Dim norec As Long = -1
    Dim maxrec As Long
    Dim addmode As Boolean

    Dim cmd As SqlClient.SqlCommand
    Dim rd As SqlClient.SqlDataReader
    Sub koneksi()
        dbSource = "data Source =.\SQLEXPRESS;AttachDbFilename = 'D:\19412416_UAS_VB\obat.mdf';integrated Security = True;Connect Timeout=30;User Instance = True"
        Con = New SqlClient.SqlConnection(dbSource)
        If Con.State = ConnectionState.Closed Then Con.Open()
    End Sub
    Sub Textboxfalse()
        NORESEPTextBox.Enabled = False
        TGLRESEPDateTimePicker.Enabled = False
        KODEOBATComboBox.Enabled = False
        QUANTITYTextBox.Enabled = False
        DISCOUNTTextBox.Enabled = False
        TOTALTextBox.Enabled = False
    End Sub
    Sub Textboxtrue()
        NORESEPTextBox.Enabled = True
        TGLRESEPDateTimePicker.Enabled = True
        KODEOBATComboBox.Enabled = True



    End Sub
    Private Sub TNORESEPBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TNORESEPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ObatDataSet)

    End Sub

    Private Sub MoveData()
        NORESEPTextBox.Text = ds.Tables("TNORESEP").Rows(norec).Item("NORESEP")
        TGLRESEPDateTimePicker.Text = ds.Tables("TNORESEP").Rows(norec).Item("TGLRESEP")
        TGLRESEPDateTimePicker.Text = ds.Tables("TNORESEP").Rows(norec).Item("NORESEP")
        QUANTITYTextBox.Text = ds.Tables("TNORESEP").Rows(norec).Item("QUANTITY")
        DISCOUNTTextBox.Text = ds.Tables("TNORESEP").Rows(norec).Item("DISCOUNT")
        DISCOUNTTextBox.Text = ds.Tables("TNORESEP").Rows(norec).Item("TOTAL")

    End Sub
    Private Sub frmtransaksi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ObatDataSet.View1' table. You can move, or remove it, as needed.
        Me.View1TableAdapter.Fill(Me.ObatDataSet.View1)
        'TODO: This line of code loads data into the 'ObatDataSet.TNORESEP' table. You can move, or remove it, as needed.
        Me.TNORESEPTableAdapter.Fill(Me.ObatDataSet.TNORESEP)
        btnSave.Enabled = False
        btnCancel.Enabled = False
        Textboxfalse()
        koneksi()
        sql = "Select * from TNORESEP"
        da = New SqlClient.SqlDataAdapter(sql, Con)
        ds = New DataSet
        da.Fill(ds, "TNORESEP")
        'seeting ukuran kolom datagridview
        DataGridView1.DataSource = (ds.Tables("TNORESEP"))
        DataGridView1.Columns.Item("NORESEP").Width = 150
        DataGridView1.Columns.Item("TGLRESEP").Width = 200
        DataGridView1.Columns.Item("NORESEP").Width = 200
        DataGridView1.Columns.Item("QUANTITY").Width = 100
        DataGridView1.Columns.Item("DISCOUNT").Width = 100
        DataGridView1.Columns.Item("TOTAL").Width = 100
        maxrec = ds.Tables("TNORESEP").Rows.Count
        If maxrec > 0 Then
            norec = 0
            MoveData()
        End If
        KODEOBATTextBox1.Text = "Select KODEOBAT from TOBAT"

    End Sub


    Private Sub Edit_Mode(ByVal OnOff As Boolean)
        NORESEPTextBox.Enabled = False
        If OnOff Then
            btnAdd.Enabled = False
            Me.DataGridView1.Enabled = False
            btnDel.Enabled = False
            btnSave.Enabled = True
            btnCancel.Enabled = True
        Else
            btnAdd.Enabled = True
            Me.DataGridView1.Enabled = True
            btnDel.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
        End If
        NORESEPTextBox.Focus()
    End Sub




    Private Sub btnAwal_Click(sender As System.Object, e As System.EventArgs) Handles btnAwal.Click
        DataGridView1.Rows(norec).Selected = False

        norec = IIf(norec <= 0, 0, norec - 1)
        DataGridView1.Rows(norec).Selected = True

        MoveData()
 
    End Sub

    Private Sub btnSebelumnya_Click(sender As System.Object, e As System.EventArgs) Handles btnSesudahnya.Click
        DataGridView1.Rows(norec).Selected = False

        norec = 0
        btnSesudahnya.Enabled = False
        DataGridView1.Rows(norec).Selected = True

        MoveData()
  
    End Sub

    Private Sub btnSesudahnya_Click(sender As System.Object, e As System.EventArgs) Handles btnSebelumnya.Click

        DataGridView1.Rows(norec).Selected = False

        norec = IIf(norec <= 0, 0, norec - 1)
        DataGridView1.Rows(norec).Selected = True

        MoveData()

    End Sub

    Private Sub btnAkhir_Click(sender As System.Object, e As System.EventArgs) Handles btnAkhir.Click

        DataGridView1.Rows(norec).Selected = False

        norec = IIf(maxrec = 0, 0, maxrec - 1)
        DataGridView1.Rows(norec).Selected = True
        DataGridView1.Rows(norec).Selected = False
        norec = IIf(maxrec = 0, 0, maxrec - 1)
        DataGridView1.Rows(norec).Selected = True
        MoveData()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If NORESEPTextBox.Text = "" Or KODEOBATComboBox.Text = "" Or QUANTITYTextBox.Text = "" Or DISCOUNTTextBox.Text = "" Then
            MsgBox("Silahkan Isi yang kosong", MsgBoxStyle.YesNo, "ERROR")
        Else
            If norec > 0 Then
                DataGridView1.Rows(norec).Selected = False
            End If

            'simpan data yang ditambah
            If addmode Then

                If NORESEPTextBox.Text = "" Then
                    MsgBox("silahkan isi NORESEP dahulu")
                    NORESEPTextBox.Focus()
                Else
                    Call koneksi()
                    sql = "Insert into TNORESEP Values('" & NORESEPTextBox.Text & "' , '" & TGLRESEPDateTimePicker.Value.Date & "','" & KODEOBATComboBox.Text & "','" & QUANTITYTextBox.Text & "','" & DISCOUNTTextBox.Text & "','" & TOTALTextBox.Text & "'   )"
                    cmd = New SqlClient.SqlCommand(sql, Con)
                    cmd.ExecuteNonQuery()
                End If
                '3
            Else
                Call koneksi()
                Dim sql As String = "Update TNORESEP set TGLRESEP='" & TGLRESEPDateTimePicker.Text & "',KODEOBAT='" & KODEOBATComboBox.Text & "',QUANTITY='" & QUANTITYTextBox.Text & "',DISCOUNT ='" & DISCOUNTTextBox.Text & "',TOTAL ='" & TOTALTextBox.Text & "' where NORESEP='" & NORESEPTextBox.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, Con)
                cmd.ExecuteNonQuery()
            End If
            '2
            'load kembali data adapter
            ds = New DataSet
            da.Fill(ds, "TNORESEP")
            DataGridView1.DataSource = (ds.Tables("TNORESEP"))
            DataGridView1.Refresh()

            'mengaktifkan baris yang baru di add
            DataGridView1.Rows(0).Selected = False
            Dim nBaris As Integer = 0
            For Each nrow As DataGridViewRow In DataGridView1.Rows
                If DataGridView1.Rows(nBaris).Cells(0).Value = NORESEPTextBox.Text Then
                    norec = nrow.Index
                End If
                nBaris = nBaris + 1
            Next
            DataGridView1.Rows([norec]).Selected = True

            'setting parameter kursor dan mode layar

            maxrec = ds.Tables("TNORESEP").Rows.Count
            MoveData()
            addmode = False
            Edit_Mode(False)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Textboxtrue()
        btnAdd.Enabled = False

        btnDel.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        '4
        addmode = True
        NORESEPTextBox.Clear()
        TOTALTextBox.Clear()
        QUANTITYTextBox.Clear()
        DISCOUNTTextBox.Clear()
        NORESEPTextBox.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If norec > 0 Then
            DataGridView1.Rows(norec).Selected = False
        End If

        addmode = False
        Edit_Mode(False)

        ds = New DataSet
        da.Fill(ds, "TNORESEP")
        DataGridView1.DataSource = (ds.Tables("TNORESEP"))
        DataGridView1.Refresh()
        DataGridView1.Rows(0).Selected = False
        MoveData()
        DataGridView1.Rows(norec).Selected = True
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        If MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Dim CMD As SqlClient.SqlCommand
            Dim sql As String = "Delete From TNORESEP where NORESEP='" & NORESEPTextBox.Text & "'"
            CMD = New SqlClient.SqlCommand(sql, Con)
            CMD.ExecuteNonQuery()

            'setting paremeter  kursor dan mengaktifkan baris aktif
            ds = New DataSet
            da.Fill(ds, "TNORESEP")
            DataGridView1.DataSource = (ds.Tables("TNORESEP"))
            DataGridView1.Refresh()

            'mengaktifkan baris (yg baru di add/update sbg
            norec = IIf(norec <= 0, 0, norec - 1)
            maxrec = ds.Tables("TNORESEP").Rows.Count
            MoveData()
            DataGridView1.Rows(0).Selected = False
            Dim nBaris As Integer = 0
            For Each nRow As DataGridViewRow In DataGridView1.Rows
                If DataGridView1.Rows(nBaris).Cells(0).Value = NORESEPTextBox.Text Then
                    norec = nRow.Index
                End If
                nBaris = nBaris + 1
            Next
            DataGridView1.Rows([norec]).Selected = True
        Else
            MessageBox.Show("Tidak jadi hapus", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        rptTrans.Show()
    End Sub

    Private Sub KODEOBATComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles KODEOBATComboBox.SelectedIndexChanged
        If KODEOBATComboBox.Text = "PB500" Then
            KODEOBATTextBox1.Text = "PB500"
            NAMAOBATTextBox.Text = "PANADOL BIRU 500MG"
            PABRIKTextBox.Text = "GLAXO SMITH KLINE"
            SATUANTextBox.Text = "STRIP"
            HARGATextBox.Text = 6500
            QUANTITYTextBox.Enabled = True
        ElseIf KODEOBATComboBox.Text = "PH500" Then
            KODEOBATTextBox1.Text = "PH500"
            NAMAOBATTextBox.Text = "PANADOL HIJAU"
            PABRIKTextBox.Text = "GLAXO SMITH KLINE"
            SATUANTextBox.Text = "STRIP"
            HARGATextBox.Text = 9500
            QUANTITYTextBox.Enabled = True
        ElseIf KODEOBATComboBox.Text = "PM500" Then
            KODEOBATTextBox1.Text = "PM500"
            NAMAOBATTextBox.Text = "PANADOL MERAH"
            PABRIKTextBox.Text = "GLAXO SMITH KLINE"
            SATUANTextBox.Text = "STRIP"
            HARGATextBox.Text = 7500
            QUANTITYTextBox.Enabled = True
        ElseIf KODEOBATComboBox.Text = "DECOL" Then
            KODEOBATTextBox1.Text = "DECOL"
            NAMAOBATTextBox.Text = "DECOLGEN STRIP"
            PABRIKTextBox.Text = "MEDIAFARMA LABORATORIES"
            SATUANTextBox.Text = "STRIP"
            HARGATextBox.Text = 4500
        ElseIf KODEOBATComboBox.Text = "FLUDA" Then
            KODEOBATTextBox1.Text = "FLUDA"
            NAMAOBATTextBox.Text = "FLUDANCE CAPSULE"
            PABRIKTextBox.Text = "AMOXINDO FARMA"
            SATUANTextBox.Text = "STRIP"
            HARGATextBox.Text = 8500
            QUANTITYTextBox.Enabled = True
        ElseIf KODEOBATComboBox.Text = "DEXYN" Then
            KODEOBATTextBox1.Text = "DEXYN"
            NAMAOBATTextBox.Text = "DECOLSIN"
            PABRIKTextBox.Text = "MEDIAFARMA LABORATORIES"
            SATUANTextBox.Text = "STRIP"
            HARGATextBox.Text = 5000
            QUANTITYTextBox.Enabled = True
        ElseIf KODEOBATComboBox.Text = "ALPAR" Then
            KODEOBATTextBox1.Text = "ALPAR"
            NAMAOBATTextBox.Text = "ALPARA CAPSULE"
            PABRIKTextBox.Text = "MEDIAFARMA LABORATORIES"
            SATUANTextBox.Text = "STRIP"
            HARGATextBox.Text = 5000
            QUANTITYTextBox.Enabled = True
        End If

     
    End Sub



    Private Sub DISCOUNTTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DISCOUNTTextBox.KeyPress
        If QUANTITYTextBox.Text = "" Then
            MsgBox("Silahkan Isi Quantit", MsgBoxStyle.YesNo, "ERROR")
            QUANTITYTextBox.Select()
            DISCOUNTTextBox.Text = 0
        End If
    End Sub


    Private Sub DISCOUNTTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles DISCOUNTTextBox.Leave
        Dim a, b, c As Double
        a = QUANTITYTextBox.Text
        b = HARGATextBox.Text
        c = DISCOUNTTextBox.Text

        TOTALTextBox.Text = Val(a * b - c)

    End Sub

    Private Sub QUANTITYTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles QUANTITYTextBox.Leave

    

    End Sub

    Private Sub QUANTITYTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles QUANTITYTextBox.KeyPress
        If KODEOBATComboBox.Text = "" Then
            MsgBox("Silahkan Isi KODEOBAT", MsgBoxStyle.YesNo, "ERROR")
            KODEOBATComboBox.Select()
            QUANTITYTextBox.Text = ""
        Else
            DISCOUNTTextBox.Enabled = True
        End If
    End Sub

    Private Sub QUANTITYTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles QUANTITYTextBox.TextChanged

    End Sub
End Class
