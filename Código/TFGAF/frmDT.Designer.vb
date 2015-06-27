<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDT))
        Me.pnlEquipo = New System.Windows.Forms.Panel()
        Me.butListo = New System.Windows.Forms.Button()
        Me.DGVEquipo = New System.Windows.Forms.DataGridView()
        Me.NPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.pnlQuienSoy = New System.Windows.Forms.Panel()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.ButSalir = New System.Windows.Forms.Button()
        Me.butGuardar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FijarObjetivoDeSprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstablecerDuracionSprintMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneraciónInformeSgtoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrrarSprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SprintBacklogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComposiciónEquipoDeProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlSelSprint = New System.Windows.Forms.Panel()
        Me.lstAux = New System.Windows.Forms.ListBox()
        Me.butSSalir = New System.Windows.Forms.Button()
        Me.butSeleccionar = New System.Windows.Forms.Button()
        Me.lstSelSprint = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlObjetivo = New System.Windows.Forms.Panel()
        Me.butSalirObj = New System.Windows.Forms.Button()
        Me.butGuardarObj = New System.Windows.Forms.Button()
        Me.txtObjetivo = New System.Windows.Forms.TextBox()
        Me.lblCabObjetivo = New System.Windows.Forms.Label()
        Me.pnlDuracion = New System.Windows.Forms.Panel()
        Me.butSalDuracion = New System.Windows.Forms.Button()
        Me.butGuardarDuracion = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nuDuracion = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDuracionSys = New System.Windows.Forms.Label()
        Me.lblDuracionActual = New System.Windows.Forms.Label()
        Me.lblCabDuracion = New System.Windows.Forms.Label()
        Me.pnlEquipo.SuspendLayout()
        CType(Me.DGVEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQuienSoy.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlSelSprint.SuspendLayout()
        Me.pnlObjetivo.SuspendLayout()
        Me.pnlDuracion.SuspendLayout()
        CType(Me.nuDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlEquipo
        '
        Me.pnlEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEquipo.Controls.Add(Me.butListo)
        Me.pnlEquipo.Controls.Add(Me.DGVEquipo)
        Me.pnlEquipo.Controls.Add(Me.lblEquipo)
        Me.pnlEquipo.Location = New System.Drawing.Point(231, 39)
        Me.pnlEquipo.Name = "pnlEquipo"
        Me.pnlEquipo.Size = New System.Drawing.Size(714, 363)
        Me.pnlEquipo.TabIndex = 11
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
        'pnlQuienSoy
        '
        Me.pnlQuienSoy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlQuienSoy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlQuienSoy.Controls.Add(Me.txtProyecto)
        Me.pnlQuienSoy.Controls.Add(Me.Label3)
        Me.pnlQuienSoy.Controls.Add(Me.txtUsuario)
        Me.pnlQuienSoy.Controls.Add(Me.txtRol)
        Me.pnlQuienSoy.Controls.Add(Me.Label1)
        Me.pnlQuienSoy.Controls.Add(Me.Label2)
        Me.pnlQuienSoy.Controls.Add(Me.pnlBotones)
        Me.pnlQuienSoy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlQuienSoy.Location = New System.Drawing.Point(0, 590)
        Me.pnlQuienSoy.Name = "pnlQuienSoy"
        Me.pnlQuienSoy.Size = New System.Drawing.Size(1289, 45)
        Me.pnlQuienSoy.TabIndex = 12
        '
        'txtProyecto
        '
        Me.txtProyecto.Enabled = False
        Me.txtProyecto.Location = New System.Drawing.Point(1020, 10)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.Size = New System.Drawing.Size(259, 20)
        Me.txtProyecto.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(707, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Rol:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(446, 10)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(253, 20)
        Me.txtUsuario.TabIndex = 14
        '
        'txtRol
        '
        Me.txtRol.Enabled = False
        Me.txtRol.Location = New System.Drawing.Point(738, 10)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(220, 20)
        Me.txtRol.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(390, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(962, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Proyecto:"
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.ButSalir)
        Me.pnlBotones.Controls.Add(Me.butGuardar)
        Me.pnlBotones.Location = New System.Drawing.Point(24, 6)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(272, 28)
        Me.pnlBotones.TabIndex = 13
        Me.pnlBotones.Visible = False
        '
        'ButSalir
        '
        Me.ButSalir.Location = New System.Drawing.Point(136, 3)
        Me.ButSalir.Name = "ButSalir"
        Me.ButSalir.Size = New System.Drawing.Size(96, 24)
        Me.ButSalir.TabIndex = 2
        Me.ButSalir.Text = "Salir"
        Me.ButSalir.UseVisualStyleBackColor = True
        '
        'butGuardar
        '
        Me.butGuardar.Location = New System.Drawing.Point(34, 3)
        Me.butGuardar.Name = "butGuardar"
        Me.butGuardar.Size = New System.Drawing.Size(96, 24)
        Me.butGuardar.TabIndex = 0
        Me.butGuardar.Text = "Guardar"
        Me.butGuardar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SprintToolStripMenuItem, Me.SprintBacklogToolStripMenuItem, Me.SalirToolStripMenuItem, Me.NotificacionesToolStripMenuItem, Me.ComposiciónEquipoDeProyectoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1289, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SprintToolStripMenuItem
        '
        Me.SprintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FijarObjetivoDeSprintToolStripMenuItem, Me.EstablecerDuracionSprintMenuItem, Me.GeneraciónInformeSgtoToolStripMenuItem, Me.CerrrarSprintToolStripMenuItem})
        Me.SprintToolStripMenuItem.Name = "SprintToolStripMenuItem"
        Me.SprintToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SprintToolStripMenuItem.Text = "Sprint"
        '
        'FijarObjetivoDeSprintToolStripMenuItem
        '
        Me.FijarObjetivoDeSprintToolStripMenuItem.Name = "FijarObjetivoDeSprintToolStripMenuItem"
        Me.FijarObjetivoDeSprintToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FijarObjetivoDeSprintToolStripMenuItem.Text = "Fijar Objetivo de Sprint"
        '
        'EstablecerDuracionSprintMenuItem
        '
        Me.EstablecerDuracionSprintMenuItem.Name = "EstablecerDuracionSprintMenuItem"
        Me.EstablecerDuracionSprintMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.EstablecerDuracionSprintMenuItem.Text = "Establecer Duración Sprint"
        '
        'GeneraciónInformeSgtoToolStripMenuItem
        '
        Me.GeneraciónInformeSgtoToolStripMenuItem.Name = "GeneraciónInformeSgtoToolStripMenuItem"
        Me.GeneraciónInformeSgtoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.GeneraciónInformeSgtoToolStripMenuItem.Text = "Generación Informe Sgto."
        '
        'CerrrarSprintToolStripMenuItem
        '
        Me.CerrrarSprintToolStripMenuItem.Name = "CerrrarSprintToolStripMenuItem"
        Me.CerrrarSprintToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CerrrarSprintToolStripMenuItem.Text = "Cerrrar Sprint"
        '
        'SprintBacklogToolStripMenuItem
        '
        Me.SprintBacklogToolStripMenuItem.Name = "SprintBacklogToolStripMenuItem"
        Me.SprintBacklogToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.SprintBacklogToolStripMenuItem.Text = "Sprint Backlog"
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
        'ComposiciónEquipoDeProyectoToolStripMenuItem
        '
        Me.ComposiciónEquipoDeProyectoToolStripMenuItem.Name = "ComposiciónEquipoDeProyectoToolStripMenuItem"
        Me.ComposiciónEquipoDeProyectoToolStripMenuItem.Size = New System.Drawing.Size(196, 20)
        Me.ComposiciónEquipoDeProyectoToolStripMenuItem.Text = "Composición Equipo de Proyecto"
        '
        'pnlSelSprint
        '
        Me.pnlSelSprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSelSprint.Controls.Add(Me.lstAux)
        Me.pnlSelSprint.Controls.Add(Me.butSSalir)
        Me.pnlSelSprint.Controls.Add(Me.butSeleccionar)
        Me.pnlSelSprint.Controls.Add(Me.lstSelSprint)
        Me.pnlSelSprint.Controls.Add(Me.Label4)
        Me.pnlSelSprint.Location = New System.Drawing.Point(26, 102)
        Me.pnlSelSprint.Name = "pnlSelSprint"
        Me.pnlSelSprint.Size = New System.Drawing.Size(179, 377)
        Me.pnlSelSprint.TabIndex = 14
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
        'pnlObjetivo
        '
        Me.pnlObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlObjetivo.Controls.Add(Me.butSalirObj)
        Me.pnlObjetivo.Controls.Add(Me.butGuardarObj)
        Me.pnlObjetivo.Controls.Add(Me.txtObjetivo)
        Me.pnlObjetivo.Controls.Add(Me.lblCabObjetivo)
        Me.pnlObjetivo.Location = New System.Drawing.Point(702, 24)
        Me.pnlObjetivo.Name = "pnlObjetivo"
        Me.pnlObjetivo.Size = New System.Drawing.Size(563, 301)
        Me.pnlObjetivo.TabIndex = 16
        Me.pnlObjetivo.Visible = False
        '
        'butSalirObj
        '
        Me.butSalirObj.Location = New System.Drawing.Point(329, 263)
        Me.butSalirObj.Name = "butSalirObj"
        Me.butSalirObj.Size = New System.Drawing.Size(111, 23)
        Me.butSalirObj.TabIndex = 3
        Me.butSalirObj.Text = "Salir"
        Me.butSalirObj.UseVisualStyleBackColor = True
        '
        'butGuardarObj
        '
        Me.butGuardarObj.Location = New System.Drawing.Point(125, 263)
        Me.butGuardarObj.Name = "butGuardarObj"
        Me.butGuardarObj.Size = New System.Drawing.Size(111, 23)
        Me.butGuardarObj.TabIndex = 2
        Me.butGuardarObj.Text = "Guardar"
        Me.butGuardarObj.UseVisualStyleBackColor = True
        '
        'txtObjetivo
        '
        Me.txtObjetivo.AcceptsReturn = True
        Me.txtObjetivo.Location = New System.Drawing.Point(26, 47)
        Me.txtObjetivo.MaxLength = 250
        Me.txtObjetivo.Multiline = True
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObjetivo.Size = New System.Drawing.Size(505, 202)
        Me.txtObjetivo.TabIndex = 1
        '
        'lblCabObjetivo
        '
        Me.lblCabObjetivo.AutoSize = True
        Me.lblCabObjetivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabObjetivo.Location = New System.Drawing.Point(10, 11)
        Me.lblCabObjetivo.Name = "lblCabObjetivo"
        Me.lblCabObjetivo.Size = New System.Drawing.Size(51, 15)
        Me.lblCabObjetivo.TabIndex = 0
        Me.lblCabObjetivo.Text = "Label5"
        '
        'pnlDuracion
        '
        Me.pnlDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDuracion.Controls.Add(Me.butSalDuracion)
        Me.pnlDuracion.Controls.Add(Me.butGuardarDuracion)
        Me.pnlDuracion.Controls.Add(Me.Label6)
        Me.pnlDuracion.Controls.Add(Me.nuDuracion)
        Me.pnlDuracion.Controls.Add(Me.Label5)
        Me.pnlDuracion.Controls.Add(Me.lblDuracionSys)
        Me.pnlDuracion.Controls.Add(Me.lblDuracionActual)
        Me.pnlDuracion.Controls.Add(Me.lblCabDuracion)
        Me.pnlDuracion.Location = New System.Drawing.Point(211, 355)
        Me.pnlDuracion.Name = "pnlDuracion"
        Me.pnlDuracion.Size = New System.Drawing.Size(642, 210)
        Me.pnlDuracion.TabIndex = 17
        Me.pnlDuracion.Visible = False
        '
        'butSalDuracion
        '
        Me.butSalDuracion.Location = New System.Drawing.Point(367, 156)
        Me.butSalDuracion.Name = "butSalDuracion"
        Me.butSalDuracion.Size = New System.Drawing.Size(147, 23)
        Me.butSalDuracion.TabIndex = 10
        Me.butSalDuracion.Text = "Salir"
        Me.butSalDuracion.UseVisualStyleBackColor = True
        '
        'butGuardarDuracion
        '
        Me.butGuardarDuracion.Location = New System.Drawing.Point(135, 156)
        Me.butGuardarDuracion.Name = "butGuardarDuracion"
        Me.butGuardarDuracion.Size = New System.Drawing.Size(147, 23)
        Me.butGuardarDuracion.TabIndex = 9
        Me.butGuardarDuracion.Text = "Guardar"
        Me.butGuardarDuracion.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(284, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(257, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "días ( recuerde no puede superar 4 semanas)"
        '
        'nuDuracion
        '
        Me.nuDuracion.Location = New System.Drawing.Point(234, 101)
        Me.nuDuracion.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nuDuracion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuDuracion.Name = "nuDuracion"
        Me.nuDuracion.Size = New System.Drawing.Size(44, 20)
        Me.nuDuracion.TabIndex = 7
        Me.nuDuracion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(108, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Duración del Sprint"
        '
        'lblDuracionSys
        '
        Me.lblDuracionSys.AutoSize = True
        Me.lblDuracionSys.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracionSys.ForeColor = System.Drawing.Color.Olive
        Me.lblDuracionSys.Location = New System.Drawing.Point(17, 67)
        Me.lblDuracionSys.Name = "lblDuracionSys"
        Me.lblDuracionSys.Size = New System.Drawing.Size(51, 15)
        Me.lblDuracionSys.TabIndex = 2
        Me.lblDuracionSys.Text = "Label5"
        '
        'lblDuracionActual
        '
        Me.lblDuracionActual.AutoSize = True
        Me.lblDuracionActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracionActual.ForeColor = System.Drawing.Color.Blue
        Me.lblDuracionActual.Location = New System.Drawing.Point(17, 40)
        Me.lblDuracionActual.Name = "lblDuracionActual"
        Me.lblDuracionActual.Size = New System.Drawing.Size(51, 15)
        Me.lblDuracionActual.TabIndex = 1
        Me.lblDuracionActual.Text = "Label5"
        '
        'lblCabDuracion
        '
        Me.lblCabDuracion.AutoSize = True
        Me.lblCabDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCabDuracion.Location = New System.Drawing.Point(5, 4)
        Me.lblCabDuracion.Name = "lblCabDuracion"
        Me.lblCabDuracion.Size = New System.Drawing.Size(51, 15)
        Me.lblCabDuracion.TabIndex = 0
        Me.lblCabDuracion.Text = "Label5"
        '
        'frmDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 635)
        Me.Controls.Add(Me.pnlDuracion)
        Me.Controls.Add(Me.pnlObjetivo)
        Me.Controls.Add(Me.pnlSelSprint)
        Me.Controls.Add(Me.pnlQuienSoy)
        Me.Controls.Add(Me.pnlEquipo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SCRUM Wizard - Development Team Member"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlEquipo.ResumeLayout(False)
        Me.pnlEquipo.PerformLayout()
        CType(Me.DGVEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuienSoy.ResumeLayout(False)
        Me.pnlQuienSoy.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlSelSprint.ResumeLayout(False)
        Me.pnlSelSprint.PerformLayout()
        Me.pnlObjetivo.ResumeLayout(False)
        Me.pnlObjetivo.PerformLayout()
        Me.pnlDuracion.ResumeLayout(False)
        Me.pnlDuracion.PerformLayout()
        CType(Me.nuDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlEquipo As System.Windows.Forms.Panel
    Friend WithEvents butListo As System.Windows.Forms.Button
    Friend WithEvents DGVEquipo As System.Windows.Forms.DataGridView
    Friend WithEvents NPerson As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEquipo As System.Windows.Forms.Label
    Friend WithEvents pnlQuienSoy As System.Windows.Forms.Panel
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents ButSalir As System.Windows.Forms.Button
    Friend WithEvents butGuardar As System.Windows.Forms.Button
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SprintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SprintBacklogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComposiciónEquipoDeProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FijarObjetivoDeSprintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneraciónInformeSgtoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrrarSprintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlSelSprint As System.Windows.Forms.Panel
    Friend WithEvents butSSalir As System.Windows.Forms.Button
    Friend WithEvents butSeleccionar As System.Windows.Forms.Button
    Friend WithEvents lstSelSprint As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstAux As System.Windows.Forms.ListBox
    Friend WithEvents pnlObjetivo As System.Windows.Forms.Panel
    Friend WithEvents butSalirObj As System.Windows.Forms.Button
    Friend WithEvents butGuardarObj As System.Windows.Forms.Button
    Friend WithEvents txtObjetivo As System.Windows.Forms.TextBox
    Friend WithEvents lblCabObjetivo As System.Windows.Forms.Label
    Friend WithEvents EstablecerDuracionSprintMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlDuracion As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDuracionSys As System.Windows.Forms.Label
    Friend WithEvents lblDuracionActual As System.Windows.Forms.Label
    Friend WithEvents lblCabDuracion As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nuDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents butSalDuracion As System.Windows.Forms.Button
    Friend WithEvents butGuardarDuracion As System.Windows.Forms.Button
End Class
