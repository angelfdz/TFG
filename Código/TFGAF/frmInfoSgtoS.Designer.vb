<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoSgtoS
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
        Me.txtFproyectadaFin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiasxSprint = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.txtNumSPendientes = New System.Windows.Forms.TextBox()
        Me.txtNumSTerminados = New System.Windows.Forms.TextBox()
        Me.txtTSprints = New System.Windows.Forms.TextBox()
        Me.DGVInfoSgtoP = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sprint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtHxH = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHPF = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlInfoDgtoP.SuspendLayout()
        CType(Me.DGVInfoSgtoP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInfoDgtoP
        '
        Me.pnlInfoDgtoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInfoDgtoP.Controls.Add(Me.txtHPF)
        Me.pnlInfoDgtoP.Controls.Add(Me.Label8)
        Me.pnlInfoDgtoP.Controls.Add(Me.txtHxH)
        Me.pnlInfoDgtoP.Controls.Add(Me.Label7)
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
        Me.pnlInfoDgtoP.Location = New System.Drawing.Point(16, 11)
        Me.pnlInfoDgtoP.Name = "pnlInfoDgtoP"
        Me.pnlInfoDgtoP.Size = New System.Drawing.Size(582, 366)
        Me.pnlInfoDgtoP.TabIndex = 1
        '
        'txtFproyectadaFin
        '
        Me.txtFproyectadaFin.Location = New System.Drawing.Point(254, 300)
        Me.txtFproyectadaFin.Name = "txtFproyectadaFin"
        Me.txtFproyectadaFin.Size = New System.Drawing.Size(78, 20)
        Me.txtFproyectadaFin.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Días proyectados finalización:"
        '
        'txtDiasxSprint
        '
        Me.txtDiasxSprint.Location = New System.Drawing.Point(322, 245)
        Me.txtDiasxSprint.Name = "txtDiasxSprint"
        Me.txtDiasxSprint.Size = New System.Drawing.Size(51, 20)
        Me.txtDiasxSprint.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Días por Historia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Núm. Historias Pendientes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Núm. Historias Terminados:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Historias:"
        '
        'butSalir
        '
        Me.butSalir.Location = New System.Drawing.Point(11, 332)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(558, 23)
        Me.butSalir.TabIndex = 5
        Me.butSalir.Text = "Salir"
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'txtNumSPendientes
        '
        Me.txtNumSPendientes.Location = New System.Drawing.Point(158, 300)
        Me.txtNumSPendientes.Name = "txtNumSPendientes"
        Me.txtNumSPendientes.Size = New System.Drawing.Size(51, 20)
        Me.txtNumSPendientes.TabIndex = 4
        '
        'txtNumSTerminados
        '
        Me.txtNumSTerminados.Location = New System.Drawing.Point(158, 274)
        Me.txtNumSTerminados.Name = "txtNumSTerminados"
        Me.txtNumSTerminados.Size = New System.Drawing.Size(51, 20)
        Me.txtNumSTerminados.TabIndex = 3
        '
        'txtTSprints
        '
        Me.txtTSprints.Location = New System.Drawing.Point(158, 245)
        Me.txtTSprints.Name = "txtTSprints"
        Me.txtTSprints.Size = New System.Drawing.Size(51, 20)
        Me.txtTSprints.TabIndex = 2
        '
        'DGVInfoSgtoP
        '
        Me.DGVInfoSgtoP.AllowUserToAddRows = False
        Me.DGVInfoSgtoP.AllowUserToDeleteRows = False
        Me.DGVInfoSgtoP.AllowUserToResizeColumns = False
        Me.DGVInfoSgtoP.AllowUserToResizeRows = False
        Me.DGVInfoSgtoP.ColumnHeadersHeight = 35
        Me.DGVInfoSgtoP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVInfoSgtoP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sprint, Me.FC, Me.DD, Me.DH, Me.Estado})
        Me.DGVInfoSgtoP.Location = New System.Drawing.Point(14, 30)
        Me.DGVInfoSgtoP.Name = "DGVInfoSgtoP"
        Me.DGVInfoSgtoP.ReadOnly = True
        Me.DGVInfoSgtoP.Size = New System.Drawing.Size(555, 209)
        Me.DGVInfoSgtoP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Información de Seguimiento del Sprint"
        '
        'Sprint
        '
        Me.Sprint.HeaderText = "Historia"
        Me.Sprint.Name = "Sprint"
        Me.Sprint.ReadOnly = True
        Me.Sprint.Width = 150
        '
        'FC
        '
        Me.FC.HeaderText = "Fecha Comienzo"
        Me.FC.Name = "FC"
        Me.FC.ReadOnly = True
        Me.FC.Width = 75
        '
        'DD
        '
        Me.DD.HeaderText = "Duración Días"
        Me.DD.Name = "DD"
        Me.DD.ReadOnly = True
        Me.DD.Width = 75
        '
        'DH
        '
        Me.DH.HeaderText = "Duración Horas"
        Me.DH.Name = "DH"
        Me.DH.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 105
        '
        'txtHxH
        '
        Me.txtHxH.Location = New System.Drawing.Point(494, 244)
        Me.txtHxH.Name = "txtHxH"
        Me.txtHxH.Size = New System.Drawing.Size(51, 20)
        Me.txtHxH.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(400, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Horas por Historia:"
        '
        'txtHPF
        '
        Me.txtHPF.Location = New System.Drawing.Point(423, 300)
        Me.txtHPF.Name = "txtHPF"
        Me.txtHPF.Size = New System.Drawing.Size(78, 20)
        Me.txtHPF.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Horas proyectadas finalización:"
        '
        'frmInfoSgtoS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 390)
        Me.Controls.Add(Me.pnlInfoDgtoP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInfoSgtoS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmInfoSgtoS"
        Me.pnlInfoDgtoP.ResumeLayout(False)
        Me.pnlInfoDgtoP.PerformLayout()
        CType(Me.DGVInfoSgtoP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInfoDgtoP As System.Windows.Forms.Panel
    Friend WithEvents txtFproyectadaFin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiasxSprint As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents txtNumSPendientes As System.Windows.Forms.TextBox
    Friend WithEvents txtNumSTerminados As System.Windows.Forms.TextBox
    Friend WithEvents txtTSprints As System.Windows.Forms.TextBox
    Friend WithEvents DGVInfoSgtoP As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHPF As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtHxH As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Sprint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
