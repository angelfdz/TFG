<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSM))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConovocatoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanificaciónSPMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisiónSRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiariaDailyScrumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrospectivaSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerIntegrantesEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivarSprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlQuiebSoy = New System.Windows.Forms.Panel()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.ButSalir = New System.Windows.Forms.Button()
        Me.butGuardar = New System.Windows.Forms.Button()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlEquipo = New System.Windows.Forms.Panel()
        Me.butListo = New System.Windows.Forms.Button()
        Me.DGVEquipo = New System.Windows.Forms.DataGridView()
        Me.NPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.pnlSelSprint = New System.Windows.Forms.Panel()
        Me.lstAux = New System.Windows.Forms.ListBox()
        Me.butSSalir = New System.Windows.Forms.Button()
        Me.butSeleccionar = New System.Windows.Forms.Button()
        Me.lstSelSprint = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlQuiebSoy.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.pnlEquipo.SuspendLayout()
        CType(Me.DGVEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSelSprint.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConovocatoriasToolStripMenuItem, Me.VerIntegrantesEquipoToolStripMenuItem, Me.SalirToolStripMenuItem, Me.NotificacionesToolStripMenuItem, Me.ActivarSprintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1289, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConovocatoriasToolStripMenuItem
        '
        Me.ConovocatoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanificaciónSPMToolStripMenuItem, Me.RevisiónSRToolStripMenuItem, Me.DiariaDailyScrumToolStripMenuItem, Me.RetrospectivaSPToolStripMenuItem})
        Me.ConovocatoriasToolStripMenuItem.Name = "ConovocatoriasToolStripMenuItem"
        Me.ConovocatoriasToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConovocatoriasToolStripMenuItem.Text = "Convocatorias"
        '
        'PlanificaciónSPMToolStripMenuItem
        '
        Me.PlanificaciónSPMToolStripMenuItem.Name = "PlanificaciónSPMToolStripMenuItem"
        Me.PlanificaciónSPMToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PlanificaciónSPMToolStripMenuItem.Text = "Planificación (SPM)"
        '
        'RevisiónSRToolStripMenuItem
        '
        Me.RevisiónSRToolStripMenuItem.Name = "RevisiónSRToolStripMenuItem"
        Me.RevisiónSRToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RevisiónSRToolStripMenuItem.Text = "Revisión (SR)"
        '
        'DiariaDailyScrumToolStripMenuItem
        '
        Me.DiariaDailyScrumToolStripMenuItem.Name = "DiariaDailyScrumToolStripMenuItem"
        Me.DiariaDailyScrumToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DiariaDailyScrumToolStripMenuItem.Text = "Diaria (DS)"
        '
        'RetrospectivaSPToolStripMenuItem
        '
        Me.RetrospectivaSPToolStripMenuItem.Name = "RetrospectivaSPToolStripMenuItem"
        Me.RetrospectivaSPToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RetrospectivaSPToolStripMenuItem.Text = "Retrospectiva (SRP)"
        '
        'VerIntegrantesEquipoToolStripMenuItem
        '
        Me.VerIntegrantesEquipoToolStripMenuItem.Name = "VerIntegrantesEquipoToolStripMenuItem"
        Me.VerIntegrantesEquipoToolStripMenuItem.Size = New System.Drawing.Size(196, 20)
        Me.VerIntegrantesEquipoToolStripMenuItem.Text = "Composición Equipo de Proyecto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'NotificacionesToolStripMenuItem
        '
        Me.NotificacionesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.NotificacionesToolStripMenuItem.Name = "NotificacionesToolStripMenuItem"
        Me.NotificacionesToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.NotificacionesToolStripMenuItem.Text = "Notificaciones"
        '
        'ActivarSprintToolStripMenuItem
        '
        Me.ActivarSprintToolStripMenuItem.Name = "ActivarSprintToolStripMenuItem"
        Me.ActivarSprintToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ActivarSprintToolStripMenuItem.Text = "Activar Sprint"
        '
        'pnlQuiebSoy
        '
        Me.pnlQuiebSoy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlQuiebSoy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlQuiebSoy.Controls.Add(Me.pnlBotones)
        Me.pnlQuiebSoy.Controls.Add(Me.txtProyecto)
        Me.pnlQuiebSoy.Controls.Add(Me.Label3)
        Me.pnlQuiebSoy.Controls.Add(Me.txtUsuario)
        Me.pnlQuiebSoy.Controls.Add(Me.txtRol)
        Me.pnlQuiebSoy.Controls.Add(Me.Label1)
        Me.pnlQuiebSoy.Controls.Add(Me.Label2)
        Me.pnlQuiebSoy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlQuiebSoy.Location = New System.Drawing.Point(0, 590)
        Me.pnlQuiebSoy.Name = "pnlQuiebSoy"
        Me.pnlQuiebSoy.Size = New System.Drawing.Size(1289, 45)
        Me.pnlQuiebSoy.TabIndex = 1
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.ButSalir)
        Me.pnlBotones.Controls.Add(Me.butGuardar)
        Me.pnlBotones.Location = New System.Drawing.Point(6, 6)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(328, 28)
        Me.pnlBotones.TabIndex = 12
        Me.pnlBotones.Visible = False
        '
        'ButSalir
        '
        Me.ButSalir.Location = New System.Drawing.Point(150, 3)
        Me.ButSalir.Name = "ButSalir"
        Me.ButSalir.Size = New System.Drawing.Size(96, 24)
        Me.ButSalir.TabIndex = 2
        Me.ButSalir.Text = "Salir"
        Me.ButSalir.UseVisualStyleBackColor = True
        '
        'butGuardar
        '
        Me.butGuardar.Location = New System.Drawing.Point(48, 3)
        Me.butGuardar.Name = "butGuardar"
        Me.butGuardar.Size = New System.Drawing.Size(96, 24)
        Me.butGuardar.TabIndex = 0
        Me.butGuardar.Text = "Guardar"
        Me.butGuardar.UseVisualStyleBackColor = True
        '
        'txtProyecto
        '
        Me.txtProyecto.Enabled = False
        Me.txtProyecto.Location = New System.Drawing.Point(988, 10)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.Size = New System.Drawing.Size(259, 20)
        Me.txtProyecto.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(675, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Rol:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(414, 10)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(253, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'txtRol
        '
        Me.txtRol.Enabled = False
        Me.txtRol.Location = New System.Drawing.Point(706, 10)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(220, 20)
        Me.txtRol.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(358, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(930, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Proyecto:"
        '
        'pnlEquipo
        '
        Me.pnlEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEquipo.Controls.Add(Me.butListo)
        Me.pnlEquipo.Controls.Add(Me.DGVEquipo)
        Me.pnlEquipo.Controls.Add(Me.lblEquipo)
        Me.pnlEquipo.Location = New System.Drawing.Point(287, 136)
        Me.pnlEquipo.Name = "pnlEquipo"
        Me.pnlEquipo.Size = New System.Drawing.Size(714, 363)
        Me.pnlEquipo.TabIndex = 10
        Me.pnlEquipo.Visible = False
        '
        'butListo
        '
        Me.butListo.Location = New System.Drawing.Point(531, 315)
        Me.butListo.Name = "butListo"
        Me.butListo.Size = New System.Drawing.Size(156, 27)
        Me.butListo.TabIndex = 2
        Me.butListo.Text = "Listo"
        Me.butListo.UseVisualStyleBackColor = True
        '
        'DGVEquipo
        '
        Me.DGVEquipo.AllowUserToAddRows = False
        Me.DGVEquipo.AllowUserToDeleteRows = False
        Me.DGVEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEquipo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPerson, Me.RolPer})
        Me.DGVEquipo.Location = New System.Drawing.Point(42, 43)
        Me.DGVEquipo.Name = "DGVEquipo"
        Me.DGVEquipo.ReadOnly = True
        Me.DGVEquipo.Size = New System.Drawing.Size(645, 254)
        Me.DGVEquipo.TabIndex = 1
        '
        'NPerson
        '
        Me.NPerson.Frozen = True
        Me.NPerson.HeaderText = "Componente del Equipo"
        Me.NPerson.Name = "NPerson"
        Me.NPerson.ReadOnly = True
        Me.NPerson.Width = 400
        '
        'RolPer
        '
        Me.RolPer.Frozen = True
        Me.RolPer.HeaderText = "Rol dentro del Equipo"
        Me.RolPer.Name = "RolPer"
        Me.RolPer.ReadOnly = True
        Me.RolPer.Width = 200
        '
        'lblEquipo
        '
        Me.lblEquipo.AutoSize = True
        Me.lblEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipo.Location = New System.Drawing.Point(39, 14)
        Me.lblEquipo.Name = "lblEquipo"
        Me.lblEquipo.Size = New System.Drawing.Size(63, 20)
        Me.lblEquipo.TabIndex = 0
        Me.lblEquipo.Text = "Label4"
        '
        'pnlSelSprint
        '
        Me.pnlSelSprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSelSprint.Controls.Add(Me.lstAux)
        Me.pnlSelSprint.Controls.Add(Me.butSSalir)
        Me.pnlSelSprint.Controls.Add(Me.butSeleccionar)
        Me.pnlSelSprint.Controls.Add(Me.lstSelSprint)
        Me.pnlSelSprint.Controls.Add(Me.Label4)
        Me.pnlSelSprint.Location = New System.Drawing.Point(56, 57)
        Me.pnlSelSprint.Name = "pnlSelSprint"
        Me.pnlSelSprint.Size = New System.Drawing.Size(179, 377)
        Me.pnlSelSprint.TabIndex = 15
        Me.pnlSelSprint.Visible = False
        '
        'lstAux
        '
        Me.lstAux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAux.FormattingEnabled = True
        Me.lstAux.ItemHeight = 15
        Me.lstAux.Location = New System.Drawing.Point(11, 51)
        Me.lstAux.Name = "lstAux"
        Me.lstAux.Size = New System.Drawing.Size(154, 62)
        Me.lstAux.TabIndex = 4
        Me.lstAux.Visible = False
        '
        'butSSalir
        '
        Me.butSSalir.Location = New System.Drawing.Point(34, 343)
        Me.butSSalir.Name = "butSSalir"
        Me.butSSalir.Size = New System.Drawing.Size(104, 23)
        Me.butSSalir.TabIndex = 3
        Me.butSSalir.Text = "Salir"
        Me.butSSalir.UseVisualStyleBackColor = True
        '
        'butSeleccionar
        '
        Me.butSeleccionar.Location = New System.Drawing.Point(34, 316)
        Me.butSeleccionar.Name = "butSeleccionar"
        Me.butSeleccionar.Size = New System.Drawing.Size(104, 23)
        Me.butSeleccionar.TabIndex = 2
        Me.butSeleccionar.Text = "Seleccionar"
        Me.butSeleccionar.UseVisualStyleBackColor = True
        '
        'lstSelSprint
        '
        Me.lstSelSprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSelSprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelSprint.FormattingEnabled = True
        Me.lstSelSprint.ItemHeight = 15
        Me.lstSelSprint.Location = New System.Drawing.Point(11, 27)
        Me.lstSelSprint.Name = "lstSelSprint"
        Me.lstSelSprint.Size = New System.Drawing.Size(154, 272)
        Me.lstSelSprint.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Seleccione el Sprint"
        '
        'frmSM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 635)
        Me.Controls.Add(Me.pnlSelSprint)
        Me.Controls.Add(Me.pnlEquipo)
        Me.Controls.Add(Me.pnlQuiebSoy)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SCRUM Wizard - Scrum Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlQuiebSoy.ResumeLayout(False)
        Me.pnlQuiebSoy.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlEquipo.ResumeLayout(False)
        Me.pnlEquipo.PerformLayout()
        CType(Me.DGVEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSelSprint.ResumeLayout(False)
        Me.pnlSelSprint.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConovocatoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanificaciónSPMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevisiónSRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiariaDailyScrumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetrospectivaSPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerIntegrantesEquipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlQuiebSoy As System.Windows.Forms.Panel
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents ButSalir As System.Windows.Forms.Button
    Friend WithEvents butGuardar As System.Windows.Forms.Button
    Friend WithEvents pnlEquipo As System.Windows.Forms.Panel
    Friend WithEvents butListo As System.Windows.Forms.Button
    Friend WithEvents DGVEquipo As System.Windows.Forms.DataGridView
    Friend WithEvents NPerson As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEquipo As System.Windows.Forms.Label
    Friend WithEvents ActivarSprintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlSelSprint As System.Windows.Forms.Panel
    Friend WithEvents lstAux As System.Windows.Forms.ListBox
    Friend WithEvents butSSalir As System.Windows.Forms.Button
    Friend WithEvents butSeleccionar As System.Windows.Forms.Button
    Friend WithEvents lstSelSprint As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
