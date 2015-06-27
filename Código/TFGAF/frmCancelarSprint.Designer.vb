<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelarSprint
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
        Me.pnlCancelarSprint = New System.Windows.Forms.Panel()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.butCancelarSprint = New System.Windows.Forms.Button()
        Me.lstAux = New System.Windows.Forms.ListBox()
        Me.lstSelSprint = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlCancelarSprint.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCancelarSprint
        '
        Me.pnlCancelarSprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCancelarSprint.Controls.Add(Me.lstAux)
        Me.pnlCancelarSprint.Controls.Add(Me.lstSelSprint)
        Me.pnlCancelarSprint.Controls.Add(Me.Label4)
        Me.pnlCancelarSprint.Controls.Add(Me.butCancelarSprint)
        Me.pnlCancelarSprint.Controls.Add(Me.butSalir)
        Me.pnlCancelarSprint.Location = New System.Drawing.Point(12, 12)
        Me.pnlCancelarSprint.Name = "pnlCancelarSprint"
        Me.pnlCancelarSprint.Size = New System.Drawing.Size(201, 406)
        Me.pnlCancelarSprint.TabIndex = 0
        '
        'butSalir
        '
        Me.butSalir.Location = New System.Drawing.Point(40, 369)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(111, 23)
        Me.butSalir.TabIndex = 1
        Me.butSalir.Text = "Salir"
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'butCancelarSprint
        '
        Me.butCancelarSprint.Location = New System.Drawing.Point(40, 340)
        Me.butCancelarSprint.Name = "butCancelarSprint"
        Me.butCancelarSprint.Size = New System.Drawing.Size(111, 23)
        Me.butCancelarSprint.TabIndex = 2
        Me.butCancelarSprint.Text = "Cancelar Sprint"
        Me.butCancelarSprint.UseVisualStyleBackColor = True
        '
        'lstAux
        '
        Me.lstAux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAux.FormattingEnabled = True
        Me.lstAux.ItemHeight = 15
        Me.lstAux.Location = New System.Drawing.Point(20, 53)
        Me.lstAux.Name = "lstAux"
        Me.lstAux.Size = New System.Drawing.Size(154, 62)
        Me.lstAux.TabIndex = 7
        Me.lstAux.Visible = False
        '
        'lstSelSprint
        '
        Me.lstSelSprint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSelSprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelSprint.FormattingEnabled = True
        Me.lstSelSprint.ItemHeight = 15
        Me.lstSelSprint.Location = New System.Drawing.Point(20, 26)
        Me.lstSelSprint.Name = "lstSelSprint"
        Me.lstSelSprint.Size = New System.Drawing.Size(154, 300)
        Me.lstSelSprint.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Seleccione el Sprint"
        '
        'frmCancelarSprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 430)
        Me.Controls.Add(Me.pnlCancelarSprint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCancelarSprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmCancelarSprint"
        Me.pnlCancelarSprint.ResumeLayout(False)
        Me.pnlCancelarSprint.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCancelarSprint As System.Windows.Forms.Panel
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents butCancelarSprint As System.Windows.Forms.Button
    Friend WithEvents lstAux As System.Windows.Forms.ListBox
    Friend WithEvents lstSelSprint As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
