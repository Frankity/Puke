Imports System.IO

Module mdlistar

    Dim contadoritems As Integer

    Public Sub ListarOnBack()
        Try
            ListarItems("")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ListarOnEnter()
        Try
            ListarItems("")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ListarOnload()
        Try
            ListarItems("")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ListarOnDoubleClick()
        Try
            Dim d As String
            For i As Integer = 0 To MainWin.ListaExplorer.SelectedIndices.Count - 1
                d = MainWin.ComboRuta.Text & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text
            Next
            ListarItems(d)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub btnatras()
        Try
            Dim userdir As String = MainWin.ComboRuta.Text
            Dim posicion As Integer = userdir.LastIndexOf("\")
            Dim usershit As String = userdir.Remove(2, userdir.Length - 2)
            usershit = userdir.Substring(0, posicion)
            If usershit.Length = 2 Then
                usershit = userdir.Substring(0, posicion + 1)
            End If
            MainWin.ComboRuta.Text = usershit
            mdlistar.ListarOnBack()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ClickOnlist()

        Try
            For i As Int16 = 0 To MainWin.ListaExplorer.SelectedIndices.Count - 1
                MsgBox(MainWin.ListaExplorer.SelectedItems.Item(i).Text)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub ListarItems(ByVal ruta As String)

        Dim d As New DirectoryInfo(MainWin.ComboRuta.Text)

        MainWin.ListaExplorer.FullRowSelect = True
        MainWin.ListaExplorer.BeginUpdate()
        MainWin.ListaExplorer.Items.Clear()

        For Each e As DirectoryInfo In d.GetDirectories
            Dim item As New ListViewItem()

            MainWin.ListaExplorer.Items.Add( _
            New ListViewItem( _
            New String() _
            {e.Name, Replace(FileAttributes.Directory, 16, "Directorio"), "No esta Vacio", e.LastWriteTime}))

            MainWin.ListaExplorer.FullRowSelect = True
            MainWin.ListaExplorer.HideSelection = False

            contadoritems = MainWin.ListaExplorer.Items.Count - 1
            If FileAttributes.Directory Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 1
            End If

            MainWin.ListaExplorer.EndUpdate()
        Next

        For Each f As FileInfo In d.GetFiles
            Dim item As New ListViewItem()
            MainWin.ListaExplorer.Items.Add( _
            New ListViewItem( _
            New String() _
            {f.Name, f.Extension, f.Length, f.LastWriteTime}))

            MainWin.ListaExplorer.FullRowSelect = True
            MainWin.ListaExplorer.HideSelection = False

            contadoritems = MainWin.ListaExplorer.Items.Count - 1

            If f.Extension = ".dll" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 8
            ElseIf f.Extension = ".torrent" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 2
            ElseIf f.Extension = ".pdf" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 3
            ElseIf f.Extension = ".mp4" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 4
            ElseIf f.Extension = ".flv" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 5
            ElseIf f.Extension = ".3gp" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 6
            ElseIf f.Extension = ".xlsx" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 7
            ElseIf f.Extension = ".rar" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 9
            ElseIf f.Extension = ".vob" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 10
            ElseIf f.Extension = ".docx" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 11
            ElseIf f.Extension = ".ppsx" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 12
            ElseIf f.Extension = ".bin" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 13
            ElseIf f.Extension = ".m4a" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 14
            ElseIf f.Extension = ".tmp" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 15
            ElseIf f.Extension = ".xpi" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 16
            ElseIf f.Extension = ".bup" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 17
            ElseIf f.Extension = ".wmv" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 18
            ElseIf f.Extension = ".thm" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 19
            ElseIf f.Extension = ".dat" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 20
            ElseIf f.Extension = ".zip" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 21
            ElseIf f.Extension = ".jpg" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 22
            ElseIf f.Extension = ".JPG" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 22
            ElseIf f.Extension = ".exe" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 23
            ElseIf f.Extension = ".mpg" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 24
            ElseIf f.Extension = ".tif" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 25
            ElseIf f.Extension = ".wav" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 26
            ElseIf f.Extension = ".mov" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 27
            ElseIf f.Extension = ".psd" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 28
            ElseIf f.Extension = ".wma" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 29
            ElseIf f.Extension = ".sitx" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 30
            ElseIf f.Extension = ".sit" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 31
            ElseIf f.Extension = ".eps" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 32
            ElseIf f.Extension = ".cdr" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 33
            ElseIf f.Extension = ".ai" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 34
            ElseIf f.Extension = ".txt" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 35
            ElseIf f.Extension = ".rmvb" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 36
            ElseIf f.Extension = ".bmp" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 37
            ElseIf f.Extension = ".aif" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 38
            ElseIf f.Extension = ".pub" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 39
            ElseIf f.Extension = ".dwg" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 40
            ElseIf f.Extension = ".gif" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 41
            ElseIf f.Extension = ".qbb" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 42
            ElseIf f.Extension = ".mpeg" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 43
            ElseIf f.Extension = ".swf" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 44
            ElseIf f.Extension = ".asf" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 45
            ElseIf f.Extension = ".indd" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 46
            ElseIf f.Extension = ".rm" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 47
            ElseIf f.Extension = ".mdb" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 48
            ElseIf f.Extension = ".chm" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 49
            ElseIf f.Extension = ".jar" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 50
            ElseIf f.Extension = ".htm" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 51
            ElseIf f.Extension = ".dvf" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 52
            ElseIf f.Extension = ".dss" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 53
            ElseIf f.Extension = ".dmg" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 54
            ElseIf f.Extension = ".iso" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 55
            ElseIf f.Extension = ".cda" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 56
            ElseIf f.Extension = ".m4b" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 57
            ElseIf f.Extension = ".7z" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 58
            ElseIf f.Extension = ".gz" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 59
            ElseIf f.Extension = ".tgz" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 60
            ElseIf f.Extension = ".fla" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 61
            ElseIf f.Extension = ".qxs" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 62
            ElseIf f.Extension = ".rtf" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 63
            ElseIf f.Extension = ".aiff" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 64
            ElseIf f.Extension = ".msi" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 65
            ElseIf f.Extension = ".jpeg" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 66
            ElseIf f.Extension = ".cdl" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 67
            ElseIf f.Extension = ".acp" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 68
            ElseIf f.Extension = ".m4p" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 69
            ElseIf f.Extension = ".divx" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 70
            ElseIf f.Extension = ".html" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 71
            ElseIf f.Extension = ".pst" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 72
            ElseIf f.Extension = ".cab" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 73
            ElseIf f.Extension = ".ttf" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 74
            ElseIf f.Extension = ".hqx" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 75
            ElseIf f.Extension = ".qbw" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 76
            ElseIf f.Extension = ".sea" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 77
            ElseIf f.Extension = ".ptb" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 78
            ElseIf f.Extension = ".mswmm" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 79
            ElseIf f.Extension = ".ifo" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 80
            ElseIf f.Extension = ".log" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 81
            ElseIf f.Extension = ".mcd" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 82
            ElseIf f.Extension = ".ss" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 83
            ElseIf f.Extension = ".m4v" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 84
            ElseIf f.Extension = ".mp3" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 84
            ElseIf f.Extension = ".eml" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 85
            ElseIf f.Extension = ".mid" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 86
            ElseIf f.Extension = ".ogg" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 87
            ElseIf f.Extension = ".ram" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 88
            ElseIf f.Extension = ".lnk" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 89
            ElseIf f.Extension = ".ses" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 90
            ElseIf f.Extension = ".mp2" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 91
            ElseIf f.Extension = ".vcd" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 92
            ElseIf f.Extension = ".bat" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 93
            ElseIf f.Extension = ".asx" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 94
            ElseIf f.Extension = ".ps" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 95
            ElseIf f.Extension = ".cbr" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 96
            ElseIf f.Extension = ".amr" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 97
            ElseIf f.Extension = ".wps" Then
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 98
            Else
                MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 83
            End If


        Next
        MainWin.ListaExplorer.EndUpdate()


    End Sub

End Module