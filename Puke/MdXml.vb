Imports System.Xml

Module MdXml

    Public Sub CrearXml()

        Dim XmlTexto As XmlTextWriter = New XmlTextWriter("Config.xml", System.Text.Encoding.UTF8)
        XmlTexto.Formatting = System.Xml.Formatting.Indented
        XmlTexto.WriteStartDocument(False)
        XmlTexto.WriteStartElement("Configuracion")
        XmlTexto.WriteStartElement("Puke", "Valores")

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
        XmlTexto.WriteEndElement()


        XmlTexto.Flush()
        XmlTexto.Close()


    End Sub

    Public Sub LeerXml()

    End Sub

End Module
