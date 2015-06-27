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

Public Class frmProyecto
    Private Sub frmProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Obtengo el Id Proyecto
        Dim sql As String = ""
        Dim ValorMasAlto As Integer = 0
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        If pnlProyecto.Tag = "Nuevo" Then

            sql = "SELECT Max(IdProyecto) As xxx FROM Proyectos"
            Try
                cnn.Open()
                Dim buscar As New OleDbCommand(sql, cnn)
                Dim pb As OleDbDataReader = buscar.ExecuteReader
                If pb.HasRows Then
                    pb.Read()
                    If IsNumeric(pb.GetValue(0)) Then
                        ValorMasAlto = pb.GetValue(0) + 1
                    Else
                        ValorMasAlto = 1
                    End If
                    cnn.Close()
                Else
                    ValorMasAlto = 1
                End If
                txtIProyecto.Text = ValorMasAlto.ToString
                txtIProyecto.Enabled = False
            Catch ex As Exception
                MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try

            'Cargo los equipos. Solo los que soy PO

            sql = "SELECT DISTINCT IdEquipo, NombreEquipo FROM Equipos WHERE IdPersona = " & IDUSER & " AND IdRolPersona = 1 ORDER BY NombreEquipo"
            Try
                cnn.Open()
                Dim bbuscar As New OleDbCommand(sql, cnn)
                Dim ppb As OleDbDataReader = bbuscar.ExecuteReader

                cbEquipos.Items.Clear()
                cbIdEquipo.Items.Clear()
                If ppb.HasRows Then
                    While ppb.Read()
                        cbIdEquipo.Items.Add(ppb.GetValue(0).ToString)
                        cbEquipos.Items.Add(ppb.GetValue(1).ToString)
                    End While
                    cnn.Close()
                Else
                    MsgBox("No está aún asignado a ningún equipo." & vbNewLine & vbNewLine & "El Administrador puede dar de alta.", MsgBoxStyle.Information, "SCRUM Wizard")
                    cnn.Close()
                    'butSal.PerformClick()
                    Me.Close()
                End If
                txtIProyecto.Text = ValorMasAlto.ToString
                txtIProyecto.Enabled = False
            Catch ex As Exception
                MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try
        Else
            'CAMBIAR
            Dim fcp As Integer

            fcp = FCPenFuturo()
            If fcp = 1 Then ' el proyecto no se puede modificar
                MsgBox("La presente versión de SCRUM Wizard no permite cambios en proyectos ya iniciados.", MsgBoxStyle.Critical, "SCRUM Wizard")
                Me.Close()
            ElseIf fcp = -1 Then ' algo raro pasa

            Else
                If DamePB() = 1 Then
                    MsgBox("La presente versión de SCRUM Wizard no permite cambios en proyectos con PB ya creados.", MsgBoxStyle.Critical, "SCRUM Wizard")
                    Me.Close()
                End If

                txtIProyecto.Enabled = False

                sql = "SELECT DISTINCT IdEquipo, NombreEquipo FROM Equipos ORDER BY NombreEquipo"
                Try
                    cnn.Open()
                    Dim bbuscar As New OleDbCommand(sql, cnn)
                    Dim ppb As OleDbDataReader = bbuscar.ExecuteReader
                    Dim jj As Integer = 0
                    Dim w As Integer

                    cbEquipos.Items.Clear()
                    cbIdEquipo.Items.Clear()
                    If ppb.HasRows Then
                        While ppb.Read()
                            cbIdEquipo.Items.Add(ppb.GetValue(0).ToString)
                            cbEquipos.Items.Add(ppb.GetValue(1).ToString)
                        End While
                        cnn.Close()

                        cnn.Open()

                        sql = "SELECT NombrePry, FechaInicio, FechaFin, NumeroDeSprints, IdEquipo, HorasDia FROM Proyectos WHERE IdProyecto = " & CInt(txtIProyecto.Text)

                        Dim b As New OleDbCommand(sql, cnn)
                        Dim z As OleDbDataReader = b.ExecuteReader
                        z.Read()
                        txtNProyecto.Text = z.GetValue(0)
                        dtFInicio.Value = z.GetValue(1)
                        dtFFin.Value = z.GetValue(2)
                        nuNSprints.Value = z.GetValue(3)
                        jj = z.GetValue(4)
                        For w = 0 To cbIdEquipo.Items.Count - 1
                            If jj = CInt(cbIdEquipo.Items(w)) Then
                                cbEquipos.SelectedIndex = w
                                w = cbEquipos.Items.Count + 3
                            End If
                        Next w
                        nuHDia.Value = z.GetValue(5)

                        If dtFInicio.Value < Microsoft.VisualBasic.Left(Now, 10) Then
                            Dim texto As String
                            texto = "Información del proyecto: " & vbNewLine & vbNewLine
                            texto = texto & "Nombre Proyecto: " & txtNProyecto.Text & vbNewLine
                            texto = texto & "Fecha de Inicio: " & dtFInicio.Value & vbNewLine
                            texto = texto & "Feha Fin: " & dtFFin.Value & vbNewLine
                            texto = texto & "Número de Sprints: " & nuNSprints.Value & vbNewLine
                            texto = texto & "Realizado por el equipo: " & cbEquipos.SelectedItem & vbNewLine & vbNewLine & vbNewLine
                            MsgBox(texto & "No pueden modificarse los proyectos ya comenzados.", MsgBoxStyle.Exclamation, "SCRUM Wizard")

                            cbEquipos.Items.Clear()
                            cbIdEquipo.Items.Clear()
                            txtIProyecto.Text = ""
                            txtNProyecto.Text = ""
                            dtFInicio.Value = Now()
                            dtFFin.Value = Now()
                            nuNSprints.Value = 0
                            Me.Close()
                        End If

                    Else
                        MsgBox("No hay aún equipos dados de alta." & vbNewLine & vbNewLine & "Debe darlos de alta para poder continuar.", MsgBoxStyle.Information, "SCRUM Wizard")
                        cnn.Close()
                        'butSal.PerformClick()
                        Me.Close()
                    End If

                Catch ex As Exception
                    MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                End Try

            End If
        End If

    End Sub



    Private Sub butGrabar_Click(sender As Object, e As EventArgs) Handles butGrabar.Click
        Dim resp As Integer
        Dim parar As Boolean = False
        Dim DiasPorSprint As Integer = 0
        Dim sql As String = ""


        If nuNSprints.Value <> 0 Then DiasPorSprint = DateDiff(DateInterval.Day, CDate(dtFInicio.Value), CDate(dtFFin.Value)) / nuNSprints.Value

            'hago comprobaciones
        If String.IsNullOrEmpty(txtNProyecto.Text) Then
            MsgBox("El proyecto debe tener un nombre.", MsgBoxStyle.Critical, "SCRUM Wizard")
            parar = True
        End If
        If dtFInicio.Value >= dtFFin.Value And Not parar Then
            MsgBox("La fecha de inicio debe ser anterior a la fecha fin.", MsgBoxStyle.Critical, "SCRUM Wizard")
            parar = True
        End If
        If DateDiff(DateInterval.Day, CDate(dtFInicio.Value), CDate(dtFFin.Value)) > 364 And Not parar Then
            resp = MsgBox("Está definiendo un proyecto de más de un año de duración." & vbNewLine & vbNewLine & "Desea hacerlo de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
            If resp = vbNo Then parar = True
        End If
        If nuNSprints.Value = 0 And Not parar Then
            MsgBox("El número de sprints debe ser superior a 0.", MsgBoxStyle.Critical, "SCRUM Wizard")
            parar = True
        End If
        If nuNSprints.Value < 3 And Not parar Then
            resp = MsgBox("Está definiendo un proyecto de menos de 3 sprints." & vbNewLine & vbNewLine & "Desea hacerlo de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
            If resp = vbNo Then parar = True
        End If
        If DiasPorSprint > 30 And Not parar Then
            Dim texto As String
            Dim ndias As Integer
            Dim ffpropuesta As Date
            texto = "Los sprints no pueden superar las 4 semanas de duración." & vbNewLine
            If nuNSprints.Value = 1 Then
                texto = texto & "Su sprint tiene una duración de " & DiasPorSprint.ToString & " días."
            Else
                texto = texto & "Su(s) sprint(s) tiene una duración de " & DiasPorSprint.ToString & " días."
            End If
            ndias = nuNSprints.Value * 30
            ffpropuesta = DateAdd(DateInterval.Day, CType(ndias, Double), CDate(dtFInicio.Value))
            texto = texto & vbNewLine & "Se propone " & Microsoft.VisualBasic.Left(ffpropuesta.ToString, 10) & " como Fecha Fin del proyecto."
            MsgBox(texto, MsgBoxStyle.Critical, "SCRUM Wizard")
            dtFFin.Value = ffpropuesta
            parar = True
        Else
            resp = MsgBox("La duración de los Sprints para este proyecto es fija." & vbNewLine & vbNewLine & "Ha configurado una duración de " & DiasPorSprint.ToString & " días por Sprint." & vbNewLine & vbNewLine & "Quiere continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "SCRUM Wizard")
            If resp = vbNo Then
                parar = True
            End If
        End If
        If String.IsNullOrWhiteSpace(cbEquipos.Text) And String.IsNullOrEmpty(cbEquipos.Text) And Not parar Then
            MsgBox("Debe seleccionar un equipo de trabajo.", MsgBoxStyle.Critical, "SCRUM Wizard")
            parar = True
        End If

        Dim IdEquipo As Integer

        cbIdEquipo.SelectedIndex = cbEquipos.SelectedIndex
        If cbIdEquipo.SelectedIndex <> -1 Then
            IdEquipo = cbIdEquipo.Text
            If EquipoYaAsignado(IdEquipo) And Not parar Then
                resp = MsgBox("El equipo seleccionado ya está asignado a otro proyecto." & vbNewLine & vbNewLine & "Desea hacerlo de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
                If resp = vbNo Then parar = True
            End If
        Else
            parar = True
        End If


        If Not parar Then
            ' se puede almacenar en BBDD
            Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
            Dim trans As OleDbTransaction
            Dim fipry As Date
            Dim ffpry As Date
            Dim dpry As Integer
            Dim nsprints As Integer
            Dim msql(100) As String
            Dim ssql As String = ""
            Dim d As Integer
            Dim f As Date
            Dim NumIdSB As Integer = 0

            If pnlProyecto.Tag = "Nuevo" Then

                sql = "INSERT INTO Proyectos VALUES ("
                sql = sql & txtIProyecto.Text & ",'" & txtNProyecto.Text & "','" & Microsoft.VisualBasic.Left(dtFInicio.Value, 10) & "','" & Microsoft.VisualBasic.Left(dtFFin.Value, 10) & "',"
                sql = sql & nuNSprints.Value & "," & IdEquipo & "," & txtIProyecto.Text & ", False, False, " & nuHDia.Value & ")"

                'ahora lanzo actualizar los sprints en base a datos metidos

                fipry = CDate(dtFInicio.Value)
                ffpry = CDate(dtFFin.Value)
                dpry = DateDiff(DateInterval.Day, fipry, ffpry)
                nsprints = CInt(nuNSprints.Value)

                'para cada sprint
                For i = 1 To nsprints
                    If i = nsprints Then
                        d = dpry - ((nsprints - 1) * DiasPorSprint)
                    Else
                        d = DiasPorSprint
                    End If
                    If i = 1 Then
                        f = Microsoft.VisualBasic.Left(fipry, 10)
                    Else
                        f = DateAdd(DateInterval.Day, DiasPorSprint, f)
                        f = Microsoft.VisualBasic.Left(f, 10)
                    End If
                    NumIdSB = NumIdSB + 1
                    ssql = "INSERT INTO Sprints (IdSprint, IdProyecto, IdSBacklog, FComienzo, Duracion, Objetivo, Cerrado, Notificado, Cancelado) "
                    ssql = ssql & "VALUES (" & i & ", " & CInt(txtIProyecto.Text) & ", " & NumIdSB & ", '" & f & "', " & d & ",'', False, False,False)"
                    msql(i) = ssql
                Next

                Dim comandoi As New OleDbCommand()
                comandoi.Connection = cnn
                cnn.Open()
                trans = cnn.BeginTransaction()
                'ejecuto el sql
                Try

                    comandoi.Connection = cnn
                    comandoi.Transaction = trans
                    comandoi.CommandText = sql

                    'inserto en proyectos
                    comandoi.ExecuteNonQuery()
                    For i = 1 To nsprints
                        comandoi.CommandText = msql(i)
                        comandoi.ExecuteNonQuery()
                    Next
                    trans.Commit()

                    cbEquipos.Items.Clear()
                    cbIdEquipo.Items.Clear()
                    txtIProyecto.Text = ""
                    txtNProyecto.Text = ""
                    dtFInicio.Value = Now()
                    dtFFin.Value = Now()
                    nuNSprints.Value = 0
                    Me.Close()

                Catch ex As Exception
                    trans.Rollback()
                    MsgBox("Ups!!! Problemas-->" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                End Try

            Else
                Dim sqld As String

                sql = "UPDATE Proyectos SET "
                sql = sql & "NombrePry = '" & txtNProyecto.Text & "', "
                sql = sql & "FechaInicio = '" & Microsoft.VisualBasic.Left(dtFInicio.Value, 10) & "', "
                sql = sql & "FechaFin = '" & Microsoft.VisualBasic.Left(dtFFin.Value, 10) & "', "
                sql = sql & "NumeroDeSprints = " & nuNSprints.Value & ", "
                sql = sql & "IdEquipo = " & IdEquipo & ", "
                sql = sql & "IdProductBacklog = " & CInt(txtIProyecto.Text) & ", "
                sql = sql & "HorasDia = " & nuHDia.Value
                sql = sql & " WHERE IdProyecto = " & CInt(txtIProyecto.Text)

                'borro sprints previos
                sqld = "DELETE FROM Sprints WHERE IdProyecto = " & IDPROYECTO

                'ahora lanzo actualizar los sprints en base a datos metidos
                fipry = CDate(dtFInicio.Value)
                ffpry = CDate(dtFFin.Value)
                dpry = DateDiff(DateInterval.Day, fipry, ffpry)
                nsprints = CInt(nuNSprints.Value)

                'para cada sprint
                For i = 1 To nsprints
                    If i = nsprints Then
                        d = dpry - ((nsprints - 1) * DiasPorSprint)
                    Else
                        d = DiasPorSprint
                    End If
                    If i = 1 Then
                        f = Microsoft.VisualBasic.Left(fipry, 10)
                    Else
                        f = DateAdd(DateInterval.Day, DiasPorSprint, f)
                        f = Microsoft.VisualBasic.Left(f, 10)
                    End If
                    ssql = "INSERT INTO Sprints VALUES(" & i & ", " & CInt(txtIProyecto.Text) & ", -1, '" & f & "', " & d & ",'', False, False)"
                    msql(i) = ssql
                Next

                Dim comandou As New OleDbCommand(sql)
                comandou.Connection = cnn

                cnn.Open()
                trans = cnn.BeginTransaction()
                comandou.Connection = cnn
                comandou.Transaction = trans

                'ejecuto el sql
                Try

                    'actualizo tabla proyectos
                    comandou.CommandText = sql
                    comandou.ExecuteNonQuery()

                    'borro los sprints
                    comandou.CommandText = sqld
                    comandou.ExecuteNonQuery()

                    'inserto en proyectos
                    For i = 1 To nsprints
                        comandou.CommandText = msql(i)
                        comandou.ExecuteNonQuery()
                    Next
                    trans.Commit()

                    cbEquipos.Items.Clear()
                    cbIdEquipo.Items.Clear()
                    txtIProyecto.Text = ""
                    txtNProyecto.Text = ""
                    dtFInicio.Value = Now()
                    dtFFin.Value = Now()
                    nuNSprints.Value = 0
                    Me.Close()

                Catch ex As Exception
                    MsgBox("Ups!!! Problemas-->" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                    trans.Rollback()
                End Try
            End If

        End If
    End Sub

    Private Sub butSal_Click(sender As Object, e As EventArgs) Handles butSal.Click
        Dim resp As Integer

        resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then
            cbEquipos.Items.Clear()
            cbIdEquipo.Items.Clear()
            txtIProyecto.Text = ""
            txtNProyecto.Text = ""
            dtFInicio.Value = Now()
            dtFFin.Value = Now()
            nuNSprints.Value = 0
            Me.Close()
        Else
            'seguir aqui
        End If
    End Sub
    Public Function EquipoYaAsignado(ieq As Integer) As Boolean
        Dim v As Boolean = False
        Dim sql As String = ""
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        sql = "SELECT Max(IdProyecto) As xxx FROM Proyectos WHERE IdEquipo = " & ieq

        Try
            cnn.Open()
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim pb As OleDbDataReader = buscar.ExecuteReader
            If pb.HasRows Then
                pb.Read()
                If IsNumeric(pb.GetValue(0)) Then
                    v = True
                Else
                    v = False
                End If
            Else
                v = False
            End If
            cnn.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = False
        End Try

        Return v

    End Function



   

    Private Sub dtFInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtFInicio.ValueChanged

    End Sub

    Private Sub dtFFin_Validated(sender As Object, e As EventArgs) Handles dtFFin.Validated
        'If DateDiff(DateInterval.Day, dtFInicio.Value, dtFFin.Value) < 0 Then
        'MsgBox("La fecha final no puede ser anterior a la fecha inicial.", MsgBoxStyle.Critical, "SCRUM Wizard")
        'dtFFin.Focus()
        'End If
    End Sub

    Private Sub dtFInicio_Validated(sender As Object, e As EventArgs) Handles dtFInicio.Validated
        ' If DateDiff(DateInterval.Day, dtFInicio.Value, dtFFin.Value) < 0 Then
        'MsgBox("La fecha final no puede ser anterior a la fecha inicial.", MsgBoxStyle.Critical, "SCRUM Wizard")
        'dtFInicio.Focus()
        'End If
    End Sub
End Class