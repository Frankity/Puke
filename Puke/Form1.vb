Imports System.IO
Imports Ionic.Zip

Public Class Form1

    Private modfile As String
    Private dir As String
    Private decomp As Boolean

    'Private Sub AbrirIWDToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    TreeView1.Nodes.Clear()
    '    Dim dialog As New OpenFileDialog With {
    '        .Filter = "Archivos IWD|*.iwd" _
    '    }
    '    If (dialog.ShowDialog = DialogResult.OK) Then
    '        Dim info As New FileInfo(dialog.FileName)
    '        Me.Text = Me.Text & " " & info.Name.ToString
    '        modfile = dialog.FileName
    '        Using file As ZipFile = ZipFile.Read(modfile)
    '            Dim str As String
    '            For Each str In file.EntryFileNames
    '                Dim cont As String = ".iwd"
    '                file.Item(str).Extract((info.Directory.ToString & "/" & dialog.SafeFileName.Replace(cont, "")), True)
    '            Next
    '        End Using
    '    End If
    '    If (Me.modfile <> "") Then
    '        Dim info As New FileInfo(Me.modfile)
    '        Me.decomp = True
    '        Dim num As Integer = New Random().Next(1, &H315)
    '        Dim lols As String = dialog.SafeFileName.Length
    '        Dim cont As String = ".iwd"
    '        Dim path As String = (info.Directory.ToString & "/" & dialog.SafeFileName.Replace(cont, "") & "/maps/mp/")
    '        Me.dir = path
    '        Dim directories As String() = Directory.GetDirectories(path)
    '        Dim str3 As String
    '        For Each str3 In directories
    '            Dim str4 As String = ""
    '            Dim num2 As Integer = 0
    '            Me.TreeView1.Nodes.Add(("[" & str3.Replace(path, "") & "]"))
    '            Dim info2 As New FileInfo(str3)
    '            str4 = info2.Name.ToString
    '            path = (path & str4)
    '            num2 += 1
    '            Dim files As String() = Directory.GetFiles(path)
    '            Dim str5 As String
    '            For Each str5 In files
    '                Me.TreeView1.Nodes.Add(str5.Replace(Me.dir, "").Remove(0, 10))
    '                Me.TreeView1.LineColor = Color.Red
    '                Me.TreeView1.ForeColor = Color.Blue
    '            Next
    '            path = (info.Directory.ToString & "/" & modfile & "/maps/mp/")
    '        Next
    '    End If
    'End Sub

    'Public Sub TreeView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim tabPage As New TabPage With { _
    '        .Text = Me.TreeView1.SelectedNode.Text.ToString _
    '    }
    '    Me.tabControl1.TabPages.Insert((Me.tabControl1.TabCount - 1), tabPage)
    '    Dim box As New RichTextBox

    '    Dim str As String = File.ReadAllText((Me.dir & "gametypes\" & Me.TreeView1.SelectedNode.Text.ToString))
    '    Me.tabControl1.Multiline = True
    '    Dim box2 As New RichTextBox With { _
    '        .Text = File.ReadAllText((Me.dir & "gametypes\" & Me.TreeView1.SelectedNode.Text.ToString)) _
    '    }
    '    tabPage.Controls.Add(box2)
    '    box2.Dock = DockStyle.Fill
    '    Console.WriteLine((Me.dir & "gametypes\" & Me.TreeView1.SelectedNode.Text.ToString))
    '    Me.tabControl1.SelectedIndex -= 1
    'End Sub

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
            ' Dim ruta As String = ComboBox1.SelectedItem
            mdlistar.ListarOnEnter()
            ' ruta = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRef.Click
        mdlistar.ListarOnEnter()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaExplorer.SelectedIndexChanged

        '  For Each seleccionado As ListViewItem In CType(sender, ListView).SelectedItems
        'Dim i As Integer = ListView1.Items.Count - 1
        'MsgBox(ListView1.Columns.Item(1).ListView.SelectedItems.Item(3).Text)
        'Dim i As Long
        '      For i = 0 To ListView1.Items.Count - 1
        ' si está seleccionado
        'If ListView1.Items(i).Selected Then
        ' lo borramos
        Try
            MsgBox(ListaExplorer.Columns.Item(2).ListView.SelectedItems.Item(35).Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'End If
        'Next
        'MessageBox.Show(seleccionado.Text)
        'Next

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
            mdlistar.ListarOnBack()

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
