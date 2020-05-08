<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_inicio))
        Me.BarraMenu = New System.Windows.Forms.MenuStrip()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaIndividualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtileriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaIndividualToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaIndividualToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreNosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarraMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.UtileriaToolStripMenuItem, Me.PagosToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(685, 24)
        Me.BarraMenu.TabIndex = 0
        Me.BarraMenu.Text = "Menu"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem, Me.ReporteToolStripMenuItem})
        Me.ClienteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaIndividualToolStripMenuItem, Me.ConsultaGeneralToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'ConsultaIndividualToolStripMenuItem
        '
        Me.ConsultaIndividualToolStripMenuItem.Name = "ConsultaIndividualToolStripMenuItem"
        Me.ConsultaIndividualToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaIndividualToolStripMenuItem.Text = "Consulta individual"
        '
        'ConsultaGeneralToolStripMenuItem
        '
        Me.ConsultaGeneralToolStripMenuItem.Name = "ConsultaGeneralToolStripMenuItem"
        Me.ConsultaGeneralToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaGeneralToolStripMenuItem.Text = "Consulta General"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'UtileriaToolStripMenuItem
        '
        Me.UtileriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem1, Me.ReporteToolStripMenuItem1})
        Me.UtileriaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.UtileriaToolStripMenuItem.Name = "UtileriaToolStripMenuItem"
        Me.UtileriaToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.UtileriaToolStripMenuItem.Text = "Utileria"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaIndividualToolStripMenuItem1, Me.ConsultaGeneralToolStripMenuItem1})
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ConsultaToolStripMenuItem1.Text = "Consulta"
        '
        'ConsultaIndividualToolStripMenuItem1
        '
        Me.ConsultaIndividualToolStripMenuItem1.Name = "ConsultaIndividualToolStripMenuItem1"
        Me.ConsultaIndividualToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaIndividualToolStripMenuItem1.Text = "Consulta Individual"
        '
        'ConsultaGeneralToolStripMenuItem1
        '
        Me.ConsultaGeneralToolStripMenuItem1.Name = "ConsultaGeneralToolStripMenuItem1"
        Me.ConsultaGeneralToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaGeneralToolStripMenuItem1.Text = "Consulta General"
        '
        'ReporteToolStripMenuItem1
        '
        Me.ReporteToolStripMenuItem1.Name = "ReporteToolStripMenuItem1"
        Me.ReporteToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ReporteToolStripMenuItem1.Text = "Reporte"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem2, Me.ReporteToolStripMenuItem2})
        Me.PagosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'ConsultaToolStripMenuItem2
        '
        Me.ConsultaToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaIndividualToolStripMenuItem2, Me.ConsultaGeneralToolStripMenuItem2})
        Me.ConsultaToolStripMenuItem2.Name = "ConsultaToolStripMenuItem2"
        Me.ConsultaToolStripMenuItem2.Size = New System.Drawing.Size(121, 22)
        Me.ConsultaToolStripMenuItem2.Text = "Consulta"
        '
        'ConsultaIndividualToolStripMenuItem2
        '
        Me.ConsultaIndividualToolStripMenuItem2.Name = "ConsultaIndividualToolStripMenuItem2"
        Me.ConsultaIndividualToolStripMenuItem2.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaIndividualToolStripMenuItem2.Text = "Consulta Individual"
        '
        'ConsultaGeneralToolStripMenuItem2
        '
        Me.ConsultaGeneralToolStripMenuItem2.Name = "ConsultaGeneralToolStripMenuItem2"
        Me.ConsultaGeneralToolStripMenuItem2.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaGeneralToolStripMenuItem2.Text = "Consulta General"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem, Me.SobreNosotrosToolStripMenuItem})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'SobreNosotrosToolStripMenuItem
        '
        Me.SobreNosotrosToolStripMenuItem.Name = "SobreNosotrosToolStripMenuItem"
        Me.SobreNosotrosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SobreNosotrosToolStripMenuItem.Text = "Sobre nosotros"
        '
        'ReporteToolStripMenuItem2
        '
        Me.ReporteToolStripMenuItem2.Name = "ReporteToolStripMenuItem2"
        Me.ReporteToolStripMenuItem2.Size = New System.Drawing.Size(121, 22)
        Me.ReporteToolStripMenuItem2.Text = "Reporte"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(337, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 180)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(131, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frm_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(685, 292)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BarraMenu)
        Me.MainMenuStrip = Me.BarraMenu
        Me.Name = "frm_inicio"
        Me.Text = "GYM ADMIN"
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtileriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaIndividualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaIndividualToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaGeneralToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaIndividualToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaGeneralToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreNosotrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
