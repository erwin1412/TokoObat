Public Class frmMaster
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
        KODEOBATTextBox.Enabled = False
        NAMAOBATTextBox.Enabled = False
        PABRIKTextBox.Enabled = False
        SATUANTextBox.Enabled = False
        HARGATextBox.Enabled = False
    End Sub
    Sub Textboxtrue()
        KODEOBATTextBox.Enabled = True
        NAMAOBATTextBox.Enabled = True
        PABRIKTextBox.Enabled = True
        SATUANTextBox.Enabled = True
        HARGATextBox.Enabled = True
    End Sub
    Private Sub KODEOBATTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles KODEOBATTextBox.TextChanged
        KODEOBATTextBox.MaxLength = 5
    End Sub
    Private Sub TOBATBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.TOBATBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ObatDataSet)

    End Sub
    Private Sub MoveData()
        KODEOBATTextBox.Text = ds.Tables("TOBAT").Rows(norec).Item("KODEOBAT")
        NAMAOBATTextBox.Text = ds.Tables("TOBAT").Rows(norec).Item("NAMAOBAT")
        PABRIKTextBox.Text = ds.Tables("TOBAT").Rows(norec).Item("PABRIK")
        SATUANTextBox.Text = ds.Tables("TOBAT").Rows(norec).Item("SATUAN")
        HARGATextBox.Text = ds.Tables("TOBAT").Rows(norec).Item("HARGA")
    End Sub
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ObatDataSet.TOBAT' table. You can move, or remove it, as needed.
        Me.TOBATTableAdapter.Fill(Me.ObatDataSet.TOBAT)
        btnSave.Enabled = False
        btnCancel.Enabled = False
        Textboxfalse()
        koneksi()
        sql = "Select * from TOBAT"
        da = New SqlClient.SqlDataAdapter(sql, Con)
        ds = New DataSet
        da.Fill(ds, "TOBAT")
        'seeting ukuran kolom datagridview
        DataGridView1.DataSource = (ds.Tables("TOBAT"))
        DataGridView1.Columns.Item("KODEOBAT").Width = 150
        DataGridView1.Columns.Item("NAMAOBAT").Width = 200
        DataGridView1.Columns.Item("PABRIK").Width = 200
        DataGridView1.Columns.Item("SATUAN").Width = 100
        DataGridView1.Columns.Item("HARGA").Width = 100
        maxrec = ds.Tables("TOBAT").Rows.Count
        If maxrec > 0 Then
            norec = 0
            MoveData()
        End If
        Convert.ToInt32(DataGridView1.SelectedRows.ToString())
    End Sub


    Private Sub Edit_Mode(ByVal OnOff As Boolean)
        KODEOBATTextBox.Enabled = False
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
        KODEOBATTextBox.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Textboxtrue()
        btnAdd.Enabled = False

        btnDel.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        addmode = True
        KODEOBATTextBox.Clear()
        NAMAOBATTextBox.Clear()
        PABRIKTextBox.Clear()
        SATUANTextBox.Clear()
        HARGATextBox.Clear()
    End Sub


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If norec > 0 Then
            DataGridView1.Rows(norec).Selected = False
        End If

        'simpan data yang ditambah
        If addmode Then

            If KODEOBATTextBox.Text = "" Then
                MsgBox("silahkan isi KODEOBAT dahulu")
                KODEOBATTextBox.Focus()
            Else
                Call koneksi()
                sql = "Insert into TOBAT Values('" & KODEOBATTextBox.Text & "' , '" & NAMAOBATTextBox.Text & "','" & PABRIKTextBox.Text & "','" & SATUANTextBox.Text & "','" & HARGATextBox.Text & "'  )"
                cmd = New SqlClient.SqlCommand(sql, Con)
                cmd.ExecuteNonQuery()
            End If

        Else
            Call koneksi()
            Dim sql As String = "Update TOBAT set NAMAOBAT='" & NAMAOBATTextBox.Text & "',PABRIK='" & PABRIKTextBox.Text & "',SATUAN='" & SATUANTextBox.Text & "',HARGA ='" & HARGATextBox.Text & "' where KODEOBAT='" & KODEOBATTextBox.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, Con)
            cmd.ExecuteNonQuery()
        End If

        'load kembali data adapter
        ds = New DataSet
        da.Fill(ds, "TOBAT")
        DataGridView1.DataSource = (ds.Tables("TOBAT"))
        DataGridView1.Refresh()

        'mengaktifkan baris yang baru di add
        DataGridView1.Rows(0).Selected = False
        Dim nBaris As Integer = 0
        For Each nrow As DataGridViewRow In DataGridView1.Rows
            If DataGridView1.Rows(nBaris).Cells(0).Value = KODEOBATTextBox.Text Then
                norec = nrow.Index
            End If
            nBaris = nBaris + 1
        Next
        DataGridView1.Rows([norec]).Selected = True

        'setting parameter kursor dan mode layar

        maxrec = ds.Tables("TOBAT").Rows.Count
        MoveData()
        addmode = False
        Edit_Mode(False)
 
    End Sub
    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        If MessageBox.Show("Yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Dim CMD As SqlClient.SqlCommand
            Dim sql As String = "Delete From TOBAT where KODEOBAT='" & KODEOBATTextBox.Text & "'"
            CMD = New SqlClient.SqlCommand(sql, Con)
            CMD.ExecuteNonQuery()

            'setting paremeter  kursor dan mengaktifkan baris aktif
            ds = New DataSet
            da.Fill(ds, "TOBAT")
            DataGridView1.DataSource = (ds.Tables("TOBAT"))
            DataGridView1.Refresh()

            'mengaktifkan baris (yg baru di add/update sbg
            norec = IIf(norec <= 0, 0, norec - 1)
            maxrec = ds.Tables("TOBAT").Rows.Count
            MoveData()
            DataGridView1.Rows(0).Selected = False
            Dim nBaris As Integer = 0
            For Each nRow As DataGridViewRow In DataGridView1.Rows
                If DataGridView1.Rows(nBaris).Cells(0).Value = KODEOBATTextBox.Text Then
                    norec = nRow.Index
                End If
                nBaris = nBaris + 1
            Next
            DataGridView1.Rows([norec]).Selected = True
        Else
            MessageBox.Show("Tidak jadi hapus", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs)

        Call koneksi()
        cmd = New SqlClient.SqlCommand("Select * From TOBAT where KODEOBAT='" & KODEOBATTextBox.Text & "'", Con)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Kode Customer Tidak Ada, Silahkan coba lagi!")
            KODEOBATTextBox.Focus()
        Else
            KODEOBATTextBox.Text = rd.Item("KODEOBAT")
            NAMAOBATTextBox.Text = rd.Item("NAMAOBAT")
            PABRIKTextBox.Text = rd.Item("PABRIK")
            SATUANTextBox.Text = rd.Item("SATUAN")
            HARGATextBox.Text = rd.Item("HARGA")
        End If
        Edit_Mode(True)
        addmode = False
        Textboxtrue()
        NAMAOBATTextBox.Focus()
        KODEOBATTextBox.ReadOnly = True

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If norec > 0 Then
            DataGridView1.Rows(norec).Selected = False
        End If

        addmode = False
        Edit_mode(False)

        ds = New DataSet
        da.Fill(ds, "TOBAT")
        DataGridView1.DataSource = (ds.Tables("TOBAT"))
        DataGridView1.Refresh()
        DataGridView1.Rows(0).Selected = False
        MoveData()
        DataGridView1.Rows(NoRec).Selected = True
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAwal_Click(sender As System.Object, e As System.EventArgs) Handles btnAwal.Click

        DataGridView1.Rows(norec).Selected = False

        norec = 0
        btnSebelumnya.Enabled = False
        DataGridView1.Rows(norec).Selected = True

        MoveData()
    End Sub

    Private Sub btnSebelumnya_Click(sender As System.Object, e As System.EventArgs) Handles btnSebelumnya.Click

        DataGridView1.Rows(norec).Selected = False

        norec = IIf(norec <= 0, 0, norec - 1)
        DataGridView1.Rows(norec).Selected = True

        MoveData()
    End Sub

    Private Sub btnSesudahnya_Click(sender As System.Object, e As System.EventArgs) Handles btnSesudahnya.Click
        Me.TOBATBindingSource.MoveNext()
        Me.DataGridView1.Refresh()
        Me.DataGridView1.Focus()
        DataGridView1.Rows(norec).Selected = False

        norec = IIf(norec >= maxrec - 1, maxrec - 1, maxrec + 1)
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
End Class