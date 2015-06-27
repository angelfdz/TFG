<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvocatoria
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlConvocatoria = New System.Windows.Forms.Panel()
        Me.pnlDetalleConvocatoria = New System.Windows.Forms.Panel()
        Me.txtFReunion = New System.Windows.Forms.MaskedTextBox()
        Me.txtHReunion = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.butAbandonar = New System.Windows.Forms.Button()
        Me.butEnviar = New System.Windows.Forms.Button()
        Me.DGVAsistentes = New System.Windows.Forms.DataGridView()
        Me.Asistente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbtYEnviadoN = New System.Windows.Forms.RadioButton()
        Me.rbtYEnviadoS = New System.Windows.Forms.RadioButton()
        Me.txtFComienzo = New System.Windows.Forms.TextBox()
        Me.txtSprint = New System.Windows.Forms.TextBox()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFReunion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.butSeleccionar = New System.Windows.Forms.Button()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVLSDisp = New System.Windows.Forms.DataGridView()
        Me.Sprint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtDReunion = New System.Windows.Forms.MaskedTextBox()
        Me.pnlConvocatoria.SuspendLayout()
        Me.pnlDetalleConvocatoria.SuspendLayout()
        CType(Me.DGVAsistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVLSDisp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlConvocatoria
        '
        Me.pnlConvocatoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConvocatoria.Controls.Add(Me.pnlDetalleConvocatoria)
        Me.pnlConvocatoria.Controls.Add(Me.butSeleccionar)
        Me.pnlConvocatoria.Controls.Add(Me.butSalir)
        Me.pnlConvocatoria.Controls.Add(Me.Label1)
        Me.pnlConvocatoria.Controls.Add(Me.DGVLSDisp)
        Me.pnlConvocatoria.Controls.Add(Me.lblTitulo)
        Me.pnlConvocatoria.Location = New System.Drawing.Point(12, 12)
        Me.pnlConvocatoria.Name = "pnlConvocatoria"
        Me.pnlConvocatoria.Size = New System.Drawing.Size(964, 353)
        Me.pnlConvocatoria.TabIndex = 0
        '
        'pnlDetalleConvocatoria
        '
        Me.pnlDetalleConvocatoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetalleConvocatoria.Controls.Add(Me.txtDReunion)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.txtFReunion)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.txtHReunion)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label11)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.butAbandonar)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.butEnviar)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.DGVAsistentes)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.rbtYEnviadoN)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.rbtYEnviadoS)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.txtFComienzo)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.txtSprint)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.txtProyecto)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label10)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label9)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label8)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label7)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.lblFReunion)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label5)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label4)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label3)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.Label2)
        Me.pnlDetalleConvocatoria.Controls.Add(Me.ShapeContainer1)
        Me.pnlDetalleConvocatoria.Location = New System.Drawing.Point(257, 56)
        Me.pnlDetalleConvocatoria.Name = "pnlDetalleConvocatoria"
        Me.pnlDetalleConvocatoria.Size = New System.Drawing.Size(470, 279)
        Me.pnlDetalleConvocatoria.TabIndex = 5
        '
        'txtFReunion
        '
        Me.txtFReunion.Location = New System.Drawing.Point(89, 94)
        Me.txtFReunion.Mask = "00/00/0000"
        Me.txtFReunion.Name = "txtFReunion"
        Me.txtFReunion.Size = New System.Drawing.Size(83, 20)
        Me.txtFReunion.TabIndex = 23
        Me.txtFReunion.ValidatingType = GetType(Date)
        '
        'txtHReunion
        '
        Me.txtHReunion.Location = New System.Drawing.Point(249, 94)
        Me.txtHReunion.Mask = "00:00"
        Me.txtHReunion.Name = "txtHReunion"
        Me.txtHReunion.Size = New System.Drawing.Size(56, 20)
        Me.txtHReunion.TabIndex = 22
        Me.txtHReunion.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(442, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "h"
        '
        'butAbandonar
        '
        Me.butAbandonar.Location = New System.Drawing.Point(318, 244)
        Me.butAbandonar.Name = "butAbandonar"
        Me.butAbandonar.Size = New System.Drawing.Size(140, 23)
        Me.butAbandonar.TabIndex = 20
        Me.butAbandonar.Text = "Abandonar"
        Me.butAbandonar.UseVisualStyleBackColor = True
        '
        'butEnviar
        '
        Me.butEnviar.Location = New System.Drawing.Point(318, 215)
        Me.butEnviar.Name = "butEnviar"
        Me.butEnviar.Size = New System.Drawing.Size(140, 23)
        Me.butEnviar.TabIndex = 19
        Me.butEnviar.Text = "Enviar Convocatoria"
        Me.butEnviar.UseVisualStyleBackColor = True
        '
        'DGVAsistentes
        '
        Me.DGVAsistentes.AllowUserToAddRows = False
        Me.DGVAsistentes.AllowUserToDeleteRows = False
        Me.DGVAsistentes.AllowUserToResizeColumns = False
        Me.DGVAsistentes.AllowUserToResizeRows = False
        Me.DGVAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVAsistentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Asistente, Me.Rol, Me.User})
        Me.DGVAsistentes.Location = New System.Drawing.Point(16, 147)
        Me.DGVAsistentes.Name = "DGVAsistentes"
        Me.DGVAsistentes.ReadOnly = True
        Me.DGVAsistentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVAsistentes.Size = New System.Drawing.Size(296, 124)
        Me.DGVAsistentes.TabIndex = 18
        '
        'Asistente
        '
        Me.Asistente.HeaderText = "Asistente"
        Me.Asistente.Name = "Asistente"
        Me.Asistente.ReadOnly = True
        Me.Asistente.Width = 125
        '
        'Rol
        '
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.ReadOnly = True
        Me.Rol.Width = 125
        '
        'User
        '
        Me.User.HeaderText = "IdUser"
        Me.User.Name = "User"
        Me.User.ReadOnly = True
        Me.User.Visible = False
        '
        'rbtYEnviadoN
        '
        Me.rbtYEnviadoN.AutoSize = True
        Me.rbtYEnviadoN.Location = New System.Drawing.Point(394, 165)
        Me.rbtYEnviadoN.Name = "rbtYEnviadoN"
        Me.rbtYEnviadoN.Size = New System.Drawing.Size(39, 17)
        Me.rbtYEnviadoN.TabIndex = 17
        Me.rbtYEnviadoN.TabStop = True
        Me.rbtYEnviadoN.Text = "No"
        Me.rbtYEnviadoN.UseVisualStyleBackColor = True
        '
        'rbtYEnviadoS
        '
        Me.rbtYEnviadoS.AutoSize = True
        Me.rbtYEnviadoS.Location = New System.Drawing.Point(352, 165)
        Me.rbtYEnviadoS.Name = "rbtYEnviadoS"
        Me.rbtYEnviadoS.Size = New System.Drawing.Size(36, 17)
        Me.rbtYEnviadoS.TabIndex = 16
        Me.rbtYEnviadoS.TabStop = True
        Me.rbtYEnviadoS.Text = "Sí"
        Me.rbtYEnviadoS.UseVisualStyleBackColor = True
        '
        'txtFComienzo
        '
        Me.txtFComienzo.Location = New System.Drawing.Point(244, 62)
        Me.txtFComienzo.Name = "txtFComienzo"
        Me.txtFComienzo.Size = New System.Drawing.Size(81, 20)
        Me.txtFComienzo.TabIndex = 12
        '
        'txtSprint
        '
        Me.txtSprint.Location = New System.Drawing.Point(73, 62)
        Me.txtSprint.Name = "txtSprint"
        Me.txtSprint.Size = New System.Drawing.Size(54, 20)
        Me.txtSprint.TabIndex = 11
        '
        'txtProyecto
        '
        Me.txtProyecto.Location = New System.Drawing.Point(73, 33)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.Size = New System.Drawing.Size(370, 20)
        Me.txtProyecto.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(353, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Ya Enviado?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Asistentes:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Duración Reunión:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hora Reunión:"
        '
        'lblFReunion
        '
        Me.lblFReunion.AutoSize = True
        Me.lblFReunion.Location = New System.Drawing.Point(15, 98)
        Me.lblFReunion.Name = "lblFReunion"
        Me.lblFReunion.Size = New System.Drawing.Size(74, 13)
        Me.lblFReunion.TabIndex = 5
        Me.lblFReunion.Text = "Fec. Reunión:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Comienzo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sprint:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proyecto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reunión de Planificación de Sprint"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(468, 277)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 6
        Me.LineShape1.X2 = 443
        Me.LineShape1.Y1 = 24
        Me.LineShape1.Y2 = 24
        '
        'butSeleccionar
        '
        Me.butSeleccionar.Location = New System.Drawing.Point(43, 293)
        Me.butSeleccionar.Name = "butSeleccionar"
        Me.butSeleccionar.Size = New System.Drawing.Size(147, 23)
        Me.butSeleccionar.TabIndex = 4
        Me.butSeleccionar.Text = "Seleccionar"
        Me.butSeleccionar.UseVisualStyleBackColor = True
        '
        'butSalir
        '
        Me.butSalir.Location = New System.Drawing.Point(163, 10)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(75, 23)
        Me.butSalir.TabIndex = 3
        Me.butSalir.Text = "Salir"
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de Sprint disponibles"
        '
        'DGVLSDisp
        '
        Me.DGVLSDisp.AllowUserToAddRows = False
        Me.DGVLSDisp.AllowUserToDeleteRows = False
        Me.DGVLSDisp.AllowUserToResizeColumns = False
        Me.DGVLSDisp.AllowUserToResizeRows = False
        Me.DGVLSDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVLSDisp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sprint, Me.FC})
        Me.DGVLSDisp.Location = New System.Drawing.Point(11, 56)
        Me.DGVLSDisp.Name = "DGVLSDisp"
        Me.DGVLSDisp.ReadOnly = True
        Me.DGVLSDisp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVLSDisp.Size = New System.Drawing.Size(221, 231)
        Me.DGVLSDisp.TabIndex = 1
        '
        'Sprint
        '
        Me.Sprint.HeaderText = "Sprint"
        Me.Sprint.Name = "Sprint"
        Me.Sprint.ReadOnly = True
        Me.Sprint.Width = 75
        '
        'FC
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FC.DefaultCellStyle = DataGridViewCellStyle1
        Me.FC.HeaderText = "Fecha Comienzo"
        Me.FC.Name = "FC"
        Me.FC.ReadOnly = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(8, 7)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(55, 16)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Label1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtDReunion
        '
        Me.txtDReunion.Location = New System.Drawing.Point(401, 94)
        Me.txtDReunion.Mask = "00:00"
        Me.txtDReunion.Name = "txtDReunion"
        Me.txtDReunion.Size = New System.Drawing.Size(39, 20)
        Me.txtDReunion.TabIndex = 24
        '
        'frmConvocatoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 377)
        Me.Controls.Add(Me.pnlConvocatoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(75, 75)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConvocatoria"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "NoVacio"
        Me.Text = "frmConvocatoria"
        Me.pnlConvocatoria.ResumeLayout(False)
        Me.pnlConvocatoria.PerformLayout()
        Me.pnlDetalleConvocatoria.ResumeLayout(False)
        Me.pnlDetalleConvocatoria.PerformLayout()
        CType(Me.DGVAsistentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVLSDisp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlConvocatoria As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVLSDisp As System.Windows.Forms.DataGridView
    Friend WithEvents Sprint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents pnlDetalleConvocatoria As System.Windows.Forms.Panel
    Friend WithEvents butSeleccionar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblFReunion As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents butAbandonar As System.Windows.Forms.Button
    Friend WithEvents butEnviar As System.Windows.Forms.Button
    Friend WithEvents DGVAsistentes As System.Windows.Forms.DataGridView
    Friend WithEvents rbtYEnviadoN As System.Windows.Forms.RadioButton
    Friend WithEvents rbtYEnviadoS As System.Windows.Forms.RadioButton
    Friend WithEvents txtFComienzo As System.Windows.Forms.TextBox
    Friend WithEvents txtSprint As System.Windows.Forms.TextBox
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFReunion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHReunion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Asistente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDReunion As System.Windows.Forms.MaskedTextBox
End Class
