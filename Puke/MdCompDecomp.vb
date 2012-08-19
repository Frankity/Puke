Imports Ionic.Zip

Module MdCompDecomp

    Public Sub Comprimir()
        Try
            Using zip As ZipFile = New ZipFile
                For i As Int16 = 0 To MainWin.ListaExplorer.SelectedIndices.Count - 1
                    If Not MainWin.ListaExplorer.SelectedItems.Item(i).Text.Contains(".") Then
                        If AddForm.Comboformato.SelectedIndex = 0 Then
                            zip.Password = AddForm.Txtpass.Text
                            zip.AddDirectory(MainWin.ComboRuta.Text & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text, "")
                            zip.Save(AddForm.TxtName.Text & ".puke")

                        ElseIf AddForm.comboformato.SelectedIndex = 1 Then
                            zip.Password = AddForm.Txtpass.Text
                            zip.AddDirectory(MainWin.ComboRuta.Text & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text, "")
                            zip.Save(AddForm.TxtName.Text & ".zip")

                        End If
                    Else
                        If AddForm.comboformato.SelectedIndex = 0 Then
                            zip.Password = AddForm.Txtpass.Text
                            zip.AddFile(MainWin.ComboRuta.Text & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text, "")
                            zip.Save(AddForm.TxtName.Text & ".puke")

                        ElseIf AddForm.comboformato.SelectedIndex = 1 Then
                            zip.Password = AddForm.Txtpass.Text
                            zip.AddFile(MainWin.ComboRuta.Text & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text, "")
                            zip.Save(AddForm.TxtName.Text & ".zip")

                        End If
                        
                    End If
                Next
            End Using
        Catch ex1 As Exception
            MsgBox(ex1.Message)
        End Try
    End Sub

    Public Function PassVerify(ByVal vars As String)
        Try
            Using zip As ZipFile = ZipFile.Read(vars)
                Dim e As ZipEntry
                For Each e In zip
                    If e.UsesEncryption Then
                        PwdForm.Show()
                        Return True
                    End If
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "pass fail")
        End Try
    End Function

    Public Sub Descomprimir(ByVal rutadesc As String)
        Try
            Using zip As ZipFile = ZipFile.Read(rutadesc)
                Dim e As ZipEntry
                If EncryptionAlgorithm.None Then 'no
                    For Each e In zip
                        e.Extract((AddForm.SelCarpDest.SelectedPath & "\" & MainWin.namefile.Replace(".zip", "")))
                    Next
                ElseIf Not EncryptionAlgorithm.None Then
                    PwdForm.ShowDialog()
                    For Each e In zip
                        e.ExtractWithPassword((AddForm.SelCarpDest.SelectedPath & "\" & MainWin.namefile.Replace(".zip", "")), PwdForm.ass)
                    Next
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "Waka waka eh eh")
        End Try
    End Sub

    Public Sub ListarZip(ByVal zipFile As String)
        Try
            MainWin.ListaExplorer.Clear()
            MainWin.ListaExplorer.BeginUpdate()
            Dim strArray As String() _
                = New String() _
                    {"name", "lastmod", "original", "ratio"}
            Dim str As String
            For Each str In strArray
                Dim header As New ColumnHeader(str.ToString)
                If ((str <> "Clnombre") AndAlso (str <> "Cltipo")) Then
                    header.TextAlign = HorizontalAlignment.Left
                End If
                MainWin.ListaExplorer.Columns.Add(header)
            Next
            If MainWin.ListaExplorer.Columns.Item(0).Text = "ColumnHeader" Then
                MainWin.ListaExplorer.Columns.Item(0).Text = "Nombre"
            End If
            If MainWin.ListaExplorer.Columns.Item(1).Text = "ColumnHeader" Then
                MainWin.ListaExplorer.Columns.Item(1).Text = "Tipo"
            End If
            If MainWin.ListaExplorer.Columns.Item(2).Text = "ColumnHeader" Then
                MainWin.ListaExplorer.Columns.Item(2).Text = "Tamaño"
            End If
            Dim num As Integer = 1
            Using file As ZipFile = Ionic.Zip.ZipFile.Read(zipFile)
                Dim entry As ZipEntry
                For Each entry In file.EntriesSorted
                    If IO.FileAttributes.Directory Then
                        MainWin.ListaExplorer.Items.Add( _
                                              New ListViewItem( _
                                                              New String() _
                                                                {entry.FileName, Replace(IO.FileAttributes.Directory, 32, "Directorio"), entry.LastModified.ToString("yyyy-MM-dd HH:mm:ss"), String.Format("{0,5:F0}%", entry.CompressionRatio)}))
                        Dim contadoritems As Integer
                        contadoritems = MainWin.ListaExplorer.Items.Count - 1
                        If entry.IsDirectory Then
                            MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 1
                        Else
                            MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 23
                        End If
                    Else
                        MainWin.ListaExplorer.Items.Add( _
                                                New ListViewItem( _
                                                            New String() _
                                                                        {entry.FileName, Replace(IO.FileAttributes.Archive, 32, "Archivo "), entry.LastModified.ToString("yyyy-MM-dd HH:mm:ss"), String.Format("{0,5:F0}%", entry.CompressionRatio)}))
                        Dim contadoritems As Integer
                        contadoritems = MainWin.ListaExplorer.Items.Count - 1
                        If entry.IsDirectory Then
                            MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 1
                        Else
                            MainWin.ListaExplorer.Items(contadoritems).ImageIndex = 23
                        End If
                    End If
                Next
            End Using
            MainWin.ListaExplorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            MainWin.ListaExplorer.EndUpdate()
        Catch exception As Exception
            MainWin.ListaExplorer.Clear()
            MainWin.ListaExplorer.EndUpdate()
            MessageBox.Show(String.Format("Ocurrio un problema durante la apertura del Archivo! [file={0}, problem={1}]", zipFile, exception.Message), "Lol!", MessageBoxButtons.OK)
        End Try
        MainWin.TotalStrip.Text = MainWin.ListaExplorer.Items.Count & " Objetos"
    End Sub

End Module
