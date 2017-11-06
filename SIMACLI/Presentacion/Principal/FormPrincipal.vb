Public Class FormPrinicpal
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        TabControl1.Visible = True
        TabControl1.SelectTab(0)
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        TabControl1.Visible = True
        TabControl1.SelectTab(1)
    End Sub
End Class