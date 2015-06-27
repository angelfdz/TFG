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
Public Class frmSM



    Private Sub NotificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificacionesToolStripMenuItem.Click
        frmNotificaciones.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmSM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim HayPB As Integer = 0
        ' muestro info de quién y dónde estoy
        txtUsuario.Text = DameUsuario(IDUSER)
        txtRol.Text = DameRol()
        If IDPROYECTO = 0 Then
            txtProyecto.Text = "Sin Proyecto"

            MsgBox("No ha elegido proyecto," & vbNewLine & vbNewLine & "Debe elegir un proyecto para poder seguir.", MsgBoxStyle.Critical, "SCRUM Wizard")
            ConovocatoriasToolStripMenuItem.Enabled = False
            VerIntegrantesEquipoToolStripMenuItem.Enabled = False
            NotificacionesToolStripMenuItem.Enabled = False
            SalirToolStripMenuItem.Enabled = True

        Else
            txtProyecto.Text = DameProyecto()
            txtProyecto.Tag = DameNS()
            txtRol.Tag = DameDS()
            ' busco si ya tiene product backlog en cuyo caso solo habilito modifiar, en otro caso alterar
            HayPB = DamePB()
            If HayPB = 0 Then   ' no hay PB => crear un nuevo PB
                MsgBox("No existe 'Product Backlog' asociado a este proyecto," & vbNewLine & vbNewLine & "Por favor, informe al PO para poder seguir.", MsgBoxStyle.Critical, "SCRUM Wizard")
                ConovocatoriasToolStripMenuItem.Enabled = False
                VerIntegrantesEquipoToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = False
                SalirToolStripMenuItem.Enabled = True
                ActivarSprintToolStripMenuItem.Enabled = False
            Else                'hay PB => refinamiento PB existente
                ConovocatoriasToolStripMenuItem.Enabled = True
                NotificacionesToolStripMenuItem.Enabled = True
                VerIntegrantesEquipoToolStripMenuItem.Enabled = True
                SalirToolStripMenuItem.Enabled = True
                ActivarSprintToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub butGuardar_Click(sender As Object, e As EventArgs) Handles butGuardar.Click

    End Sub

    Private Sub VerIntegrantesEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerIntegrantesEquipoToolStripMenuItem.Click
        ' Se visualiza el equipo completo de ese proyecto
        Dim sql As String = ""
        Dim punto As New Point(50, 50)

        sql = "SELECT Equipos.NombreEquipo, Usuarios.Nombre, Roles.NombreRol FROM Equipos, Proyectos, Roles, Usuarios "
        sql = sql & "WHERE (((Proyectos.IdProyecto)=" & IDPROYECTO & ") AND ((Equipos.IdEquipo)=[Proyectos].[IdEquipo]) AND ((Usuarios.IdUser)=[Equipos].[IDPersona]) "
        sql = sql & "AND ((Roles.IdRol)=[Equipos].[IdRolPersona]))"

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim pb As OleDbDataReader = buscar.ExecuteReader

            If pb.HasRows Then
                While pb.Read
                    DGVEquipo.Rows.Add(pb.GetValue(1), pb.GetValue(2))
                    lblEquipo.Text = "Lista de Integrantes de " & pb.GetValue(0)
                End While
                cnn.Close()
            Else
                MsgBox("No existe personal asignado al proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If
            ConovocatoriasToolStripMenuItem.Enabled = False
            VerIntegrantesEquipoToolStripMenuItem.Enabled = False
            NotificacionesToolStripMenuItem.Enabled = False
            SalirToolStripMenuItem.Enabled = False
            pnlEquipo.Location = punto
            pnlEquipo.Visible = True

        Catch ex As Exception
            MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

    End Sub

    Private Sub butListo_Click(sender As Object, e As EventArgs) Handles butListo.Click

        pnlEquipo.Visible = False
        DGVEquipo.Rows.Clear()
        DGVEquipo.EndEdit()
        ConovocatoriasToolStripMenuItem.Enabled = True
        VerIntegrantesEquipoToolStripMenuItem.Enabled = True
        NotificacionesToolStripMenuItem.Enabled = True
        SalirToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PlanificaciónSPMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanificaciónSPMToolStripMenuItem.Click
        Dim punto As New Point(75, 75)
        Dim frm As frmConvocatoria
        frm = New frmConvocatoria("Planificacion", txtProyecto.Text)
        frm.Location = punto
        frm.ShowDialog()
    End Sub

    Private Sub RevisiónSRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisiónSRToolStripMenuItem.Click
        Dim punto As New Point(75, 75)
        Dim frm As frmConvocatoria
        frm = New frmConvocatoria("Revision", txtProyecto.Text)
        frm.Location = punto
        frm.ShowDialog()
    End Sub

    Private Sub DiariaDailyScrumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiariaDailyScrumToolStripMenuItem.Click
        Dim punto As New Point(75, 75)
        Dim frm As frmConvocatoria
        frm = New frmConvocatoria("Diaria", txtProyecto.Text)
        frm.Location = punto
        frm.ShowDialog()
    End Sub

    Private Sub RetrospectivaSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrospectivaSPToolStripMenuItem.Click
        Dim punto As New Point(75, 75)
        Dim frm As frmConvocatoria
        frm = New frmConvocatoria("Retrospectiva", txtProyecto.Text)
        frm.Location = punto
        frm.ShowDialog()
    End Sub

    Private Sub ConovocatoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConovocatoriasToolStripMenuItem.Click

    End Sub

    Private Sub ActivarSprintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivarSprintToolStripMenuItem.Click
        'primero hay que elegir para que Sprint del proyecto quiere trabajar
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim punto As New Point(50, 50)

        lstSelSprint.Items.Clear()
        lstAux.Items.Clear()

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT IdSprint, FComienzo FROM Sprints WHERE (IdProyecto = " & IDPROYECTO & ") AND (Cerrado = False) AND (Cancelado = False) AND (FComienzo > " & FormatDateTime(Now(), DateFormat.ShortDate) & ")"
            Console.Write(sql)

            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    lstSelSprint.Items.Add(existe.GetValue(0))
                    lstAux.Items.Add(existe.GetValue(1))
                End While
                cdu.Close()

                ConovocatoriasToolStripMenuItem.Enabled = False
                SalirToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = False
                VerIntegrantesEquipoToolStripMenuItem.Enabled = False

                pnlSelSprint.Location = punto
                pnlSelSprint.Visible = True
            Else
                MsgBox("No hay Sprints aún en este Proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If
            butSeleccionar.Text = "Activar Sprint"
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
    End Sub

    Private Sub butSSalir_Click(sender As Object, e As EventArgs) Handles butSSalir.Click

        ConovocatoriasToolStripMenuItem.Enabled = True
        VerIntegrantesEquipoToolStripMenuItem.Enabled = True
        SalirToolStripMenuItem.Enabled = True
        NotificacionesToolStripMenuItem.Enabled = True

        pnlSelSprint.Visible = False

    End Sub

    Private Sub butSeleccionar_Click(sender As Object, e As EventArgs) Handles butSeleccionar.Click
        Dim IdS As Integer
        Dim FComienzo As Date
        Dim resp As Integer


        IdS = CInt(lstSelSprint.SelectedItem)

            If IdS <> 0 Then

            FComienzo = FormatDateTime(CDate(lstAux.Items(lstSelSprint.SelectedIndex)), DateFormat.ShortDate)

            resp = MsgBox("El Sprint " & IdS.ToString & " que comienza el " & Trim(Microsoft.VisualBasic.Left(FComienzo.ToString, 10)) & " será seleccionado como el activo." & vbNewLine & vbNewLine & "Quiere coninuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "SCRUM wizard")
            If resp = vbYes Then

                If ActivarSprint(IdS) Then
                    'ok
                Else
                    'ko
                End If

                ConovocatoriasToolStripMenuItem.Enabled = True
                VerIntegrantesEquipoToolStripMenuItem.Enabled = True
                SalirToolStripMenuItem.Enabled = True
                NotificacionesToolStripMenuItem.Enabled = True
                pnlSelSprint.Visible = False

            Else
            End If

        Else
            MsgBox("Debe elegir primero un Sprint.", MsgBoxStyle.Information, "SCRUM Wizard")
        End If
    End Sub
End Class