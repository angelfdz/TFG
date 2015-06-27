<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReleases
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
        Me.pnlProyecto = New System.Windows.Forms.Panel()
        Me.butQuitar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVHRelease = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.butAnadir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVHCandidatas = New System.Windows.Forms.DataGridView()
        Me.IdH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Historia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.butGuardar = New System.Windows.Forms.Button()
        Me.butIncluir = New System.Windows.Forms.Button()
        Me.lblLiberado = New System.Windows.Forms.Label()
        Me.lblCabecera = New System.Windows.Forms.Label()
        Me.txtNRelease = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdRelease = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pnlProyecto.SuspendLayout()
        CType(Me.DGVHRelease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVHCandidatas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlProyecto
        '
        Me.pnlProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProyecto.Controls.Add(Me.butQuitar)
        Me.pnlProyecto.Controls.Add(Me.Label4)
        Me.pnlProyecto.Controls.Add(Me.DGVHRelease)
        Me.pnlProyecto.Controls.Add(Me.butAnadir)
        Me.pnlProyecto.Controls.Add(Me.Label3)
        Me.pnlProyecto.Controls.Add(Me.DGVHCandidatas)
        Me.pnlProyecto.Controls.Add(Me.butSalir)
        Me.pnlProyecto.Controls.Add(Me.butGuardar)
        Me.pnlProyecto.Controls.Add(Me.butIncluir)
        Me.pnlProyecto.Controls.Add(Me.lblLiberado)
        Me.pnlProyecto.Controls.Add(Me.lblCabecera)
        Me.pnlProyecto.Controls.Add(Me.txtNRelease)
        Me.pnlProyecto.Controls.Add(Me.Label2)
        Me.pnlProyecto.Controls.Add(Me.txtIdRelease)
        Me.pnlProyecto.Controls.Add(Me.Label1)
        Me.pnlProyecto.Controls.Add(Me.ShapeContainer1)
        Me.pnlProyecto.Location = New System.Drawing.Point(12, 12)
        Me.pnlProyecto.Name = "pnlProyecto"
        Me.pnlProyecto.Size = New System.Drawing.Size(831, 386)
        Me.pnlProyecto.TabIndex = 1
        '
        'butQuitar
        '
        Me.butQuitar.Location = New System.Drawing.Point(518, 343)
        Me.butQuitar.Name = "butQuitar"
        Me.butQuitar.Size = New System.Drawing.Size(161, 23)
        Me.butQuitar.TabIndex = 15
        Me.butQuitar.Text = "Quitar Historia de la Release"
        Me.butQuitar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(441, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Historias de la Release"
        '
        'DGVHRelease
        '
        Me.DGVHRelease.AllowUserToAddRows = False
        Me.DGVHRelease.AllowUserToDeleteRows = False
        Me.DGVHRelease.AllowUserToResizeColumns = False
        Me.DGVHRelease.AllowUserToResizeRows = False
        Me.DGVHRelease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVHRelease.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DGVHRelease.Location = New System.Drawing.Point(444, 187)
        Me.DGVHRelease.Name = "DGVHRelease"
        Me.DGVHRelease.ReadOnly = True
        Me.DGVHRelease.Size = New System.Drawing.Size(346, 150)
        Me.DGVHRelease.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdHistoria"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Historia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'butAnadir
        '
        Me.butAnadir.Location = New System.Drawing.Point(142, 342)
        Me.butAnadir.Name = "butAnadir"
        Me.butAnadir.Size = New System.Drawing.Size(161, 23)
        Me.butAnadir.TabIndex = 12
        Me.butAnadir.Text = "Añadir Historia a Release"
        Me.butAnadir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Lista de historias candidatas a ser liberadas"
        '
        'DGVHCandidatas
        '
        Me.DGVHCandidatas.AllowUserToAddRows = False
        Me.DGVHCandidatas.AllowUserToDeleteRows = False
        Me.DGVHCandidatas.AllowUserToResizeColumns = False
        Me.DGVHCandidatas.AllowUserToResizeRows = False
        Me.DGVHCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVHCandidatas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdH, Me.Historia})
        Me.DGVHCandidatas.Location = New System.Drawing.Point(68, 186)
        Me.DGVHCandidatas.Name = "DGVHCandidatas"
        Me.DGVHCandidatas.ReadOnly = True
        Me.DGVHCandidatas.Size = New System.Drawing.Size(346, 150)
        Me.DGVHCandidatas.TabIndex = 10
        '
        'IdH
        '
        Me.IdH.HeaderText = "IdHistoria"
        Me.IdH.Name = "IdH"
        Me.IdH.ReadOnly = True
        Me.IdH.Visible = False
        '
        'Historia
        '
        Me.Historia.HeaderText = "Historia"
        Me.Historia.Name = "Historia"
        Me.Historia.ReadOnly = True
        Me.Historia.Width = 300
        '
        'butSalir
        '
        Me.butSalir.Location = New System.Drawing.Point(662, 108)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(102, 23)
        Me.butSalir.TabIndex = 9
        Me.butSalir.Text = "Salir"
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'butGuardar
        '
        Me.butGuardar.Location = New System.Drawing.Point(662, 82)
        Me.butGuardar.Name = "butGuardar"
        Me.butGuardar.Size = New System.Drawing.Size(102, 23)
        Me.butGuardar.TabIndex = 8
        Me.butGuardar.Text = "Liberar"
        Me.butGuardar.UseVisualStyleBackColor = True
        '
        'butIncluir
        '
        Me.butIncluir.Location = New System.Drawing.Point(662, 55)
        Me.butIncluir.Name = "butIncluir"
        Me.butIncluir.Size = New System.Drawing.Size(102, 23)
        Me.butIncluir.TabIndex = 7
        Me.butIncluir.Text = "Incluir"
        Me.butIncluir.UseVisualStyleBackColor = True
        '
        'lblLiberado
        '
        Me.lblLiberado.AutoSize = True
        Me.lblLiberado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiberado.ForeColor = System.Drawing.Color.Red
        Me.lblLiberado.Location = New System.Drawing.Point(132, 104)
        Me.lblLiberado.Name = "lblLiberado"
        Me.lblLiberado.Size = New System.Drawing.Size(267, 15)
        Me.lblLiberado.TabIndex = 6
        Me.lblLiberado.Text = "Release PENDIENTE de liberar a cliente"
        '
        'lblCabecera
        '
        Me.lblCabecera.AutoSize = True
        Me.lblCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabecera.Location = New System.Drawing.Point(57, 19)
        Me.lblCabecera.Name = "lblCabecera"
        Me.lblCabecera.Size = New System.Drawing.Size(342, 18)
        Me.lblCabecera.TabIndex = 4
        Me.lblCabecera.Text = "Generación de la 'Release' para el proyecto:"
        '
        'txtNRelease
        '
        Me.txtNRelease.Location = New System.Drawing.Point(293, 61)
        Me.txtNRelease.Name = "txtNRelease"
        Me.txtNRelease.Size = New System.Drawing.Size(308, 20)
        Me.txtNRelease.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Release"
        '
        'txtIdRelease
        '
        Me.txtIdRelease.Location = New System.Drawing.Point(127, 61)
        Me.txtIdRelease.Name = "txtIdRelease"
        Me.txtIdRelease.Size = New System.Drawing.Size(51, 20)
        Me.txtIdRelease.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Release"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(829, 384)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 57
        Me.LineShape2.X2 = 798
        Me.LineShape2.Y1 = 139
        Me.LineShape2.Y2 = 139
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 57
        Me.LineShape1.X2 = 798
        Me.LineShape1.Y1 = 43
        Me.LineShape1.Y2 = 43
        '
        'frmReleases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 415)
        Me.Controls.Add(Me.pnlProyecto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReleases"
        Me.Text = "frmReleases"
        Me.pnlProyecto.ResumeLayout(False)
        Me.pnlProyecto.PerformLayout()
        CType(Me.DGVHRelease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVHCandidatas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlProyecto As System.Windows.Forms.Panel
    Friend WithEvents lblCabecera As System.Windows.Forms.Label
    Friend WithEvents txtNRelease As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdRelease As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblLiberado As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents butGuardar As System.Windows.Forms.Button
    Friend WithEvents butIncluir As System.Windows.Forms.Button
    Friend WithEvents DGVHCandidatas As System.Windows.Forms.DataGridView
    Friend WithEvents IdH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Historia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents butQuitar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGVHRelease As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents butAnadir As System.Windows.Forms.Button
End Class
