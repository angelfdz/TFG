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

Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        'MsgBox(My.Application.Info.DirectoryPath)

        Try
            cnn.Open()
            Dim sql As String = String.Format("SELECT * FROM Usuarios WHERE Nombre ='{0}' AND Clave ='{1}'", UsernameTextBox.Text, PasswordTextBox.Text)
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                existe.Read()
                IDUSER = existe.GetValue(0)
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("Usuario y/o contraseña incorrectos!!!", MsgBoxStyle.Critical, "SCRUM Wizard")
            End If

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Application.EnableVisualStyles()
    End Sub

End Class
