Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.Click
        Me.Hide()
        Game.Show()
    End Sub
End Class
