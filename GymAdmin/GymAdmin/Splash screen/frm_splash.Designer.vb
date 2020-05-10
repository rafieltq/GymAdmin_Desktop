<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splash
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Fondo_barra = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Barra = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Unispace", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GYM ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Unispace", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(307, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "5.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Unispace", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(39, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Administra tu gimnasio de manera eficiente."
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Barra, Me.Fondo_barra})
        Me.ShapeContainer1.Size = New System.Drawing.Size(564, 217)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'Fondo_barra
        '
        Me.Fondo_barra.BackColor = System.Drawing.Color.White
        Me.Fondo_barra.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Fondo_barra.BorderColor = System.Drawing.Color.White
        Me.Fondo_barra.FillColor = System.Drawing.Color.White
        Me.Fondo_barra.Location = New System.Drawing.Point(0, 194)
        Me.Fondo_barra.Name = "Fondo_barra"
        Me.Fondo_barra.Size = New System.Drawing.Size(563, 23)
        '
        'Barra
        '
        Me.Barra.BackColor = System.Drawing.Color.Black
        Me.Barra.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Barra.BorderColor = System.Drawing.Color.Black
        Me.Barra.FillColor = System.Drawing.Color.White
        Me.Barra.Location = New System.Drawing.Point(0, 194)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(10, 23)
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        Me.Tiempo.Interval = 1
        '
        'frm_splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(564, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_splash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Barra As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Fondo_barra As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Tiempo As System.Windows.Forms.Timer
End Class
