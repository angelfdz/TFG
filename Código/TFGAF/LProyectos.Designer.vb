<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LProyectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LProyectos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVProy = New System.Windows.Forms.DataGridView()
        Me.IdPry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlNoProyectos = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButCrearNProyecto = New System.Windows.Forms.Button()
        CType(Me.DGVProy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoProyectos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de proyectos en los que participa. Seleccione uno de ellos:"
        '
        'DGVProy
        '
        Me.DGVProy.AllowUserToAddRows = False
        Me.DGVProy.AllowUserToDeleteRows = False
        Me.DGVProy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProy.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVProy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVProy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPry, Me.NombrePry, Me.Column2, Me.Column1})
        Me.DGVProy.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVProy.Location = New System.Drawing.Point(12, 63)
        Me.DGVProy.MultiSelect = False
        Me.DGVProy.Name = "DGVProy"
        Me.DGVProy.ReadOnly = True
        Me.DGVProy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProy.Size = New System.Drawing.Size(548, 336)
        Me.DGVProy.TabIndex = 1
        '
        'IdPry
        '
        Me.IdPry.HeaderText = "IdProyecto"
        Me.IdPry.Name = "IdPry"
        Me.IdPry.ReadOnly = True
        Me.IdPry.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdPry.Visible = False
        '
        'NombrePry
        '
        Me.NombrePry.FillWeight = 149.2386!
        Me.NombrePry.HeaderText = "Nombre Proyecto"
        Me.NombrePry.Name = "NombrePry"
        Me.NombrePry.ReadOnly = True
        Me.NombrePry.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        Me.Column2.HeaderText = "IdRol"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Visible = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 50.76142!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'pnlNoProyectos
        '
        Me.pnlNoProyectos.Controls.Add(Me.Label2)
        Me.pnlNoProyectos.Location = New System.Drawing.Point(38, 132)
        Me.pnlNoProyectos.Name = "pnlNoProyectos"
        Me.pnlNoProyectos.Size = New System.Drawing.Size(457, 177)
        Me.pnlNoProyectos.TabIndex = 2
        Me.pnlNoProyectos.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 80)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No participa en proyectos o están todos terminados o cancelados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pulse en e" & _
    "l botón si quiere crear un nuevo proyecto"
        '
        'ButCrearNProyecto
        '
        Me.ButCrearNProyecto.Location = New System.Drawing.Point(12, 405)
        Me.ButCrearNProyecto.Name = "ButCrearNProyecto"
        Me.ButCrearNProyecto.Size = New System.Drawing.Size(548, 25)
        Me.ButCrearNProyecto.TabIndex = 1
        Me.ButCrearNProyecto.Text = "Crear Nuevo Proyecto"
        Me.ButCrearNProyecto.UseVisualStyleBackColor = True
        '
        'LProyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 437)
        Me.Controls.Add(Me.ButCrearNProyecto)
        Me.Controls.Add(Me.pnlNoProyectos)
        Me.Controls.Add(Me.DGVProy)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LProyectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SCRUM Wizard"
        CType(Me.DGVProy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoProyectos.ResumeLayout(False)
        Me.pnlNoProyectos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVProy As System.Windows.Forms.DataGridView
    Friend WithEvents IdPry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombrePry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlNoProyectos As System.Windows.Forms.Panel
    Friend WithEvents ButCrearNProyecto As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
