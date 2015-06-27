<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSB
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSB))
        Me.pnlSB = New System.Windows.Forms.Panel()
        Me.pnlHA = New System.Windows.Forms.Panel()
        Me.butSHA = New System.Windows.Forms.Button()
        Me.dgvHA = New System.Windows.Forms.DataGridView()
        Me.H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Co = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.V = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butListahAccionables = New System.Windows.Forms.Button()
        Me.butGuardarSB = New System.Windows.Forms.Button()
        Me.lblCabecera = New System.Windows.Forms.Label()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.dgvSB = New System.Windows.Forms.DataGridView()
        Me.IdH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NHistoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sprint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSB.SuspendLayout()
        Me.pnlHA.SuspendLayout()
        CType(Me.dgvHA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSB
        '
        Me.pnlSB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSB.Controls.Add(Me.pnlHA)
        Me.pnlSB.Controls.Add(Me.butListahAccionables)
        Me.pnlSB.Controls.Add(Me.butGuardarSB)
        Me.pnlSB.Controls.Add(Me.lblCabecera)
        Me.pnlSB.Controls.Add(Me.butSalir)
        Me.pnlSB.Controls.Add(Me.dgvSB)
        Me.pnlSB.Location = New System.Drawing.Point(12, 8)
        Me.pnlSB.Name = "pnlSB"
        Me.pnlSB.Size = New System.Drawing.Size(1250, 482)
        Me.pnlSB.TabIndex = 0
        '
        'pnlHA
        '
        Me.pnlHA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHA.Controls.Add(Me.butSHA)
        Me.pnlHA.Controls.Add(Me.dgvHA)
        Me.pnlHA.Controls.Add(Me.Label1)
        Me.pnlHA.Location = New System.Drawing.Point(610, 203)
        Me.pnlHA.Name = "pnlHA"
        Me.pnlHA.Size = New System.Drawing.Size(584, 261)
        Me.pnlHA.TabIndex = 9
        Me.pnlHA.Visible = False
        '
        'butSHA
        '
        Me.butSHA.Location = New System.Drawing.Point(500, 7)
        Me.butSHA.Name = "butSHA"
        Me.butSHA.Size = New System.Drawing.Size(75, 23)
        Me.butSHA.TabIndex = 2
        Me.butSHA.Text = "Salir"
        Me.butSHA.UseVisualStyleBackColor = True
        '
        'dgvHA
        '
        Me.dgvHA.AllowUserToAddRows = False
        Me.dgvHA.AllowUserToDeleteRows = False
        Me.dgvHA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvHA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.H, Me.D, Me.S, Me.P, Me.Co, Me.V})
        Me.dgvHA.Location = New System.Drawing.Point(9, 36)
        Me.dgvHA.Name = "dgvHA"
        Me.dgvHA.ReadOnly = True
        Me.dgvHA.Size = New System.Drawing.Size(566, 212)
        Me.dgvHA.TabIndex = 1
        '
        'H
        '
        Me.H.Frozen = True
        Me.H.HeaderText = "Historia"
        Me.H.Name = "H"
        Me.H.ReadOnly = True
        Me.H.Width = 200
        '
        'D
        '
        Me.D.Frozen = True
        Me.D.HeaderText = "Duración"
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Width = 70
        '
        'S
        '
        Me.S.Frozen = True
        Me.S.HeaderText = "Sprint"
        Me.S.Name = "S"
        Me.S.ReadOnly = True
        Me.S.Width = 50
        '
        'P
        '
        Me.P.Frozen = True
        Me.P.HeaderText = "Proridad"
        Me.P.Name = "P"
        Me.P.ReadOnly = True
        Me.P.Width = 50
        '
        'Co
        '
        Me.Co.Frozen = True
        Me.Co.HeaderText = "Coste"
        Me.Co.Name = "Co"
        Me.Co.ReadOnly = True
        Me.Co.Width = 75
        '
        'V
        '
        Me.V.Frozen = True
        Me.V.HeaderText = "Valor"
        Me.V.Name = "V"
        Me.V.ReadOnly = True
        Me.V.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Historias Accionables"
        '
        'butListahAccionables
        '
        Me.butListahAccionables.Location = New System.Drawing.Point(12, 454)
        Me.butListahAccionables.Name = "butListahAccionables"
        Me.butListahAccionables.Size = New System.Drawing.Size(148, 23)
        Me.butListahAccionables.TabIndex = 5
        Me.butListahAccionables.Text = "Historias Accionables"
        Me.butListahAccionables.UseVisualStyleBackColor = True
        '
        'butGuardarSB
        '
        Me.butGuardarSB.Location = New System.Drawing.Point(188, 454)
        Me.butGuardarSB.Name = "butGuardarSB"
        Me.butGuardarSB.Size = New System.Drawing.Size(148, 23)
        Me.butGuardarSB.TabIndex = 4
        Me.butGuardarSB.Text = "Guardar"
        Me.butGuardarSB.UseVisualStyleBackColor = True
        '
        'lblCabecera
        '
        Me.lblCabecera.AutoSize = True
        Me.lblCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabecera.Location = New System.Drawing.Point(8, 7)
        Me.lblCabecera.Name = "lblCabecera"
        Me.lblCabecera.Size = New System.Drawing.Size(55, 16)
        Me.lblCabecera.TabIndex = 3
        Me.lblCabecera.Text = "Label1"
        '
        'butSalir
        '
        Me.butSalir.Location = New System.Drawing.Point(342, 454)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(148, 23)
        Me.butSalir.TabIndex = 2
        Me.butSalir.Text = "Salir"
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'dgvSB
        '
        Me.dgvSB.AllowUserToDeleteRows = False
        Me.dgvSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdH, Me.NHistoria, Me.Sprint, Me.Duracion})
        Me.dgvSB.Location = New System.Drawing.Point(9, 28)
        Me.dgvSB.Name = "dgvSB"
        Me.dgvSB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSB.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSB.Size = New System.Drawing.Size(1212, 420)
        Me.dgvSB.TabIndex = 0
        '
        'IdH
        '
        Me.IdH.HeaderText = "Id.His."
        Me.IdH.Name = "IdH"
        Me.IdH.ReadOnly = True
        Me.IdH.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdH.Width = 50
        '
        'NHistoria
        '
        Me.NHistoria.HeaderText = "Historia"
        Me.NHistoria.Name = "NHistoria"
        Me.NHistoria.ReadOnly = True
        Me.NHistoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NHistoria.Width = 200
        '
        'Sprint
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Sprint.DefaultCellStyle = DataGridViewCellStyle1
        Me.Sprint.HeaderText = "Sprint"
        Me.Sprint.Name = "Sprint"
        Me.Sprint.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sprint.Width = 75
        '
        'Duracion
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Duracion.DefaultCellStyle = DataGridViewCellStyle2
        Me.Duracion.HeaderText = "Duracion (d)"
        Me.Duracion.Name = "Duracion"
        Me.Duracion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Duracion.Width = 75
        '
        'frmSB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 502)
        Me.Controls.Add(Me.pnlSB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(25, 25)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmSB"
        Me.pnlSB.ResumeLayout(False)
        Me.pnlSB.PerformLayout()
        Me.pnlHA.ResumeLayout(False)
        Me.pnlHA.PerformLayout()
        CType(Me.dgvHA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSB As System.Windows.Forms.Panel
    Friend WithEvents dgvSB As System.Windows.Forms.DataGridView
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents butGuardarSB As System.Windows.Forms.Button
    Friend WithEvents lblCabecera As System.Windows.Forms.Label
    Friend WithEvents IdH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NHistoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sprint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents butListahAccionables As System.Windows.Forms.Button
    Friend WithEvents pnlHA As System.Windows.Forms.Panel
    Friend WithEvents butSHA As System.Windows.Forms.Button
    Friend WithEvents dgvHA As System.Windows.Forms.DataGridView
    Friend WithEvents H As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Co As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents V As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
