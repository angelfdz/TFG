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
Public Class frmVerRel

    Private Sub butRelYGenSalir_Click(sender As Object, e As EventArgs) Handles butRelYGenSalir.Click
        DGVRelYaGen.Rows.Clear()
        DGVRelYaGen.EndEdit()
        Me.Close()
    End Sub

    Private Sub frmVerRel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = ""
        Dim sql1 As String = ""
        Dim matriz(999, 1) As String ' primer campo Id de Historia, sgundo campo nombre de la release
        Dim i, j As Integer


        sql = "SELECT IdHistoria, NombreRelease FROM Releases WHERE IdProyecto = " & IDPROYECTO & " AND Liberado = True"


        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim pb As OleDbDataReader = buscar.ExecuteReader
            
            i = 0
            j = 0
            If pb.HasRows Then
                While pb.Read
                    matriz(i, 0) = pb.GetValue(0)
                    matriz(i, 1) = pb.GetValue(1)
                    i += 1
                End While
                pb.Close()

                Dim bbuscar As New OleDbCommand
                bbuscar.Connection = cnn

                For j = 0 To i - 1
                    sql1 = "SELECT NHistoria FROM PBackLog WHERE IdProyecto = " & IDPROYECTO & " AND IdHistoria = " & CInt(matriz(j, 0))

                    bbuscar.CommandText = sql1
                    Dim ppb As OleDbDataReader = bbuscar.ExecuteReader
                    If ppb.HasRows Then
                        ppb.Read()
                        DGVRelYaGen.Rows.Add(matriz(j, 1), ppb.GetValue(0))
                    End If
                    ppb.Close()
                Next

                cnn.Close()
            Else
                MsgBox("No existen 'Releases' en este proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

        Dim punto As New Point(50, 50)
        Me.Location = punto

    End Sub
End Class