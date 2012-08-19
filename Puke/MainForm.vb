Imports System.IO

Public Class MainWin

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        SplitContainer1.SplitterDistance = 65
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
            If Not System.IO.File.Exists(Application.StartupPath & "\Config.xml") Then
                ComboRuta.Text = Application.StartupPath
            End If
            MdXml.LeerXml()
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
            mdlistar.ListarOnEnter()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRef.Click
        Try
            mdlistar.ListarOnEnter()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboRuta.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                e.Handled = True
                mdlistar.ListarOnEnter()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Try
            mdlistar.btnatras()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PropiedadesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PropiedadesToolStripMenuItem.Click
        MsgBox(namefile)
    End Sub

    Public Function namefile()
        Dim lel As String
        For i As Int16 = 0 To ListaExplorer.SelectedIndices.Count - 1
            lel = ListaExplorer.SelectedItems.Item(i).Text
        Next
        Return lel
    End Function

    Private Sub ListaExplorer_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaExplorer.DoubleClick
        listarall()
    End Sub

    Public Sub listarall()
        Try
            For r As Integer = 0 To ListaExplorer.SelectedIndices.Count - 1
                Dim selectedtex As String = "\" & ListaExplorer.SelectedItems.Item(r).Text
                Dim xDD As String = ComboRuta.Text & selectedtex
                ComboRuta.Text = xDD
                If xDD.EndsWith(".zip") Then
                    MdCompDecomp.ListarZip(xDD)
                ElseIf xDD.EndsWith(".puke") Then
                    MdCompDecomp.ListarZip(xDD)
                Else
                    mdlistar.ListarOnDoubleClick()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VistaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaToolStripButton.Click
        If ListaExplorer.View = View.Details Then
            ListaExplorer.View = View.List
        Else
            ListaExplorer.View = View.Details
        End If
    End Sub
    '

    Private Sub MainWin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            MdXml.CrearXml()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ListaExplorer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListaExplorer.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                e.Handled = True
                For r As Integer = 0 To ListaExplorer.SelectedIndices.Count - 1
                    Dim selectedtex As String = "\" & ListaExplorer.SelectedItems.Item(r).Text
                    Dim xDD As String = ComboRuta.Text & selectedtex
                    ComboRuta.Text = xDD
                    If xDD.EndsWith(".zip") Then
                        MdCompDecomp.ListarZip(xDD)
                    ElseIf xDD.EndsWith(".puke") Then
                        MdCompDecomp.ListarZip(xDD)
                    Else
                        mdlistar.ListarOnDoubleClick()
                    End If
                Next
            ElseIf e.KeyCode = Keys.Back Then
                e.Handled = True
                mdlistar.btnatras()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Try
            For r As Integer = 0 To ListaExplorer.SelectedIndices.Count - 1
                Dim selectedtex As String = "\" & ListaExplorer.SelectedItems.Item(r).Text
                If selectedtex.StartsWith("\") Then
                    Dim remv As String = selectedtex.Replace("\", "")
                    Dim xDD As String = remv
                    AddForm.TxtName.Text = xDD
                    AddForm.Show()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AgregarArchivosAlFicheroToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AgregarArchivosAlFicheroToolStripMenuItem.Click
        Try
            For r As Integer = 0 To ListaExplorer.SelectedIndices.Count - 1
                Dim selectedtex As String = "\" & ListaExplorer.SelectedItems.Item(r).Text
                If selectedtex.StartsWith("\") Then
                    Dim remv As String = selectedtex.Replace("\", "")
                    Dim xDD As String = remv
                    AddForm.TxtName.Text = xDD
                    AddForm.Show()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExtraerEnUnaCarpetaEspecificaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExtraerEnUnaCarpetaEspecificaToolStripMenuItem.Click
        AddForm.SelCarpDest.ShowDialog()
        Dim rutaarchivo As String

        Try
            For i As Int16 = 0 To ListaExplorer.SelectedIndices.Count - 1
                rutaarchivo = ComboRuta.Text & "\" & ListaExplorer.SelectedItems.Item(i).Text
            Next
            MdCompDecomp.Descomprimir(rutaarchivo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AbrirRutaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("explorer.exe " & ComboRuta.Text, AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub ListaExplorer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaExplorer.SelectedIndexChanged

    End Sub
End Class
