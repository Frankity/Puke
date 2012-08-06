Imports Ionic.Zip

Module MdCompDecomp

    Public Sub Comprimir()
        Try
            Using zip As ZipFile = New ZipFile
                For i As Int16 = 0 To MainWin.ListaExplorer.SelectedIndices.Count - 1
                    If Not MainWin.ListaExplorer.SelectedItems.Item(i).Text.Contains(".") Then
                        zip.AddDirectory(MainWin.ComboRuta.Text & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text, "")
                        zip.Save(AddForm.TxtName.Text & ".puke")
                    Else
                        zip.AddFile(MainWin.ComboRuta.Text & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text, "")
                        zip.Save(AddForm.TxtName.Text & ".puke")
                    End If
                Next
            End Using
        Catch ex1 As Exception
            MsgBox(ex1.Message)
        End Try
    End Sub

    Public Sub Descomprimir()
        Try
            For i As Int16 = 0 To MainWin.ListaExplorer.SelectedIndices.Count - 1

                Using zip As ZipFile = ZipFile.Read(MainWin.ComboRuta.Text & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text)
                    Dim e As ZipEntry
                    For Each e In zip
                        e.Extract(AddForm.SelCarpDest.SelectedPath & "\" & MainWin.ListaExplorer.SelectedItems.Item(i).Text.Replace(".puke", ""))
                    Next
                End Using
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
