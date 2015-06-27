
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
Public Class frmCancelarSprint

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        Me.Close()
    End Sub

    Private Sub frmCancelarSprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'primero hay que elegir para que Sprint del proyecto quiere trabajar
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim punto As New Point(50, 50)

        lstSelSprint.Items.Clear()
        lstAux.Items.Clear()
        Me.Location = punto

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
                pnlCancelarSprint.Visible = True
            Else
                MsgBox("No hay Sprints aún en este Proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try



    End Sub

    Private Sub butCancelarSprint_Click(sender As Object, e As EventArgs) Handles butCancelarSprint.Click
        'cuando cancelo el sprint
        Dim texto As String
        Dim resp As Integer
        Dim hh(999) As Integer
        Dim max As Integer
        Dim i As Integer = 0
        Dim iHis As Integer = 0
        Dim IdS As Integer
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim cdu As New OleDbConnection(My.Settings.tfgConnectionString)

        Dim trans As OleDbTransaction
        Dim comando As New OleDbCommand()
        Dim Historias(1000) As Integer

        Dim sql As String = ""
        Dim sql1 As String = ""
        Dim sql2 As String = ""
        Dim ssql As String = ""

        IdS = CInt(lstSelSprint.SelectedItem)


        texto = "La cancelación del sprint supone: " & vbNewLine & vbNewLine
        texto = texto & "1) Pasar a 'Accionables' todas las historias no terminadas del Sprint" & vbNewLine
        texto = texto & "2) Las historias quedan desligadas del Sprint tanto en el PB como en el SB y se marcan como del Sprint '-1'" & vbNewLine
        texto = texto & "3) El Sprint no podrá volver a ser utilizado" & vbNewLine & vbNewLine
        texto = texto & "Podría suponer generar situaciones de inconsistencia." & vbNewLine & vbNewLine
        texto = texto & "Desea continuar de todas formas?"
        resp = MsgBox(texto, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "SCRUM Wizard")
        If resp = vbYes Then
            max = DameHistoriasAfectadasPorCancelacionSprint(IdS, hh)

            comando.Connection = cnn
            cnn.Open()
            trans = cnn.BeginTransaction()
            comando.Connection = cnn
            comando.Transaction = trans

            sql = "SELECT IdHistoria FROM PBacklog WHERE IdProyecto =" & IDPROYECTO & " AND NumSprint = " & IdS
            cdu.Open()
            Dim buscar As New OleDbCommand(sql, cdu)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            'recorro el PB
            While existe.Read()
                sql1 = "UPDATE PBackLog SET NumSprint = -1 "
                iHis = CInt(existe.GetValue(0))
                For i = 0 To max - 1
                    If hh(i) = iHis Then
                        ' pasar a accionable
                        sql1 = sql1 & ", Estado = 'Accionable' "
                        i = max + 3
                    End If
                Next
                sql1 = sql1 & "WHERE IdProyecto = " & IDPROYECTO & " AND NumSprint = " & IdS & " AND IdHistoria = " & iHis

                'SB
                sql2 = "UPDATE SBackLog SET IdSprint = -1 "
                If i = max + 3 Then sql2 = sql2 & ", Estado = 'Accionable' "
                sql2 = sql2 & "WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint = " & IdS & " AND IdHistoria = " & iHis

                ' Y ahora el Sprint ha canacelado
                ssql = "UPDATE Sprints SET Cancelado = True WHERE IdProyecto = " & IDPROYECTO & " AND IdSprint = " & IdS


                Try

                    'ejecuto sql
                    comando.CommandText = sql1
                    comando.ExecuteNonQuery()

                    comando.CommandText = sql2
                    comando.ExecuteNonQuery()

                    comando.CommandText = ssql
                    comando.ExecuteNonQuery()


                Catch ex As Exception
                    MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                    MsgBox(ex.HResult)
                    trans.Rollback()
                End Try

            End While
            trans.Commit()
            cdu.Close()
            Me.Close()

        Else
            'no hacer nada
        End If

    End Sub
End Class