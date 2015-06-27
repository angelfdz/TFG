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
Public Class frmReleases

    Private Sub frmReleases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim punto As New Point(50, 50)
        Me.Location = punto
        Me.Width = 859
        Me.Height = 185
        pnlProyecto.Width = 831
        pnlProyecto.Height = 161
        lblCabecera.Text = "Generación de la 'Release' para el proyecto"

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim sql As String
            sql = "SELECT Max(IdRelease) AS xxx FROM Releases WHERE IdProyecto = " & IDPROYECTO

            Dim buscar As New OleDbCommand(sql, cnn)
            Dim usuarios As OleDbDataReader = buscar.ExecuteReader

            If usuarios.HasRows Then
                usuarios.Read()
                If String.IsNullOrEmpty(usuarios.GetValue(0).ToString) Then
                    txtIdRelease.Text = 1
                Else
                    txtIdRelease.Text = CInt(usuarios.GetValue(0)) + 1
                End If
                cnn.Close()
            Else
                txtIdRelease.Text = 1
            End If
            txtNRelease.Text = ""
        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try


        DGVHCandidatas.Enabled = False
        DGVHRelease.Enabled = False
        butQuitar.Enabled = False
        butAnadir.Enabled = False
        butGuardar.Enabled = False
        butIncluir.Enabled = True
        txtIdRelease.Enabled = False

    End Sub

 
    Private Sub butSalir_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        Dim resp As Integer

        resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then
            DGVHCandidatas.Enabled = False
            DGVHRelease.Enabled = False
            butQuitar.Enabled = False
            butAnadir.Enabled = False
            DGVHCandidatas.Rows.Clear()
            DGVHRelease.Rows.Clear()
            Me.Close()
        Else
            'seguir aqui
        End If
    End Sub

    Private Sub butIncluir_Click(sender As Object, e As EventArgs) Handles butIncluir.Click

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim sql As String = ""
        Dim k As Integer = 0


        If butIncluir.Text = "Incluir" Then

            sql = "SELECT PBacklog.IdHistoria, PBacklog.NHistoria FROM PBacklog WHERE PBacklog.IdProyecto =" & IDPROYECTO & " AND "
            sql = sql & "PBacklog.Estado = 'Terminado' AND "
            sql = sql & "NOT EXISTS ("
            sql = sql & "SELECT IdProyecto, IdHistoria, Liberado FROM Releases WHERE "
            sql = sql & "PBacklog.Idproyecto = Releases.IDProyecto AND "
            sql = sql & "PBacklog.IdHistoria = Releases.IdHistoria AND "
            sql = sql & "Releases.Liberado = True)"

            Try
                cnn.Open()
                Dim buscar As New OleDbCommand(sql, cnn)
                Dim his As OleDbDataReader = buscar.ExecuteReader

                If his.HasRows Then
                    While his.Read()
                        DGVHCandidatas.Rows.Add(CInt(his.GetValue(0)), his.GetValue(1))
                    End While
                    cnn.Close()
                    k += 1
                Else
                    MsgBox("No hay historias candidatas a entrar en una release", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                End If

            Catch ex As Exception
                MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try


            If k <> 0 Then

                DGVHCandidatas.Enabled = True
                DGVHRelease.Enabled = True
                butQuitar.Enabled = False
                butAnadir.Enabled = True
                butIncluir.Enabled = False
                butGuardar.Enabled = True
                Me.Width = 859
                Me.Height = 419
                pnlProyecto.Width = 831
                pnlProyecto.Height = 395

            End If

        Else

        End If
    End Sub

    Private Sub butAnadir_Click(sender As Object, e As EventArgs) Handles butAnadir.Click
        Dim fila As Integer
        fila = DGVHCandidatas.CurrentCell.RowIndex
        DGVHRelease.Rows.Add(DGVHCandidatas.Rows(fila).Cells(0).Value, DGVHCandidatas.Rows(fila).Cells(1).Value)
        DGVHCandidatas.Rows.RemoveAt(fila)
        If DGVHCandidatas.RowCount = 0 Then
            butAnadir.Enabled = False
        Else
            butAnadir.Enabled = True
        End If
        butQuitar.Enabled = True
    End Sub

    Private Sub butQuitar_Click(sender As Object, e As EventArgs) Handles butQuitar.Click
        Dim fila As Integer
        fila = DGVHRelease.CurrentCell.RowIndex
        DGVHCandidatas.Rows.Add(DGVHRelease.Rows(fila).Cells(0).Value, DGVHRelease.Rows(fila).Cells(1).Value)
        DGVHRelease.Rows.RemoveAt(fila)
        If DGVHRelease.RowCount = 0 Then
            butQuitar.Enabled = False
        Else
            butQuitar.Enabled = True
        End If
        butAnadir.Enabled = True
    End Sub

    Private Sub butGuardar_Click(sender As Object, e As EventArgs) Handles butGuardar.Click
        If DGVHRelease.RowCount = 0 Then
            MsgBox("No ha seleccionado ninguna historia que incluir en esta Release", MsgBoxStyle.Exclamation, "SCRUM Wizard")
        ElseIf String.IsNullOrEmpty(txtNRelease.Text) Or String.IsNullOrWhiteSpace(txtNRelease.Text) Then
            MsgBox("Debe dar un nombre a la Release", MsgBoxStyle.Exclamation, "SCRUM Wizard")
        Else
            'Liberamos
            Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
            Dim sql As String = ""
            Dim ssql As String = ""
            Dim i As Integer

            Try
                cnn.Open()

                For i = 0 To DGVHRelease.RowCount - 1
                    sql = "INSERT INTO Releases VALUES ("
                    sql = sql & CInt(txtIdRelease.Text) & ", "
                    sql = sql & IDPROYECTO & ", "
                    sql = sql & "'" & txtNRelease.Text & "', "
                    sql = sql & CInt(DGVHRelease.Rows(i).Cells(0).Value) & ", "
                    sql = sql & "True)"

                    ssql = "UPDATE PBacklog SET "
                    ssql = ssql & "Estado = 'Liberada' "
                    ssql = ssql & "WHERE (IdProyecto = " & IDPROYECTO
                    ssql = ssql & " AND IdHistoria = " & CInt(DGVHRelease.Rows(i).Cells(0).Value) & ")"

                    Dim ccomando As New OleDbCommand(sql)
                    Dim comando As New OleDbCommand(ssql)

                    ccomando.Connection = cnn
                    comando.Connection = cnn

                    'ejecuto el sql
                    ccomando.ExecuteNonQuery()
                    comando.ExecuteNonQuery()

                Next i

                cnn.Close()

                DGVHCandidatas.Enabled = False
                DGVHRelease.Enabled = False
                butQuitar.Enabled = False
                butAnadir.Enabled = False
                DGVHCandidatas.Rows.Clear()
                DGVHRelease.Rows.Clear()

                Me.Close()

            Catch ex As Exception
                MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try


        End If
    End Sub
End Class