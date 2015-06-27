<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPO
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPO))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.pnlQuienSoy = New System.Windows.Forms.Panel()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.ButSalir = New System.Windows.Forms.Button()
        Me.butGuardar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CrearProductBacklogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefinarProductBacklogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevoProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevoProyectoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenerProyectoExistenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminarProyectoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarProyectoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComposiciónEquipoDeProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReleaseDeProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLasYaGeneradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarSprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionSgtoProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGVPBacklog = New System.Windows.Forms.DataGridView()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlEquipo = New System.Windows.Forms.Panel()
        Me.butListo = New System.Windows.Forms.Button()
        Me.DGVEquipo = New System.Windows.Forms.DataGridView()
        Me.NPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.pnlQuienSoy.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGVPBacklog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEquipo.SuspendLayout()
        CType(Me.DGVEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(400, 13)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(253, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(344, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(916, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proyecto:"
        '
        'txtProyecto
        '
        Me.txtProyecto.Enabled = False
        Me.txtProyecto.Location = New System.Drawing.Point(974, 13)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.Size = New System.Drawing.Size(259, 20)
        Me.txtProyecto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(661, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Rol:"
        '
        'txtRol
        '
        Me.txtRol.Enabled = False
        Me.txtRol.Location = New System.Drawing.Point(692, 13)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(220, 20)
        Me.txtRol.TabIndex = 4
        '
        'pnlQuienSoy
        '
        Me.pnlQuienSoy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlQuienSoy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlQuienSoy.Controls.Add(Me.pnlBotones)
        Me.pnlQuienSoy.Controls.Add(Me.txtProyecto)
        Me.pnlQuienSoy.Controls.Add(Me.Label3)
        Me.pnlQuienSoy.Controls.Add(Me.txtUsuario)
        Me.pnlQuienSoy.Controls.Add(Me.txtRol)
        Me.pnlQuienSoy.Controls.Add(Me.Label1)
        Me.pnlQuienSoy.Controls.Add(Me.Label2)
        Me.pnlQuienSoy.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlQuienSoy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlQuienSoy.Location = New System.Drawing.Point(0, 590)
        Me.pnlQuienSoy.Name = "pnlQuienSoy"
        Me.pnlQuienSoy.Size = New System.Drawing.Size(1289, 45)
        Me.pnlQuienSoy.TabIndex = 6
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.ButSalir)
        Me.pnlBotones.Controls.Add(Me.butGuardar)
        Me.pnlBotones.Location = New System.Drawing.Point(10, 5)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(328, 28)
        Me.pnlBotones.TabIndex = 6
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearProductBacklogToolStripMenuItem, Me.RefinarProductBacklogToolStripMenuItem, Me.SalirToolStripMenuItem, Me.NotificacionesToolStripMenuItem, Me.CrearNuevoProyectoToolStripMenuItem, Me.CancelarSprintToolStripMenuItem, Me.InformacionSgtoProyectoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1289, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CrearProductBacklogToolStripMenuItem
        '
        Me.CrearProductBacklogToolStripMenuItem.Name = "CrearProductBacklogToolStripMenuItem"
        Me.CrearProductBacklogToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.CrearProductBacklogToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.CrearProductBacklogToolStripMenuItem.Text = "&Crear Product Backlog"
        '
        'RefinarProductBacklogToolStripMenuItem
        '
        Me.RefinarProductBacklogToolStripMenuItem.Name = "RefinarProductBacklogToolStripMenuItem"
        Me.RefinarProductBacklogToolStripMenuItem.Size = New System.Drawing.Size(146, 20)
        Me.RefinarProductBacklogToolStripMenuItem.Text = "&Refinar Product Backlog"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'NotificacionesToolStripMenuItem
        '
        Me.NotificacionesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.NotificacionesToolStripMenuItem.Name = "NotificacionesToolStripMenuItem"
        Me.NotificacionesToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.NotificacionesToolStripMenuItem.Text = "Notificaciones"
        '
        'CrearNuevoProyectoToolStripMenuItem
        '
        Me.CrearNuevoProyectoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevoProyectoToolStripMenuItem1, Me.MantenerProyectoExistenteToolStripMenuItem, Me.TerminarProyectoToolStripMenuItem1, Me.CancelarProyectoToolStripMenuItem1, Me.ComposiciónEquipoDeProyectoToolStripMenuItem, Me.GenerarReleaseDeProyectoToolStripMenuItem})
        Me.CrearNuevoProyectoToolStripMenuItem.Name = "CrearNuevoProyectoToolStripMenuItem"
        Me.CrearNuevoProyectoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CrearNuevoProyectoToolStripMenuItem.Text = "&Proyecto"
        '
        'CrearNuevoProyectoToolStripMenuItem1
        '
        Me.CrearNuevoProyectoToolStripMenuItem1.Name = "CrearNuevoProyectoToolStripMenuItem1"
        Me.CrearNuevoProyectoToolStripMenuItem1.Size = New System.Drawing.Size(251, 22)
        Me.CrearNuevoProyectoToolStripMenuItem1.Text = "Crear Nuevo Proyecto"
        '
        'MantenerProyectoExistenteToolStripMenuItem
        '
        Me.MantenerProyectoExistenteToolStripMenuItem.Name = "MantenerProyectoExistenteToolStripMenuItem"
        Me.MantenerProyectoExistenteToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.MantenerProyectoExistenteToolStripMenuItem.Text = "Modificar Proyecto Actual"
        '
        'TerminarProyectoToolStripMenuItem1
        '
        Me.TerminarProyectoToolStripMenuItem1.Name = "TerminarProyectoToolStripMenuItem1"
        Me.TerminarProyectoToolStripMenuItem1.Size = New System.Drawing.Size(251, 22)
        Me.TerminarProyectoToolStripMenuItem1.Text = "Terminar Proyecto Actual"
        '
        'CancelarProyectoToolStripMenuItem1
        '
        Me.CancelarProyectoToolStripMenuItem1.Name = "CancelarProyectoToolStripMenuItem1"
        Me.CancelarProyectoToolStripMenuItem1.Size = New System.Drawing.Size(251, 22)
        Me.CancelarProyectoToolStripMenuItem1.Text = "Cancelar Proyecto Actual"
        '
        'ComposiciónEquipoDeProyectoToolStripMenuItem
        '
        Me.ComposiciónEquipoDeProyectoToolStripMenuItem.Name = "ComposiciónEquipoDeProyectoToolStripMenuItem"
        Me.ComposiciónEquipoDeProyectoToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.ComposiciónEquipoDeProyectoToolStripMenuItem.Text = "Composición Equipo de Proyecto"
        '
        'GenerarReleaseDeProyectoToolStripMenuItem
        '
        Me.GenerarReleaseDeProyectoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarToolStripMenuItem, Me.VerLasYaGeneradasToolStripMenuItem})
        Me.GenerarReleaseDeProyectoToolStripMenuItem.Name = "GenerarReleaseDeProyectoToolStripMenuItem"
        Me.GenerarReleaseDeProyectoToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.GenerarReleaseDeProyectoToolStripMenuItem.Text = "Releases de Proyecto"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GenerarToolStripMenuItem.Text = "Generar"
        '
        'VerLasYaGeneradasToolStripMenuItem
        '
        Me.VerLasYaGeneradasToolStripMenuItem.Name = "VerLasYaGeneradasToolStripMenuItem"
        Me.VerLasYaGeneradasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerLasYaGeneradasToolStripMenuItem.Text = "Ver las ya generadas"
        '
        'CancelarSprintToolStripMenuItem
        '
        Me.CancelarSprintToolStripMenuItem.Name = "CancelarSprintToolStripMenuItem"
        Me.CancelarSprintToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.CancelarSprintToolStripMenuItem.Text = "Cancelar Sprint"
        '
        'InformacionSgtoProyectoToolStripMenuItem
        '
        Me.InformacionSgtoProyectoToolStripMenuItem.Name = "InformacionSgtoProyectoToolStripMenuItem"
        Me.InformacionSgtoProyectoToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.InformacionSgtoProyectoToolStripMenuItem.Text = "Información Sgto Proyecto"
        '
        'DGVPBacklog
        '
        Me.DGVPBacklog.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGVPBacklog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVPBacklog.CausesValidation = False
        Me.DGVPBacklog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPBacklog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6, Me.col7, Me.col8, Me.Col9, Me.EST})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPBacklog.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVPBacklog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPBacklog.Location = New System.Drawing.Point(0, 24)
        Me.DGVPBacklog.Name = "DGVPBacklog"
        Me.DGVPBacklog.Size = New System.Drawing.Size(1289, 566)
        Me.DGVPBacklog.TabIndex = 8
        Me.DGVPBacklog.Visible = False
        '
        'Col1
        '
        Me.Col1.HeaderText = "ID Historia"
        Me.Col1.MaxInputLength = 10
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        Me.Col1.Width = 138
        '
        'Col2
        '
        Me.Col2.HeaderText = "Descripción Historia"
        Me.Col2.MaxInputLength = 400
        Me.Col2.Name = "Col2"
        Me.Col2.Width = 139
        '
        'Col3
        '
        Me.Col3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Col3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Col3.HeaderText = "Estado"
        Me.Col3.Items.AddRange(New Object() {"Accionable", "Cancelado", "En marcha", "Planificado", "Terminado", "Liberada"})
        Me.Col3.Name = "Col3"
        Me.Col3.Width = 138
        '
        'Col4
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Col4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Col4.HeaderText = "Tamaño (días)"
        Me.Col4.MaxInputLength = 10
        Me.Col4.Name = "Col4"
        Me.Col4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Col4.Width = 139
        '
        'Col5
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Col5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Col5.HeaderText = "Sprint"
        Me.Col5.MaxInputLength = 10
        Me.Col5.Name = "Col5"
        Me.Col5.Width = 138
        '
        'Col6
        '
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Col6.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col6.HeaderText = "Prioridad"
        Me.Col6.MaxInputLength = 10
        Me.Col6.Name = "Col6"
        Me.Col6.Width = 139
        '
        'col7
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col7.DefaultCellStyle = DataGridViewCellStyle4
        Me.col7.HeaderText = "Coste Estimado"
        Me.col7.MaxInputLength = 15
        Me.col7.Name = "col7"
        Me.col7.Width = 138
        '
        'col8
        '
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.col8.DefaultCellStyle = DataGridViewCellStyle5
        Me.col8.HeaderText = "Valor Estimado"
        Me.col8.MaxInputLength = 15
        Me.col8.Name = "col8"
        Me.col8.Width = 139
        '
        'Col9
        '
        Me.Col9.HeaderText = "Comentarios"
        Me.Col9.Name = "Col9"
        Me.Col9.Width = 1000
        '
        'EST
        '
        Me.EST.HeaderText = "EST"
        Me.EST.Name = "EST"
        Me.EST.Visible = False
        '
        'pnlEquipo
        '
        Me.pnlEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEquipo.Controls.Add(Me.butListo)
        Me.pnlEquipo.Controls.Add(Me.DGVEquipo)
        Me.pnlEquipo.Controls.Add(Me.lblEquipo)
        Me.pnlEquipo.Location = New System.Drawing.Point(121, 93)
        Me.pnlEquipo.Name = "pnlEquipo"
        Me.pnlEquipo.Size = New System.Drawing.Size(714, 363)
        Me.pnlEquipo.TabIndex = 9
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
        'frmPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 635)
        Me.Controls.Add(Me.pnlEquipo)
        Me.Controls.Add(Me.DGVPBacklog)
        Me.Controls.Add(Me.pnlQuienSoy)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SCRUM Wizard - Product Owner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlQuienSoy.ResumeLayout(False)
        Me.pnlQuienSoy.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGVPBacklog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEquipo.ResumeLayout(False)
        Me.pnlEquipo.PerformLayout()
        CType(Me.DGVEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents pnlQuienSoy As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CrearProductBacklogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefinarProductBacklogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DGVPBacklog As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents butGuardar As System.Windows.Forms.Button
    Friend WithEvents ButSalir As System.Windows.Forms.Button
    Friend WithEvents CrearNuevoProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearNuevoProyectoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenerProyectoExistenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminarProyectoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarProyectoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComposiciónEquipoDeProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlEquipo As System.Windows.Forms.Panel
    Friend WithEvents lblEquipo As System.Windows.Forms.Label
    Friend WithEvents DGVEquipo As System.Windows.Forms.DataGridView
    Friend WithEvents NPerson As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents butListo As System.Windows.Forms.Button
    Friend WithEvents GenerarReleaseDeProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerLasYaGeneradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CancelarSprintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionSgtoProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
