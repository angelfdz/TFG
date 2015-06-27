<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProyecto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIProyecto = New System.Windows.Forms.TextBox()
        Me.txtNProyecto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nuNSprints = New System.Windows.Forms.NumericUpDown()
        Me.dtFInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtFFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEquipos = New System.Windows.Forms.ComboBox()
        Me.butGrabar = New System.Windows.Forms.Button()
        Me.pnlProyecto = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.butSal = New System.Windows.Forms.Button()
        Me.nuHDia = New System.Windows.Forms.NumericUpDown()
        Me.cbIdEquipo = New System.Windows.Forms.ComboBox()
        CType(Me.nuNSprints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProyecto.SuspendLayout()
        CType(Me.nuHDia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id."
        '
        'txtIProyecto
        '
        Me.txtIProyecto.Location = New System.Drawing.Point(16, 45)
        Me.txtIProyecto.Name = "txtIProyecto"
        Me.txtIProyecto.Size = New System.Drawing.Size(49, 20)
        Me.txtIProyecto.TabIndex = 0
        '
        'txtNProyecto
        '
        Me.txtNProyecto.Location = New System.Drawing.Point(71, 45)
        Me.txtNProyecto.MaxLength = 500
        Me.txtNProyecto.Name = "txtNProyecto"
        Me.txtNProyecto.Size = New System.Drawing.Size(612, 20)
        Me.txtNProyecto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Inicio"
        '
        'nuNSprints
        '
        Me.nuNSprints.Location = New System.Drawing.Point(302, 113)
        Me.nuNSprints.Name = "nuNSprints"
        Me.nuNSprints.Size = New System.Drawing.Size(44, 20)
        Me.nuNSprints.TabIndex = 4
        '
        'dtFInicio
        '
        Me.dtFInicio.CustomFormat = ""
        Me.dtFInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFInicio.Location = New System.Drawing.Point(21, 113)
        Me.dtFInicio.Name = "dtFInicio"
        Me.dtFInicio.Size = New System.Drawing.Size(124, 20)
        Me.dtFInicio.TabIndex = 2
        '
        'dtFFin
        '
        Me.dtFFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFFin.Location = New System.Drawing.Point(154, 113)
        Me.dtFFin.Name = "dtFFin"
        Me.dtFFin.Size = New System.Drawing.Size(124, 20)
        Me.dtFFin.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Núm. de Sprints"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(374, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Equipo de proyecto"
        '
        'cbEquipos
        '
        Me.cbEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbEquipos.FormattingEnabled = True
        Me.cbEquipos.Location = New System.Drawing.Point(374, 113)
        Me.cbEquipos.Name = "cbEquipos"
        Me.cbEquipos.Size = New System.Drawing.Size(199, 21)
        Me.cbEquipos.TabIndex = 5
        '
        'butGrabar
        '
        Me.butGrabar.Location = New System.Drawing.Point(707, 46)
        Me.butGrabar.Name = "butGrabar"
        Me.butGrabar.Size = New System.Drawing.Size(139, 30)
        Me.butGrabar.TabIndex = 7
        Me.butGrabar.Text = "Guardar"
        Me.butGrabar.UseVisualStyleBackColor = True
        '
        'pnlProyecto
        '
        Me.pnlProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProyecto.Controls.Add(Me.Label7)
        Me.pnlProyecto.Controls.Add(Me.butSal)
        Me.pnlProyecto.Controls.Add(Me.nuHDia)
        Me.pnlProyecto.Controls.Add(Me.cbIdEquipo)
        Me.pnlProyecto.Location = New System.Drawing.Point(3, 12)
        Me.pnlProyecto.Name = "pnlProyecto"
        Me.pnlProyecto.Size = New System.Drawing.Size(850, 151)
        Me.pnlProyecto.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(592, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Horas Día Lab."
        '
        'butSal
        '
        Me.butSal.Location = New System.Drawing.Point(703, 69)
        Me.butSal.Name = "butSal"
        Me.butSal.Size = New System.Drawing.Size(139, 30)
        Me.butSal.TabIndex = 8
        Me.butSal.Text = "Salir"
        Me.butSal.UseVisualStyleBackColor = True
        '
        'nuHDia
        '
        Me.nuHDia.Location = New System.Drawing.Point(612, 100)
        Me.nuHDia.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nuHDia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuHDia.Name = "nuHDia"
        Me.nuHDia.Size = New System.Drawing.Size(44, 20)
        Me.nuHDia.TabIndex = 6
        Me.nuHDia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbIdEquipo
        '
        Me.cbIdEquipo.FormattingEnabled = True
        Me.cbIdEquipo.Location = New System.Drawing.Point(563, 3)
        Me.cbIdEquipo.Name = "cbIdEquipo"
        Me.cbIdEquipo.Size = New System.Drawing.Size(249, 21)
        Me.cbIdEquipo.TabIndex = 2
        Me.cbIdEquipo.Visible = False
        '
        'frmProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 175)
        Me.Controls.Add(Me.butGrabar)
        Me.Controls.Add(Me.cbEquipos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtFFin)
        Me.Controls.Add(Me.dtFInicio)
        Me.Controls.Add(Me.nuNSprints)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNProyecto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIProyecto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlProyecto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(100, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión de Proyectos"
        CType(Me.nuNSprints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProyecto.ResumeLayout(False)
        Me.pnlProyecto.PerformLayout()
        CType(Me.nuHDia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIProyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtNProyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nuNSprints As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtFInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEquipos As System.Windows.Forms.ComboBox
    Friend WithEvents butGrabar As System.Windows.Forms.Button
    Friend WithEvents pnlProyecto As System.Windows.Forms.Panel
    Friend WithEvents cbIdEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents butSal As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nuHDia As System.Windows.Forms.NumericUpDown
End Class
