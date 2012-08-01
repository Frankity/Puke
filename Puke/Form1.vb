Imports System.IO
Imports Ionic.Zip

Public Class MainWin

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        SplitContainer1.SplitterDistance = 50
    End Sub

    Dim abrirdlg As New OpenFileDialog

    Sub abrirdlgfunc()
        Dim loles
        abrirdlg.Filter = "Archivos Puke (*.puke)|*.puke|Todos los archivos (*.*)|*.*"
        loles = abrirdlg.ShowDialog()

        If loles = DialogResult.OK Then
            MsgBox("ok")
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Try
            abrirdlgfunc()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        abrirdlgfunc()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboRuta.Text = Application.StartupPath
            SplitContainer1.SplitterDistance = 50
            mdlistar.ListarOnload()
            rutainicio()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub rutainicio()
        Dim combo As New directoryinfo("\")
        Dim carpetas() As directoryinfo
        carpetas = combo.getdirectories()
        Dim carpetas2 As DirectoryInfo
        For Each carpetas2 In carpetas
            ComboRuta.Items.Add(carpetas2.FullName)
        Next
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboRuta.SelectedIndexChanged
        Try
            'mdlistar.ListarOnEnter()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRef.Click
        ' mdlistar.ListarOnEnter()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaExplorer.SelectedIndexChanged
        mdlistar.ClickOnlist()
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboRuta.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                e.Handled = True
                ' mdlistar.ListarOnEnter()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        btnatras()
    End Sub

    Public Sub btnatras()
        Try

            Dim userdir As String = ComboRuta.Text
            Dim posicion As Integer = userdir.LastIndexOf("\")
            Dim usershit As String = userdir.Remove(2, userdir.Length - 2)
            usershit = userdir.Substring(0, posicion)
            If usershit.Length = 2 Then
                usershit = userdir.Substring(0, posicion + 1)
            End If
            ComboRuta.Text = usershit
            'mdlistar.ListarOnBack()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PropiedadesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PropiedadesToolStripMenuItem.Click
        For i As Int16 = 0 To ListaExplorer.SelectedIndices.Count - 1
            MsgBox(ListaExplorer.SelectedItems.Item(i).Text)
        Next
    End Sub
End Class
