<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PwdForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFich = New System.Windows.Forms.Label()
        Me.TxtExtractPwd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Establecer contraseña de extracion para el fichero:"
        '
        'LblFich
        '
        Me.LblFich.AutoSize = True
        Me.LblFich.Location = New System.Drawing.Point(12, 29)
        Me.LblFich.Name = "LblFich"
        Me.LblFich.Size = New System.Drawing.Size(42, 13)
        Me.LblFich.TabIndex = 1
        Me.LblFich.Text = "Fichero"
        '
        'TxtExtractPwd
        '
        Me.TxtExtractPwd.Location = New System.Drawing.Point(15, 51)
        Me.TxtExtractPwd.Name = "TxtExtractPwd"
        Me.TxtExtractPwd.Size = New System.Drawing.Size(244, 20)
        Me.TxtExtractPwd.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(44, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(160, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PwdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 115)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtExtractPwd)
        Me.Controls.Add(Me.LblFich)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PwdForm"
        Me.ShowInTaskbar = False
        Me.Text = "PwdForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblFich As System.Windows.Forms.Label
    Friend WithEvents TxtExtractPwd As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
