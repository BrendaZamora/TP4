<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Productos = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ArticulosButton = New System.Windows.Forms.ToolStripButton()
        Me.RubrosButton = New System.Windows.Forms.ToolStripButton()
        Me.SalirButton = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Productos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 86)
        Me.Panel1.TabIndex = 0
        '
        'Productos
        '
        Me.Productos.AutoSize = True
        Me.Productos.Font = New System.Drawing.Font("Georgia", 27.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productos.Location = New System.Drawing.Point(162, 25)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(185, 43)
        Me.Productos.TabIndex = 1
        Me.Productos.Text = "Productos"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosButton, Me.RubrosButton, Me.SalirButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 86)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(582, 62)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ArticulosButton
        '
        Me.ArticulosButton.BackColor = System.Drawing.Color.Olive
        Me.ArticulosButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ArticulosButton.ForeColor = System.Drawing.Color.White
        Me.ArticulosButton.Image = CType(resources.GetObject("ArticulosButton.Image"), System.Drawing.Image)
        Me.ArticulosButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ArticulosButton.Name = "ArticulosButton"
        Me.ArticulosButton.Size = New System.Drawing.Size(58, 59)
        Me.ArticulosButton.Text = "Articulos"
        Me.ArticulosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ArticulosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RubrosButton
        '
        Me.RubrosButton.BackColor = System.Drawing.Color.Olive
        Me.RubrosButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RubrosButton.ForeColor = System.Drawing.Color.White
        Me.RubrosButton.Image = CType(resources.GetObject("RubrosButton.Image"), System.Drawing.Image)
        Me.RubrosButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RubrosButton.Name = "RubrosButton"
        Me.RubrosButton.Size = New System.Drawing.Size(48, 59)
        Me.RubrosButton.Text = "Rubros"
        Me.RubrosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RubrosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalirButton
        '
        Me.SalirButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirButton.ForeColor = System.Drawing.Color.White
        Me.SalirButton.Image = Global.WindowsApplication1.My.Resources.Resources.Salir
        Me.SalirButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(44, 59)
        Me.SalirButton.Text = "Salir"
        Me.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(582, 179)
        Me.DataGridView1.TabIndex = 2
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 327)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Productos As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ArticulosButton As ToolStripButton
    Friend WithEvents RubrosButton As ToolStripButton
    Friend WithEvents SalirButton As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
End Class
