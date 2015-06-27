<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciónDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónDeEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmistrarCuentaadminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBUsuarios = New System.Windows.Forms.GroupBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.butEliminar = New System.Windows.Forms.Button()
        Me.butCambiar = New System.Windows.Forms.Button()
        Me.butNuevo = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DGVUsuarios = New System.Windows.Forms.DataGridView()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Original = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBEquipos = New System.Windows.Forms.GroupBox()
        Me.butVerEquipo = New System.Windows.Forms.Button()
        Me.butIncluir = New System.Windows.Forms.Button()
        Me.pnlNuevos = New System.Windows.Forms.Panel()
        Me.butBorrar = New System.Windows.Forms.Button()
        Me.butSeleccionar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVRoles = New System.Windows.Forms.DataGridView()
        Me.IdRRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVUsers = New System.Windows.Forms.DataGridView()
        Me.IdUsuarios1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuarios1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVCompEq = New System.Windows.Forms.DataGridView()
        Me.NUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDRo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCompEquipo = New System.Windows.Forms.Label()
        Me.butEliminarE = New System.Windows.Forms.Button()
        Me.butCambiarE = New System.Windows.Forms.Button()
        Me.butNuevoE = New System.Windows.Forms.Button()
        Me.txtNombreEquipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.butSalirE = New System.Windows.Forms.Button()
        Me.DGVEquipos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbAdmin = New System.Windows.Forms.GroupBox()
        Me.txtCAdmin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNAdmin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.butCAdmin = New System.Windows.Forms.Button()
        Me.butCSalir = New System.Windows.Forms.Button()
        Me.pnlEquipo = New System.Windows.Forms.Panel()
        Me.butListo = New System.Windows.Forms.Button()
        Me.DGVEquipo = New System.Windows.Forms.DataGridView()
        Me.NPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GBUsuarios.SuspendLayout()
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEquipos.SuspendLayout()
        Me.pnlNuevos.SuspendLayout()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCompEq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAdmin.SuspendLayout()
        Me.pnlEquipo.SuspendLayout()
        CType(Me.DGVEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónDeUsuariosToolStripMenuItem, Me.AdministraciónDeEquiposToolStripMenuItem, Me.SalirToolStripMenuItem, Me.AdmistrarCuentaadminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónDeUsuariosToolStripMenuItem
        '
        Me.AdministraciónDeUsuariosToolStripMenuItem.Name = "AdministraciónDeUsuariosToolStripMenuItem"
        Me.AdministraciónDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(164, 20)
        Me.AdministraciónDeUsuariosToolStripMenuItem.Text = "Administración de &Usuarios"
        '
        'AdministraciónDeEquiposToolStripMenuItem
        '
        Me.AdministraciónDeEquiposToolStripMenuItem.Name = "AdministraciónDeEquiposToolStripMenuItem"
        Me.AdministraciónDeEquiposToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.AdministraciónDeEquiposToolStripMenuItem.Text = "Administración de &Equipos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'AdmistrarCuentaadminToolStripMenuItem
        '
        Me.AdmistrarCuentaadminToolStripMenuItem.Name = "AdmistrarCuentaadminToolStripMenuItem"
        Me.AdmistrarCuentaadminToolStripMenuItem.Size = New System.Drawing.Size(157, 20)
        Me.AdmistrarCuentaadminToolStripMenuItem.Text = "Admistrar cuenta ""admin"""
        '
        'GBUsuarios
        '
        Me.GBUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GBUsuarios.Controls.Add(Me.txtClave)
        Me.GBUsuarios.Controls.Add(Me.Label2)
        Me.GBUsuarios.Controls.Add(Me.butEliminar)
        Me.GBUsuarios.Controls.Add(Me.butCambiar)
        Me.GBUsuarios.Controls.Add(Me.butNuevo)
        Me.GBUsuarios.Controls.Add(Me.txtNombre)
        Me.GBUsuarios.Controls.Add(Me.Label1)
        Me.GBUsuarios.Controls.Add(Me.btnSalir)
        Me.GBUsuarios.Controls.Add(Me.DGVUsuarios)
        Me.GBUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBUsuarios.Location = New System.Drawing.Point(30, 56)
        Me.GBUsuarios.Name = "GBUsuarios"
        Me.GBUsuarios.Size = New System.Drawing.Size(901, 371)
        Me.GBUsuarios.TabIndex = 1
        Me.GBUsuarios.TabStop = False
        Me.GBUsuarios.Text = "Administración de Usuarios"
        Me.GBUsuarios.Visible = False
        '
        'txtClave
        '
        Me.txtClave.Enabled = False
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(168, 334)
        Me.txtClave.MaxLength = 50
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(425, 22)
        Me.txtClave.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Clave Usuario"
        '
        'butEliminar
        '
        Me.butEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEliminar.Location = New System.Drawing.Point(649, 333)
        Me.butEliminar.Name = "butEliminar"
        Me.butEliminar.Size = New System.Drawing.Size(75, 23)
        Me.butEliminar.TabIndex = 3
        Me.butEliminar.Text = "Eliminar"
        Me.butEliminar.UseVisualStyleBackColor = True
        '
        'butCambiar
        '
        Me.butCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCambiar.Location = New System.Drawing.Point(694, 304)
        Me.butCambiar.Name = "butCambiar"
        Me.butCambiar.Size = New System.Drawing.Size(75, 23)
        Me.butCambiar.TabIndex = 4
        Me.butCambiar.Text = "Cambiar"
        Me.butCambiar.UseVisualStyleBackColor = True
        '
        'butNuevo
        '
        Me.butNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butNuevo.Location = New System.Drawing.Point(613, 304)
        Me.butNuevo.Name = "butNuevo"
        Me.butNuevo.Size = New System.Drawing.Size(75, 23)
        Me.butNuevo.TabIndex = 5
        Me.butNuevo.Text = "Nuevo"
        Me.butNuevo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(168, 301)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(425, 22)
        Me.txtNombre.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre Usuario"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(803, 40)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DGVUsuarios
        '
        Me.DGVUsuarios.AllowUserToAddRows = False
        Me.DGVUsuarios.AllowUserToDeleteRows = False
        Me.DGVUsuarios.AllowUserToResizeColumns = False
        Me.DGVUsuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUsuarios.ColumnHeadersHeight = 30
        Me.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuario, Me.NUsuario, Me.Clave, Me.Original})
        Me.DGVUsuarios.Location = New System.Drawing.Point(51, 40)
        Me.DGVUsuarios.Name = "DGVUsuarios"
        Me.DGVUsuarios.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVUsuarios.Size = New System.Drawing.Size(718, 255)
        Me.DGVUsuarios.TabIndex = 0
        '
        'IdUsuario
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdUsuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.IdUsuario.HeaderText = "Id Usuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Width = 75
        '
        'NUsuario
        '
        Me.NUsuario.HeaderText = "Nombre de Usuario"
        Me.NUsuario.Name = "NUsuario"
        Me.NUsuario.ReadOnly = True
        Me.NUsuario.Width = 300
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave Usuario"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        Me.Clave.Width = 300
        '
        'Original
        '
        Me.Original.HeaderText = "Original"
        Me.Original.Name = "Original"
        Me.Original.ReadOnly = True
        Me.Original.Visible = False
        '
        'GBEquipos
        '
        Me.GBEquipos.AutoSize = True
        Me.GBEquipos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GBEquipos.Controls.Add(Me.butVerEquipo)
        Me.GBEquipos.Controls.Add(Me.butIncluir)
        Me.GBEquipos.Controls.Add(Me.pnlNuevos)
        Me.GBEquipos.Controls.Add(Me.butEliminarE)
        Me.GBEquipos.Controls.Add(Me.butCambiarE)
        Me.GBEquipos.Controls.Add(Me.butNuevoE)
        Me.GBEquipos.Controls.Add(Me.txtNombreEquipo)
        Me.GBEquipos.Controls.Add(Me.Label4)
        Me.GBEquipos.Controls.Add(Me.butSalirE)
        Me.GBEquipos.Controls.Add(Me.DGVEquipos)
        Me.GBEquipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEquipos.Location = New System.Drawing.Point(30, 50)
        Me.GBEquipos.Name = "GBEquipos"
        Me.GBEquipos.Size = New System.Drawing.Size(1213, 404)
        Me.GBEquipos.TabIndex = 2
        Me.GBEquipos.TabStop = False
        Me.GBEquipos.Text = "Administración de Equipos"
        Me.GBEquipos.Visible = False
        '
        'butVerEquipo
        '
        Me.butVerEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerEquipo.Location = New System.Drawing.Point(60, 360)
        Me.butVerEquipo.Name = "butVerEquipo"
        Me.butVerEquipo.Size = New System.Drawing.Size(154, 23)
        Me.butVerEquipo.TabIndex = 12
        Me.butVerEquipo.Text = "Ver Componentes"
        Me.butVerEquipo.UseVisualStyleBackColor = True
        '
        'butIncluir
        '
        Me.butIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butIncluir.Location = New System.Drawing.Point(292, 331)
        Me.butIncluir.Name = "butIncluir"
        Me.butIncluir.Size = New System.Drawing.Size(134, 23)
        Me.butIncluir.TabIndex = 11
        Me.butIncluir.Text = "Incluir"
        Me.butIncluir.UseVisualStyleBackColor = True
        Me.butIncluir.Visible = False
        '
        'pnlNuevos
        '
        Me.pnlNuevos.Controls.Add(Me.butBorrar)
        Me.pnlNuevos.Controls.Add(Me.butSeleccionar)
        Me.pnlNuevos.Controls.Add(Me.Label5)
        Me.pnlNuevos.Controls.Add(Me.DGVRoles)
        Me.pnlNuevos.Controls.Add(Me.DGVUsers)
        Me.pnlNuevos.Controls.Add(Me.Label3)
        Me.pnlNuevos.Controls.Add(Me.DGVCompEq)
        Me.pnlNuevos.Controls.Add(Me.lblCompEquipo)
        Me.pnlNuevos.Location = New System.Drawing.Point(441, 40)
        Me.pnlNuevos.Name = "pnlNuevos"
        Me.pnlNuevos.Size = New System.Drawing.Size(669, 314)
        Me.pnlNuevos.TabIndex = 10
        Me.pnlNuevos.Visible = False
        '
        'butBorrar
        '
        Me.butBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butBorrar.Location = New System.Drawing.Point(22, 282)
        Me.butBorrar.Name = "butBorrar"
        Me.butBorrar.Size = New System.Drawing.Size(366, 23)
        Me.butBorrar.TabIndex = 19
        Me.butBorrar.Text = "Quitar Componente Seleccionado"
        Me.butBorrar.UseVisualStyleBackColor = True
        Me.butBorrar.Visible = False
        '
        'butSeleccionar
        '
        Me.butSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSeleccionar.Location = New System.Drawing.Point(408, 283)
        Me.butSeleccionar.Name = "butSeleccionar"
        Me.butSeleccionar.Size = New System.Drawing.Size(247, 23)
        Me.butSeleccionar.TabIndex = 14
        Me.butSeleccionar.Text = "Seleccionar"
        Me.butSeleccionar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Roles"
        '
        'DGVRoles
        '
        Me.DGVRoles.AllowUserToAddRows = False
        Me.DGVRoles.AllowUserToDeleteRows = False
        Me.DGVRoles.AllowUserToResizeColumns = False
        Me.DGVRoles.AllowUserToResizeRows = False
        Me.DGVRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRRol, Me.RRol, Me.ColEli})
        Me.DGVRoles.Location = New System.Drawing.Point(408, 165)
        Me.DGVRoles.MultiSelect = False
        Me.DGVRoles.Name = "DGVRoles"
        Me.DGVRoles.ReadOnly = True
        Me.DGVRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVRoles.Size = New System.Drawing.Size(247, 106)
        Me.DGVRoles.TabIndex = 12
        '
        'IdRRol
        '
        Me.IdRRol.HeaderText = "IdRol"
        Me.IdRRol.Name = "IdRRol"
        Me.IdRRol.ReadOnly = True
        Me.IdRRol.Visible = False
        '
        'RRol
        '
        Me.RRol.HeaderText = "Rol"
        Me.RRol.Name = "RRol"
        Me.RRol.ReadOnly = True
        Me.RRol.Width = 200
        '
        'ColEli
        '
        Me.ColEli.HeaderText = "ColEli"
        Me.ColEli.Name = "ColEli"
        Me.ColEli.ReadOnly = True
        Me.ColEli.Visible = False
        '
        'DGVUsers
        '
        Me.DGVUsers.AllowUserToAddRows = False
        Me.DGVUsers.AllowUserToDeleteRows = False
        Me.DGVUsers.AllowUserToResizeColumns = False
        Me.DGVUsers.AllowUserToResizeRows = False
        Me.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuarios1, Me.Usuarios1, Me.ColEl})
        Me.DGVUsers.Location = New System.Drawing.Point(408, 20)
        Me.DGVUsers.MultiSelect = False
        Me.DGVUsers.Name = "DGVUsers"
        Me.DGVUsers.ReadOnly = True
        Me.DGVUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVUsers.Size = New System.Drawing.Size(247, 114)
        Me.DGVUsers.TabIndex = 10
        '
        'IdUsuarios1
        '
        Me.IdUsuarios1.HeaderText = "IdUsuario"
        Me.IdUsuarios1.Name = "IdUsuarios1"
        Me.IdUsuarios1.ReadOnly = True
        Me.IdUsuarios1.Visible = False
        '
        'Usuarios1
        '
        Me.Usuarios1.HeaderText = "Usuarios"
        Me.Usuarios1.Name = "Usuarios1"
        Me.Usuarios1.ReadOnly = True
        Me.Usuarios1.Width = 200
        '
        'ColEl
        '
        Me.ColEl.HeaderText = "ColEl"
        Me.ColEl.Name = "ColEl"
        Me.ColEl.ReadOnly = True
        Me.ColEl.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Usuarios"
        '
        'DGVCompEq
        '
        Me.DGVCompEq.AllowUserToAddRows = False
        Me.DGVCompEq.AllowUserToDeleteRows = False
        Me.DGVCompEq.AllowUserToResizeColumns = False
        Me.DGVCompEq.AllowUserToResizeRows = False
        Me.DGVCompEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCompEq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUser, Me.Rol, Me.IdUs, Me.IDRo})
        Me.DGVCompEq.Location = New System.Drawing.Point(5, 20)
        Me.DGVCompEq.MultiSelect = False
        Me.DGVCompEq.Name = "DGVCompEq"
        Me.DGVCompEq.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVCompEq.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVCompEq.Size = New System.Drawing.Size(394, 260)
        Me.DGVCompEq.TabIndex = 8
        '
        'NUser
        '
        Me.NUser.HeaderText = "Usuario"
        Me.NUser.Name = "NUser"
        Me.NUser.ReadOnly = True
        Me.NUser.Width = 200
        '
        'Rol
        '
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.ReadOnly = True
        Me.Rol.Width = 150
        '
        'IdUs
        '
        Me.IdUs.HeaderText = "IdUsuario"
        Me.IdUs.Name = "IdUs"
        Me.IdUs.ReadOnly = True
        Me.IdUs.Visible = False
        '
        'IDRo
        '
        Me.IDRo.HeaderText = "IDRol"
        Me.IDRo.Name = "IDRo"
        Me.IDRo.ReadOnly = True
        Me.IDRo.Visible = False
        '
        'lblCompEquipo
        '
        Me.lblCompEquipo.AutoSize = True
        Me.lblCompEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompEquipo.Location = New System.Drawing.Point(6, 2)
        Me.lblCompEquipo.Name = "lblCompEquipo"
        Me.lblCompEquipo.Size = New System.Drawing.Size(168, 15)
        Me.lblCompEquipo.TabIndex = 9
        Me.lblCompEquipo.Text = "Componentes del Equipo"
        '
        'butEliminarE
        '
        Me.butEliminarE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEliminarE.Location = New System.Drawing.Point(185, 331)
        Me.butEliminarE.Name = "butEliminarE"
        Me.butEliminarE.Size = New System.Drawing.Size(75, 23)
        Me.butEliminarE.TabIndex = 3
        Me.butEliminarE.Text = "Eliminar"
        Me.butEliminarE.UseVisualStyleBackColor = True
        '
        'butCambiarE
        '
        Me.butCambiarE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCambiarE.Location = New System.Drawing.Point(103, 331)
        Me.butCambiarE.Name = "butCambiarE"
        Me.butCambiarE.Size = New System.Drawing.Size(75, 23)
        Me.butCambiarE.TabIndex = 4
        Me.butCambiarE.Text = "Cambiar"
        Me.butCambiarE.UseVisualStyleBackColor = True
        '
        'butNuevoE
        '
        Me.butNuevoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butNuevoE.Location = New System.Drawing.Point(22, 331)
        Me.butNuevoE.Name = "butNuevoE"
        Me.butNuevoE.Size = New System.Drawing.Size(75, 23)
        Me.butNuevoE.TabIndex = 5
        Me.butNuevoE.Text = "Nuevo"
        Me.butNuevoE.UseVisualStyleBackColor = True
        '
        'txtNombreEquipo
        '
        Me.txtNombreEquipo.Enabled = False
        Me.txtNombreEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEquipo.Location = New System.Drawing.Point(130, 301)
        Me.txtNombreEquipo.MaxLength = 100
        Me.txtNombreEquipo.Name = "txtNombreEquipo"
        Me.txtNombreEquipo.Size = New System.Drawing.Size(296, 22)
        Me.txtNombreEquipo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre Equipo"
        '
        'butSalirE
        '
        Me.butSalirE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSalirE.Location = New System.Drawing.Point(1132, 21)
        Me.butSalirE.Name = "butSalirE"
        Me.butSalirE.Size = New System.Drawing.Size(75, 23)
        Me.butSalirE.TabIndex = 2
        Me.butSalirE.Text = "&Salir"
        Me.butSalirE.UseVisualStyleBackColor = True
        '
        'DGVEquipos
        '
        Me.DGVEquipos.AllowUserToAddRows = False
        Me.DGVEquipos.AllowUserToDeleteRows = False
        Me.DGVEquipos.AllowUserToResizeColumns = False
        Me.DGVEquipos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVEquipos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVEquipos.ColumnHeadersHeight = 30
        Me.DGVEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVEquipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.DGVEquipos.Location = New System.Drawing.Point(13, 40)
        Me.DGVEquipos.MultiSelect = False
        Me.DGVEquipos.Name = "DGVEquipos"
        Me.DGVEquipos.ReadOnly = True
        Me.DGVEquipos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVEquipos.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVEquipos.Size = New System.Drawing.Size(422, 255)
        Me.DGVEquipos.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Equipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre de Equipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Original"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'gbAdmin
        '
        Me.gbAdmin.AutoSize = True
        Me.gbAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbAdmin.Controls.Add(Me.txtCAdmin)
        Me.gbAdmin.Controls.Add(Me.Label7)
        Me.gbAdmin.Controls.Add(Me.txtNAdmin)
        Me.gbAdmin.Controls.Add(Me.Label6)
        Me.gbAdmin.Controls.Add(Me.butCAdmin)
        Me.gbAdmin.Controls.Add(Me.butCSalir)
        Me.gbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAdmin.Location = New System.Drawing.Point(13, 39)
        Me.gbAdmin.Name = "gbAdmin"
        Me.gbAdmin.Size = New System.Drawing.Size(458, 185)
        Me.gbAdmin.TabIndex = 12
        Me.gbAdmin.TabStop = False
        Me.gbAdmin.Text = "Administración cuenta ""admin"""
        Me.gbAdmin.Visible = False
        '
        'txtCAdmin
        '
        Me.txtCAdmin.Enabled = False
        Me.txtCAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAdmin.Location = New System.Drawing.Point(88, 97)
        Me.txtCAdmin.MaxLength = 100
        Me.txtCAdmin.Name = "txtCAdmin"
        Me.txtCAdmin.Size = New System.Drawing.Size(279, 22)
        Me.txtCAdmin.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Clave"
        '
        'txtNAdmin
        '
        Me.txtNAdmin.Enabled = False
        Me.txtNAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNAdmin.Location = New System.Drawing.Point(88, 64)
        Me.txtNAdmin.MaxLength = 100
        Me.txtNAdmin.Name = "txtNAdmin"
        Me.txtNAdmin.Size = New System.Drawing.Size(279, 22)
        Me.txtNAdmin.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombre"
        '
        'butCAdmin
        '
        Me.butCAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCAdmin.Location = New System.Drawing.Point(31, 141)
        Me.butCAdmin.Name = "butCAdmin"
        Me.butCAdmin.Size = New System.Drawing.Size(336, 23)
        Me.butCAdmin.TabIndex = 4
        Me.butCAdmin.Text = "Cambiar"
        Me.butCAdmin.UseVisualStyleBackColor = True
        '
        'butCSalir
        '
        Me.butCSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCSalir.Location = New System.Drawing.Point(377, 31)
        Me.butCSalir.Name = "butCSalir"
        Me.butCSalir.Size = New System.Drawing.Size(75, 23)
        Me.butCSalir.TabIndex = 2
        Me.butCSalir.Text = "&Salir"
        Me.butCSalir.UseVisualStyleBackColor = True
        '
        'pnlEquipo
        '
        Me.pnlEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEquipo.Controls.Add(Me.butListo)
        Me.pnlEquipo.Controls.Add(Me.DGVEquipo)
        Me.pnlEquipo.Controls.Add(Me.lblEquipo)
        Me.pnlEquipo.Location = New System.Drawing.Point(4, 180)
        Me.pnlEquipo.Name = "pnlEquipo"
        Me.pnlEquipo.Size = New System.Drawing.Size(714, 363)
        Me.pnlEquipo.TabIndex = 14
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
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 517)
        Me.Controls.Add(Me.pnlEquipo)
        Me.Controls.Add(Me.GBEquipos)
        Me.Controls.Add(Me.GBUsuarios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbAdmin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdmin"
        Me.Text = "SCRUM Wizard - Administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBUsuarios.ResumeLayout(False)
        Me.GBUsuarios.PerformLayout()
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEquipos.ResumeLayout(False)
        Me.GBEquipos.PerformLayout()
        Me.pnlNuevos.ResumeLayout(False)
        Me.pnlNuevos.PerformLayout()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCompEq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAdmin.ResumeLayout(False)
        Me.gbAdmin.PerformLayout()
        Me.pnlEquipo.ResumeLayout(False)
        Me.pnlEquipo.PerformLayout()
        CType(Me.DGVEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministraciónDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDeEquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GBUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents DGVUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents IdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Original As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents butCambiar As System.Windows.Forms.Button
    Friend WithEvents butEliminar As System.Windows.Forms.Button
    Friend WithEvents butNuevo As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBEquipos As System.Windows.Forms.GroupBox
    Friend WithEvents butEliminarE As System.Windows.Forms.Button
    Friend WithEvents butCambiarE As System.Windows.Forms.Button
    Friend WithEvents butNuevoE As System.Windows.Forms.Button
    Friend WithEvents txtNombreEquipo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents butSalirE As System.Windows.Forms.Button
    Friend WithEvents DGVEquipos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlNuevos As System.Windows.Forms.Panel
    Friend WithEvents DGVCompEq As System.Windows.Forms.DataGridView
    Friend WithEvents lblCompEquipo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGVRoles As System.Windows.Forms.DataGridView
    Friend WithEvents DGVUsers As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents butSeleccionar As System.Windows.Forms.Button
    Friend WithEvents NUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDRo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents butIncluir As System.Windows.Forms.Button
    Friend WithEvents butBorrar As System.Windows.Forms.Button
    Friend WithEvents IdRRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColEli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUsuarios1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuarios1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColEl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdmistrarCuentaadminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbAdmin As System.Windows.Forms.GroupBox
    Friend WithEvents butCAdmin As System.Windows.Forms.Button
    Friend WithEvents butCSalir As System.Windows.Forms.Button
    Friend WithEvents txtCAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents butVerEquipo As System.Windows.Forms.Button
    Friend WithEvents pnlEquipo As System.Windows.Forms.Panel
    Friend WithEvents butListo As System.Windows.Forms.Button
    Friend WithEvents DGVEquipo As System.Windows.Forms.DataGridView
    Friend WithEvents NPerson As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEquipo As System.Windows.Forms.Label
End Class
