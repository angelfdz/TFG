<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoSgtoP
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
        Me.pnlInfoDgtoP = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVInfoSgtoP = New System.Windows.Forms.DataGridView()
        Me.txtTSprints = New System.Windows.Forms.TextBox()
        Me.txtNumSTerminados = New System.Windows.Forms.TextBox()
        Me.txtNumSPendientes = New System.Windows.Forms.TextBox()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiasxSprint = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFproyectadaFin = New System.Windows.Forms.TextBox()
        Me.Sprint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlInfoDgtoP.SuspendLayout()
        CType(Me.DGVInfoSgtoP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInfoDgtoP
        '
        Me.pnlInfoDgtoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInfoDgtoP.Controls.Add(Me.txtFproyectadaFin)
        Me.pnlInfoDgtoP.Controls.Add(Me.Label6)
        Me.pnlInfoDgtoP.Controls.Add(Me.txtDiasxSprint)
        Me.pnlInfoDgtoP.Controls.Add(Me.Label5)
        Me.pnlInfoDgtoP.Controls.Add(Me.Label4)
        Me.pnlInfoDgtoP.Controls.Add(Me.Label3)
        Me.pnlInfoDgtoP.Controls.Add(Me.Label2)
        Me.pnlInfoDgtoP.Controls.Add(Me.butSalir)
        Me.pnlInfoDgtoP.Controls.Add(Me.txtNumSPendientes)
        Me.pnlInfoDgtoP.Controls.Add(Me.txtNumSTerminados)
        Me.pnlInfoDgtoP.Controls.Add(Me.txtTSprints)
        Me.pnlInfoDgtoP.Controls.Add(Me.DGVInfoSgtoP)
        Me.pnlInfoDgtoP.Controls.Add(Me.Label1)
        Me.pnlInfoDgtoP.Location = New System.Drawing.Point(12, 12)
        Me.pnlInfoDgtoP.Name = "pnlInfoDgtoP"
        Me.pnlInfoDgtoP.Size = New System.Drawing.Size(401, 366)
        Me.pnlInfoDgtoP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Información de Seguimiento del Proyecto"
        '
        'DGVInfoSgtoP
        '
        Me.DGVInfoSgtoP.AllowUserToAddRows = False
        Me.DGVInfoSgtoP.AllowUserToDeleteRows = False
        Me.DGVInfoSgtoP.AllowUserToResizeColumns = False
        Me.DGVInfoSgtoP.AllowUserToResizeRows = False
        Me.DGVInfoSgtoP.ColumnHeadersHeight = 35
        Me.DGVInfoSgtoP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVInfoSgtoP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sprint, Me.FC, Me.D, Me.Estado})
        Me.DGVInfoSgtoP.Location = New System.Drawing.Point(14, 30)
        Me.DGVInfoSgtoP.Name = "DGVInfoSgtoP"
        Me.DGVInfoSgtoP.ReadOnly = True
        Me.DGVInfoSgtoP.Size = New System.Drawing.Size(366, 209)
        Me.DGVInfoSgtoP.TabIndex = 1
        '
        'txtTSprints
        '
        Me.txtTSprints.Location = New System.Drawing.Point(154, 245)
        Me.txtTSprints.Name = "txtTSprints"
        Me.txtTSprints.Size = New System.Drawing.Size(51, 20)
        Me.txtTSprints.TabIndex = 2
        '
        'txtNumSTerminados
        '
        Me.txtNumSTerminados.Location = New System.Drawing.Point(154, 274)
        Me.txtNumSTerminados.Name = "txtNumSTerminados"
        Me.txtNumSTerminados.Size = New System.Drawing.Size(51, 20)
        Me.txtNumSTerminados.TabIndex = 3
        '
        'txtNumSPendientes
        '
        Me.txtNumSPendientes.Location = New System.Drawing.Point(154, 300)
        Me.txtNumSPendientes.Name = "txtNumSPendientes"
        Me.txtNumSPendientes.Size = New System.Drawing.Size(51, 20)
        Me.txtNumSPendientes.TabIndex = 4
        '
        'butSalir
        '
        Me.butSalir.Location = New System.Drawing.Point(11, 332)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(375, 23)
        Me.butSalir.TabIndex = 5
        Me.butSalir.Text = "Salir"
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Sprints:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Núm. Sprints Terminados:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Núm. Sprints Pendientes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(215, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Días por Sprint:"
        '
        'txtDiasxSprint
        '
        Me.txtDiasxSprint.Location = New System.Drawing.Point(302, 245)
        Me.txtDiasxSprint.Name = "txtDiasxSprint"
        Me.txtDiasxSprint.Size = New System.Drawing.Size(51, 20)
        Me.txtDiasxSprint.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha proyectada finalización:"
        '
        'txtFproyectadaFin
        '
        Me.txtFproyectadaFin.Location = New System.Drawing.Point(244, 300)
        Me.txtFproyectadaFin.Name = "txtFproyectadaFin"
        Me.txtFproyectadaFin.Size = New System.Drawing.Size(78, 20)
        Me.txtFproyectadaFin.TabIndex = 13
        '
        'Sprint
        '
        Me.Sprint.HeaderText = "Sprint"
        Me.Sprint.Name = "Sprint"
        Me.Sprint.ReadOnly = True
        Me.Sprint.Width = 60
        '
        'FC
        '
        Me.FC.HeaderText = "Fecha Comienzo"
        Me.FC.Name = "FC"
        Me.FC.ReadOnly = True
        Me.FC.Width = 75
        '
        'D
        '
        Me.D.HeaderText = "Duración"
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Width = 75
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 105
        '
        'frmInfoSgtoP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 390)
        Me.Controls.Add(Me.pnlInfoDgtoP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInfoSgtoP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmInfoSgtoP"
        Me.pnlInfoDgtoP.ResumeLayout(False)
        Me.pnlInfoDgtoP.PerformLayout()
        CType(Me.DGVInfoSgtoP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInfoDgtoP As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents txtNumSPendientes As System.Windows.Forms.TextBox
    Friend WithEvents txtNumSTerminados As System.Windows.Forms.TextBox
    Friend WithEvents txtTSprints As System.Windows.Forms.TextBox
    Friend WithEvents DGVInfoSgtoP As System.Windows.Forms.DataGridView
    Friend WithEvents txtFproyectadaFin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiasxSprint As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sprint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
