Imports System.Xml

Module MdXml

    Public Sub CrearFuncion()
        Dim XmlTexto As XmlTextWriter = New XmlTextWriter("Config.xml", System.Text.Encoding.UTF8)
        XmlTexto.Formatting = System.Xml.Formatting.Indented
        XmlTexto.WriteStartDocument(False)
        XmlTexto.WriteStartElement("Puke")
        XmlTexto.WriteStartElement("Configuracion")

        XmlTexto.WriteStartElement("Ruta")
        XmlTexto.WriteString(MainWin.ComboRuta.Text)
        XmlTexto.WriteEndElement()

        XmlTexto.WriteStartElement("Alto")
        XmlTexto.WriteString(MainWin.Size.Height)
        XmlTexto.WriteEndElement()

        XmlTexto.WriteStartElement("Ancho")
        XmlTexto.WriteString(MainWin.Size.Width)
        XmlTexto.WriteEndElement()

        XmlTexto.WriteStartElement("Vertical")
        XmlTexto.WriteString(MainWin.DesktopLocation.Y)
        XmlTexto.WriteEndElement()

        XmlTexto.WriteStartElement("Horizontal")
        XmlTexto.WriteString(MainWin.DesktopLocation.X)
        XmlTexto.WriteEndElement()

        XmlTexto.WriteEndElement()

        XmlTexto.Flush()
        XmlTexto.Close()
    End Sub

    Public Sub CrearXml()
        If Not System.IO.File.Exists(Application.StartupPath & "\Config.xml") Then
            CrearFuncion()
        Else
            CrearFuncion()
        End If
    End Sub

    Public Sub LeerXml()
        If Not System.IO.File.Exists(Application.StartupPath & "\Config.xml") Then
            MsgBox("El fichero de configuracion 'Config.xml' no se encuentra," & vbNewLine & "es posible que sea la primera vez que se ejecute la aplicacion." & vbNewLine & "No se preocupe el archivo se creara automaticamente.",  MsgBoxStyle.Information)
            CrearXml()
        Else
            Dim reader As XmlTextReader = New XmlTextReader(Application.StartupPath & "\Config.xml")
            reader.ReadStartElement("Puke")
            reader.ReadStartElement("Configuracion")
            reader.ReadStartElement("Ruta")
            MainWin.ComboRuta.Text = reader.ReadString
            reader.ReadEndElement()
            reader.ReadStartElement("Alto")
            MainWin.Height = reader.ReadString
            reader.ReadEndElement()
            reader.ReadStartElement("Ancho")
            MainWin.Width = reader.ReadString
            reader.ReadEndElement()
            reader.Close()
        End If
    End Sub

End Module
