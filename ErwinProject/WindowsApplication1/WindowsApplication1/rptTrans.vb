Public Class rptTrans

    Private Sub rptTrans_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ObatDataSet.View1' table. You can move, or remove it, as needed.
        Me.View1TableAdapter.Fill(Me.ObatDataSet.View1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class