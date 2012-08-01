Imports System.IO

Module mdlistar


    Dim contadoritems As Integer

    

    Dim ruta As String = Form1.ComboRuta.Text

    Public Sub ListarOnload()

        Dim d As New DirectoryInfo(ruta)

        Form1.ListaExplorer.FullRowSelect = True

        Form1.ListaExplorer.BeginUpdate()
        Form1.ListaExplorer.Items.Clear()

        For Each e As DirectoryInfo In d.GetDirectories

            Dim item As New ListViewItem()

            item.SubItems.Add(e.Name)
            item.SubItems.Add(Replace(FileAttributes.Directory, 16, "Directorio"))
            item.SubItems.Add("No esta Vacio")
            item.SubItems.Add(e.LastWriteTime)
            Form1.ListaExplorer.Items.Add(item)
            contadoritems = Form1.ListaExplorer.Items.Count - 1

            If FileAttributes.Directory Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 1
            End If

           
        Next

        Form1.ListaExplorer.EndUpdate()

        For Each f As FileInfo In d.GetFiles
            Dim item As New ListViewItem()

            item.SubItems.Add(f.Name)
            item.SubItems.Add("Archivo " & f.Extension)
            item.SubItems.Add(f.Length)
            item.SubItems.Add(f.LastWriteTime)
            Form1.ListaExplorer.Items.Add(item)
            contadoritems = Form1.ListaExplorer.Items.Count - 1

            If f.Extension = ".dll" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 8
            ElseIf f.Extension = ".torrent" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 2
            ElseIf f.Extension = ".pdf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 3
            ElseIf f.Extension = ".mp4" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 4
            ElseIf f.Extension = ".flv" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 5
            ElseIf f.Extension = ".3gp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 6
            ElseIf f.Extension = ".xlsx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 7
            ElseIf f.Extension = ".rar" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 9
            ElseIf f.Extension = ".vob" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 10
            ElseIf f.Extension = ".docx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 11
            ElseIf f.Extension = ".ppsx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 12
            ElseIf f.Extension = ".bin" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 13
            ElseIf f.Extension = ".m4a" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 14
            ElseIf f.Extension = ".tmp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 15
            ElseIf f.Extension = ".xpi" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 16
            ElseIf f.Extension = ".bup" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 17
            ElseIf f.Extension = ".wmv" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 18
            ElseIf f.Extension = ".thm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 19
            ElseIf f.Extension = ".dat" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 20
            ElseIf f.Extension = ".zip" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 21
            ElseIf f.Extension = ".jpg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 22
            ElseIf f.Extension = ".JPG" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 22
            ElseIf f.Extension = ".exe" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 23
            ElseIf f.Extension = ".mpg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 24
            ElseIf f.Extension = ".tif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 25
            ElseIf f.Extension = ".wav" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 26
            ElseIf f.Extension = ".mov" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 27
            ElseIf f.Extension = ".psd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 28
            ElseIf f.Extension = ".wma" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 29
            ElseIf f.Extension = ".sitx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 30
            ElseIf f.Extension = ".sit" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 31
            ElseIf f.Extension = ".eps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 32
            ElseIf f.Extension = ".cdr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 33
            ElseIf f.Extension = ".ai" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 34
            ElseIf f.Extension = ".txt" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 35
            ElseIf f.Extension = ".rmvb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 36
            ElseIf f.Extension = ".bmp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 37
            ElseIf f.Extension = ".aif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 38
            ElseIf f.Extension = ".pub" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 39
            ElseIf f.Extension = ".dwg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 40
            ElseIf f.Extension = ".gif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 41
            ElseIf f.Extension = ".qbb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 42
            ElseIf f.Extension = ".mpeg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 43
            ElseIf f.Extension = ".swf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 44
            ElseIf f.Extension = ".asf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 45
            ElseIf f.Extension = ".indd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 46
            ElseIf f.Extension = ".rm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 47
            ElseIf f.Extension = ".mdb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 48
            ElseIf f.Extension = ".chm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 49
            ElseIf f.Extension = ".jar" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 50
            ElseIf f.Extension = ".htm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 51
            ElseIf f.Extension = ".dvf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 52
            ElseIf f.Extension = ".dss" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 53
            ElseIf f.Extension = ".dmg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 54
            ElseIf f.Extension = ".iso" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 55
            ElseIf f.Extension = ".cda" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 56
            ElseIf f.Extension = ".m4b" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 57
            ElseIf f.Extension = ".7z" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 58
            ElseIf f.Extension = ".gz" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 59
            ElseIf f.Extension = ".tgz" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 60
            ElseIf f.Extension = ".fla" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 61
            ElseIf f.Extension = ".qxs" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 62
            ElseIf f.Extension = ".rtf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 63
            ElseIf f.Extension = ".aiff" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 64
            ElseIf f.Extension = ".msi" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 65
            ElseIf f.Extension = ".jpeg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 66
            ElseIf f.Extension = ".cdl" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 67
            ElseIf f.Extension = ".acp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 68
            ElseIf f.Extension = ".m4p" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 69
            ElseIf f.Extension = ".divx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 70
            ElseIf f.Extension = ".html" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 71
            ElseIf f.Extension = ".pst" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 72
            ElseIf f.Extension = ".cab" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 73
            ElseIf f.Extension = ".ttf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 74
            ElseIf f.Extension = ".hqx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 75
            ElseIf f.Extension = ".qbw" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 76
            ElseIf f.Extension = ".sea" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 77
            ElseIf f.Extension = ".ptb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 78
            ElseIf f.Extension = ".mswmm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 79
            ElseIf f.Extension = ".ifo" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 80
            ElseIf f.Extension = ".log" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 81
            ElseIf f.Extension = ".mcd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 82
            ElseIf f.Extension = ".ss" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 83
            ElseIf f.Extension = ".m4v" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 84
            ElseIf f.Extension = ".mp3" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 84
            ElseIf f.Extension = ".eml" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 85
            ElseIf f.Extension = ".mid" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 86
            ElseIf f.Extension = ".ogg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 87
            ElseIf f.Extension = ".ram" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 88
            ElseIf f.Extension = ".lnk" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 89
            ElseIf f.Extension = ".ses" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 90
            ElseIf f.Extension = ".mp2" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 91
            ElseIf f.Extension = ".vcd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 92
            ElseIf f.Extension = ".bat" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 93
            ElseIf f.Extension = ".asx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 94
            ElseIf f.Extension = ".ps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 95
            ElseIf f.Extension = ".cbr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 96
            ElseIf f.Extension = ".amr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 97
            ElseIf f.Extension = ".wps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 98
            Else
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 83
            End If

            Dim i As Integer
            Dim b As Integer
            If f.Extension.Contains(".") Then
                i = i + 1
            ElseIf f.Extension.StartsWith("D") Then
                b = b + 1
            End If

            Form1.ToolStripStatusLabel1.Text = i & " Archivos y " & b & " Carpetas"

        Next

        Form1.ListaExplorer.EndUpdate()

    End Sub

    Public Sub ListarOnBack()

        Dim d As New DirectoryInfo(Form1.ComboRuta.Text)

        Form1.ListaExplorer.FullRowSelect = True

        Form1.ListaExplorer.BeginUpdate()
        Form1.ListaExplorer.Items.Clear()

        For Each e As DirectoryInfo In d.GetDirectories

            Dim item As New ListViewItem()

            item.SubItems.Add(e.Name)
            item.SubItems.Add(Replace(FileAttributes.Directory, 16, "Directorio"))
            item.SubItems.Add("No esta Vacio")
            item.SubItems.Add(e.LastWriteTime)
            Form1.ListaExplorer.Items.Add(item)
            contadoritems = Form1.ListaExplorer.Items.Count - 1

            If FileAttributes.Directory Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 1
            End If

        Next

        Form1.ListaExplorer.EndUpdate()

        For Each f As FileInfo In d.GetFiles
            Dim item As New ListViewItem()

            item.SubItems.Add(f.Name)
            item.SubItems.Add("Archivo " & f.Extension)
            item.SubItems.Add(f.Length)
            item.SubItems.Add(f.LastWriteTime)
            Form1.ListaExplorer.Items.Add(item)
            contadoritems = Form1.ListaExplorer.Items.Count - 1

            If f.Extension = ".dll" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 8
            ElseIf f.Extension = ".torrent" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 2
            ElseIf f.Extension = ".pdf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 3
            ElseIf f.Extension = ".mp4" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 4
            ElseIf f.Extension = ".flv" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 5
            ElseIf f.Extension = ".3gp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 6
            ElseIf f.Extension = ".xlsx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 7
            ElseIf f.Extension = ".rar" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 9
            ElseIf f.Extension = ".vob" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 10
            ElseIf f.Extension = ".docx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 11
            ElseIf f.Extension = ".ppsx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 12
            ElseIf f.Extension = ".bin" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 13
            ElseIf f.Extension = ".m4a" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 14
            ElseIf f.Extension = ".tmp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 15
            ElseIf f.Extension = ".xpi" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 16
            ElseIf f.Extension = ".bup" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 17
            ElseIf f.Extension = ".wmv" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 18
            ElseIf f.Extension = ".thm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 19
            ElseIf f.Extension = ".dat" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 20
            ElseIf f.Extension = ".zip" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 21
            ElseIf f.Extension = ".jpg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 22
            ElseIf f.Extension = ".JPG" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 22
            ElseIf f.Extension = ".exe" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 23
            ElseIf f.Extension = ".mpg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 24
            ElseIf f.Extension = ".tif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 25
            ElseIf f.Extension = ".wav" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 26
            ElseIf f.Extension = ".mov" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 27
            ElseIf f.Extension = ".psd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 28
            ElseIf f.Extension = ".wma" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 29
            ElseIf f.Extension = ".sitx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 30
            ElseIf f.Extension = ".sit" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 31
            ElseIf f.Extension = ".eps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 32
            ElseIf f.Extension = ".cdr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 33
            ElseIf f.Extension = ".ai" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 34
            ElseIf f.Extension = ".txt" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 35
            ElseIf f.Extension = ".rmvb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 36
            ElseIf f.Extension = ".bmp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 37
            ElseIf f.Extension = ".aif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 38
            ElseIf f.Extension = ".pub" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 39
            ElseIf f.Extension = ".dwg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 40
            ElseIf f.Extension = ".gif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 41
            ElseIf f.Extension = ".qbb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 42
            ElseIf f.Extension = ".mpeg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 43
            ElseIf f.Extension = ".swf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 44
            ElseIf f.Extension = ".asf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 45
            ElseIf f.Extension = ".indd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 46
            ElseIf f.Extension = ".rm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 47
            ElseIf f.Extension = ".mdb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 48
            ElseIf f.Extension = ".chm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 49
            ElseIf f.Extension = ".jar" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 50
            ElseIf f.Extension = ".htm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 51
            ElseIf f.Extension = ".dvf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 52
            ElseIf f.Extension = ".dss" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 53
            ElseIf f.Extension = ".dmg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 54
            ElseIf f.Extension = ".iso" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 55
            ElseIf f.Extension = ".cda" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 56
            ElseIf f.Extension = ".m4b" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 57
            ElseIf f.Extension = ".7z" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 58
            ElseIf f.Extension = ".gz" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 59
            ElseIf f.Extension = ".tgz" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 60
            ElseIf f.Extension = ".fla" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 61
            ElseIf f.Extension = ".qxs" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 62
            ElseIf f.Extension = ".rtf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 63
            ElseIf f.Extension = ".aiff" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 64
            ElseIf f.Extension = ".msi" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 65
            ElseIf f.Extension = ".jpeg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 66
            ElseIf f.Extension = ".cdl" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 67
            ElseIf f.Extension = ".acp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 68
            ElseIf f.Extension = ".m4p" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 69
            ElseIf f.Extension = ".divx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 70
            ElseIf f.Extension = ".html" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 71
            ElseIf f.Extension = ".pst" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 72
            ElseIf f.Extension = ".cab" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 73
            ElseIf f.Extension = ".ttf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 74
            ElseIf f.Extension = ".hqx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 75
            ElseIf f.Extension = ".qbw" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 76
            ElseIf f.Extension = ".sea" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 77
            ElseIf f.Extension = ".ptb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 78
            ElseIf f.Extension = ".mswmm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 79
            ElseIf f.Extension = ".ifo" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 80
            ElseIf f.Extension = ".log" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 81
            ElseIf f.Extension = ".mcd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 82
            ElseIf f.Extension = ".ss" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 83
            ElseIf f.Extension = ".m4v" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 84
            ElseIf f.Extension = ".mp3" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 84
            ElseIf f.Extension = ".eml" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 85
            ElseIf f.Extension = ".mid" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 86
            ElseIf f.Extension = ".ogg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 87
            ElseIf f.Extension = ".ram" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 88
            ElseIf f.Extension = ".lnk" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 89
            ElseIf f.Extension = ".ses" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 90
            ElseIf f.Extension = ".mp2" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 91
            ElseIf f.Extension = ".vcd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 92
            ElseIf f.Extension = ".bat" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 93
            ElseIf f.Extension = ".asx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 94
            ElseIf f.Extension = ".ps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 95
            ElseIf f.Extension = ".cbr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 96
            ElseIf f.Extension = ".amr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 97
            ElseIf f.Extension = ".wps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 98
            Else
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 83
            End If

            Dim i As Integer
            Dim b As Integer
            If f.Extension.Contains(".") Then
                i = i + 1
            ElseIf f.Extension.StartsWith("D") Then
                b = b + 1
            End If

            Form1.ToolStripStatusLabel1.Text = i & " Archivos y " & b & " Carpetas"

        Next

        Form1.ListaExplorer.EndUpdate()

    End Sub

    Public Sub ListarOnEnter()

        Dim d As New DirectoryInfo(Form1.ComboRuta.Text)

        Form1.ListaExplorer.FullRowSelect = True

        Form1.ListaExplorer.BeginUpdate()
        Form1.ListaExplorer.Items.Clear()

        For Each e As DirectoryInfo In d.GetDirectories

            Dim item As New ListViewItem()

            item.SubItems.Add(e.Name)
            item.SubItems.Add(Replace(FileAttributes.Directory, 16, "Directorio"))
            item.SubItems.Add("No esta Vacio")
            item.SubItems.Add(e.LastWriteTime)
            Form1.ListaExplorer.Items.Add(item)
            contadoritems = Form1.ListaExplorer.Items.Count - 1

            If FileAttributes.Directory Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 1
            End If


        Next

        Form1.ListaExplorer.EndUpdate()

        For Each f As FileInfo In d.GetFiles
            Dim item As New ListViewItem()

            item.SubItems.Add(f.Name)
            item.SubItems.Add("Archivo " & f.Extension)
            item.SubItems.Add(f.Length)
            item.SubItems.Add(f.LastWriteTime)
            Form1.ListaExplorer.Items.Add(item)
            contadoritems = Form1.ListaExplorer.Items.Count - 1

            If f.Extension = ".dll" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 8
            ElseIf f.Extension = ".torrent" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 2
            ElseIf f.Extension = ".pdf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 3
            ElseIf f.Extension = ".mp4" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 4
            ElseIf f.Extension = ".flv" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 5
            ElseIf f.Extension = ".3gp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 6
            ElseIf f.Extension = ".xlsx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 7
            ElseIf f.Extension = ".rar" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 9
            ElseIf f.Extension = ".vob" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 10
            ElseIf f.Extension = ".docx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 11
            ElseIf f.Extension = ".ppsx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 12
            ElseIf f.Extension = ".bin" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 13
            ElseIf f.Extension = ".m4a" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 14
            ElseIf f.Extension = ".tmp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 15
            ElseIf f.Extension = ".xpi" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 16
            ElseIf f.Extension = ".bup" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 17
            ElseIf f.Extension = ".wmv" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 18
            ElseIf f.Extension = ".thm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 19
            ElseIf f.Extension = ".dat" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 20
            ElseIf f.Extension = ".zip" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 21
            ElseIf f.Extension = ".jpg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 22
            ElseIf f.Extension = ".JPG" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 22
            ElseIf f.Extension = ".exe" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 23
            ElseIf f.Extension = ".mpg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 24
            ElseIf f.Extension = ".tif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 25
            ElseIf f.Extension = ".wav" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 26
            ElseIf f.Extension = ".mov" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 27
            ElseIf f.Extension = ".psd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 28
            ElseIf f.Extension = ".wma" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 29
            ElseIf f.Extension = ".sitx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 30
            ElseIf f.Extension = ".sit" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 31
            ElseIf f.Extension = ".eps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 32
            ElseIf f.Extension = ".cdr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 33
            ElseIf f.Extension = ".ai" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 34
            ElseIf f.Extension = ".txt" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 35
            ElseIf f.Extension = ".rmvb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 36
            ElseIf f.Extension = ".bmp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 37
            ElseIf f.Extension = ".aif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 38
            ElseIf f.Extension = ".pub" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 39
            ElseIf f.Extension = ".dwg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 40
            ElseIf f.Extension = ".gif" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 41
            ElseIf f.Extension = ".qbb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 42
            ElseIf f.Extension = ".mpeg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 43
            ElseIf f.Extension = ".swf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 44
            ElseIf f.Extension = ".asf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 45
            ElseIf f.Extension = ".indd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 46
            ElseIf f.Extension = ".rm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 47
            ElseIf f.Extension = ".mdb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 48
            ElseIf f.Extension = ".chm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 49
            ElseIf f.Extension = ".jar" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 50
            ElseIf f.Extension = ".htm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 51
            ElseIf f.Extension = ".dvf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 52
            ElseIf f.Extension = ".dss" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 53
            ElseIf f.Extension = ".dmg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 54
            ElseIf f.Extension = ".iso" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 55
            ElseIf f.Extension = ".cda" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 56
            ElseIf f.Extension = ".m4b" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 57
            ElseIf f.Extension = ".7z" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 58
            ElseIf f.Extension = ".gz" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 59
            ElseIf f.Extension = ".tgz" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 60
            ElseIf f.Extension = ".fla" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 61
            ElseIf f.Extension = ".qxs" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 62
            ElseIf f.Extension = ".rtf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 63
            ElseIf f.Extension = ".aiff" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 64
            ElseIf f.Extension = ".msi" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 65
            ElseIf f.Extension = ".jpeg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 66
            ElseIf f.Extension = ".cdl" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 67
            ElseIf f.Extension = ".acp" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 68
            ElseIf f.Extension = ".m4p" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 69
            ElseIf f.Extension = ".divx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 70
            ElseIf f.Extension = ".html" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 71
            ElseIf f.Extension = ".pst" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 72
            ElseIf f.Extension = ".cab" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 73
            ElseIf f.Extension = ".ttf" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 74
            ElseIf f.Extension = ".hqx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 75
            ElseIf f.Extension = ".qbw" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 76
            ElseIf f.Extension = ".sea" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 77
            ElseIf f.Extension = ".ptb" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 78
            ElseIf f.Extension = ".mswmm" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 79
            ElseIf f.Extension = ".ifo" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 80
            ElseIf f.Extension = ".log" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 81
            ElseIf f.Extension = ".mcd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 82
            ElseIf f.Extension = ".ss" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 83
            ElseIf f.Extension = ".m4v" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 84
            ElseIf f.Extension = ".mp3" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 84
            ElseIf f.Extension = ".eml" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 85
            ElseIf f.Extension = ".mid" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 86
            ElseIf f.Extension = ".ogg" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 87
            ElseIf f.Extension = ".ram" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 88
            ElseIf f.Extension = ".lnk" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 89
            ElseIf f.Extension = ".ses" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 90
            ElseIf f.Extension = ".mp2" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 91
            ElseIf f.Extension = ".vcd" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 92
            ElseIf f.Extension = ".bat" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 93
            ElseIf f.Extension = ".asx" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 94
            ElseIf f.Extension = ".ps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 95
            ElseIf f.Extension = ".cbr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 96
            ElseIf f.Extension = ".amr" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 97
            ElseIf f.Extension = ".wps" Then
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 98
            Else
                Form1.ListaExplorer.Items(contadoritems).ImageIndex = 83
            End If

            Dim i As Integer
            Dim b As Integer
            If f.Extension.Contains(".") Then
                i = i + 1
            ElseIf f.Extension.StartsWith("D") Then
                b = b + 1
            End If

            Form1.ToolStripStatusLabel1.Text = i & " Archivos y " & b & " Carpetas"

        Next

        Form1.ListaExplorer.EndUpdate()

    End Sub

End Module