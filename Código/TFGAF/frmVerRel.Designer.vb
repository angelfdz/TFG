<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerRel
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
        Me.pnlVerRel = New System.Windows.Forms.Panel()
        Me.butRelYGenSalir = New System.Windows.Forms.Button()
        Me.DGVRelYaGen = New System.Windows.Forms.DataGridView()
        Me.NRelease = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NHistoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlVerRel.SuspendLayout()
        CType(Me.DGVRelYaGen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlVerRel
        '
        Me.pnlVerRel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlVerRel.Controls.Add(Me.butRelYGenSalir)
        Me.pnlVerRel.Controls.Add(Me.DGVRelYaGen)
        Me.pnlVerRel.Controls.Add(Me.Label1)
        Me.pnlVerRel.Location = New System.Drawing.Point(12, 12)
        Me.pnlVerRel.Name = "pnlVerRel"
        Me.pnlVerRel.Size = New System.Drawing.Size(569, 375)
        Me.pnlVerRel.TabIndex = 0
        '
        'butRelYGenSalir
        '
        Me.butRelYGenSalir.Location = New System.Drawing.Point(440, 338)
        Me.butRelYGenSalir.Name = "butRelYGenSalir"
        Me.butRelYGenSalir.Size = New System.Drawing.Size(119, 23)
        Me.butRelYGenSalir.TabIndex = 2
        Me.butRelYGenSalir.Text = "Salir"
        Me.butRelYGenSalir.UseVisualStyleBackColor = True
        '
        'DGVRelYaGen
        '
        Me.DGVRelYaGen.AllowUserToAddRows = False
        Me.DGVRelYaGen.AllowUserToDeleteRows = False
        Me.DGVRelYaGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRelYaGen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRelease, Me.NHistoria})
        Me.DGVRelYaGen.Location = New System.Drawing.Point(12, 38)
        Me.DGVRelYaGen.Name = "DGVRelYaGen"
        Me.DGVRelYaGen.ReadOnly = True
        Me.DGVRelYaGen.Size = New System.Drawing.Size(547, 293)
        Me.DGVRelYaGen.TabIndex = 1
        '
        'NRelease
        '
        Me.NRelease.HeaderText = "Nombre Release"
        Me.NRelease.Name = "NRelease"
        Me.NRelease.ReadOnly = True
        Me.NRelease.Width = 250
        '
        'NHistoria
        '
        Me.NHistoria.HeaderText = "Nombre Historia"
        Me.NHistoria.Name = "NHistoria"
        Me.NHistoria.ReadOnly = True
        Me.NHistoria.Width = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Release ya generadas en el proyecto"
        '
        'frmVerRel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 399)
        Me.Controls.Add(Me.pnlVerRel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerRel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SCRUM Wizard"
        Me.pnlVerRel.ResumeLayout(False)
        Me.pnlVerRel.PerformLayout()
        CType(Me.DGVRelYaGen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlVerRel As System.Windows.Forms.Panel
    Friend WithEvents butRelYGenSalir As System.Windows.Forms.Button
    Friend WithEvents DGVRelYaGen As System.Windows.Forms.DataGridView
    Friend WithEvents NRelease As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NHistoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
