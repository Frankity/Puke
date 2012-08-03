<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenombrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiarAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropiedadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TotalStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Clnombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cltipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cltamaño = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Clmodificado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListaExplorer = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgregarArchivosAlFicheroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraerEnUnaCarpetaEspecificaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerElArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarElArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CrearCarpetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenombrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropiedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ComboRuta = New System.Windows.Forms.ComboBox()
        Me.BtnRef = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.VistaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdicionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(1, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(878, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.AbrirToolStripMenuItem1, Me.RenombrarToolStripMenuItem1, Me.ToolStripMenuItem4, Me.CopiarAToolStripMenuItem, Me.MoverAToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.ToolStripMenuItem5, Me.PropiedadesToolStripMenuItem1, Me.ComenToolStripMenuItem, Me.CrearArchivoToolStripMenuItem, Me.ToolStripMenuItem6, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.AbrirToolStripMenuItem.Text = "Puke"
        Me.AbrirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbrirToolStripMenuItem1
        '
        Me.AbrirToolStripMenuItem1.Name = "AbrirToolStripMenuItem1"
        Me.AbrirToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.AbrirToolStripMenuItem1.Size = New System.Drawing.Size(141, 20)
        Me.AbrirToolStripMenuItem1.Text = "Abrir"
        '
        'RenombrarToolStripMenuItem1
        '
        Me.RenombrarToolStripMenuItem1.Name = "RenombrarToolStripMenuItem1"
        Me.RenombrarToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.RenombrarToolStripMenuItem1.Size = New System.Drawing.Size(141, 20)
        Me.RenombrarToolStripMenuItem1.Text = "Renombrar"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(138, 6)
        '
        'CopiarAToolStripMenuItem
        '
        Me.CopiarAToolStripMenuItem.Name = "CopiarAToolStripMenuItem"
        Me.CopiarAToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.CopiarAToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.CopiarAToolStripMenuItem.Text = "Copiar a..."
        '
        'MoverAToolStripMenuItem
        '
        Me.MoverAToolStripMenuItem.Name = "MoverAToolStripMenuItem"
        Me.MoverAToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.MoverAToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.MoverAToolStripMenuItem.Text = "Mover a..."
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(138, 6)
        '
        'PropiedadesToolStripMenuItem1
        '
        Me.PropiedadesToolStripMenuItem1.Name = "PropiedadesToolStripMenuItem1"
        Me.PropiedadesToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.PropiedadesToolStripMenuItem1.Size = New System.Drawing.Size(141, 20)
        Me.PropiedadesToolStripMenuItem1.Text = "Propiedades"
        '
        'ComenToolStripMenuItem
        '
        Me.ComenToolStripMenuItem.Name = "ComenToolStripMenuItem"
        Me.ComenToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.ComenToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.ComenToolStripMenuItem.Text = "Crear carpeta"
        '
        'CrearArchivoToolStripMenuItem
        '
        Me.CrearArchivoToolStripMenuItem.Name = "CrearArchivoToolStripMenuItem"
        Me.CrearArchivoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.CrearArchivoToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.CrearArchivoToolStripMenuItem.Text = "Crear archivo"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(138, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EdicionToolStripMenuItem
        '
        Me.EdicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem})
        Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.EdicionToolStripMenuItem.Text = "&Edicion"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(878, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TotalStrip
        '
        Me.TotalStrip.Name = "TotalStrip"
        Me.TotalStrip.Size = New System.Drawing.Size(47, 17)
        Me.TotalStrip.Text = "<valor>"
        '
        'Clnombre
        '
        Me.Clnombre.Text = "Nombre"
        Me.Clnombre.Width = 238
        '
        'Cltipo
        '
        Me.Cltipo.Text = "Tipo"
        Me.Cltipo.Width = 147
        '
        'Cltamaño
        '
        Me.Cltamaño.Text = "Tamaño"
        Me.Cltamaño.Width = 171
        '
        'Clmodificado
        '
        Me.Clmodificado.Text = "Fecha de Modificacion"
        Me.Clmodificado.Width = 232
        '
        'ListaExplorer
        '
        Me.ListaExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListaExplorer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Clnombre, Me.Cltipo, Me.Cltamaño, Me.Clmodificado})
        Me.ListaExplorer.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListaExplorer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaExplorer.HideSelection = False
        Me.ListaExplorer.LabelEdit = True
        Me.ListaExplorer.Location = New System.Drawing.Point(0, 0)
        Me.ListaExplorer.Name = "ListaExplorer"
        Me.ListaExplorer.ShowItemToolTips = True
        Me.ListaExplorer.Size = New System.Drawing.Size(878, 444)
        Me.ListaExplorer.SmallImageList = Me.ImageList1
        Me.ListaExplorer.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ListaExplorer, "Listado de Archivos")
        Me.ListaExplorer.UseCompatibleStateImageBehavior = False
        Me.ListaExplorer.View = System.Windows.Forms.View.Details
        Me.ListaExplorer.VirtualListSize = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarTodoToolStripMenuItem, Me.ToolStripMenuItem1, Me.AgregarArchivosAlFicheroToolStripMenuItem, Me.ExtraerEnUnaCarpetaEspecificaToolStripMenuItem, Me.VerElArchivoToolStripMenuItem, Me.EliminarElArchivoToolStripMenuItem, Me.ToolStripMenuItem2, Me.CrearCarpetaToolStripMenuItem, Me.RenombrarToolStripMenuItem, Me.ToolStripMenuItem3, Me.PropiedadesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(246, 182)
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.SeleccionarTodoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(245, 20)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(242, 6)
        '
        'AgregarArchivosAlFicheroToolStripMenuItem
        '
        Me.AgregarArchivosAlFicheroToolStripMenuItem.Name = "AgregarArchivosAlFicheroToolStripMenuItem"
        Me.AgregarArchivosAlFicheroToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.AgregarArchivosAlFicheroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AgregarArchivosAlFicheroToolStripMenuItem.Size = New System.Drawing.Size(245, 20)
        Me.AgregarArchivosAlFicheroToolStripMenuItem.Text = "Agregar archivos al fichero"
        '
        'ExtraerEnUnaCarpetaEspecificaToolStripMenuItem
        '
        Me.ExtraerEnUnaCarpetaEspecificaToolStripMenuItem.Name = "ExtraerEnUnaCarpetaEspecificaToolStripMenuItem"
        Me.ExtraerEnUnaCarpetaEspecificaToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.ExtraerEnUnaCarpetaEspecificaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExtraerEnUnaCarpetaEspecificaToolStripMenuItem.Size = New System.Drawing.Size(245, 20)
        Me.ExtraerEnUnaCarpetaEspecificaToolStripMenuItem.Text = "Extraer en una carpeta especifica"
        '
        'VerElArchivoToolStripMenuItem
        '
        Me.VerElArchivoToolStripMenuItem.Name = "VerElArchivoToolStripMenuItem"
        Me.VerElArchivoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.VerElArchivoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VerElArchivoToolStripMenuItem.Size = New System.Drawing.Size(245, 20)
        Me.VerElArchivoToolStripMenuItem.Text = "Ver el archivo"
        '
        'EliminarElArchivoToolStripMenuItem
        '
        Me.EliminarElArchivoToolStripMenuItem.Name = "EliminarElArchivoToolStripMenuItem"
        Me.EliminarElArchivoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.EliminarElArchivoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.EliminarElArchivoToolStripMenuItem.Size = New System.Drawing.Size(245, 20)
        Me.EliminarElArchivoToolStripMenuItem.Text = "Eliminar el archivo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(242, 6)
        '
        'CrearCarpetaToolStripMenuItem
        '
        Me.CrearCarpetaToolStripMenuItem.Name = "CrearCarpetaToolStripMenuItem"
        Me.CrearCarpetaToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.CrearCarpetaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.CrearCarpetaToolStripMenuItem.Size = New System.Drawing.Size(245, 20)
        Me.CrearCarpetaToolStripMenuItem.Text = "Crear carpeta"
        '
        'RenombrarToolStripMenuItem
        '
        Me.RenombrarToolStripMenuItem.Name = "RenombrarToolStripMenuItem"
        Me.RenombrarToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.RenombrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RenombrarToolStripMenuItem.Size = New System.Drawing.Size(245, 20)
        Me.RenombrarToolStripMenuItem.Text = "Renombrar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(242, 6)
        '
        'PropiedadesToolStripMenuItem
        '
        Me.PropiedadesToolStripMenuItem.Name = "PropiedadesToolStripMenuItem"
        Me.PropiedadesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.PropiedadesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.PropiedadesToolStripMenuItem.Size = New System.Drawing.Size(245, 20)
        Me.PropiedadesToolStripMenuItem.Text = "Propiedades"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "file_extension_png.png")
        Me.ImageList1.Images.SetKeyName(1, "folder.png")
        Me.ImageList1.Images.SetKeyName(2, "file_extension_torrent.png")
        Me.ImageList1.Images.SetKeyName(3, "file_extension_pdf.png")
        Me.ImageList1.Images.SetKeyName(4, "file_extension_mp4.png")
        Me.ImageList1.Images.SetKeyName(5, "file_extension_flv.png")
        Me.ImageList1.Images.SetKeyName(6, "file_extension_3gp.png")
        Me.ImageList1.Images.SetKeyName(7, "file_extension_xls.png")
        Me.ImageList1.Images.SetKeyName(8, "file_extension_dll.png")
        Me.ImageList1.Images.SetKeyName(9, "file_extension_rar.png")
        Me.ImageList1.Images.SetKeyName(10, "file_extension_vob.png")
        Me.ImageList1.Images.SetKeyName(11, "file_extension_doc.png")
        Me.ImageList1.Images.SetKeyName(12, "file_extension_pps.png")
        Me.ImageList1.Images.SetKeyName(13, "file_extension_bin.png")
        Me.ImageList1.Images.SetKeyName(14, "file_extension_m4a.png")
        Me.ImageList1.Images.SetKeyName(15, "file_extension_tmp.png")
        Me.ImageList1.Images.SetKeyName(16, "file_extension_xpi.png")
        Me.ImageList1.Images.SetKeyName(17, "file_extension_bup.png")
        Me.ImageList1.Images.SetKeyName(18, "file_extension_wmv.png")
        Me.ImageList1.Images.SetKeyName(19, "file_extension_thm.png")
        Me.ImageList1.Images.SetKeyName(20, "file_extension_dat.png")
        Me.ImageList1.Images.SetKeyName(21, "file_extension_zip.png")
        Me.ImageList1.Images.SetKeyName(22, "file_extension_jpg.png")
        Me.ImageList1.Images.SetKeyName(23, "file_extension_exe.png")
        Me.ImageList1.Images.SetKeyName(24, "file_extension_mpg.png")
        Me.ImageList1.Images.SetKeyName(25, "file_extension_tif.png")
        Me.ImageList1.Images.SetKeyName(26, "file_extension_wav.png")
        Me.ImageList1.Images.SetKeyName(27, "file_extension_mov.png")
        Me.ImageList1.Images.SetKeyName(28, "file_extension_psd.png")
        Me.ImageList1.Images.SetKeyName(29, "file_extension_wma.png")
        Me.ImageList1.Images.SetKeyName(30, "file_extension_sitx.png")
        Me.ImageList1.Images.SetKeyName(31, "file_extension_sit.png")
        Me.ImageList1.Images.SetKeyName(32, "file_extension_eps.png")
        Me.ImageList1.Images.SetKeyName(33, "file_extension_cdr.png")
        Me.ImageList1.Images.SetKeyName(34, "file_extension_ai.png")
        Me.ImageList1.Images.SetKeyName(35, "file_extension_txt.png")
        Me.ImageList1.Images.SetKeyName(36, "file_extension_rmvb.png")
        Me.ImageList1.Images.SetKeyName(37, "file_extension_bmp.png")
        Me.ImageList1.Images.SetKeyName(38, "file_extension_aif.png")
        Me.ImageList1.Images.SetKeyName(39, "file_extension_pub.png")
        Me.ImageList1.Images.SetKeyName(40, "file_extension_dwg.png")
        Me.ImageList1.Images.SetKeyName(41, "file_extension_gif.png")
        Me.ImageList1.Images.SetKeyName(42, "file_extension_qbb.png")
        Me.ImageList1.Images.SetKeyName(43, "file_extension_mpeg.png")
        Me.ImageList1.Images.SetKeyName(44, "file_extension_swf.png")
        Me.ImageList1.Images.SetKeyName(45, "file_extension_asf.png")
        Me.ImageList1.Images.SetKeyName(46, "file_extension_indd.png")
        Me.ImageList1.Images.SetKeyName(47, "file_extension_rm.png")
        Me.ImageList1.Images.SetKeyName(48, "file_extension_mdb.png")
        Me.ImageList1.Images.SetKeyName(49, "file_extension_chm.png")
        Me.ImageList1.Images.SetKeyName(50, "file_extension_jar.png")
        Me.ImageList1.Images.SetKeyName(51, "file_extension_htm.png")
        Me.ImageList1.Images.SetKeyName(52, "file_extension_dvf.png")
        Me.ImageList1.Images.SetKeyName(53, "file_extension_dss.png")
        Me.ImageList1.Images.SetKeyName(54, "file_extension_dmg.png")
        Me.ImageList1.Images.SetKeyName(55, "file_extension_iso.png")
        Me.ImageList1.Images.SetKeyName(56, "file_extension_cda.png")
        Me.ImageList1.Images.SetKeyName(57, "file_extension_m4b.png")
        Me.ImageList1.Images.SetKeyName(58, "file_extension_7z.png")
        Me.ImageList1.Images.SetKeyName(59, "file_extension_gz.png")
        Me.ImageList1.Images.SetKeyName(60, "file_extension_tgz.png")
        Me.ImageList1.Images.SetKeyName(61, "file_extension_fla.png")
        Me.ImageList1.Images.SetKeyName(62, "file_extension_qxd.png")
        Me.ImageList1.Images.SetKeyName(63, "file_extension_rtf.png")
        Me.ImageList1.Images.SetKeyName(64, "file_extension_aiff.png")
        Me.ImageList1.Images.SetKeyName(65, "file_extension_msi.png")
        Me.ImageList1.Images.SetKeyName(66, "file_extension_jpeg.png")
        Me.ImageList1.Images.SetKeyName(67, "file_extension_cdl.png")
        Me.ImageList1.Images.SetKeyName(68, "file_extension_ace.png")
        Me.ImageList1.Images.SetKeyName(69, "file_extension_m4p.png")
        Me.ImageList1.Images.SetKeyName(70, "file_extension_divx.png")
        Me.ImageList1.Images.SetKeyName(71, "file_extension_html.png")
        Me.ImageList1.Images.SetKeyName(72, "file_extension_pst.png")
        Me.ImageList1.Images.SetKeyName(73, "file_extension_cab.png")
        Me.ImageList1.Images.SetKeyName(74, "file_extension_ttf.png")
        Me.ImageList1.Images.SetKeyName(75, "file_extension_hqx.png")
        Me.ImageList1.Images.SetKeyName(76, "file_extension_qbw.png")
        Me.ImageList1.Images.SetKeyName(77, "file_extension_sea.png")
        Me.ImageList1.Images.SetKeyName(78, "file_extension_ptb.png")
        Me.ImageList1.Images.SetKeyName(79, "file_extension_mswmm.png")
        Me.ImageList1.Images.SetKeyName(80, "file_extension_ifo.png")
        Me.ImageList1.Images.SetKeyName(81, "file_extension_log.png")
        Me.ImageList1.Images.SetKeyName(82, "file_extension_mcd.png")
        Me.ImageList1.Images.SetKeyName(83, "file_extension_ss.png")
        Me.ImageList1.Images.SetKeyName(84, "file_extension_m4v.png")
        Me.ImageList1.Images.SetKeyName(85, "file_extension_eml.png")
        Me.ImageList1.Images.SetKeyName(86, "file_extension_mid.png")
        Me.ImageList1.Images.SetKeyName(87, "file_extension_ogg.png")
        Me.ImageList1.Images.SetKeyName(88, "file_extension_ram.png")
        Me.ImageList1.Images.SetKeyName(89, "file_extension_lnk.png")
        Me.ImageList1.Images.SetKeyName(90, "file_extension_ses.png")
        Me.ImageList1.Images.SetKeyName(91, "file_extension_mp2.png")
        Me.ImageList1.Images.SetKeyName(92, "file_extension_vcd.png")
        Me.ImageList1.Images.SetKeyName(93, "file_extension_bat.png")
        Me.ImageList1.Images.SetKeyName(94, "file_extension_asx.png")
        Me.ImageList1.Images.SetKeyName(95, "file_extension_ps.png")
        Me.ImageList1.Images.SetKeyName(96, "file_extension_cbr.png")
        Me.ImageList1.Images.SetKeyName(97, "file_extension_amr.png")
        Me.ImageList1.Images.SetKeyName(98, "file_extension_wps.png")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboRuta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnRef)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnBack)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Panel1MinSize = 65
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListaExplorer)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(878, 513)
        Me.SplitContainer1.SplitterDistance = 65
        Me.SplitContainer1.TabIndex = 5
        '
        'ComboRuta
        '
        Me.ComboRuta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.ComboRuta.FormattingEnabled = True
        Me.ComboRuta.Location = New System.Drawing.Point(60, 43)
        Me.ComboRuta.Name = "ComboRuta"
        Me.ComboRuta.Size = New System.Drawing.Size(2916, 21)
        Me.ComboRuta.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ComboRuta, "Url de directorio")
        '
        'BtnRef
        '
        Me.BtnRef.BackgroundImage = CType(resources.GetObject("BtnRef.BackgroundImage"), System.Drawing.Image)
        Me.BtnRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRef.Location = New System.Drawing.Point(33, 42)
        Me.BtnRef.Name = "BtnRef"
        Me.BtnRef.Size = New System.Drawing.Size(24, 23)
        Me.BtnRef.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BtnRef, "Recargar")
        Me.BtnRef.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBack.Location = New System.Drawing.Point(5, 42)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(24, 23)
        Me.BtnBack.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.BtnBack, "Atras")
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowItemReorder = True
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.VistaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.MaximumSize = New System.Drawing.Size(0, 50)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(878, 41)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(36, 38)
        Me.NewToolStripButton.Text = "&New"
        Me.NewToolStripButton.ToolTipText = "Nuevo"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(36, 38)
        Me.OpenToolStripButton.Text = "&Open"
        Me.OpenToolStripButton.ToolTipText = "Abrir"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(36, 38)
        Me.SaveToolStripButton.Text = "&Save"
        Me.SaveToolStripButton.ToolTipText = "Guardar"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(36, 38)
        Me.PrintToolStripButton.Text = "&Print"
        Me.PrintToolStripButton.ToolTipText = "Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 41)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(36, 38)
        Me.CutToolStripButton.Text = "C&ut"
        Me.CutToolStripButton.ToolTipText = "Cortar"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(36, 38)
        Me.CopyToolStripButton.Text = "&Copy"
        Me.CopyToolStripButton.ToolTipText = "Copiar"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(36, 38)
        Me.PasteToolStripButton.Text = "&Paste"
        Me.PasteToolStripButton.ToolTipText = "Pegar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 41)
        '
        'VistaToolStripButton
        '
        Me.VistaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VistaToolStripButton.Image = CType(resources.GetObject("VistaToolStripButton.Image"), System.Drawing.Image)
        Me.VistaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VistaToolStripButton.Name = "VistaToolStripButton"
        Me.VistaToolStripButton.Size = New System.Drawing.Size(36, 38)
        Me.VistaToolStripButton.Text = "He&lp"
        Me.VistaToolStripButton.ToolTipText = "Cambiar vista"
        '
        'MainWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 559)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWin"
        Me.Text = "Puke"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Clnombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cltipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cltamaño As System.Windows.Forms.ColumnHeader
    Friend WithEvents Clmodificado As System.Windows.Forms.ColumnHeader
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VistaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ComboRuta As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnRef As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PropiedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AgregarArchivosAlFicheroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraerEnUnaCarpetaEspecificaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerElArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarElArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CrearCarpetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenombrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListaExplorer As System.Windows.Forms.ListView
    Friend WithEvents AbrirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RenombrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoverAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropiedadesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalStrip As System.Windows.Forms.ToolStripStatusLabel

End Class
