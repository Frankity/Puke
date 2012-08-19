Public Class PwdForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ass = Me.TxtExtractPwd.Text
        Me.Hide()
    End Sub

    Private Sub PwdForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public ass As String


End Class