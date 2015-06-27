<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotificaciones
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlNotificaciones = New System.Windows.Forms.Panel()
        Me.DGVNotPasadas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.butNotSalir = New System.Windows.Forms.Button()
        Me.butNotGuardar = New System.Windows.Forms.Button()
        Me.butNotPasadas = New System.Windows.Forms.Button()
        Me.DGVNotificaciones = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Leido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aviso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlNotificaciones.SuspendLayout()
        CType(Me.DGVNotPasadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVNotificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlNotificaciones
        '
        Me.pnlNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNotificaciones.Controls.Add(Me.DGVNotPasadas)
        Me.pnlNotificaciones.Controls.Add(Me.butNotSalir)
        Me.pnlNotificaciones.Controls.Add(Me.butNotGuardar)
        Me.pnlNotificaciones.Controls.Add(Me.butNotPasadas)
        Me.pnlNotificaciones.Controls.Add(Me.DGVNotificaciones)
        Me.pnlNotificaciones.Controls.Add(Me.Label1)
        Me.pnlNotificaciones.Location = New System.Drawing.Point(12, 11)
        Me.pnlNotificaciones.Name = "pnlNotificaciones"
        Me.pnlNotificaciones.Size = New System.Drawing.Size(635, 467)
        Me.pnlNotificaciones.TabIndex = 0
        '
        'DGVNotPasadas
        '
        Me.DGVNotPasadas.AllowUserToAddRows = False
        Me.DGVNotPasadas.AllowUserToDeleteRows = False
        Me.DGVNotPasadas.ColumnHeadersHeight = 40
        Me.DGVNotPasadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVNotPasadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DGVNotPasadas.Location = New System.Drawing.Point(18, 293)
        Me.DGVNotPasadas.Name = "DGVNotPasadas"
        Me.DGVNotPasadas.ReadOnly = True
        Me.DGVNotPasadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVNotPasadas.Size = New System.Drawing.Size(237, 126)
        Me.DGVNotPasadas.TabIndex = 5
        Me.DGVNotPasadas.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Leido"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha Reunión"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hora Reunión"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Duración Reunión"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Aviso"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 275
        '
        'butNotSalir
        '
        Me.butNotSalir.Location = New System.Drawing.Point(463, 425)
        Me.butNotSalir.Name = "butNotSalir"
        Me.butNotSalir.Size = New System.Drawing.Size(101, 23)
        Me.butNotSalir.TabIndex = 4
        Me.butNotSalir.Text = "Salir"
        Me.butNotSalir.UseVisualStyleBackColor = True
        '
        'butNotGuardar
        '
        Me.butNotGuardar.Location = New System.Drawing.Point(341, 425)
        Me.butNotGuardar.Name = "butNotGuardar"
        Me.butNotGuardar.Size = New System.Drawing.Size(101, 23)
        Me.butNotGuardar.TabIndex = 3
        Me.butNotGuardar.Text = "Guardar"
        Me.butNotGuardar.UseVisualStyleBackColor = True
        '
        'butNotPasadas
        '
        Me.butNotPasadas.Location = New System.Drawing.Point(218, 425)
        Me.butNotPasadas.Name = "butNotPasadas"
        Me.butNotPasadas.Size = New System.Drawing.Size(101, 23)
        Me.butNotPasadas.TabIndex = 2
        Me.butNotPasadas.Text = "Ver no atendidas"
        Me.butNotPasadas.UseVisualStyleBackColor = True
        '
        'DGVNotificaciones
        '
        Me.DGVNotificaciones.AllowUserToAddRows = False
        Me.DGVNotificaciones.AllowUserToDeleteRows = False
        Me.DGVNotificaciones.ColumnHeadersHeight = 40
        Me.DGVNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVNotificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Leido, Me.Fecha, Me.Hora, Me.Duracion, Me.Aviso, Me.Id})
        Me.DGVNotificaciones.Location = New System.Drawing.Point(18, 34)
        Me.DGVNotificaciones.Name = "DGVNotificaciones"
        Me.DGVNotificaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVNotificaciones.Size = New System.Drawing.Size(600, 384)
        Me.DGVNotificaciones.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notificaciones"
        '
        'Leido
        '
        Me.Leido.HeaderText = "Leido"
        Me.Leido.Name = "Leido"
        Me.Leido.Width = 50
        '
        'Fecha
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle4
        Me.Fecha.HeaderText = "Fecha Reunión"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 75
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora Reunión"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        Me.Hora.Width = 75
        '
        'Duracion
        '
        Me.Duracion.HeaderText = "Duración Reunión"
        Me.Duracion.Name = "Duracion"
        Me.Duracion.ReadOnly = True
        Me.Duracion.Width = 75
        '
        'Aviso
        '
        Me.Aviso.HeaderText = "Aviso"
        Me.Aviso.Name = "Aviso"
        Me.Aviso.ReadOnly = True
        Me.Aviso.Width = 275
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'frmNotificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 488)
        Me.Controls.Add(Me.pnlNotificaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SCRUM Wizard - Notificaciones"
        Me.pnlNotificaciones.ResumeLayout(False)
        Me.pnlNotificaciones.PerformLayout()
        CType(Me.DGVNotPasadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVNotificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlNotificaciones As System.Windows.Forms.Panel
    Friend WithEvents butNotSalir As System.Windows.Forms.Button
    Friend WithEvents butNotGuardar As System.Windows.Forms.Button
    Friend WithEvents butNotPasadas As System.Windows.Forms.Button
    Friend WithEvents DGVNotificaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVNotPasadas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Leido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aviso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
