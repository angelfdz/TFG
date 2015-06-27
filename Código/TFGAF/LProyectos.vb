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


Public Class LProyectos

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim hay As Boolean = False


        If IDUSER <> -1 Then
            Try
                cnn.Open()
                Dim sql As String
                sql = "SELECT Proyectos.IDProyecto, Proyectos.NombrePry, Equipos.IdRolPersona, Proyectos.Terminado, Proyectos.Cancelado FROM Equipos INNER JOIN Proyectos ON Equipos.IdEquipo = Proyectos.IdEquipo WHERE(Equipos.IDPersona = " & IDUSER & ") ORDER BY Proyectos.NombrePry"
                Dim buscar As New OleDbCommand(sql, cnn)
                Dim proyectos As OleDbDataReader = buscar.ExecuteReader
                DGVProy.Rows.Clear()
                If proyectos.HasRows Then
                    While proyectos.Read
                        If proyectos.GetValue(3) = True Or proyectos.GetValue(4) = True Then
                            'cuando el proyecto está terminado o cancelado no se muestra
                        Else
                            DGVProy.Rows.Add(proyectos.GetValue(0), proyectos.GetValue(1), proyectos.GetValue(2), "Seleccionar")
                            hay = True
                        End If
                    End While
                    cnn.Close()
                Else
                    MsgBox("No tiene proyectos abiertos asignados.", MsgBoxStyle.Information, "SCRUM Wizard")
                End If

                ' cuando todos los proyectos que pudiera tener están terminados o cancelados o no tiene
                If Not hay Then
                    pnlNoProyectos.Visible = True
                    DGVProy.Visible = False
                End If


            Catch ex As Exception
                MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try
        Else
            ' Ha entrado el Administrador
        End If
    End Sub

    Private Sub ClickEnBoton(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProy.CellClick
        If DGVProy.CurrentCell.ColumnIndex = 3 Then
            IDPROYECTO = DGVProy.CurrentRow.Cells(0).Value
            ROLUSER = DGVProy.CurrentRow.Cells(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub ButCrearNProyecto_Click(sender As Object, e As EventArgs) Handles ButCrearNProyecto.Click
        IDPROYECTO = 0
        ROLUSER = 1 ' Solo puedo crear proyectos como PO
        Me.Close()
    End Sub


End Class