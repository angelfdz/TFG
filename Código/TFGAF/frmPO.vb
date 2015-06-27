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
Imports System.ComponentModel

Public Class frmPO
    Private original(1000, 9) As String

    Private Sub frmPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim HayPB As Integer = 0
        ' muestro info de quién y dónde estoy
        txtUsuario.Text = DameUsuario(IDUSER)
        txtRol.Text = DameRol()

        If IDPROYECTO = 0 Then

            txtProyecto.Text = "Sin Proyecto"
            CrearProductBacklogToolStripMenuItem.Enabled = False
            CrearNuevoProyectoToolStripMenuItem.Enabled = False
            RefinarProductBacklogToolStripMenuItem.Enabled = False
            TerminarProyectoToolStripMenuItem1.Enabled = False
            CancelarProyectoToolStripMenuItem1.Enabled = False
            CancelarSprintToolStripMenuItem.Enabled = False
            MantenerProyectoExistenteToolStripMenuItem.Enabled = False
            ComposiciónEquipoDeProyectoToolStripMenuItem.Enabled = False
            CrearNuevoProyectoToolStripMenuItem1.PerformClick()

        Else
            txtProyecto.Text = DameProyecto()
            txtProyecto.Tag = DameNS()
            txtRol.Tag = DameDS()
            ' busco si ya tiene product backlog en cuyo caso solo habilito modifiar, en otro caso alterar
            HayPB = DamePB()
            If HayPB = 0 Then   ' no hay PB => crear un nuevo PB
                CrearProductBacklogToolStripMenuItem.Enabled = True
                RefinarProductBacklogToolStripMenuItem.Enabled = False
                CrearNuevoProyectoToolStripMenuItem.Enabled = True
                CancelarProyectoToolStripMenuItem1.Enabled = False
            Else                'hay PB => refinamiento PB existente
                CrearProductBacklogToolStripMenuItem.Enabled = False
                RefinarProductBacklogToolStripMenuItem.Enabled = True
                CrearNuevoProyectoToolStripMenuItem.Enabled = True
                CancelarProyectoToolStripMenuItem1.Enabled = True
            End If
        End If
    End Sub


    Private Sub ModificarProductBacklogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefinarProductBacklogToolStripMenuItem.Click
        'Esta sección muestra un product backlog existente para su alteración
        Dim sql As String = ""
        Dim ValorMasAlto As Integer = 0
        Dim i, k As Integer
        Dim l As String = "Accionable" & vbNewLine & "Cancelado" & vbNewLine & "En marcha" & "Planificado" & vbNewLine & "Terminado"

        pnlBotones.Tag = "Refinar"

        sql = "SELECT IdHistoria, NHistoria, Estado, Dias, NumSprint, Prioridad, CosteEstimado, ValorEstimado, Comentarios FROM PBacklog WHERE IdProyecto = " & IDPROYECTO

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim buscar As New OleDbCommand(sql, cnn)
            Dim pb As OleDbDataReader = buscar.ExecuteReader

            If pb.HasRows Then
                While pb.Read
                    'DGVPBacklog.Rows.Add(pb.GetValue(1), pb.GetValue(2), pb.GetValue(3), pb.GetValue(4), pb.GetValue(7), pb.GetValue(8), pb.GetValue(5), pb.GetValue(6), pb.GetValue(9))
                    DGVPBacklog.Rows.Add(pb.GetValue(0), pb.GetValue(1), pb.GetValue(2), pb.GetValue(3), pb.GetValue(4), pb.GetValue(5), pb.GetValue(6), pb.GetValue(7), pb.GetValue(8))
                    'If pb.GetValue(1) > ValorMasAlto Then ValorMasAlto = pb.GetValue(1)
                    If pb.GetValue(0) > ValorMasAlto Then ValorMasAlto = pb.GetValue(0)
                End While
                cnn.Close()
            Else
                MsgBox("No existe Product Backlog asignado.", MsgBoxStyle.Information, "SCRUM Wizard")
            End If


            For i = 0 To DGVPBacklog.RowCount - 2
                If DGVPBacklog.Rows(i).Cells(2).Value = "Liberada" Then
                    DGVPBacklog.Rows(i).Cells("EST").Value = "LIB"
                    DGVPBacklog.Rows(i).Cells(0).Style.ForeColor = Color.White
                    DGVPBacklog.Rows(i).Cells(0).Style.BackColor = Color.Red
                    DGVPBacklog.Rows(i).ReadOnly = True
                Else
                    If EstaElSprintCerrado(CInt(DGVPBacklog.Rows(i).Cells(4).Value)) Then
                        DGVPBacklog.Rows(i).Cells("EST").Value = "SPRINTCERRADO"
                        DGVPBacklog.Rows(i).Cells(0).Style.ForeColor = Color.Black
                        DGVPBacklog.Rows(i).Cells(0).Style.BackColor = Color.Aquamarine
                        DGVPBacklog.Rows(i).ReadOnly = True
                    Else
                        DGVPBacklog.Rows(i).Cells("EST").Value = "NOLIB"
                    End If

                End If
                For k = 0 To 9
                    original(i, k) = DGVPBacklog.Rows(i).Cells(k).Value
                Next k
                k = 0
            Next
            original(i, 0) = "FIN"

            DGVPBacklog.CurrentCell = DGVPBacklog(i - 1, 0)
            DGVPBacklog.BeginEdit(True)

            ValorMasAlto = ValorMasAlto + 1
            DGVPBacklog.Tag = ValorMasAlto

            DGVPBacklog.Rows(DGVPBacklog.RowCount - 1).Cells(0).Value = ValorMasAlto

            DGVPBacklog.Columns(0).Width = 50
            DGVPBacklog.Columns(1).Width = 200
            DGVPBacklog.Columns(2).Width = 100
            DGVPBacklog.Columns(3).Width = 75
            DGVPBacklog.Columns(4).Width = 75
            DGVPBacklog.Columns(5).Width = 75
            DGVPBacklog.Columns(6).Width = 75
            DGVPBacklog.Columns(7).Width = 75
            DGVPBacklog.Columns(8).Width = 600

            DGVPBacklog.Visible = True
            pnlBotones.Visible = True

        Catch ex As Exception
            MsgBox("Ups!!! Problemas  " & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
        SalirToolStripMenuItem.Enabled = False
        CrearNuevoProyectoToolStripMenuItem.Enabled = False
        RefinarProductBacklogToolStripMenuItem.Enabled = False
        NotificacionesToolStripMenuItem.Enabled = False
        CancelarSprintToolStripMenuItem.Enabled = False
        InformacionSgtoProyectoToolStripMenuItem.Enabled = False

    End Sub


    Private Sub CrearProductBacklogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearProductBacklogToolStripMenuItem.Click
        'Esta sección muestra la creación de un nuevo product backlog asociado al proyecto

        pnlBotones.Tag = "Crear"

        DGVPBacklog.Columns(0).Width = 50
        DGVPBacklog.Columns(1).Width = 200
        DGVPBacklog.Columns(2).Width = 100
        DGVPBacklog.Columns(3).Width = 75
        DGVPBacklog.Columns(4).Width = 75
        DGVPBacklog.Columns(5).Width = 75
        DGVPBacklog.Columns(6).Width = 75
        DGVPBacklog.Columns(7).Width = 75
        DGVPBacklog.Columns(8).Width = 600

        DGVPBacklog.Visible = True
        pnlBotones.Visible = True
        SalirToolStripMenuItem.Enabled = False
        CrearNuevoProyectoToolStripMenuItem.Enabled = False
        NotificacionesToolStripMenuItem.Enabled = False
        CancelarSprintToolStripMenuItem.Enabled = False
        InformacionSgtoProyectoToolStripMenuItem.Enabled = False

        original(0, 0) = "FIN"

    End Sub

    Private Sub CeldaNueva(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGVPBacklog.RowsAdded
        Dim fila As Integer

        fila = DGVPBacklog.RowCount
        If fila = 1 And ToString(DGVPBacklog.Tag) = "" Then
            DGVPBacklog.Rows(fila - 1).Cells(0).Value = 1
            DGVPBacklog.Tag = 1
        Else
            DGVPBacklog.Rows(fila - 1).Cells(0).Value = DGVPBacklog.Tag + 1
            DGVPBacklog.Tag = DGVPBacklog.Tag + 1
        End If
        DGVPBacklog.Rows(fila - 1).Cells(9).Value = "NOLIB"

    End Sub

    Private Sub Verifica(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGVPBacklog.CellValidating
        If DGVPBacklog.Visible = True Then
            Select Case StrConv(DGVPBacklog.Columns(e.ColumnIndex).Name, VbStrConv.Uppercase)
                Case "COL1" ' ID
                Case "COL2" ' Nomre Historia
                    If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                        MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    End If
                Case "COL3" ' Estado
                    If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                        MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    ElseIf String.Equals(e.FormattedValue.ToString, "Liberada") Then
                        MsgBox("El estado 'Liberada' se configura mediante la generación de una nueva 'Release'", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    End If
                Case "COL4" ' Tamaño
                    If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                        If Not IsNumeric(e.FormattedValue.ToString()) Then
                            MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' solo admite valores numéricos", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        ElseIf CInt(e.FormattedValue) > CInt(txtRol.Tag) Then
                            MsgBox("Este proyecto está configurado con " & txtRol.Tag & " días por sprints." & vbNewLine & vbNewLine & "El número de días introducido supera este valor.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        End If
                    Else
                        MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    End If
                Case "COL6"  'prioridad
                    If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                        If Not IsNumeric(e.FormattedValue.ToString()) Then
                            MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' solo admite valores numéricos", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        End If
                    Else
                        MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    End If
                Case "COL5" 'sprint
                    If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                        If Not IsNumeric(e.FormattedValue.ToString()) Then
                            MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' solo admite valores numéricos", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        ElseIf CInt(e.FormattedValue) > CInt(txtProyecto.Tag) Then
                            MsgBox("Este proyecto está configurado con " & txtProyecto.Tag & " sprints." & vbNewLine & vbNewLine & "El número de sprint introducido supera este valor.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        ElseIf SprintCerradooCancelado(CInt(e.FormattedValue)) And DGVPBacklog.Rows(e.RowIndex).Cells("EST").Value = "NOLIB" Then
                            MsgBox("El sprint introducido está cerrado o cancelado, y por ello no puede ser usado", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        Else
                        End If
                    Else
                        MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    End If
                Case "COL7", "COL8" ' coste y valor
                    If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                        If Not IsNumeric(e.FormattedValue.ToString()) Then
                            MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' solo admite valores numéricos", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        End If
                    Else
                        MsgBox("La columna '" & DGVPBacklog.Columns(e.ColumnIndex).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    End If
                Case "COL9" ' comentario
            End Select
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butGuardar.Click
        Dim NumFilas As Integer

        Dim i As Integer = 0
        Dim k As Integer
        Dim w, q As Integer
        Dim texto As String = ""
        Dim Parar As Boolean = False
        Dim YaExisteIdSB As Boolean
        Dim sql As String = ""
        Dim sql1 As String = ""
        Dim sql2 As String = ""
        Dim ssql As String = ""
        Dim HaceFalta As Boolean = False
        Dim MeHeCargadoTodoPB As Boolean = False

        Dim msprints(1) As Integer


        DGVPBacklog.EndEdit()
        NumFilas = DGVPBacklog.RowCount


        If CrearProductBacklogToolStripMenuItem.Enabled = True Then
            ' si vengo de crear
            For i = 0 To NumFilas - 1
                DGVPBacklog.Rows(i).Cells("EST").Value = "NOLIB"
            Next
            i = 0
        Else

        End If


        ' lo primero que hago es verificar que hay datos correctos introducidos
        ' recorro todo el data grid - ojo que la última fila puede dar pegas
        Dim resp As Integer

        Do While (i < NumFilas) Or Parar

            ' si es la última fila tratamiento especial pues no hay que considerarla
            If i = NumFilas - 1 Then
                ' el usuario pulsa guardar sin nada metido y solo una fila
                For k = 1 To 8
                    texto = texto & DGVPBacklog.Rows(i).Cells(k).Value
                Next k
                If NumFilas = 1 And texto = "" Then
                    resp = MsgBox("Guardando ...." & vbNewLine & vbNewLine & "Ha eliminado todas las historias del PB o bien el PB está vacío." & vbNewLine & vbNewLine & "Está seguro que quiere seguir?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "SCRUM Wizard")
                    MeHeCargadoTodoPB = True
                    If resp = vbYes Then
                        'parar = True
                        i = NumFilas
                        'Exit Do
                    Else
                        k = 0
                        w = DGVPBacklog.Rows(0).Cells(0).Value
                        While original(k, 0) <> "FIN"
                            DGVPBacklog.Tag = w - 1
                            DGVPBacklog.Rows.Insert(k, original(k, 0), original(k, 1), original(k, 2), original(k, 3), original(k, 4), original(k, 5), original(k, 6), original(k, 7), original(k, 8), original(k, 9))
                            k += 1
                        End While

                        Parar = True
                        Exit Do

                    End If

                ElseIf NumFilas <> 1 Then
                    i = i + 1
                End If
            Else

                If String.IsNullOrEmpty(DGVPBacklog.Rows(i).Cells(1).Value) Then
                    MsgBox("Guardando ...." & vbNewLine & vbNewLine & "La columna '" & DGVPBacklog.Columns(1).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    DGVPBacklog.Rows(i).Selected = True
                    Parar = True
                    Exit Do
                End If
                If String.IsNullOrEmpty(DGVPBacklog.Rows(i).Cells(2).Value) Then ' Estado
                    MsgBox("Guardando ...." & vbNewLine & vbNewLine & "La columna '" & DGVPBacklog.Columns(2).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    DGVPBacklog.Rows(i).Selected = True
                    Parar = True
                    Exit Do
                ElseIf String.Equals(DGVPBacklog.Rows(i).Cells(2).Value.ToString, "Liberada") And String.Equals(DGVPBacklog.Rows(i).Cells("EST").Value.ToString, "NOLIB") Then
                    MsgBox("Guardando ...." & vbNewLine & vbNewLine & "El estado 'Liberada' se configura mediante la generación de una nueva 'Release'", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    DGVPBacklog.Rows(i).Selected = True
                    Parar = True
                    Exit Do
                End If
                For k = 3 To 7
                    'MsgBox(k & "-----" & DGVPBacklog.Rows(i).Cells(k).Value)
                    If String.IsNullOrEmpty(DGVPBacklog.Rows(i).Cells(k).Value) Then
                        MsgBox("Guardando ...." & vbNewLine & vbNewLine & "La columna '" & DGVPBacklog.Columns(k).HeaderText & "' no puede estar vacía", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        DGVPBacklog.Rows(i).Selected = True
                        k = 8
                        Parar = True
                        Exit Do
                    Else
                        If Not IsNumeric(DGVPBacklog.Rows(i).Cells(k).Value) Then
                            MsgBox("La columna '" & DGVPBacklog.Columns(k).HeaderText & "' solo admite valores numéricos", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                            DGVPBacklog.Rows(i).Selected = True
                            k = 8
                            Parar = True
                            Exit Do
                        Else
                            If k = 4 Then ' controlo el número del sprint
                                If CInt(DGVPBacklog.Rows(i).Cells(k).Value) > CInt(txtProyecto.Tag) Then
                                    MsgBox("Este proyecto está configurado con " & txtProyecto.Tag & " sprints." & vbNewLine & vbNewLine & "El número de sprint introducido supera este valor.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                                    DGVPBacklog.Rows(i).Cells(k).Selected = True
                                    k = 8
                                    Parar = True
                                    Exit Do
                                End If
                                If EstaElSprintCerrado(CInt(DGVPBacklog.Rows(i).Cells(k).Value)) And DGVPBacklog.Rows(i).Cells("EST").Value = "NOLIB" Then
                                    MsgBox("El sprint introducido está cerrado o cancelado, y por ello no puede ser usado", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                                    DGVPBacklog.Rows(i).Cells(k).Selected = True
                                    k = 8
                                    Parar = True
                                    Exit Do
                                End If
                            ElseIf k = 3 Then
                                If CInt(DGVPBacklog.Rows(i).Cells(k).Value) > CInt(txtRol.Tag) Then
                                    MsgBox("Este proyecto está configurado con " & txtRol.Tag & " días por sprints." & vbNewLine & vbNewLine & "El número de días introducido supera este valor.", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                                    DGVPBacklog.Rows(i).Cells(k).Selected = True
                                    k = 8
                                    Parar = True
                                    Exit Do
                                End If

                            End If
                        End If
                    End If
                Next k

                i = i + 1

            End If
        Loop


        If Not Parar Then

            Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
            Dim trans As OleDbTransaction
            Dim comando As New OleDbCommand()

            comando.Connection = cnn
            cnn.Open()
            trans = cnn.BeginTransaction()
            comando.Connection = cnn
            comando.Transaction = trans

            If CrearProductBacklogToolStripMenuItem.Enabled = False Then 'Refinando...

                i = 0
                Dim tratados(999, 2) As Integer
                Dim z As Integer
                Dim encontrado As Boolean = False

                Do While original(i, 0) <> "FIN"
                    For w = 0 To NumFilas - 2
                        If CInt(original(i, 0)) = CInt(DGVPBacklog.Rows(w).Cells(0).Value) Then
                            tratados(z, 0) = CInt(original(i, 0))
                            tratados(z, 1) = i
                            tratados(z, 2) = w
                            z += 1
                            w = NumFilas
                            encontrado = True
                        End If
                    Next
                    If Not encontrado Then
                        tratados(z, 0) = CInt(original(i, 0))
                        tratados(z, 1) = i
                        tratados(z, 2) = -1
                        z += 1
                    End If
                    encontrado = False
                    i += 1
                Loop

                'Dim cadena As String = ""
                ' For i = 0 To z - 1
                'cadena = cadena & tratados(i, 0) & "/" & tratados(i, 1) & "/" & tratados(i, 2) & vbNewLine
                ' Next
                'MsgBox(cadena)


                q = z - 1
                encontrado = False
                For i = 0 To NumFilas - 2
                    For w = 0 To q
                        If CInt(DGVPBacklog.Rows(i).Cells(0).Value) = tratados(w, 0) Then
                            encontrado = True
                            w = q + 1
                        End If
                    Next
                    If Not encontrado Then
                        tratados(z, 0) = CInt(DGVPBacklog.Rows(i).Cells(0).Value)
                        tratados(z, 1) = -1
                        tratados(z, 2) = i
                        z += 1
                    End If
                    encontrado = False
                Next

                'cadena = ""
                'For i = 0 To z - 1
                'cadena = cadena & tratados(i, 0) & "/" & tratados(i, 1) & "/" & tratados(i, 2) & vbNewLine
                'Next
                'MsgBox(cadena)


                'Tratamiento en función de lo que tengo
                Dim filaorg As Integer
                Dim filadgv As Integer
                Dim IdH As Integer

                Dim cad1 As String = ""
                Dim cad2 As String = ""

                ' iniciar transacción

                For i = 0 To z - 1
                    IdH = tratados(i, 0)
                    filaorg = tratados(i, 1)
                    filadgv = tratados(i, 2)

                    If filaorg <> -1 And filadgv <> -1 Then
                        For q = 0 To 9
                            cad1 = cad1 & original(filaorg, q)
                            cad2 = cad2 & DGVPBacklog.Rows(filadgv).Cells(q).Value
                        Next

                        If String.Equals(cad1, cad2) Then
                            'son identicas, nada que hacer
                            HaceFalta = False
                        Else
                            HaceFalta = True
                            ' hay cambios
                            'veo si ha cambiado el sprint

                            ' Tabla PBacklog
                            sql = "UPDATE PBacklog SET "
                            sql = sql & "IdProyecto = " & IDPROYECTO & ", "
                            sql = sql & "IdHistoria = " & IdH & ", "
                            sql = sql & "NHistoria = '" & DGVPBacklog.Rows(filadgv).Cells(1).Value & "', "
                            sql = sql & "Estado = '" & DGVPBacklog.Rows(filadgv).Cells(2).Value & "', "
                            sql = sql & "Dias = " & DGVPBacklog.Rows(filadgv).Cells(3).Value & ", "
                            sql = sql & "CosteEstimado = " & CInt(DGVPBacklog.Rows(filadgv).Cells(6).Value) & ", "
                            sql = sql & "ValorEstimado = " & CInt(DGVPBacklog.Rows(filadgv).Cells(7).Value) & ", "
                            sql = sql & "NumSprint = " & CInt(DGVPBacklog.Rows(filadgv).Cells(4).Value) & ", "
                            sql = sql & "Prioridad = " & CInt(DGVPBacklog.Rows(filadgv).Cells(5).Value) & ", "
                            sql = sql & "Comentarios = '" & DGVPBacklog.Rows(filadgv).Cells(8).Value & "' "
                            sql = sql & "WHERE ("
                            sql = sql & "(IdProyecto = " & IDPROYECTO & ") AND "
                            sql = sql & "(IdHistoria = " & IdH & "))"


                            'en la tabla sprints no hay que hacer nada - eso creo

                            'tabla SBacklog
                            sql1 = "UPDATE SBackLog SET "
                            sql1 = sql1 & "NombreHistoria = '" & DGVPBacklog.Rows(filadgv).Cells(1).Value & "', "
                            sql1 = sql1 & "IdSprint = " & CInt(DGVPBacklog.Rows(filadgv).Cells(4).Value) & ", "
                            sql1 = sql1 & "Estado = '" & DGVPBacklog.Rows(filadgv).Cells(2).Value & "' "
                            sql1 = sql1 & "WHERE ("
                            sql1 = sql1 & "(IdProyecto = " & IDPROYECTO & ") AND "
                            sql1 = sql1 & "(IdHistoria = " & IdH & "))"
                        End If

                    ElseIf filaorg <> -1 Then
                        ' fila borrada del original

                        HaceFalta = True

                        sql = "DELETE FROM PBacklog "
                        sql = sql & "WHERE ("
                        sql = sql & "(IdProyecto = " & IDPROYECTO & ") AND "
                        sql = sql & "(IdHistoria = " & IdH & "))"

                        sql1 = "DELETE FROM SBacklog "
                        sql1 = sql1 & "WHERE ("
                        sql1 = sql1 & "(IdProyecto = " & IDPROYECTO & ") AND "
                        sql1 = sql1 & "(IdHistoria = " & IdH & "))"


                    ElseIf filadgv <> -1 Then
                        ' ha habido nuevas historias
                        'Tiene pinta de insert (igual que algo totalmente nuevo)

                        HaceFalta = True

                        sql = "INSERT INTO PBacklog ("
                        sql = sql & "IdProyecto, IdHistoria, NHistoria, Estado, Dias, CosteEstimado, ValorEstimado, NumSprint, Prioridad, Comentarios) "
                        sql = sql & "VALUES (" & IDPROYECTO & ", " & IdH & ", '"
                        sql = sql & DGVPBacklog.Rows(filadgv).Cells(1).Value & "', '"
                        sql = sql & DGVPBacklog.Rows(filadgv).Cells(2).Value & "', "
                        sql = sql & CInt(DGVPBacklog.Rows(filadgv).Cells(3).Value) & ", "
                        sql = sql & CInt(DGVPBacklog.Rows(filadgv).Cells(6).Value) & ", "
                        sql = sql & CInt(DGVPBacklog.Rows(filadgv).Cells(7).Value) & ", "
                        sql = sql & CInt(DGVPBacklog.Rows(filadgv).Cells(4).Value) & ", "
                        sql = sql & CInt(DGVPBacklog.Rows(filadgv).Cells(5).Value) & ", '"
                        sql = sql & DGVPBacklog.Rows(filadgv).Cells(8).Value & "')"

                        sql1 = "INSERT INTO SBacklog ("
                        sql1 = sql1 & "IdSBacklog, IdProyecto, IdHistoria, NombreHistoria, IdUser, IdSprint, Duracion, Estado, DetalleDias) "
                        sql1 = sql1 & "VALUES (" & DameIdSB(CInt(DGVPBacklog.Rows(filadgv).Cells(4).Value)) & ", " & IDPROYECTO & ", " & IdH & ", '"
                        sql1 = sql1 & DGVPBacklog.Rows(filadgv).Cells(1).Value & "', " & 0 & ", "
                        sql1 = sql1 & CInt(DGVPBacklog.Rows(filadgv).Cells(4).Value) & ", "
                        sql1 = sql1 & CInt(DGVPBacklog.Rows(filadgv).Cells(3).Value) & ", '"
                        sql1 = sql1 & DGVPBacklog.Rows(filadgv).Cells(2).Value & "', '"
                        sql1 = sql1 & MontarDiasDetalle(CInt(DGVPBacklog.Rows(filadgv).Cells(4).Value)) & "')"


                    End If

                    If HaceFalta Then

                        Try
                            'ejecuto sql
                            comando.CommandText = sql
                            comando.ExecuteNonQuery()

                            'ejecuto ssql
                            comando.CommandText = sql1
                            comando.ExecuteNonQuery()


                        Catch ex As Exception
                            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                            trans.Rollback()
                        End Try

                    End If

                    sql = ""
                    sql1 = ""

                    cad1 = ""
                    cad2 = ""
                Next
                trans.Commit()

            Else ' Creando

                ' AQUI ESTOY CREANDO PB
                ' todo bien y validado - así que a guardarlo en BBDD

                For i = 0 To NumFilas - 2


                    'inserto en PB
                    sql = "INSERT INTO PBackLog (IdProyecto, IdHistoria, NHistoria, Estado, Dias, CosteEstimado, ValorEstimado, NumSprint, Prioridad, Comentarios) VALUES ("
                    sql = sql & IDPROYECTO & ", "
                    sql = sql & DGVPBacklog.Rows(i).Cells(0).Value & ", "
                    sql = sql & "'" & DGVPBacklog.Rows(i).Cells(1).Value & "', "
                    sql = sql & "'" & DGVPBacklog.Rows(i).Cells(2).Value & "', "
                    sql = sql & DGVPBacklog.Rows(i).Cells(3).Value & ", "
                    sql = sql & DGVPBacklog.Rows(i).Cells(6).Value & ", "
                    sql = sql & DGVPBacklog.Rows(i).Cells(7).Value & ", "
                    sql = sql & DGVPBacklog.Rows(i).Cells(4).Value & ", "
                    sql = sql & DGVPBacklog.Rows(i).Cells(5).Value & ", "
                    sql = sql & "'" & DGVPBacklog.Rows(i).Cells(8).Value & "');"

                    'inserto en SB
                    ssql = "INSERT INTO SBacklog (IdSBacklog, IdProyecto, IdHistoria, NombreHistoria, IdSprint, Duracion, Estado, DetalleDias) VALUES ("
                    ssql = ssql & DameIdSB(CInt(DGVPBacklog.Rows(i).Cells(4).Value)) & ", "
                    ssql = ssql & IDPROYECTO & ", " & CInt(DGVPBacklog.Rows(i).Cells(0).Value) & ", '"
                    ssql = ssql & DGVPBacklog.Rows(i).Cells(1).Value & "', "
                    ssql = ssql & CInt(DGVPBacklog.Rows(i).Cells(4).Value) & ", " & CInt(DGVPBacklog.Rows(i).Cells(3).Value) & ", '"
                    ssql = ssql & DGVPBacklog.Rows(i).Cells(2).Value & "','"
                    ssql = ssql & MontarDiasDetalle(CInt(DGVPBacklog.Rows(i).Cells(4).Value)) & "')"


                    q = i

                    For w = 0 To q
                        If msprints(w) = CInt(DGVPBacklog.Rows(i).Cells(4).Value) Then
                            'ya está no hay que salvar
                            YaExisteIdSB = True
                            w = q + 1
                        Else
                            'no está hay que salvar
                            YaExisteIdSB = False
                        End If
                    Next

                    msprints(i) = DGVPBacklog.Rows(i).Cells(4).Value
                    ReDim Preserve msprints(i + 1)

                    YaExisteIdSB = False

                    Try
                        'ejecuto sql
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()

                        If Not YaExisteIdSB Then
                            'ejecuto ssql
                            comando.CommandText = ssql
                            comando.ExecuteNonQuery()
                        End If

                    Catch ex As Exception
                        MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")

                        trans.Rollback()
                    End Try

                Next i
                trans.Commit()
                ButSalir.Tag = "HEGUARDADO"
            End If



            DGVPBacklog.Visible = vbFalse
            DGVPBacklog.Rows.Clear()
            DGVPBacklog.Rows(0).Cells(0).Value = 1
            DGVPBacklog.Tag = 1

            ' Se desactiva la creación
            If MeHeCargadoTodoPB Then
                If Parar Then CrearProductBacklogToolStripMenuItem.PerformClick()
                CrearProductBacklogToolStripMenuItem.Enabled = True
                RefinarProductBacklogToolStripMenuItem.Enabled = False
            Else
                CrearProductBacklogToolStripMenuItem.Enabled = False
                RefinarProductBacklogToolStripMenuItem.Enabled = True
            End If

            CrearNuevoProyectoToolStripMenuItem.Enabled = True
            pnlBotones.Visible = False
            InformacionSgtoProyectoToolStripMenuItem.Enabled = True
            SalirToolStripMenuItem.Enabled = True
            NotificacionesToolStripMenuItem.Enabled = True
            CancelarSprintToolStripMenuItem.Enabled = True

        End If
    End Sub

    Private Sub ButSalir_Click(sender As Object, e As EventArgs) Handles ButSalir.Click
        Dim resp As Integer


        resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then
            ' Salgo. Esto es crítico para la siguiente vez (no quitar ni de coña)
            DGVPBacklog.Visible = False
            DGVPBacklog.Rows.Clear()
            DGVPBacklog.Rows(0).Cells(0).Value = 1
            DGVPBacklog.Tag = 1
            pnlBotones.Visible = False
            DGVPBacklog.EndEdit()
            If pnlBotones.Tag = "Crear" Then
                ' no ha salvado nada
                CrearNuevoProyectoToolStripMenuItem.Enabled = True
                RefinarProductBacklogToolStripMenuItem.Enabled = False
                NotificacionesToolStripMenuItem.Enabled = True
                SalirToolStripMenuItem.Enabled = True
                CancelarSprintToolStripMenuItem.Enabled = True
                InformacionSgtoProyectoToolStripMenuItem.Enabled = True
            Else
                CrearNuevoProyectoToolStripMenuItem.Enabled = True
                RefinarProductBacklogToolStripMenuItem.Enabled = True
                NotificacionesToolStripMenuItem.Enabled = True
                SalirToolStripMenuItem.Enabled = True
                CancelarSprintToolStripMenuItem.Enabled = True
                InformacionSgtoProyectoToolStripMenuItem.Enabled = True
            End If
        Else
            ' No hago nada
            pnlBotones.Visible = True
            CrearNuevoProyectoToolStripMenuItem.Enabled = False
            NotificacionesToolStripMenuItem.Enabled = False
            SalirToolStripMenuItem.Enabled = False
            CancelarSprintToolStripMenuItem.Enabled = False
            InformacionSgtoProyectoToolStripMenuItem.Enabled = False
        End If


    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub TerminarProyectoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TerminarProyectoToolStripMenuItem1.Click
        Dim msj As String
        Dim resp As Integer
        Dim sql As String = ""
        ' Monto mensaje para asegurarme de que lo quiero cancelar
        msj = "Está seguro que quiere 'Terminar' el proyecto: " & txtProyecto.Text & "?" & vbNewLine & vbNewLine & "Una vez terminado el proyecto esta acción no podrá deshacerse."
        resp = MsgBox(msj, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then
            sql = "UPDATE Proyectos SET Terminado = " & True & " WHERE IdProyecto = " & IDPROYECTO
            Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
            Dim xxx As New OleDbCommand(sql)
            xxx.Connection = cnn

            'ejecuto el sql
            Try
                cnn.Open()
                xxx.ExecuteNonQuery()
                cnn.Close()
                CrearProductBacklogToolStripMenuItem.Enabled = False
                RefinarProductBacklogToolStripMenuItem.Enabled = False
                TerminarProyectoToolStripMenuItem1.Enabled = False
                CancelarProyectoToolStripMenuItem1.Enabled = False
                MantenerProyectoExistenteToolStripMenuItem.Enabled = False
            Catch ex As Exception
                MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try
        Else
        End If

    End Sub

    Private Sub CancelarProyectoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CancelarProyectoToolStripMenuItem1.Click
        Dim msj As String
        Dim resp As Integer
        Dim sql As String = ""
        ' Monto mensaje para asegurarme de que lo quiero cancelar
        msj = "Está seguro que quiere 'Cancelar' el proyecto: " & txtProyecto.Text & "?" & vbNewLine & vbNewLine & "Una vez cancelado el proyecto esta acción no podrá deshacerse."
        resp = MsgBox(msj, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then
            sql = "UPDATE Proyectos SET Cancelado = " & True & " WHERE IdProyecto = " & IDPROYECTO
            Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
            Dim xxx As New OleDbCommand(sql)
            xxx.Connection = cnn

            'ejecuto el sql
            Try
                cnn.Open()
                xxx.ExecuteNonQuery()
                cnn.Close()

                CrearProductBacklogToolStripMenuItem.Enabled = False
                RefinarProductBacklogToolStripMenuItem.Enabled = False
                TerminarProyectoToolStripMenuItem1.Enabled = False
                CancelarProyectoToolStripMenuItem1.Enabled = False
                MantenerProyectoExistenteToolStripMenuItem.Enabled = False
            Catch ex As Exception
                MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try
        Else
        End If
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
            DGVPBacklog.Visible = False
            butListo.Tag = CrearProductBacklogToolStripMenuItem.Enabled
            CrearProductBacklogToolStripMenuItem.Enabled = False
            RefinarProductBacklogToolStripMenuItem.Enabled = False
            CrearNuevoProyectoToolStripMenuItem.Enabled = False
            NotificacionesToolStripMenuItem.Enabled = False
            SalirToolStripMenuItem.Enabled = False
            CancelarSprintToolStripMenuItem.Enabled = False
            InformacionSgtoProyectoToolStripMenuItem.Enabled = False
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
        SalirToolStripMenuItem.Enabled = True
        NotificacionesToolStripMenuItem.Enabled = True
        CrearProductBacklogToolStripMenuItem.Enabled = butListo.Tag
        RefinarProductBacklogToolStripMenuItem.Enabled = Not CrearProductBacklogToolStripMenuItem.Enabled
        CrearNuevoProyectoToolStripMenuItem.Enabled = True
        InformacionSgtoProyectoToolStripMenuItem.Enabled = True
        CancelarSprintToolStripMenuItem.Enabled = True
    End Sub


    Private Sub CrearNuevoProyectoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CrearNuevoProyectoToolStripMenuItem1.Click
        frmProyecto.pnlProyecto.Tag = "Nuevo"
        frmProyecto.ShowDialog()
    End Sub

    Private Sub MantenerProyectoExistenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenerProyectoExistenteToolStripMenuItem.Click

        frmProyecto.pnlProyecto.Tag = "Cambiar"

        frmProyecto.txtNProyecto.Text = Me.txtProyecto.Text
        frmProyecto.txtIProyecto.Text = IDPROYECTO

        frmProyecto.ShowDialog()

    End Sub


    Private Sub GenerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarToolStripMenuItem.Click
        frmReleases.ShowDialog()
    End Sub

    Private Sub NotificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificacionesToolStripMenuItem.Click
        frmNotificaciones.ShowDialog()
    End Sub

    Private Sub VerLasYaGeneradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLasYaGeneradasToolStripMenuItem.Click
        frmVerRel.ShowDialog()
    End Sub

    Private Sub CancelarSprintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarSprintToolStripMenuItem.Click
        frmCancelarSprint.ShowDialog()
    End Sub
  
    Private Sub InformacionSgtoProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionSgtoProyectoToolStripMenuItem.Click
        frmInfoSgtoP.ShowDialog()
    End Sub
 
    Private Sub CAMBIOPToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox(IDPROYECTO)
        LProyectos.ShowDialog()
        MsgBox(IDPROYECTO)
    End Sub
End Class