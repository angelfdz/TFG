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
Public Class frmAdmin

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdministraciónDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónDeUsuariosToolStripMenuItem.Click
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim sql As String
            'presento usuarios existentes. quito el admin (-1) y el de trabajo (0)
            sql = "SELECT IdUser, Nombre, Clave FROM Usuarios WHERE IdUSer <> " & IDUSER & " And IdUser <> 0"
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim usuarios As OleDbDataReader = buscar.ExecuteReader

            If usuarios.HasRows Then
                While usuarios.Read
                    DGVUsuarios.Rows.Add(usuarios.GetValue(0), usuarios.GetValue(1), usuarios.GetValue(2), "SI")
                End While
                cnn.Close()
                butEliminar.Enabled = True
                butCambiar.Enabled = True
            Else
                DGVUsuarios.Rows.Add("1")
                DGVUsuarios.Tag = 1
                butEliminar.Enabled = False
                butCambiar.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try


        GBUsuarios.Visible = True
        AdministraciónDeUsuariosToolStripMenuItem.Enabled = False
        AdministraciónDeEquiposToolStripMenuItem.Enabled = False
        AdmistrarCuentaadminToolStripMenuItem.Enabled = False

        SalirToolStripMenuItem.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resp As Integer

        'resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        resp = vbYes
        If resp = vbYes Then
            ' Salgo. Esto es crítico para la siguiente vez (no quitar ni de coña)
            GBUsuarios.Visible = vbFalse
            DGVUsuarios.Rows.Clear()
            'DGVUsuarios.Rows(0).Cells(0).Value = 1
            DGVUsuarios.Tag = 1
            DGVUsuarios.EndEdit()
            butNuevo.Text = "Nuevo"
            AdministraciónDeUsuariosToolStripMenuItem.Enabled = True
            AdministraciónDeEquiposToolStripMenuItem.Enabled = True
            AdmistrarCuentaadminToolStripMenuItem.Enabled = True
            SalirToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butCambiar.Click
        ' Cambio un usuario en la base de datos
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        If butCambiar.Text = "Cambiar" Then
            txtClave.Enabled = True
            txtNombre.Enabled = True
            butCambiar.Text = "Guardar"
            butEliminar.Enabled = False
            butNuevo.Enabled = False
            btnSalir.Enabled = False
            DGVUsuarios.Enabled = False
            txtNombre.Focus()
        Else
            Try
                cnn.Open()
                Dim sql As String
                sql = "UPDATE Usuarios SET Nombre = '" & txtNombre.Text & "', "
                sql = sql & "Clave = '" & txtClave.Text & "' WHERE IdUser = " & txtNombre.Tag
                Dim comando As New OleDbCommand(sql)
                comando.Connection = cnn

                'ejecuto el sql

                    comando.ExecuteNonQuery()
                    cnn.Close()

                    'recrago grid
                    DGVUsuarios.Rows.Clear()

                    cnn.Open()
                    'Dim sql As String
                sql = "SELECT IdUSer, Nombre, Clave FROM Usuarios WHERE IdUSer <> " & IDUSER & " AND IdUser <> 0"
                    Dim bbuscar As New OleDbCommand(sql, cnn)
                    Dim uusuarios As OleDbDataReader = bbuscar.ExecuteReader

                    If uusuarios.HasRows Then
                        While uusuarios.Read
                            DGVUsuarios.Rows.Add(uusuarios.GetValue(0), uusuarios.GetValue(1), uusuarios.GetValue(2), "SI")
                        End While
                        cnn.Close()
                    Else
                    DGVUsuarios.Rows.Add("1")
                    DGVUsuarios.Tag = 1

                    End If

            Catch ex As Exception
                MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try

            txtClave.Enabled = False
            txtNombre.Enabled = False
            butCambiar.Text = "Cambiar"
            butEliminar.Enabled = True
            butNuevo.Enabled = True
            DGVUsuarios.Enabled = True
            btnSalir.Enabled = True
            txtNombre.Focus()
        End If
    End Sub


    Private Sub EnFila(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsuarios.RowEnter
        txtNombre.Text = DGVUsuarios.Rows(e.RowIndex).Cells(1).Value
        txtNombre.Tag = DGVUsuarios.Rows(e.RowIndex).Cells(0).Value
        txtClave.Text = DGVUsuarios.Rows(e.RowIndex).Cells(2).Value
        txtClave.Tag = DGVUsuarios.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub butEliminar_Click(sender As Object, e As EventArgs) Handles butEliminar.Click
        ' cuando voy a eliminar lo primero es ver que no está en equipos ese id
        ' si lo está no permitir esta operación
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        
        Try
            cnn.Open()
            Dim sql As String
            sql = "SELECT * FROM Equipos WHERE IDPersona = " & txtNombre.Tag
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim usuarios As OleDbDataReader = buscar.ExecuteReader

            If usuarios.HasRows Then
                MsgBox("Este usuario '" & txtNombre.Text & "' está asignado al menos a un equipo." & vbNewLine & vbNewLine & "Primero debe eliminarlo del equipo para proceder a su borrado", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                cnn.Close()
            Else
                cnn.Close()
                sql = "DELETE FROM Usuarios WHERE IdUser = " & txtNombre.Tag
                Dim comando As New OleDbCommand(sql)
                comando.Connection = cnn

                'ejecuto el sql
                Try

                    cnn.Open()
                    comando.ExecuteNonQuery()
                    cnn.Close()

                    'recrago grid
                    DGVUsuarios.Rows.Clear()

                    Try
                        cnn.Open()
                        'Dim sql As String
                        sql = "SELECT IdUser, Nombre, Clave FROM Usuarios WHERE IdUSer <> " & IDUSER & " AND IdUser <> 0"
                        Dim bbuscar As New OleDbCommand(sql, cnn)
                        Dim uusuarios As OleDbDataReader = bbuscar.ExecuteReader

                        If uusuarios.HasRows Then
                            While uusuarios.Read
                                DGVUsuarios.Rows.Add(uusuarios.GetValue(0), uusuarios.GetValue(1), uusuarios.GetValue(2), "SI")
                            End While
                            cnn.Close()
                            butEliminar.Enabled = True
                            butCambiar.Enabled = True
                        Else
                            DGVUsuarios.Rows.Add("1")
                            DGVUsuarios.Tag = 1
                            butEliminar.Enabled = False
                            butCambiar.Enabled = False
                        End If

                    Catch ex As Exception
                        MsgBox("Ups!!! Problemas--" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                    End Try

                Catch ex As Exception
                    MsgBox("Ups!!! Problemas--->" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                End Try
            End If

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

    End Sub

    Private Sub butNuevo_Click(sender As Object, e As EventArgs) Handles butNuevo.Click
        Dim ElMayor As Integer = 0
        Dim i As Integer = 0
        If butNuevo.Text = "Nuevo" Then
            ' cuando es nuevo lo que hago es borro cajas de entradas de texto
            txtClave.Text = ""
            txtNombre.Text = ""
            txtNombre.Tag = "NO"
            For i = 1 To DGVUsuarios.RowCount ' - 1
                If IsNothing(DGVUsuarios.Rows(i - 1).Cells(1).Value) Then
                    ElMayor = 0
                Else
                    If DGVUsuarios.Rows(i - 1).Cells(0).Value > ElMayor Then ElMayor = CInt(DGVUsuarios.Rows(i - 1).Cells(0).Value)
                End If

            Next i
            txtClave.Tag = ElMayor + 1
            txtClave.Enabled = True
            txtNombre.Enabled = True
            butNuevo.Text = "Guardar"
            butEliminar.Enabled = False
            butCambiar.Enabled = False
            DGVUsuarios.Enabled = False
            'btnSalir.Enabled = False
            txtNombre.Focus()
        Else
            ' hay que grabar lo que sea
            If String.IsNullOrEmpty(txtNombre.Text) Then
                MsgBox("Nombre de Usuario no permitido", MsgBoxStyle.Exclamation, "SCRUM Wizard")
            ElseIf String.IsNullOrEmpty(txtClave.Text) Then
                MsgBox("Clave de Usuario no permitido", MsgBoxStyle.Exclamation, "SCRUM Wizard")
            Else
                Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
                Dim sql As String = ""
                sql = "INSERT INTO Usuarios (IdUser, Nombre, Clave) VALUES ("
                sql = sql & txtClave.Tag & ", "
                sql = sql & "'" & txtNombre.Text & "', "
                sql = sql & "'" & txtClave.Text & "')"

                Dim comando As New OleDbCommand(sql)
                comando.Connection = cnn

                'ejecuto el sql
                Try

                    cnn.Open()
                    comando.ExecuteNonQuery()
                    cnn.Close()

                Catch ex As Exception
                    MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                End Try

                If IsNothing(DGVUsuarios.Rows(0).Cells(1).Value) Then
                    DGVUsuarios.Rows.Clear()
                End If
                DGVUsuarios.Rows.Add(txtClave.Tag, txtNombre.Text, txtClave.Text, txtNombre.Tag)

                butNuevo.Text = "Nuevo"
                DGVUsuarios.Enabled = True
                txtClave.Enabled = False
                txtNombre.Enabled = False
                butEliminar.Enabled = True
                btnSalir.Enabled = True
                butCambiar.Enabled = True

            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GBEquipos.Enter

    End Sub

    Private Sub AdministraciónDeEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónDeEquiposToolStripMenuItem.Click
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim sql As String
            sql = "SELECT DISTINCT IdEquipo, NombreEquipo FROM Equipos"
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim usuarios As OleDbDataReader = buscar.ExecuteReader

            If usuarios.HasRows Then
                While usuarios.Read
                    DGVEquipos.Rows.Add(usuarios.GetValue(0), usuarios.GetValue(1), "SI")
                End While
                cnn.Close()
                butCambiarE.Enabled = True
                butEliminarE.Enabled = True
            Else
                DGVEquipos.Rows.Add("1")
                DGVEquipos.Tag = 1
                butCambiarE.Enabled = False
                butEliminarE.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

        Dim punto As New Point(441, 21)
        butSalirE.Location = punto
        GBEquipos.Width = 500

        GBEquipos.Visible = True
        AdministraciónDeUsuariosToolStripMenuItem.Enabled = False
        AdministraciónDeEquiposToolStripMenuItem.Enabled = False
        AdmistrarCuentaadminToolStripMenuItem.Enabled = False
        SalirToolStripMenuItem.Enabled = False
        butNuevoE.Text = "Nuevo"
        butNuevoE.Enabled = True
        butCambiarE.Text = "Cambiar"


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles butSalirE.Click
        'BOTON SALIR DE EQUIPOS
        Dim resp As Integer
        resp = vbYes
        If resp = vbYes Then
            ' Salgo. Esto es crítico para la siguiente vez (no quitar ni de coña)
            GBEquipos.Visible = vbFalse
            DGVEquipos.Rows.Clear()
            DGVCompEq.Rows.Clear()
            DGVUsers.Rows.Clear()
            DGVRoles.Rows.Clear()
            'DGVUsuarios.Rows(0).Cells(0).Value = 1
            DGVEquipos.Tag = 1
            DGVEquipos.EndEdit()
            DGVCompEq.EndEdit()
            DGVUsers.EndEdit()
            DGVRoles.EndEdit()
            butNuevoE.Text = "Nuevo"
            butCambiarE.Enabled = True
            butEliminarE.Enabled = True
            DGVEquipos.Enabled = True
            butIncluir.Visible = False
            lblCompEquipo.Text = "Componentes del Equipo"
            txtNombreEquipo.Enabled = False
            pnlNuevos.Visible = False
            AdministraciónDeUsuariosToolStripMenuItem.Enabled = True
            AdministraciónDeEquiposToolStripMenuItem.Enabled = True
            AdmistrarCuentaadminToolStripMenuItem.Enabled = True
            SalirToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub EnFilaEq(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEquipos.RowEnter
        txtNombreEquipo.Text = DGVEquipos.Rows(e.RowIndex).Cells(1).Value
        txtNombreEquipo.Tag = DGVEquipos.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub butNuevoE_Click(sender As Object, e As EventArgs) Handles butNuevoE.Click
        Dim ElMayor As Integer = 0
        Dim i As Integer = 0
        Dim r As Integer = 0
        Dim sql As String = ""

        If butNuevoE.Text = "Nuevo" Then
            ' cuando es nuevo lo que hago es borro cajas de entradas de texto
            txtNombreEquipo.Text = ""

            For i = 1 To DGVEquipos.RowCount - 1
                If DGVEquipos.Rows(i).Cells(0).Value > ElMayor Then ElMayor = DGVEquipos.Rows(i).Cells(0).Value
            Next i

            txtNombreEquipo.Tag = ElMayor
            txtNombreEquipo.Enabled = True
            butNuevoE.Text = "Guardar"
            butIncluir.Text = "Incluir"
            butIncluir.Visible = True

            butEliminarE.Enabled = False
            butCambiarE.Enabled = False
            DGVEquipos.Enabled = False

            txtNombreEquipo.Focus()
        Else
            ' cuando quiero guardar
            ' verifico que el equipo tiene po y sm (obligatorio)
            Dim lim As Integer
            Dim cad1 As String = "Product Owner"
            Dim cad2 As String = "Scrum Master"
            Dim HayPO As Boolean = False
            Dim HaySM As Boolean = False

            lim = DGVCompEq.RowCount - 1
            For i = 0 To lim
                If DGVCompEq.Rows(i).Cells(1).Value = cad1 Then
                    HayPo = True
                    i = lim + 1
                End If
            Next i
            For i = 0 To lim
                If DGVCompEq.Rows(i).Cells(1).Value = cad2 Then
                    HaySM = True
                    i = lim + 1
                End If
            Next i

            If Trim(txtNombreEquipo.Text) = "" Then
                MsgBox("Debe proporcionar un nombre de equipo antes de continuar.", MsgBoxStyle.Information, "SCRUM Wizard")
            ElseIf Not HayPO Then
                MsgBox("El equipo debe tener un usuario con el rol Product Owner", MsgBoxStyle.Critical, "SCRUM Master")
            ElseIf Not HaySM Then
                MsgBox("El equipo debe tener un usuario con el rol Scrum Master", MsgBoxStyle.Critical, "SCRUM Master")
            Else
                'TODo BIEN
                If lim < 2 Then
                    r = MsgBox("Equipos con menos de 3 miembros reduce la interacción y resulta en ganancias de productividad más pequeñas." & vbNewLine & vbNewLine & "Quiere continuar de todas formas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SCRUM Master")
                ElseIf lim > 8 Then
                    r = MsgBox("Equipos con más de 9 miembros requiere demasiada coordinación." & vbNewLine & vbNewLine & "Quiere continuar de todas formas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SCRUM Master")
                End If
                If r = vbYes Or r = 0 Then
                    ' AQUI GRABO

                    Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

                    For i = 0 To lim
                        sql = "INSERT INTO Equipos VALUES ("
                        sql = sql & txtNombreEquipo.Tag + 1 & ", "
                        sql = sql & "'" & txtNombreEquipo.Text & "', "
                        sql = sql & DGVCompEq.Rows(i).Cells(2).Value & ", "
                        sql = sql & DGVCompEq.Rows(i).Cells(3).Value & ")"

                        Dim comando As New OleDbCommand(sql)

                        comando.Connection = cnn

                        'ejecuto el sql
                        Try

                            cnn.Open()
                            comando.ExecuteNonQuery()
                            cnn.Close()

                        Catch ex As Exception
                            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                        End Try
                    Next
                    'recargo grid
                    DGVEquipos.Rows.Clear()
                    Try
                        cnn.Open()
                        sql = "SELECT DISTINCT IdEquipo, NombreEquipo FROM Equipos"
                        Dim buscar As New OleDbCommand(sql, cnn)
                        Dim usuarios As OleDbDataReader = buscar.ExecuteReader

                        If usuarios.HasRows Then
                            While usuarios.Read
                                DGVEquipos.Rows.Add(usuarios.GetValue(0), usuarios.GetValue(1), "SI")
                            End While
                            cnn.Close()
                        Else
                            DGVEquipos.Rows.Add("1")
                            DGVEquipos.Tag = 1
                        End If

                    Catch ex As Exception
                        MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                    End Try


                    pnlNuevos.Visible = False

                    DGVCompEq.Rows.Clear()
                    DGVUsers.Rows.Clear()
                    DGVRoles.Rows.Clear()
                    DGVEquipos.Tag = 1

                    DGVCompEq.EndEdit()
                    DGVUsers.EndEdit()
                    DGVRoles.EndEdit()
                    butNuevoE.Text = "Nuevo"
                    butCambiarE.Enabled = True
                    butEliminarE.Enabled = True
                    butIncluir.Visible = False
                    lblCompEquipo.Text = "Componentes del Equipo"
                    DGVEquipos.Enabled = True
                    txtNombreEquipo.Enabled = False

                    Dim punto As New Point(441, 21)
                    butSalirE.Location = punto
                    GBEquipos.Width = 500

                End If
            End If
            End If

    End Sub

    Private Sub butIncluir_Click(sender As Object, e As EventArgs) Handles butIncluir.Click
        If txtNombreEquipo.Text = "" Then
            MsgBox("Debe proporcionar un nombre de equipo antes de continuar.", MsgBoxStyle.Information, "SCRUM Wizard")
        Else
            lblCompEquipo.Text = "Componentes del equipo llamado ... " & txtNombreEquipo.Text
            butIncluir.Visible = False
            butSeleccionar.Visible = True
            pnlNuevos.Visible = True

            Dim punto As New Point(1132, 21)
            butSalirE.Location = punto
            GBEquipos.Width = 1213

            Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
            Dim sql As String

            If butIncluir.Text = "Modificar" Then
                'CARGO LOS COMPONENTES del EQUIPO
                Try
                    cnn.Open()
                    sql = "SELECT Usuarios.Nombre, Roles.NombreRol, Equipos.IDPersona, Equipos.IdRolPersona"
                    sql = sql & " FROM Equipos, Roles, Usuarios"
                    sql = sql & " WHERE ((Equipos.IdEquipo= " & txtNombreEquipo.Tag & ") AND (Equipos.IDPersona=Usuarios.IdUser)"
                    sql = sql & " AND (Equipos.IdRolPersona=Roles.IdRol)) "
                    sql = sql & " ORDER BY Equipos.IdRolPersona;"
                    Dim bs As New OleDbCommand(sql, cnn)
                    Dim comp As OleDbDataReader = bs.ExecuteReader

                    If comp.HasRows Then
                        While comp.Read
                            DGVCompEq.Rows.Add(comp.GetValue(0), comp.GetValue(1), comp.GetValue(2), comp.GetValue(3))
                        End While
                        cnn.Close()
                    Else
                        MsgBox("No hay compoentes en este equipo dados de alta.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        cnn.Close()
                    End If

                Catch ex As Exception
                    MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                End Try
                cnn.Close()
            End If

            'Cargo los usuarios
            Try
                cnn.Open()

                sql = "SELECT IdUser, Nombre FROM Usuarios WHERE Nombre <>'Admin' ORDER BY Nombre"
                Dim buscar As New OleDbCommand(sql, cnn)
                Dim usuarios As OleDbDataReader = buscar.ExecuteReader

                If usuarios.HasRows Then
                    While usuarios.Read
                            DGVUsers.Rows.Add(usuarios.GetValue(0), usuarios.GetValue(1))
                    End While
                    cnn.Close()
                Else
                    MsgBox("No hay usuarios dados de alta en el sistema.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    cnn.Close()
                End If

            Catch ex As Exception
                MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try

            'Cargo los roles
            Try
                cnn.Open()
                sql = "SELECT IdROl, NombreRol FROM Roles WHERE NombreRol <>'Administrador' ORDER BY NombreRol"

                Dim bbuscar As New OleDbCommand(sql, cnn)
                Dim roles As OleDbDataReader = bbuscar.ExecuteReader

                If roles.HasRows Then
                    While roles.Read
                        DGVRoles.Rows.Add(roles.GetValue(0), roles.GetValue(1))
                    End While
                    cnn.Close()
                Else
                    MsgBox("No hay roles dados de alta en el sistema.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    cnn.Close()
                End If

            Catch ex As Exception
                MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try

            If butIncluir.Text = "Modificar" Then
                Dim u, r, j, l As Integer
                ' tengo que quitar de usuarios y de roles los ya en uso
                For i = 0 To DGVCompEq.RowCount - 1
                    u = DGVCompEq.Rows(i).Cells(2).Value
                    r = DGVCompEq.Rows(i).Cells(3).Value
                    For l = 0 To DGVRoles.RowCount - 1
                        If r <> 3 Then
                            If r = DGVRoles.Rows(l).Cells(0).Value Then
                                DGVRoles.Rows(l).Cells(2).Value = "SI"
                            End If
                        End If
                    Next
                    For j = 0 To DGVUsers.RowCount - 1
                        If u = DGVUsers.Rows(j).Cells(0).Value Then
                            DGVUsers.Rows(j).Cells(2).Value = "SI"
                        End If
                    Next
                Next

                u = DGVRoles.RowCount - 1
                While u >= 0
                    If DGVRoles.Rows(u).Cells(2).Value = "SI" Then
                        DGVRoles.Rows.RemoveAt(u)
                        u = DGVRoles.RowCount - 1
                    Else
                        u = u - 1
                    End If
                End While

                u = DGVUsers.RowCount - 1
                While u >= 0
                    If DGVUsers.Rows(u).Cells(2).Value = "SI" Then
                        DGVUsers.Rows.RemoveAt(u)
                        u = DGVUsers.RowCount - 1
                    Else
                        u = u - 1
                    End If
                End While

            End If
            butBorrar.Visible = True
        End If
    End Sub

    Private Sub butSeleccionar_Click(sender As Object, e As EventArgs) Handles butSeleccionar.Click
        Dim fu, fr As Integer

        fu = DGVUsers.CurrentCell.RowIndex
        fr = DGVRoles.CurrentCell.RowIndex

        DGVCompEq.Rows.Add(DGVUsers.Rows(fu).Cells(1).Value, DGVRoles.Rows(fr).Cells(1).Value, DGVUsers.Rows(fu).Cells(0).Value, DGVRoles.Rows(fr).Cells(0).Value)
        If DGVRoles.Rows(fr).Cells(1).Value <> "Development Team Member" Then
            ' hay que quitar de la lista
            DGVRoles.Rows.RemoveAt(fr)
        End If
        DGVUsers.Rows.RemoveAt(fu)
        butBorrar.Visible = True
        If DGVUsers.RowCount = 0 Then butSeleccionar.Visible = False
    End Sub


    Private Sub butBorrar_Click(sender As Object, e As EventArgs) Handles butBorrar.Click
        Dim ff As Integer

        ' Borra la línea seleccioanda y la devuelve al origen
        ff = DGVCompEq.CurrentCell.RowIndex
        DGVUsers.Rows.Add(DGVCompEq.Rows(ff).Cells(2).Value, DGVCompEq.Rows(ff).Cells(0).Value)
        DGVUsers.Sort(DGVUsers.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        If DGVCompEq.Rows(ff).Cells(1).Value <> "Development Team Member" Then
            DGVRoles.Rows.Add(DGVCompEq.Rows(ff).Cells(3).Value, DGVCompEq.Rows(ff).Cells(1).Value)
            DGVRoles.Sort(DGVRoles.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        End If
        DGVCompEq.Rows.RemoveAt(ff)
        If DGVCompEq.RowCount = 0 Then butBorrar.Visible = False
        If DGVUsers.RowCount = 1 Then butSeleccionar.Visible = True
    End Sub

    Private Sub butEliminarE_Click(sender As Object, e As EventArgs) Handles butEliminarE.Click
        'Elimio un equipo
        ' Veo si está asigando a algún proyect

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
        Dim sql As String
        Dim kk As String = ""
        Dim r As Integer = 0

        Try
            cnn.Open()
            sql = "SELECT NombrePry FROM Proyectos WHERE IdEquipo =" & txtNombreEquipo.Tag
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim usuarios As OleDbDataReader = buscar.ExecuteReader

            If usuarios.HasRows Then
                While usuarios.Read
                    kk = usuarios.GetValue(0)
                End While
                cnn.Close()
                r = MsgBox("El equipo '" & txtNombreEquipo.Text & "' está asignado al proyecto '" & kk & "'" & vbNewLine & vbNewLine & "Está seguro que quiere continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "SCRUM Wizard")
            End If
            cnn.Close()
            If r = 0 Or r = vbYes Then
                'no hay problemas pues no está sigando o respuesta es sí
                sql = "DELETE FROM Equipos WHERE IdEquipo = " & txtNombreEquipo.Tag

                Dim comando As New OleDbCommand(sql)
                comando.Connection = cnn

                'ejecuto el sql
                Try

                    cnn.Open()
                    comando.ExecuteNonQuery()
                    cnn.Close()

                    'recrago grid
                    DGVEquipos.Rows.Clear()

                    cnn.Open()
                    sql = "SELECT DISTINCT IdEquipo, NombreEquipo FROM Equipos"
                    Dim bbuscar As New OleDbCommand(sql, cnn)
                    Dim eqs As OleDbDataReader = bbuscar.ExecuteReader

                    If eqs.HasRows Then
                        While eqs.Read
                            DGVEquipos.Rows.Add(eqs.GetValue(0), eqs.GetValue(1), "SI")
                        End While
                        cnn.Close()
                    Else
                        DGVEquipos.Rows.Add("1")
                        DGVEquipos.Tag = 1
                    End If

                Catch ex As Exception
                    MsgBox("Ups!!! Problemas--" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                End Try

            End If
        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
    End Sub

    Private Sub butCambiarE_Click(sender As Object, e As EventArgs) Handles butCambiarE.Click
        Dim ElMayor As Integer = 0
        Dim i As Integer = 0
        Dim r As Integer = 0
        Dim sql As String = ""
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        If butCambiarE.Text = "Cambiar" Then
            i = DGVEquipos.CurrentCell.RowIndex
            txtNombreEquipo.Tag = DGVEquipos.Rows(i).Cells(0).Value

            txtNombreEquipo.Enabled = True
            butCambiarE.Text = "Guardar"
            butIncluir.Text = "Modificar"
            butIncluir.Visible = True

            butEliminarE.Enabled = False
            butNuevoE.Enabled = False
            DGVEquipos.Enabled = False

            txtNombreEquipo.Focus()
        Else
            If butSalirE.Location.X = 441 Then
                'SOLO CAMBIO EL NOMBRE DEL EQUIPO - No sus integrantes
                If Trim(txtNombreEquipo.Text) = "" Then
                    MsgBox("Debe proporcionar un nombre de equipo antes de continuar.", MsgBoxStyle.Information, "SCRUM Wizard")
                Else

                    Try
                        cnn.Open()
                        sql = "UPDATE Equipos SET NombreEquipo = '" & txtNombreEquipo.Text & "' "
                        sql = sql & "WHERE IdEquipo = " & txtNombreEquipo.Tag
                        Dim comando As New OleDbCommand(sql)
                        comando.Connection = cnn

                        'ejecuto el sql
                        comando.ExecuteNonQuery()
                        cnn.Close()

                        'recrago grid
                        DGVEquipos.Rows.Clear()

                        Try
                            cnn.Open()
                            sql = "SELECT DISTINCT IdEquipo, NombreEquipo FROM Equipos"
                            Dim buscar As New OleDbCommand(sql, cnn)
                            Dim usuarios As OleDbDataReader = buscar.ExecuteReader

                            If usuarios.HasRows Then
                                While usuarios.Read
                                    DGVEquipos.Rows.Add(usuarios.GetValue(0), usuarios.GetValue(1), "SI")
                                End While
                                cnn.Close()
                            Else
                                DGVEquipos.Rows.Add("1")
                                DGVEquipos.Tag = 1
                            End If

                        Catch ex As Exception
                            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                        End Try

                    Catch ex As Exception
                        MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                    End Try

                    pnlNuevos.Visible = False

                    DGVCompEq.Rows.Clear()
                    DGVUsers.Rows.Clear()
                    DGVRoles.Rows.Clear()
                    DGVEquipos.Tag = 1

                    DGVCompEq.EndEdit()
                    DGVUsers.EndEdit()
                    DGVRoles.EndEdit()
                    butCambiarE.Text = "Cambiar"
                    butNuevoE.Enabled = True
                    butEliminarE.Enabled = True
                    butIncluir.Visible = False
                    lblCompEquipo.Text = "Componentes del Equipo"
                    DGVEquipos.Enabled = True
                    txtNombreEquipo.Enabled = False

                    Dim punto As New Point(441, 21)
                    butSalirE.Location = punto
                    GBEquipos.Width = 500
                End If
            Else

                ' cuando quiero guardar
                ' verifico que el equipo tiene po y sm (obligatorio)
                Dim lim As Integer
                Dim cad1 As String = "Product Owner"
                Dim cad2 As String = "Scrum Master"
                Dim HayPO As Boolean = False
                Dim HaySM As Boolean = False

                lim = DGVCompEq.RowCount - 1
                For i = 0 To lim
                    If DGVCompEq.Rows(i).Cells(1).Value = cad1 Then
                        HayPO = True
                        i = lim + 1
                    End If
                Next i
                For i = 0 To lim
                    If DGVCompEq.Rows(i).Cells(1).Value = cad2 Then
                        HaySM = True
                        i = lim + 1
                    End If
                Next i

                If txtNombreEquipo.Text = "" Then
                    MsgBox("Debe proporcionar un nombre de equipo antes de continuar.", MsgBoxStyle.Information, "SCRUM Wizard")
                ElseIf Not HayPO Then
                    MsgBox("El equipo debe tener un usuario con el rol Product Owner", MsgBoxStyle.Critical, "SCRUM Master")
                ElseIf Not HaySM Then
                    MsgBox("El equipo debe tener un usuario con el rol Scrum Master", MsgBoxStyle.Critical, "SCRUM Master")
                Else
                    'TODO BIEN
                    If lim < 2 Then
                        r = MsgBox("Equipos con menos de 3 miembros reduce la interacción y resulta en ganancias de productividad más pequeñas." & vbNewLine & vbNewLine & "Quiere continuar de todas formas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SCRUM Master")
                    ElseIf lim > 8 Then
                        r = MsgBox("Equipos con más de 9 miembros requiere demasiada coordinación." & vbNewLine & vbNewLine & "Quiere continuar de todas formas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SCRUM Master")
                    End If
                    If r = vbYes Or r = 0 Then

                        'Primero me cargo lo que hay en equipos para que no haya problemas después
                        cnn.Close()
                        sql = "DELETE FROM Equipos WHERE IdEquipo = " & txtNombreEquipo.Tag
                        Dim comando As New OleDbCommand(sql)
                        comando.Connection = cnn

                        'ejecuto el sql

                        Try

                            cnn.Open()
                            comando.ExecuteNonQuery()
                            cnn.Close()

                        Catch ex As Exception
                            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                        End Try

                        ' AQUI GRABO

                        For i = 0 To lim
                            sql = "INSERT INTO Equipos VALUES ("
                            sql = sql & txtNombreEquipo.Tag & ", "
                            sql = sql & "'" & txtNombreEquipo.Text & "', "
                            sql = sql & DGVCompEq.Rows(i).Cells(2).Value & ", "
                            sql = sql & DGVCompEq.Rows(i).Cells(3).Value & ")"

                            Dim ccomando As New OleDbCommand(sql)

                            ccomando.Connection = cnn

                            'ejecuto el sql
                            Try

                                cnn.Open()
                                ccomando.ExecuteNonQuery()
                                cnn.Close()

                            Catch ex As Exception
                                MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                            End Try
                        Next
                        'recargo grid
                        DGVEquipos.Rows.Clear()
                        Try
                            cnn.Open()
                            sql = "SELECT DISTINCT IdEquipo, NombreEquipo FROM Equipos"
                            Dim buscar As New OleDbCommand(sql, cnn)
                            Dim usuarios As OleDbDataReader = buscar.ExecuteReader

                            If usuarios.HasRows Then
                                While usuarios.Read
                                    DGVEquipos.Rows.Add(usuarios.GetValue(0), usuarios.GetValue(1), "SI")
                                End While
                                cnn.Close()
                            Else
                                DGVEquipos.Rows.Add("1")
                                DGVEquipos.Tag = 1
                            End If

                        Catch ex As Exception
                            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
                        End Try


                        pnlNuevos.Visible = False

                        DGVCompEq.Rows.Clear()
                        DGVUsers.Rows.Clear()
                        DGVRoles.Rows.Clear()
                        DGVEquipos.Tag = 1

                        DGVCompEq.EndEdit(
                        DGVUsers.EndEdit())
                        DGVRoles.EndEdit()
                        butCambiarE.Text = "Cambiar"
                        butNuevoE.Enabled = True
                        butEliminarE.Enabled = True
                        butIncluir.Visible = False
                        lblCompEquipo.Text = "Componentes del Equipo"
                        DGVEquipos.Enabled = True
                        txtNombreEquipo.Enabled = False

                        Dim punto As New Point(441, 21)
                        butSalirE.Location = punto
                        GBEquipos.Width = 500

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub AdmistrarCuentaadminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdmistrarCuentaadminToolStripMenuItem.Click
        Dim punto As New Point(100, 100)
        Dim sql As String = ""
        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        AdministraciónDeUsuariosToolStripMenuItem.Enabled = False
        AdministraciónDeEquiposToolStripMenuItem.Enabled = False
        SalirToolStripMenuItem.Enabled = False

        Try
            cnn.Open()

            sql = "SELECT Nombre, Clave FROM Usuarios WHERE IdUser = -1"
            Dim buscar As New OleDbCommand(Sql, cnn)
            Dim usuarios As OleDbDataReader = buscar.ExecuteReader

            If usuarios.HasRows Then
                While usuarios.Read
                    txtNAdmin.Text = usuarios.GetValue(0)
                    txtCAdmin.Text = usuarios.GetValue(1)
                End While
                cnn.Close()
            Else
                MsgBox("No hay usuarios dados de alta en el sistema.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                cnn.Close()
            End If

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
        txtNAdmin.Enabled = True
        txtCAdmin.Enabled = True

        gbAdmin.Location = punto
        gbAdmin.Visible = True

    End Sub

    Private Sub butCSalir_Click(sender As Object, e As EventArgs) Handles butCSalir.Click

        AdministraciónDeUsuariosToolStripMenuItem.Enabled = True
        AdministraciónDeEquiposToolStripMenuItem.Enabled = True
        AdmistrarCuentaadminToolStripMenuItem.Enabled = True
        SalirToolStripMenuItem.Enabled = True
        gbAdmin.Visible = False
        txtCAdmin.Text = ""
        txtNAdmin.Text = ""

    End Sub

    Private Sub butCAdmin_Click(sender As Object, e As EventArgs) Handles butCAdmin.Click

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        If String.IsNullOrEmpty(txtCAdmin.Text) Or String.IsNullOrWhiteSpace(txtCAdmin.Text) Then
            ' no puede ser blanco
            MsgBox("Debe proporcionar una contraseña válida de usuario Administrador antes de continuar.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
        ElseIf String.IsNullOrEmpty(txtNAdmin.Text) Or String.IsNullOrWhiteSpace(txtNAdmin.Text) Then
            ' no puede ser blanco
            MsgBox("Debe proporcionar un nombre válido de usuario Administrador antes de continuar.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
        Else
            ' cambio se puede hacer
            Try
                cnn.Open()
                Dim sql As String
                sql = "UPDATE Usuarios SET Nombre = '" & txtNAdmin.Text & "', "
                sql = sql & "Clave = '" & txtCAdmin.Text & "' WHERE IdUser = -1"
                Dim comando As New OleDbCommand(sql)

                comando.Connection = cnn
                'ejecuto el sql
                comando.ExecuteNonQuery()
                cnn.Close()

            Catch ex As Exception
                MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try

            AdministraciónDeUsuariosToolStripMenuItem.Enabled = True
            AdministraciónDeEquiposToolStripMenuItem.Enabled = True
            AdmistrarCuentaadminToolStripMenuItem.Enabled = True
            SalirToolStripMenuItem.Enabled = True
            gbAdmin.Visible = False
            txtCAdmin.Text = ""
            txtNAdmin.Text = ""
        End If
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' cargo el formato correcto de los grids que se van en diseño

        Dim tipoletra As String
        tipoletra = DGVCompEq.ColumnHeadersDefaultCellStyle.Font.FontFamily.Name
        Dim fuente As New Font(tipoletra, 9, FontStyle.Regular, GraphicsUnit.Point)


        DGVCompEq.ColumnHeadersDefaultCellStyle.Font = fuente
        DGVCompEq.DefaultCellStyle.Font = fuente
        DGVCompEq.RowHeadersDefaultCellStyle.Font = fuente
        DGVCompEq.RowsDefaultCellStyle.Font = fuente

        DGVEquipos.ColumnHeadersDefaultCellStyle.Font = fuente
        DGVEquipos.DefaultCellStyle.Font = fuente
        DGVEquipos.RowHeadersDefaultCellStyle.Font = fuente
        DGVEquipos.RowsDefaultCellStyle.Font = fuente

        DGVRoles.ColumnHeadersDefaultCellStyle.Font = fuente
        DGVRoles.DefaultCellStyle.Font = fuente
        DGVRoles.RowHeadersDefaultCellStyle.Font = fuente
        DGVRoles.RowsDefaultCellStyle.Font = fuente

        DGVUsers.ColumnHeadersDefaultCellStyle.Font = fuente
        DGVUsers.DefaultCellStyle.Font = fuente
        DGVUsers.RowHeadersDefaultCellStyle.Font = fuente
        DGVUsers.RowsDefaultCellStyle.Font = fuente

        DGVUsuarios.ColumnHeadersDefaultCellStyle.Font = fuente
        DGVUsuarios.DefaultCellStyle.Font = fuente
        DGVUsuarios.RowHeadersDefaultCellStyle.Font = fuente
        DGVUsuarios.RowsDefaultCellStyle.Font = fuente


    End Sub

    Private Sub butVerEquipo_Click(sender As Object, e As EventArgs) Handles butVerEquipo.Click
        ' Se visualiza el equipo completo de ese proyecto
        Dim sql As String = ""
        Dim punto As New Point(50, 50)
        Dim IdEq As Integer = 0

        IdEq = DGVEquipos.Rows(DGVEquipos.CurrentCell.RowIndex).Cells(0).Value


        sql = "SELECT Usuarios.Nombre, Roles.NombreRol, Equipos.IDPersona, Equipos.IdRolPersona"
        sql = sql & " FROM Equipos, Roles, Usuarios"
        sql = sql & " WHERE ((Equipos.IdEquipo= " & IdEq & ") AND (Equipos.IDPersona=Usuarios.IdUser)"
        sql = sql & " AND (Equipos.IdRolPersona=Roles.IdRol)) "
        sql = sql & " ORDER BY Equipos.IdRolPersona;"

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim pb As OleDbDataReader = buscar.ExecuteReader

            If pb.HasRows Then
                While pb.Read
                    DGVEquipo.Rows.Add(pb.GetValue(0), pb.GetValue(1))
                    lblEquipo.Text = "Lista de Integrantes de " & DGVEquipos.Rows(DGVEquipos.CurrentCell.RowIndex).Cells(1).Value
                End While
                cnn.Close()
                GBEquipos.Visible = False
                SalirToolStripMenuItem.Enabled = False
                pnlEquipo.Location = punto
                pnlEquipo.Visible = True
            Else
                MsgBox("No existe personal asignado al proyecto.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If


        Catch ex As Exception
            MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
    End Sub

    Private Sub butListo_Click(sender As Object, e As EventArgs)
        DGVEquipo.Rows.Clear()
        pnlEquipo.Visible = False
        GBEquipos.Visible = True
    End Sub

    Private Sub butListo_Click_1(sender As Object, e As EventArgs) Handles butListo.Click
        DGVEquipo.Rows.Clear()
        GBEquipos.Visible = True
        pnlEquipo.Visible = False
    End Sub
End Class