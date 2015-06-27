'Copyright (C) 2015, Angel Fernández

'
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports System.Data.OleDb
Public Class frmNotificaciones
    Dim notis(999) As Boolean

    Private Sub butNotSalir_Click(sender As Object, e As EventArgs) Handles butNotSalir.Click
        Dim resp As Integer

        If butNotGuardar.Tag = "" Then
            If butNotPasadas.Text <> "Volver" Then
                resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
            Else
                resp = vbYes
            End If
        Else
            resp = vbYes
        End If

        If resp = vbYes Then
            ' Salgo. Esto es crítico para la siguiente vez (no quitar ni de coña)

            DGVNotificaciones.Rows.Clear()
            DGVNotificaciones.EndEdit()
            ReDim notis(999)
            DGVNotPasadas.Visible = False
            DGVNotificaciones.Visible = True
            butNotGuardar.Enabled = True
            butNotPasadas.Text = "Ver no atendidas"
            butNotGuardar.Tag = ""
            Me.Close()

        Else
            ' No hago nada

        End If

    End Sub

    Private Sub frmNotificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim punto As New Point(50, 50)
        Me.Location = punto

        butNotGuardar.Tag = ""

        If CargaNotificaciones(DGVNotificaciones, DGVNotPasadas, notis) Then
            'todo bien

            If DGVNotificaciones.Tag = "NOHAY" Then
                butNotGuardar.Tag = "NOHAY"
                Me.Close()
            Else

            End If

            If DGVNotPasadas.Tag = "NOHAY" Then
                butNotPasadas.Enabled = False
            Else
                butNotPasadas.Enabled = True
            End If
        Else
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
        End If

    End Sub

 
    Private Sub butNotPasadas_Click(sender As Object, e As EventArgs) Handles butNotPasadas.Click
        If butNotPasadas.Text = "Volver" Then
            DGVNotificaciones.Visible = True
            DGVNotPasadas.Visible = False
            butNotGuardar.Enabled = True
            butNotPasadas.Text = "Ver no atendidas"
        Else
            DGVNotPasadas.Location = DGVNotificaciones.Location
            DGVNotPasadas.Width = DGVNotificaciones.Width
            DGVNotPasadas.Height = DGVNotificaciones.Height
            DGVNotificaciones.Visible = False
            DGVNotPasadas.Visible = True
            butNotGuardar.Enabled = False
            butNotPasadas.Text = "Volver"
        End If
    End Sub

    Private Sub butNotGuardar_Click(sender As Object, e As EventArgs) Handles butNotGuardar.Click

        If GuardarCambiosNotificaciones(DGVNotificaciones, notis) Then
            'no ha habido problemas
            butNotGuardar.Tag = "CERRAR"
            ReDim notis(999)
            Me.Close()
        Else
            butNotGuardar.Tag = ""
            'problemas
        End If

    End Sub

End Class