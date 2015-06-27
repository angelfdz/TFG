
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
Module general
    Public IDUSER As Integer = 0
    Public ROLUSER As Integer = 0
    Public IDPROYECTO As Integer = 0
    Public RECUERDAPB As Boolean = False
    Public CONVOCATORIA As String = ""

    Public Sub Main()


        If My.Forms.LoginForm1.ShowDialog = DialogResult.OK Then
            If IDUSER <> -1 Then
                Application.DoEvents()
                Application.Run(New LProyectos)
                Application.DoEvents()
                'en función del rol lanzo una ventana u otra de trabajo
                If ROLUSER = 1 Then         ' Prouct Owner
                    Application.Run(New frmPO)
                ElseIf ROLUSER = 2 Then     ' Scrum Master
                    Application.Run(New frmSM)
                ElseIf ROLUSER = 3 Then                       ' Development Team Member
                    Application.Run(New frmDT)
                ElseIf ROLUSER = -1 Then    'Administrador
                    ' No debería entrar nunca aqui
                Else
                    'MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                    End
                End If
            Else ' el administrador está conectado
                Application.DoEvents()
                Application.Run(New frmAdmin)
                Application.DoEvents()
                ROLUSER = -1 ' Rol de Administrador
            End If
        End If
    End Sub
    Public Function DameUsuario(idu As Integer) As String

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim usuario As String

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT Nombre FROM Usuarios WHERE IdUser = " & idu
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()

            usuario = existe.GetValue(0)
            cdu.Close()
            DameUsuario = usuario
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            usuario = "FALLO"
            DameUsuario = usuario
        End Try

    End Function
    Public Function DameEstado(IdH As Integer) As String

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim estado As String

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT Estado FROM PBacklog WHERE (IdProyecto = " & IDPROYECTO & "AND IdHistoria = " & IdH & ")"
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            estado = existe.GetValue(0)
            cdu.Close()
            DameEstado = estado
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            estado = "FALLO"
            DameEstado = estado
        End Try

    End Function

    Public Function DameRol() As String
        Dim cdr As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim rol As String

        Try
            cdr.Open()
            Dim sql As String
            sql = "SELECT NombreRol FROM Roles WHERE IdRol = " & ROLUSER
            Dim buscar As New OleDbCommand(sql, cdr)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            rol = existe.GetValue(0)
            cdr.Close()
            DameRol = rol
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            rol = "FALLO"
            DameRol = rol
        End Try

    End Function
    Public Function DameProyecto() As String
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim proyecto As String

        Try
            cdp.Open()
            Dim sql As String
            sql = "SELECT NombrePry FROM Proyectos WHERE IdProyecto = " & IDPROYECTO
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            proyecto = existe.GetValue(0)
            cdp.Close()
            DameProyecto = proyecto
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            proyecto = "FALLO"
            DameProyecto = proyecto
        End Try
    End Function
    Public Function DameNS() As String
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim proyecto As String
        Try
            cdp.Open()
            Dim sql As String
            sql = "SELECT NumeroDeSprints FROM Proyectos WHERE IdProyecto = " & IDPROYECTO
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            proyecto = existe.GetValue(0)
            cdp.Close()
            DameNS = proyecto
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            proyecto = "FALLO"
            DameNS = proyecto
        End Try
    End Function
    Public Function DameDS() As String
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim ns As String
        Dim fini As Date
        Dim ffin As Date
        Dim diasdesprint As Integer

        Try
            cdp.Open()
            Dim sql As String
            sql = "SELECT FechaInicio, FechaFin, NumeroDeSprints FROM Proyectos WHERE IdProyecto = " & IDPROYECTO
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()

            fini = CDate(existe.GetValue(0))
            ffin = CDate(existe.GetValue(1))
            ns = CInt(existe.GetValue(2))
            cdp.Close()

            diasdesprint = CInt(DateDiff(DateInterval.Day, fini, ffin) / ns)

            DameDS = diasdesprint
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            diasdesprint = "FALLO"
            DameDS = diasdesprint
        End Try
    End Function

    Public Function DamePB() As Integer
        Dim hpb As Integer = 0
        Dim cdpb As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cdpb.Open()
            Dim sql As String
            sql = "SELECT IDProyecto FROM PBacklog WHERE IdProyecto = " & IDPROYECTO
            Dim buscar As New OleDbCommand(sql, cdpb)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            If existe.HasRows Then
                hpb = 1
                DamePB = hpb
            Else
                hpb = 0
                DamePB = hpb
            End If
            cdpb.Close()
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            hpb = 0
            DamePB = hpb
        End Try
    End Function
    Public Function FCPenFuturo() As Integer
        Dim sql As String
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim vuelta As Integer = -1 '0 no en futuro
        Dim diasdiff As Integer

        sql = "SELECT FechaInicio FROM Proyectos WHERE IdProyecto = " & IDPROYECTO

        Try
            cnn.Open()
            Dim b As New OleDbCommand(sql, cnn)
            Dim z As OleDbDataReader = b.ExecuteReader

            If z.HasRows Then
                z.Read()
                diasdiff = DateDiff(DateInterval.Day, Now(), z.GetValue(0))

                If diasdiff < 0 Then
                    ' día de inicio anterior a hoy
                    vuelta = 1
                Else
                    vuelta = 0
                End If
                cnn.Close()

            End If
        Catch ex As Exception
            MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

        FCPenFuturo = vuelta

    End Function
    Public Function DameIdSB(dato As Integer) As Integer

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim id As Integer

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT IdSBacklog FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint =" & dato
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            id = CInt(existe.GetValue(0))
            cdu.Close()
            DameIdSB = id

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            id = -1
            DameIdSB = id
        End Try

    End Function
    Public Function MontarDiasDetalle(dato As Integer) As String

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim diasdet As String = ""
        Dim d As Integer
        Dim i As Integer
        Dim h As Integer
        Dim sql As String
        Dim v As String = "PB"

        Try
            cdu.Open()

            sql = "SELECT Duracion FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint =" & dato
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            If IsNumeric(existe.GetValue(0)) Then
                d = CInt(existe.GetValue(0))
            Else
                d = 0
            End If


            sql = "SELECT HorasDia FROM Proyectos WHERE IdProyecto = " & IDPROYECTO
            Dim bbuscar As New OleDbCommand(sql, cdu)
            Dim exi As OleDbDataReader = bbuscar.ExecuteReader
            exi.Read()
            If IsNumeric(exi.GetValue(0)) Then
                h = CInt(exi.GetValue(0))
            Else
                h = 0
            End If
            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            diasdet = "FALLO"
            MontarDiasDetalle = diasdet
        End Try


        If diasdet = "FALLO" Then

        Else
            Dim itexto As String = ""
            Dim htexto As String = ""

            diasdet = "|"
            For i = 1 To d
                If i < 10 Then
                    itexto = "0" & i.ToString
                Else
                    itexto = i.ToString
                End If
                If v = "PB" Then
                    htexto = "YY"
                Else
                    If h < 10 Then
                        htexto = "0" & h.ToString
                    Else
                        htexto = h.ToString
                    End If
                End If
                diasdet = diasdet & itexto & "/" & htexto & "|"
            Next

        End If


        MontarDiasDetalle = diasdet

    End Function

    Public Function DameObjetivoSprint(ByVal ispr As Integer) As String

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim objetivo As String = ""
        Dim sql As String

        Try
            cdu.Open()

            sql = "SELECT Objetivo FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint =" & ispr
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                existe.Read()
                objetivo = existe.GetValue(0)
            End If

            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

        Return objetivo
    End Function

    Public Function DameDiasSprint() As Integer
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim dias As Integer
        Dim fi, ff As Date
        Dim ns As Integer
        Dim sql As String = ""

        Try
            cdp.Open()
            sql = "SELECT FechaInicio, FechaFin, NumeroDeSprints FROM Proyectos WHERE IdProyecto = " & IDPROYECTO
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            fi = CDate(existe.GetValue(0))
            ff = CDate(existe.GetValue(1))
            ns = CInt(existe.GetValue(2))
            cdp.Close()
            dias = CInt(DateDiff(DateInterval.Day, fi, ff) / ns)

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            dias = -1
        End Try

        Return dias
    End Function

    Public Function DameDuracionSprintEnBD(ByVal ispr As Integer) As Integer

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim duracion As Integer
        Dim sql As String

        Try
            cdu.Open()

            sql = "SELECT Duracion FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint =" & ispr
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                existe.Read()
                duracion = CInt(existe.GetValue(0))

            End If

            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            duracion = -1
        End Try

        Return duracion
    End Function
    Public Function DameDuracionMaxHistEnSprint(ByVal ispr As Integer) As Integer
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim duracion As Integer
        Dim sql As String

        Try
            cdu.Open()

            sql = "SELECT Max(Duracion) as xxx FROM SBacklog WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint =" & ispr
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                existe.Read()
                If IsNumeric(existe.GetValue(0)) Then
                    duracion = CInt(existe.GetValue(0))
                Else
                    duracion = 0
                End If
            End If
            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            duracion = -1
        End Try

        Return duracion

    End Function

    Public Function DameHorasDiaProyecto() As Integer
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim hproyecto As Integer

        Try
            cdp.Open()
            Dim sql As String
            sql = "SELECT HorasDia FROM Proyectos WHERE IdProyecto = " & IDPROYECTO
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            hproyecto = CInt(existe.GetValue(0))
            cdp.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            hproyecto = -1
        End Try

        Return hproyecto
    End Function
    Public Function DameIdUsuario(usr As String) As Integer

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim usuario As Integer

        Try
            cdu.Open()
            Dim sql As String
            sql = "SELECT IdUser FROM Usuarios WHERE Nombre = '" & usr & "'"
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            usuario = CInt(existe.GetValue(0))
            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            usuario = -2
        End Try
        Return usuario
    End Function
    Public Function ComprobarEstadoHistoriasDeSprint(isp As Integer) As Integer
        Dim v As Integer = 0

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim hmany As Integer
        Dim sql As String
        Dim resp As Integer

        Try
            cdu.Open()

            sql = "SELECT Count(IdHistoria) AS xxx "
            sql = sql & "FROM SBacklog "
            sql = sql & "WHERE ((((SBacklog.Estado) <>'Terminado' And (SBacklog.Estado) <>'Liberada')) AND "
            sql = sql & "((SBacklog.IdProyecto) = " & IDPROYECTO & ") AND ((SBacklog.IdSprint) = " & isp & "))"

            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            existe.Read()
            hmany = CInt(existe.GetValue(0))
            cdu.Close()

            If hmany <> 0 Then
                resp = MsgBox("Este sprint tiene historias aún no terminadas." & vbNewLine & "Si continua el sistema terminará esas historias por Vd." & vbNewLine & vbNewLine & "Quiere continuar de todas formas?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "SCRUM Wizard")
                If resp = vbYes Then
                    v = 2
                Else
                    v = 0
                End If
            Else
                v = 1
            End If

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            v = -1
        End Try

        Return v
    End Function
    Public Function CerrarSprint(isp As Integer)
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim comando As New OleDbCommand()
        Dim sql As String
        Dim v As Integer = 0

        Try

            sql = "UPDATE Sprints SET Cerrado = True WHERE ((IdProyecto = " & IDPROYECTO & ") AND (IdSprint = " & isp & "))"
            comando.Connection = cnn
            cnn.Open()
            comando.CommandText = sql
            comando.ExecuteNonQuery()
            cnn.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = -1
        End Try

        Return v
    End Function
    Public Function TerminarHistoriasSprint(isp As Integer) As Boolean
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)

        Dim trans As OleDbTransaction
        Dim comando As New OleDbCommand()
        Dim Historias(1000) As Integer

        Dim sql As String = ""
        Dim sql1 As String = ""
        Dim sql2 As String = ""

        Dim i, j As Integer

        Dim v As Boolean = True
        'para recorrer
        sql2 = "SELECT PBacklog.IdHistoria FROM PBacklog, SBacklog WHERE "
        sql2 = sql2 & "((PBacklog.IdHistoria = SBacklog.IdHistoria) AND (PBacklog.NumSprint = SBAcklog.IdSprint) AND "
        sql2 = sql2 & "(PBackLog.IdProyecto = Sbacklog.IdProyecto) AND (SBacklog.IdProyecto = " & IDPROYECTO & ") AND (Sbacklog.IdSprint = " & isp & "))"

        cdu.Open()
        Dim buscar As New OleDbCommand(sql2, cdu)
        Dim existe As OleDbDataReader = buscar.ExecuteReader

        i = 0
        While existe.Read()
            Historias(i) = CInt(existe.GetValue(0))
            i += 1
        End While
        cdu.Close()


        comando.Connection = cnn
        cnn.Open()
        trans = cnn.BeginTransaction()
        comando.Connection = cnn
        comando.Transaction = trans

        'actualizacion sbacklog
        sql = "UPDATE SBacklog SET Estado = 'Terminado' WHERE ((IdProyecto = " & IDPROYECTO & ") AND (IdSprint = " & isp & "))"

        Try
            'ejecuto sql
            comando.CommandText = sql
            comando.ExecuteNonQuery()

            'actualizacion pbacklog
            For j = 0 To i - 1
                sql1 = "UPDATE PBacklog SET Estado = 'Terminado' WHERE ((PBacklog.IdProyecto = " & IDPROYECTO & ") AND (PBacklog.NumSprint = " & isp & ") AND "
                sql1 = sql1 & "(PBacklog.IdHistoria = " & Historias(j) & "))"
                'ejecuto ssql
                comando.CommandText = sql1
                comando.ExecuteNonQuery()
            Next j

            trans.Commit()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            trans.Rollback()
            v = False
        End Try

        Return v
    End Function
    Public Function EstaElSprintCerrado(ByVal ispr As Integer) As Boolean

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim v As Boolean = False
        Dim sql As String

        Try
            cdu.Open()

            sql = "SELECT Cerrado FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint =" & ispr
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                existe.Read()
                v = CBool(existe.GetValue(0))
            End If

            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = False
        End Try

        Return v
    End Function
    Public Function SprintCerradooCancelado(ByVal ispr As Integer) As Boolean

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim v As Boolean = False
        Dim sql As String

        Try
            cdu.Open()

            sql = "SELECT Cerrado, Cancelado FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint =" & ispr
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                existe.Read()
                v = CBool(existe.GetValue(0)) Or CBool(existe.GetValue(1))
            End If

            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = True
        End Try

        Return v
    End Function
    Public Function DameHistoriasAfectadasPorCancelacionSprint(ByVal ispr As Integer, ByRef hh() As Integer) As Integer

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim v As Integer = 0
        Dim sql As String

        Try
            cdu.Open()

            sql = "SELECT IdHistoria FROM PBacklog WHERE IdProyecto = " & IDPROYECTO & " AND NumSprint = " & ispr & " AND Estado <> 'Liberada' AND Estado <> 'Terminado'"

            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    hh(v) = CInt(existe.GetValue(0))
                    v += 1
                End While
            End If

            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = -1
        End Try

        Return v

    End Function
    Public Function DameDuracionSprint(ByVal Ispr As Integer) As Integer

        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim v As Integer = 0

        Dim sql As String

        Try
            cdu.Open()

            sql = "SELECT Duracion FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint = " & Ispr

            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    v = CInt(existe.GetValue(0))
                End While
            End If
            cdu.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = -1
        End Try

        Return v

    End Function
    Public Function DuracionSPM(ByVal dpry As Integer) As Double
        Dim v As Double

        v = (dpry * 8) / 20

        Return v
    End Function
    Public Function DuracionSR(ByVal dpry As Integer) As Double
        Dim v As Double

        v = (dpry * 4) / 20

        Return v
    End Function
    Public Function DuracionSRetro(ByVal dpry As Integer) As Double
        Dim v As Double

        v = (dpry * 3) / 20

        Return v
    End Function

    Public Function AsistentesConocatoria(dgv As DataGridView, ByVal tipo As String) As Integer
        Dim v As Integer

        ' Se visualiza el equipo completo de ese proyecto
        Dim sql As String = ""

        sql = "SELECT Usuarios.IdUser, Usuarios.Nombre, Roles.NombreRol FROM Equipos, Proyectos, Roles, Usuarios "
        sql = sql & "WHERE (((Proyectos.IdProyecto) = " & IDPROYECTO & ") AND ((Equipos.IdEquipo)=[Proyectos].[IdEquipo]) AND ((Usuarios.IdUser)=[Equipos].[IDPersona]) "
        If tipo = "ST" Then ' todo el equipo
            sql = sql & "AND ((Roles.IdRol)=[Equipos].[IdRolPersona]))"
        ElseIf tipo = "DT" Then ' solo equipo de desarrollo
            sql = sql & "AND ((Roles.IdRol)=[Equipos].[IdRolPersona]) AND ((Roles.IdRol) = 3))"
        Else
            v = -1
        End If

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim pb As OleDbDataReader = buscar.ExecuteReader

            If pb.HasRows Then
                While pb.Read
                    dgv.Rows.Add(pb.GetValue(1), pb.GetValue(2), pb.GetValue(0))
                End While
                cnn.Close()
                v = 0
            Else
                MsgBox("No existe personal asignado al proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
                v = -1
            End If


        Catch ex As Exception
            MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = -1
        End Try

        Return v

    End Function
    Public Function YaNotificado(ByVal ispr As Integer) As Boolean
        Dim v As Boolean = False

        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim sql As String = ""

        Try
            cdp.Open()
            sql = "SELECT Notificado FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint = " & Ispr
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            v = CBool(existe.GetValue(0))

            cdp.Close()
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            v = False
        End Try

        Return v
    End Function
    Public Function EnviarNotificaciones(ByVal cual As String, ByVal IdS As Integer, ByVal fecha As Date, dgv As DataGridView, ByVal hora As Date, ByVal duracionreunion As String, ByVal AuxAnterior As Integer) As Boolean
        Dim aviso As String = ""
        Dim v As Boolean = False
        Dim IdNot As Integer
        Dim hoy As Date = Now()
        Dim pasado As Boolean
        Dim max As Integer
        Dim i, j As Integer
        Dim duracion As Integer
        Dim dia As Date
        Dim sql As String = ""
        Dim ssql As String = ""
        Dim valor As Integer = 0
        Dim vvalor As Integer = 0


        max = dgv.RowCount - 1

        IdNot = DameSgteIdNotificaciones(IdS)
        pasado = (hoy > fecha)
        IdNot = DameSgteIdNotificaciones(IdS)
        If cual = "Planificacion" Then
            aviso = "Convocatoria Reunión de Planificación de Sprint"
            valor = 8
        ElseIf cual = "Revision" Then
            aviso = "Convocatoria Reunión de Revisión de Sprint"
            valor = 2
        ElseIf cual = "Diaria" Then
            aviso = "Convocatoria Reunión Daily Scrum"
            valor = 4
        ElseIf cual = "Retrospectiva" Then
            aviso = "Convocatoria Reunión de Retrospecctiva de Sprint"
            valor = 1
        End If


        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Dim trans As OleDbTransaction
        Dim comando As New OleDbCommand()
        comando.Connection = cnn
        cnn.Open()

        trans = cnn.BeginTransaction()
        comando.Connection = cnn
        comando.Transaction = trans

        For i = 0 To max
            If cual = "Diaria" Then
                duracion = DameDuracionSprintEnBD(IdS)
                dia = fecha

                For j = 1 To duracion - 3
                    sql = "INSERT INTO Notificaciones (IdNotificacion, Aviso, IdProyecto, IdSprint, Fecha, Quien, Leido, Overdued, Hora, Duracion) VALUES "
                    sql = sql & "(" & IdNot & ", '" & aviso & "', " & IDPROYECTO & ", " & IdS & ", '" & dia & "'," & CInt(dgv.Rows(i).Cells(2).Value) & ", False," & pasado & ", '" & hora & "','" & duracionreunion & "')"
                    IdNot += 1
                    dia = DateAdd(DateInterval.Day, CDbl(1), dia)

                    Try
                        'ejecuto sql
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                        trans.Rollback()
                        j = duracion + 5
                        i = max + 5
                        v = False
                    End Try

                Next j
            Else
                'resto de reuniones
                sql = "INSERT INTO Notificaciones (IdNotificacion, Aviso, IdProyecto, IdSprint, Fecha, Quien, Leido, Overdued, Hora, Duracion) VALUES "
                sql = sql & "(" & IdNot & ", '" & aviso & "', " & IDPROYECTO & ", " & IdS & ", '" & fecha & "'," & CInt(dgv.Rows(i).Cells(2).Value) & ", False," & pasado & ", '" & hora & "', '" & duracionreunion & "')"
                IdNot += 1
                Try
                    'ejecuto sql
                    comando.CommandText = sql
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                    i = max + 5
                    trans.Rollback()
                    v = False
                End Try
            End If
            If i <> max + 5 And j <> duracion + 5 Then v = True
        Next i

        If v Then
            sql = "UPDATE Sprints SET Auxiliar = " & AuxAnterior + valor & " WHERE IdProyecto =" & IDPROYECTO & " AND IdSprint = " & IdS
            Try
                'ejecuto sql
                comando.CommandText = sql
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                trans.Rollback()
                v = False
            End Try
            If v Then trans.Commit()
        End If

        Return v

    End Function
    Public Function DameSgteIdNotificaciones(ByVal IdS As Integer) As Integer
        Dim v As Integer
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim sql As String = ""

        Try
            cdp.Open()
            sql = "SELECT Max(IdNotificacion) as XXX FROM Notificaciones" ' WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint = " & IdS
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            If Not IsNumeric(existe.GetValue(0)) Then
                v = 1
            Else
                v = CInt(existe.GetValue(0)) + 1
            End If
            cdp.Close()
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            v = 0
        End Try
        Return v
    End Function
    Public Function conversor(ByVal tipo As String, ByVal Dato As Long, ByRef reunion() As String) As Long

        Dim Residuo As String 'Declaramos el Residuo
        Dim resultado As String = ""
        Dim vuelta As Long = 0
        Dim i As Integer = 0
        Dim car As String = ""
        Dim mul As Integer = 0
        Dim bloque As String = ""

        Dim Numero As Long 'Declaramos la Variable que manejará el numero

        If tipo = "DaB" Then ' decimal a binario
            i = 0
            Numero = Dato ' le damos el valor del textbox a la variable numerica

            Do
                Residuo = Numero Mod 2 'Obtenemos el Residuo de la division
                resultado = resultado & Trim(Str(Residuo))
                Numero = Int(Numero / 2) 'Obtenemos el entero de la division
                reunion(i) = Residuo
                i += 1
            Loop Until Numero < 2 'Seguimos haciendo la operación hasta que el numero sea 0 o 1

            If (Numero = 1) Then 'verificamos que valor tenemos como ultimo residuo o mejor dicho como ultimo numero
                resultado = "1" & StrReverse(resultado)
                reunion(i) = 1
            Else
                resultado = StrReverse(resultado)
                reunion(i) = 0
            End If
            vuelta = CLng(resultado)

        Else 'de binario a decimal

            vuelta = 0
            bloque = Trim(Dato.ToString)

            For i = 4 To 1 Step -1
                mul = 2 ^ (i - 1)
                bloque = Microsoft.VisualBasic.Left(bloque, i)
                car = Microsoft.VisualBasic.Right(bloque, 1)
                vuelta = vuelta + (CLng(car) * mul)
            Next i

        End If

        Return vuelta

    End Function
    Public Function DameValorAuxiliarSprint(ByVal IdS As Integer) As Integer
        Dim v As Integer = 0
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim sql As String = ""

        Try
            cdp.Open()
            sql = "SELECT Auxiliar FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint = " & IdS
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            If Not IsNumeric(existe.GetValue(0)) Then
                v = 0
            Else
                v = CInt(existe.GetValue(0))
            End If
            cdp.Close()
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            v = 0
        End Try

        Return v
    End Function
    Public Function SeHaNotificado(ByVal tipo As String, ByVal IdS As Integer, ByRef reunion() As String) As Long

        Dim v As Long
        Dim ccad As Long
        Dim cad As String

        v = DameValorAuxiliarSprint(IdS)
        ccad = conversor("DaB", CLng(v), reunion)
        cad = ccad.ToString

        Return v

    End Function

    Public Function DameCadenaFormateada(ByVal numero As Double) As String
        Dim v As String = ""
        Dim ent As Integer = 0
        Dim dec As Double = 0
        Dim ParteEntera As String = ""
        Dim ParteDecimal As String = ""

        ent = Math.Truncate(numero)
        dec = numero - ent

        ParteEntera = ent.ToString
        ParteDecimal = dec.ToString

        If Len(ParteEntera) < 2 Then ParteEntera = "0" & ParteEntera
        If Len(ParteDecimal) = 3 Then
            ParteDecimal = Microsoft.VisualBasic.Right(ParteDecimal, 1) & "0"
        ElseIf Len(ParteDecimal) = 4 Then
            ParteDecimal = Microsoft.VisualBasic.Right(ParteDecimal, 2)
        ElseIf Len(ParteDecimal) = 0 Then
            ParteDecimal = "00"
        ElseIf Len(ParteDecimal) = 1 Then
            ParteDecimal = ParteDecimal & "0"
        Else
            ParteDecimal = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(ParteDecimal, 4), 2)
        End If

        v = ParteEntera & ":" & ParteDecimal

        Return v
    End Function

    Public Function CargaNotificaciones(dgv As DataGridView, dgv1 As DataGridView, notis() As Boolean) As Boolean
        Dim v As Boolean = False
        Dim i As Integer = 0
        Dim hora As String
        Dim dia As Date
        Dim hmdias As Integer = 0

        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim sql As String = ""

        Try
            cdp.Open()
            sql = "SELECT Leido, Fecha, Hora, Duracion, Aviso, IdNotificacion FROM Notificaciones WHERE IdProyecto = " & IDPROYECTO & " AND Quien = " & IDUSER & " And Overdued = False And Leido = False"
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                dgv.Rows.Clear()

                While existe.Read()
                    dia = existe.GetValue(1)
                    hora = existe.GetValue(2)
                    hmdias = DateDiff(DateInterval.Day, Now(), dia)
                    hora = FormatDateTime(hora, DateFormat.ShortTime)
                    dgv.Rows.Add(existe.GetValue(0), existe.GetValue(1), hora, existe.GetValue(3), existe.GetValue(4), existe.GetValue(5))
                    notis(i) = CBool(existe.GetValue(0))
                    If hmdias = 0 Then ' la reunión es hoy
                        dgv.Rows(i).Cells(0).Style.BackColor = Color.Red
                        dgv.Rows(i).Cells(0).Style.ForeColor = Color.White
                    ElseIf hmdias = 1 Then ' la reunión es mañana
                        dgv.Rows(i).Cells(0).Style.BackColor = Color.LightPink
                        dgv.Rows(i).Cells(0).Style.ForeColor = Color.White
                    ElseIf hmdias > 3 Then ' la reunión es en 3 días
                        'sin color
                    ElseIf hmdias > 0 Then
                        dgv.Rows(i).Cells(0).Style.BackColor = Color.LightYellow
                        dgv.Rows(i).Cells(0).Style.ForeColor = Color.Black
                    Else ' sobrepadado
                    End If

                    i += 1
                End While
                v = True
                dgv.Tag = "HAY"
            Else
                MsgBox("No hay notificaciones.", MsgBoxStyle.Information, "SCRUM Wizard")
                dgv.Tag = "NOHAY"
                v = True
            End If

            If v Then
                ' Ahora trato las pasadas (overdued)
                sql = "SELECT Leido, Fecha, Hora, Duracion, Aviso FROM Notificaciones WHERE IdProyecto = " & IDPROYECTO & " AND Quien = " & IDUSER & " And Overdued = True And Leido = False"
                Dim bbuscar As New OleDbCommand(sql, cdp)
                Dim eexiste As OleDbDataReader = bbuscar.ExecuteReader
                If eexiste.HasRows Then
                    dgv1.Rows.Clear()
                    While eexiste.Read()
                        hora = eexiste.GetValue(2)
                        hora = FormatDateTime(hora, DateFormat.ShortTime)
                        dgv1.Rows.Add(eexiste.GetValue(0), eexiste.GetValue(1), hora, eexiste.GetValue(3), eexiste.GetValue(4))
                    End While
                    cdp.Close()
                    dgv1.Tag = "HAY"
                Else
                    dgv1.Tag = "NOHAY"
                End If
            End If
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = False
        End Try

        Return v
    End Function

    Public Function GuardarCambiosNotificaciones(dgv As DataGridView, notis() As Boolean) As Boolean
        Dim v As Boolean = True
        Dim fila As Integer = 0
        Dim NumFilas As Integer = 0
        Dim sql As String = ""
        Dim leido As Boolean = False
        Dim IdNot As Integer = 0
        Dim i As Integer

        NumFilas = dgv.RowCount

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Dim trans As OleDbTransaction
        Dim comando As New OleDbCommand()
        comando.Connection = cnn
        cnn.Open()

        trans = cnn.BeginTransaction()
        comando.Connection = cnn
        comando.Transaction = trans

        Try
            For i = 0 To NumFilas - 1
                leido = dgv.Rows(i).Cells(0).Value
                If leido = notis(i) Then
                    ' no hay que hacer nada pues no ha habio cambio
                Else
                    IdNot = CInt(dgv.Rows(i).Cells(5).Value)
                    ' ha cambiado, luego hay que salvar

                    sql = "UPDATE Notificaciones SET Leido = " & leido & " WHERE IdNotificacion = " & IdNot

                    'ejecuto sql
                    comando.CommandText = sql
                    comando.ExecuteNonQuery()
                End If
            Next i

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            trans.Rollback()
            v = False
        End Try
 
        If v Then trans.Commit()


        Return v


    End Function
    Public Function ActivarSprint(ByVal isp As Integer) As Boolean

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim comando As New OleDbCommand()
        Dim sql As String
        Dim v As Integer = 0

        Try

            sql = "UPDATE Sprints SET Activo = True WHERE ((IdProyecto = " & IDPROYECTO & ") AND (IdSprint = " & isp & "))"
            comando.Connection = cnn
            cnn.Open()
            comando.CommandText = sql
            comando.ExecuteNonQuery()
            cnn.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = -1
        End Try

        Return v
    End Function
    Public Function GeneraInformeSgtoPry(dgv As DataGridView) As Boolean
        Dim v As Boolean
        Dim estado As String

        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim sql As String = ""

        Try
            cdp.Open()
            sql = "SELECT IdSprint, FComienzo, Duracion, Cerrado, Cancelado, Activo FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " ORDER BY IdSprint"
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader


            While existe.Read()
                If CBool(existe.GetValue(5)) Then
                    estado = "Activo"
                ElseIf CBool(existe.GetValue(4)) Then
                    estado = "Cancelado"
                ElseIf CBool(existe.GetValue(3)) Then
                    estado = "Cerrado"
                Else
                    estado = "Planificado"
                End If

                dgv.Rows.Add(existe.GetValue(0), Trim(Microsoft.VisualBasic.Left(existe.GetValue(1), 10)), existe.GetValue(2) & " d", estado)

            End While
            v = True
            cdp.Close()
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            v = False
        End Try

        Return v
    End Function
    Public Function DameFCProyecto() As Date
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim hproyecto As Date

        Try
            cdp.Open()
            Dim sql As String
            sql = "SELECT FechaInicio FROM Proyectos WHERE IdProyecto = " & IDPROYECTO
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            hproyecto = CDate(existe.GetValue(0))
            cdp.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            hproyecto = Now()
        End Try

        Return hproyecto
    End Function
    Public Function GeneraInformeSgtoSpr(dgv As DataGridView, ByVal IdS As Integer) As Boolean
        Dim v As Boolean
        Dim estado As String = ""
        Dim fecha As String
        Dim horas As Integer = 0
        Dim hhoras As String = ""

        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim sql As String = ""

        Try
            cdp.Open()
            sql = "SELECT NombreHistoria, Duracion, Estado, DetalleDias FROM SBacklog WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint = " & IdS & " ORDER BY IdHistoria"
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            fecha = Trim(Microsoft.VisualBasic.Left(DameFCSprint(IdS).ToString, 10))

            While existe.Read()
                horas = DimeHoras(existe.GetValue(3))
                If horas = 0 Then hhoras = "N/D" Else hhoras = horas.ToString
                dgv.Rows.Add(existe.GetValue(0), fecha, existe.GetValue(1) & " d", hhoras & " h", existe.GetValue(2))
            End While
            v = True
            cdp.Close()
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            v = False
        End Try

        Return v
    End Function
    Public Function DameFCSprint(ByVal IdS As Integer) As Date
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim hproyecto As Date

        Try
            cdp.Open()
            Dim sql As String
            sql = "SELECT FComienzo FROM Sprints WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint = " & IdS
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            existe.Read()
            hproyecto = CDate(existe.GetValue(0))
            cdp.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            hproyecto = Now()
        End Try

        Return hproyecto
    End Function

    Public Function DimeHoras(ByVal detalle As String) As Integer
        Dim v As Integer = 0
        Dim longitud As Integer = 0
        Dim numbloques As Integer = 0
        Dim i As Integer = 0
        Dim pp As Integer = 0
        Dim hh As String = ""


        longitud = Len(detalle)
        numbloques = (longitud - 1) / 6

        For i = 1 To numbloques
            pp = i * 6
            hh = Mid(detalle, (pp - 1), 2)
            If hh <> "YY" Then v += CInt(hh)
        Next i

        Return v
    End Function

End Module
