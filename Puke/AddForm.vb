Public Class AddForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SelCarpDest.ShowDialog()
        TxtName.Text = SelCarpDest.SelectedPath & "\" & TxtName.Text
    End Sub

    Private Sub AddForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboformato.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MdCompDecomp.Comprimir()
        Me.Close()
    End Sub

    Private Sub CheckPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckPass.CheckedChanged
        If Me.CheckPass.Checked Then
            Txtpass.Enabled = True
        Else
            Txtpass.Enabled = False
            Txtpass.Text = ""
        End If
    End Sub
End Class