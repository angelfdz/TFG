
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
'

Imports System.Data.OleDb
Public Class frmDT


    Private Sub frmDT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim HayPB As Integer = 0
        ' muestro info de quién y dónde estoy
        txtUsuario.Text = DameUsuario(IDUSER)
        txtRol.Text = DameRol()
        If IDPROYECTO = 0 Then
            txtProyecto.Text = "Sin Proyecto"
            MsgBox("No ha elegido proyecto," & vbNewLine & vbNewLine & "Debe elegir un proyecto para poder seguir.", MsgBoxStyle.Critical, "SCRUM Wizard")
            SprintBacklogToolStripMenuItem.Enabled = True
            SprintToolStripMenuItem.Enabled = True
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
                SprintBacklogToolStripMenuItem.Enabled = False
                SprintToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = False
                SalirToolStripMenuItem.Enabled = True

            Else                'hay PB => refinamiento PB existente
                SprintBacklogToolStripMenuItem.Enabled = True
                NotificacionesToolStripMenuItem.Enabled = True
                SprintToolStripMenuItem.Enabled = True
                SalirToolStripMenuItem.Enabled = True
            End If
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub NotificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificacionesToolStripMenuItem.Click
        frmNotificaciones.ShowDialog()
    End Sub

    Private Sub ComposiciónEquipoDeProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComposiciónEquipoDeProyectoToolStripMenuItem.Click
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

            SprintBacklogToolStripMenuItem.Enabled = False
            SprintToolStripMenuItem.Enabled = False
            ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = False
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
        SprintBacklogToolStripMenuItem.Enabled = True
        SprintToolStripMenuItem.Enabled = True
        ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True
        NotificacionesToolStripMenuItem.Enabled = True
        SalirToolStripMenuItem.Enabled = True
    End Sub

    Private Sub CrearPBToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'frmSBacklog.ShowDialog()
    End Sub


    Private Sub SprintBacklogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SprintBacklogToolStripMenuItem.Click

        'primero hay que elegir para que Sprint del proyecto quiere trabajar
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim punto As New Point(50, 50)

        lstSelSprint.Items.Clear()
        lstAux.Items.Clear()

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT IdSprint, Duracion FROM Sprints WHERE (IdProyecto = " & IDPROYECTO & ") AND (Cerrado = False) AND (Cancelado = False)"


            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    lstSelSprint.Items.Add(existe.GetValue(0))
                    lstAux.Items.Add(existe.GetValue(1))
                End While
                cdu.Close()

                SprintBacklogToolStripMenuItem.Enabled = False
                SprintToolStripMenuItem.Enabled = False
                SalirToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = False
                ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = False

                pnlSelSprint.Location = punto
                pnlSelSprint.Visible = True
            Else
                MsgBox("No hay Sprints aún en este Proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If
            butSeleccionar.Text = "Seleccionar"
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

    End Sub

    Private Sub butSeleccionar_Click(sender As Object, e As EventArgs) Handles butSeleccionar.Click
        Dim IdS As Integer
        Dim duracion As Integer
        Dim p As New Point(50, 50)
        Dim dias, diasbd As Integer


        IdS = CInt(lstSelSprint.SelectedItem)

        If butSeleccionar.Text = "Seleccionar" Then ' trabajar con SB

            If IdS <> 0 Then

                duracion = CInt(lstAux.Items(lstSelSprint.SelectedIndex))

                SprintBacklogToolStripMenuItem.Enabled = True
                SprintToolStripMenuItem.Enabled = True
                SalirToolStripMenuItem.Enabled = True
                NotificacionesToolStripMenuItem.Enabled = True
                ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True
                pnlSelSprint.Visible = False

                'una vez elegido pues a ello
                Dim punto As New Point(25, 50)
                Dim frm As frmSB
                frm = New frmSB(IdS, txtProyecto.Text, duracion)
                frm.Location = punto
                frm.ShowDialog()

            Else
                MsgBox("Debe elegir primero un Sprint.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If

        ElseIf butSeleccionar.Text = "Fijar Objetivo" Then
            ' definir objetivo

            If IdS <> 0 Then

                pnlObjetivo.Location = p
                lblCabObjetivo.Text = "Indique el objetivo para el Sprint " & IdS & " del proyecto & " & txtProyecto.Text

                txtObjetivo.Text = DameObjetivoSprint(IdS)
                txtObjetivo.Tag = IdS

                pnlObjetivo.Visible = True
                pnlSelSprint.Visible = False

            Else
                MsgBox("Debe elegir primero un Sprint.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If

        ElseIf butSeleccionar.Text = "Fijar Duración" Then ' Fijar duración

            If IdS <> 0 Then

                pnlDuracion.Location = p
                lblCabDuracion.Text = "Fijar la duración del Sprint & " & IdS.ToString

                nuDuracion.Tag = IdS

                dias = DameDiasSprint()
                diasbd = DameDuracionSprintEnBD(IdS)


                lblDuracionActual.Text = "La duración actual de Sprint es de " & diasbd.ToString & " días"
                lblDuracionActual.Tag = diasbd
                lblDuracionSys.Text = "La duración propuesta en función de la duración del proyecto y de su num. de sprints es de " & dias.ToString & " días"

                nuDuracion.Value = diasbd

                pnlDuracion.Visible = True
                pnlSelSprint.Visible = False

            Else
                MsgBox("Debe elegir primero un Sprint.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If

        ElseIf butSeleccionar.Text = "Cerrar Sprint" Then       ' Cerrar Sprint
            Dim resp As Integer

            If IdS <> 0 Then
                resp = ComprobarEstadoHistoriasDeSprint(IdS)

                If resp = 1 Then ' todas las historias terminadas
                    'solo cerrar el sprint
                    If CerrarSprint(IdS) = 0 Then
                        'no ha habido problemas
                        lstSelSprint.Items.Clear()
                        lstAux.Items.Clear()
                        pnlSelSprint.Visible = False
                        SprintToolStripMenuItem.Enabled = True
                        SprintBacklogToolStripMenuItem.Enabled = True
                        NotificacionesToolStripMenuItem.Enabled = True
                        SalirToolStripMenuItem.Enabled = True
                        ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True
                    End If
                ElseIf resp = 2 Then ' no todas terminadas pero ha dicho cerrar de todas formas => actualizar las historias no terminadas en PB y SB
                    'terminar historias y cerrar sprint
                    If TerminarHistoriasSprint(IdS) Then
                        If CerrarSprint(IdS) = 0 Then
                            'no ha habido problemas
                            lstSelSprint.Items.Clear()
                            lstAux.Items.Clear()
                            pnlSelSprint.Visible = False
                            SprintToolStripMenuItem.Enabled = True
                            SprintBacklogToolStripMenuItem.Enabled = True
                            NotificacionesToolStripMenuItem.Enabled = True
                            SalirToolStripMenuItem.Enabled = True
                            ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True
                        End If
                    Else
                        'problemas
                    End If

                Else    'ha cancelado la operación o error
                    'no hago nada
                End If
            Else
                MsgBox("Debe elegir primero un Sprint.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If

        ElseIf butSeleccionar.Text = "Ver Informe Sgto." Then       ' Cerrar Sprint
            If IdS <> 0 Then

                SprintBacklogToolStripMenuItem.Enabled = True
                SprintToolStripMenuItem.Enabled = True
                SalirToolStripMenuItem.Enabled = True
                NotificacionesToolStripMenuItem.Enabled = True
                ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True
                pnlSelSprint.Visible = False

                'una vez elegido pues a ello
                Dim pto As New Point(50, 50)
                Dim frm As frmInfoSgtoS
                frm = New frmInfoSgtoS(IdS)
                frm.Location = pto
                frm.ShowDialog()
            Else
                MsgBox("Debe elegir primero un Sprint.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If

        End If

    End Sub
    Private Sub butSSalir_Click(sender As Object, e As EventArgs) Handles butSSalir.Click

        SprintBacklogToolStripMenuItem.Enabled = True
        SprintToolStripMenuItem.Enabled = True
        SalirToolStripMenuItem.Enabled = True
        NotificacionesToolStripMenuItem.Enabled = True
        ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True

        pnlSelSprint.Visible = False

    End Sub

    Private Sub FijarObjetivoDeSprintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FijarObjetivoDeSprintToolStripMenuItem.Click
        'primero hay que elegir para que Sprint del proyecto quiere trabajar
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim punto As New Point(50, 50)

        lstSelSprint.Items.Clear()
        lstAux.Items.Clear()

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT IdSprint, Duracion FROM Sprints WHERE (IdProyecto = " & IDPROYECTO & ") AND (Cerrado = False) AND (Cancelado = False)"


            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    lstSelSprint.Items.Add(existe.GetValue(0))
                    lstAux.Items.Add(existe.GetValue(1))
                End While
                cdu.Close()

                SprintBacklogToolStripMenuItem.Enabled = False
                SprintToolStripMenuItem.Enabled = False
                SalirToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = False
                ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = False

                pnlSelSprint.Location = punto
                pnlSelSprint.Visible = True
            Else
                MsgBox("No hay Sprints aún en este Proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If
            butSeleccionar.Text = "Fijar Objetivo"
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

    End Sub

    Private Sub butSalirObj_Click(sender As Object, e As EventArgs) Handles butSalirObj.Click

        Dim resp As Integer

        resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then

            ' Salgo
            txtObjetivo.Text = ""
            pnlObjetivo.Visible = False
            lstSelSprint.Items.Clear()
            lstAux.Items.Clear()
            SprintToolStripMenuItem.Enabled = True
            SprintBacklogToolStripMenuItem.Enabled = True
            NotificacionesToolStripMenuItem.Enabled = True
            SalirToolStripMenuItem.Enabled = True
            ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True

        Else
            ' No hago nada
        End If

    End Sub

    Private Sub butGuardarObj_Click(sender As Object, e As EventArgs) Handles butGuardarObj.Click


        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim comando As New OleDbCommand()
        Dim sql As String

        Try
            sql = "UPDATE Sprints SET Objetivo = '" & txtObjetivo.Text & "' WHERE ((IdProyecto = " & IDPROYECTO & ") AND (IdSprint = " & CInt(txtObjetivo.Tag) & "))"
            comando.Connection = cnn
            cnn.Open()
            comando.CommandText = sql
            comando.ExecuteNonQuery()
            cnn.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

        ' Salgo
        txtObjetivo.Text = ""
        pnlObjetivo.Visible = False
        lstSelSprint.Items.Clear()
        lstAux.Items.Clear()
        SprintToolStripMenuItem.Enabled = True
        SprintBacklogToolStripMenuItem.Enabled = True
        NotificacionesToolStripMenuItem.Enabled = True
        SalirToolStripMenuItem.Enabled = True
        ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True

    End Sub

    Private Sub EstablecerDuracionSprintMenuItem_Click(sender As Object, e As EventArgs) Handles EstablecerDuracionSprintMenuItem.Click
        'primero hay que elegir para que Sprint del proyecto quiere trabajar
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim punto As New Point(50, 50)

        lstSelSprint.Items.Clear()
        lstAux.Items.Clear()

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT IdSprint, Duracion FROM Sprints WHERE (IdProyecto = " & IDPROYECTO & ") AND (Cerrado = False) AND (Cancelado = False)"


            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    lstSelSprint.Items.Add(existe.GetValue(0))
                    lstAux.Items.Add(existe.GetValue(1))
                End While
                cdu.Close()

                SprintBacklogToolStripMenuItem.Enabled = False
                SprintToolStripMenuItem.Enabled = False
                SalirToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = False
                ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = False

                pnlSelSprint.Location = punto
                pnlSelSprint.Visible = True
            Else
                MsgBox("No hay Sprints aún en este Proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If
            butSeleccionar.Text = "Fijar Duración"
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
    End Sub

    Private Sub butSalDuracion_Click(sender As Object, e As EventArgs) Handles butSalDuracion.Click
        Dim resp As Integer

        resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then

            ' Salgo
            lblCabDuracion.Text = ""
            lblDuracionActual.Text = ""
            lblDuracionSys.Text = ""
            nuDuracion.Value = 1
            pnlDuracion.Visible = False

            SprintToolStripMenuItem.Enabled = True
            SprintBacklogToolStripMenuItem.Enabled = True
            NotificacionesToolStripMenuItem.Enabled = True
            SalirToolStripMenuItem.Enabled = True
            ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True

        Else
            ' No hago nada
        End If

    End Sub

    Private Sub butGuardarDuracion_Click(sender As Object, e As EventArgs) Handles butGuardarDuracion.Click

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim comando As New OleDbCommand()
        Dim sql As String
        Dim resp As Integer
        Dim seguir As Boolean = True


        If DameDuracionMaxHistEnSprint(CInt(nuDuracion.Tag)) > CInt(nuDuracion.Value) Then

            resp = MsgBox("El Sprint tiene Historias de duración superior a la que trata de fijar para el Sprint" & vbNewLine & vbNewLine & "Desea hacerlo de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "SCRUM Wizard")
            If resp = vbYes Then
                seguir = True
            Else
                seguir = False
            End If

        Else

            If CInt(nuDuracion.Value) < CInt(lblDuracionActual.Tag) Then
                resp = MsgBox("Reducir la duración puede suponer perdida de la planificación realizada." & vbNewLine & vbNewLine & "Desea hacerlo de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "SCRUM Wizard")
                If resp = vbYes Then
                    seguir = True
                Else
                    seguir = False
                End If
            End If
        End If

        If seguir Then
        Try
            sql = "UPDATE Sprints SET Duracion = " & nuDuracion.Value & " WHERE ((IdProyecto = " & IDPROYECTO & ") AND (IdSprint = " & CInt(nuDuracion.Tag) & "))"
            comando.Connection = cnn
            cnn.Open()
            comando.CommandText = sql
            comando.ExecuteNonQuery()
            cnn.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try


        lblCabDuracion.Text = ""
        lblDuracionActual.Text = ""
        lblDuracionSys.Text = ""
        nuDuracion.Value = 1
        pnlDuracion.Visible = False

        SprintToolStripMenuItem.Enabled = True
        SprintBacklogToolStripMenuItem.Enabled = True
        NotificacionesToolStripMenuItem.Enabled = True
        SalirToolStripMenuItem.Enabled = True
        ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = True

        End If

    End Sub


    Private Sub CerrrarSprintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrrarSprintToolStripMenuItem.Click
        'primero hay que elegir para que Sprint del proyecto quiere trabajar
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim punto As New Point(50, 50)

        lstSelSprint.Items.Clear()
        lstAux.Items.Clear()

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT IdSprint, Duracion FROM Sprints WHERE (IdProyecto = " & IDPROYECTO & ") AND (Cerrado = False) AND (Cancelado = False)"


            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    lstSelSprint.Items.Add(existe.GetValue(0))
                    lstAux.Items.Add(existe.GetValue(1))
                End While
                cdu.Close()

                SprintBacklogToolStripMenuItem.Enabled = False
                SprintToolStripMenuItem.Enabled = False
                SalirToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = False
                ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = False

                pnlSelSprint.Location = punto
                pnlSelSprint.Visible = True
            Else
                MsgBox("No hay Sprints aún en este Proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If
            butSeleccionar.Text = "Cerrar Sprint"
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
    End Sub


    Private Sub GeneraciónInformeSgtoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraciónInformeSgtoToolStripMenuItem.Click
        'primero hay que elegir para que Sprint del proyecto quiere trabajar
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim punto As New Point(50, 50)

        lstSelSprint.Items.Clear()
        lstAux.Items.Clear()

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT IdSprint, Duracion FROM Sprints WHERE (IdProyecto = " & IDPROYECTO & ") AND (Cerrado = False) AND (Cancelado = False)"


            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    lstSelSprint.Items.Add(existe.GetValue(0))
                    lstAux.Items.Add(existe.GetValue(1))
                End While
                cdu.Close()

                SprintBacklogToolStripMenuItem.Enabled = False
                SprintToolStripMenuItem.Enabled = False
                SalirToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = False
                ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = False

                pnlSelSprint.Location = punto
                pnlSelSprint.Visible = True
            Else
                MsgBox("No hay Sprints aún en este Proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If
            butSeleccionar.Text = "Ver Informe Sgto."
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
    End Sub


End Class