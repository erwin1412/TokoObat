Public Class Form1

    Private Sub ToolStripTextBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MASTERPRODUKToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MASTERPRODUKToolStripMenuItem.Click
        frmMaster.Show()
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        frmtransaksi.Show()
    End Sub

    Private Sub LAPORANToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LAPORANToolStripMenuItem.Click
        rptTrans.show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
