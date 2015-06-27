
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
Imports System.Collections.ObjectModel


Public Class frmSB
    Public HDPry As Integer
    Private Sub frmSB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' al cargar tengo que generar el dgv completo
    End Sub

    Public Sub New(ByVal IdS As Integer, ByVal NPry As String, ByVal Dura As Integer)

        MyBase.New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        lblCabecera.Text = "Sprint Backlog del Sprint " & IdS.ToString & " del Proyecto " & NPry

        Dim NomMiembrosEquipo(0) As String
        Dim NumMiembrosEquipo As Integer
        Dim seguir As Boolean

        Dim i, IdEq, longi, mx As Integer
        Dim sql As String

        Dim estados() As String = {"Accionable", "En marcha", "Terminado"}

        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)

        HDPry = DameHorasDiaProyecto()

        Try
            cdp.Open()

            sql = "SELECT IdEquipo FROM Proyectos "
            sql = sql & "WHERE (Proyectos.IdProyecto = " & IDPROYECTO & ")"

            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader

            If existe.HasRows Then
                While existe.Read()
                    IdEq = CInt(existe.GetValue(0))
                End While
            End If

            sql = "SELECT Usuarios.Nombre, Usuarios.IdUser FROM Usuarios, Equipos "
            sql = sql & "WHERE ((Equipos.IdEquipo = " & IdEq & ") AND "
            sql = sql & "(Equipos.IdPersona = Usuarios.IdUser) AND "
            sql = sql & "(Equipos.IdRolPersona = 3)) ORDER BY Usuarios.Nombre"

            Dim bbuscar As New OleDbCommand(sql, cdp)
            Dim eexiste As OleDbDataReader = bbuscar.ExecuteReader

            If eexiste.HasRows Then
                While eexiste.Read()
                    NomMiembrosEquipo(i) = eexiste.GetValue(0).ToString
                    i += 1
                    ReDim Preserve NomMiembrosEquipo(i)
                End While
            End If

            cdp.Close()
            NumMiembrosEquipo = i - 1

            ReDim Preserve NomMiembrosEquipo(NumMiembrosEquipo)

            seguir = True

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            seguir = False
        End Try

        If seguir Then

            ' creo las columnas del DGV

            Dim col, col1 As New DataGridViewComboBoxColumn()


            With col
                .DataPropertyName = "Resp"
                .HeaderText = "Resp"
                .DropDownWidth = 100
                .Width = 100
                .MaxDropDownItems = 3
                .FlatStyle = FlatStyle.Flat
            End With

            With col1
                .DataPropertyName = "Est"
                .HeaderText = "Est"
                .DropDownWidth = 100
                .Width = 100
                .MaxDropDownItems = 3
                .FlatStyle = FlatStyle.Flat
            End With

            col.Items.AddRange(NomMiembrosEquipo)
            col.HeaderText = "Responsable"
            col1.Items.AddRange(estados)
            col1.HeaderText = "Estado"

            dgvSB.Columns.Insert(2, col)
            dgvSB.Columns.Insert(4, col1)

            Dim v As String = ""
            i = 1
            While i <= Dura
                v = "D" & (i).ToString
                AddColumnaDia(v)
                i += 1
            End While

            ' en este punto ya tengo creado el datagrid con todas su columnas
            ' ahora toca cargar la info que haya en la tabla sbacklog

            dgvSB.AllowUserToAddRows = True

            sql = "SELECT SBacklog.IdHistoria, "
            sql = sql & "SBacklog.NombreHistoria, "
            sql = sql & "Usuarios.Nombre, "
            sql = sql & "SBacklog.IdSprint, "
            sql = sql & "SBacklog.Estado, "
            sql = sql & "SBacklog.Duracion, "
            sql = sql & "SBacklog.DetalleDias "
            sql = sql & "FROM SBacklog, Usuarios, Sprints "
            sql = sql & "WHERE ("
            sql = sql & "(SBacklog.IdProyecto = " & IDPROYECTO & ") AND "
            sql = sql & "(SBacklog.IdSprint = " & IdS & ") AND "
            sql = sql & "(SBacklog.IdUser = Usuarios.IdUser) AND "
            sql = sql & "(Sprints.IdProyecto = " & IDPROYECTO & ") AND "
            sql = sql & "(Sprints.IdSprint = " & IdS & ") AND "
            sql = sql & "(Sprints.Cerrado = False))"

            Try
                cdp.Open()

                Dim bus As New OleDbCommand(sql, cdp)
                Dim exi As OleDbDataReader = bus.ExecuteReader
                Dim fila As Integer
                Dim k, up As Integer
                Dim horas As Integer
                Dim bloque As String
                Dim detalle As String
                Dim DurSprint As Integer

                DurSprint = DameDuracionSprintEnBD(IdS)


                If exi.HasRows Then
                    While exi.Read()
                        detalle = exi.GetValue(6)
                        longi = Len(detalle)
                        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(detalle, 6), 2) = "YY" Then
                            mx = (longi - 1) / 6
                        Else
                            mx = (longi - 1) / 6
                        End If
                        If mx > DurSprint Then mx = DurSprint
                        dgvSB.Rows.Add(exi.GetValue(0), exi.GetValue(1), exi.GetValue(2), exi.GetValue(3), exi.GetValue(4), exi.GetValue(5))
                        fila = dgvSB.RowCount - 2
                        k = 6
                        up = 1
                        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(detalle, 6), 2) <> "YY" Then
                            For i = 1 To mx '- 6
                                up = up + 6
                                bloque = Microsoft.VisualBasic.Left(detalle, up)
                                bloque = Microsoft.VisualBasic.Right(bloque, 3)
                                bloque = Microsoft.VisualBasic.Left(bloque, 2)
                                If bloque = "YY" Then horas = 0 Else horas = CInt(bloque)
                                If horas = 0 Then
                                    dgvSB.Rows(fila).Cells(k).Value = ""
                                Else
                                    dgvSB.Rows(fila).Cells(k).Value = horas
                                End If
                                k += 1
                            Next
                        End If
                    End While
                End If
                cdp.Close()

                'Cargo la lista de historias accionables del PB
                CargaListaHstoriasAccionables(dgvHA)

                dgvSB.AllowUserToAddRows = False
            Catch ex As Exception
                MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
            End Try

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        Dim resp As Integer

        resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub AddColumnaDia(ByVal v As String)

        Dim dia As New DataGridViewTextBoxColumn()

        dia = CreaColumnaDia(v)
        dia.HeaderText = v & " (h)"

        dgvSB.Columns.Add(dia)

    End Sub
    Private Function CreaColumnaDia(ByVal v As String) As DataGridViewTextBoxColumn

        Dim diacol As New DataGridViewTextBoxColumn()

        With diacol
            .DataPropertyName = v
            .HeaderText = v
            .Width = 50
            .DefaultCellStyle.Format = "N0"
            .Resizable = DataGridViewTriState.False
        End With

        Return diacol
    End Function


    Private Sub butGuardarSB_Click(sender As Object, e As EventArgs) Handles butGuardarSB.Click
        'Primero verfico
        Dim fila As Integer
        Dim col As Integer
        Dim texto As String = ""
        Dim hh(100, 30) As Integer
        Dim resp As Integer
        Dim grabar As Boolean = False
        Dim numfilas As Integer
        Dim NumCols As Integer
        Dim i, j As Integer

        fila = VerificaCeldasSB(dgvSB, col)
        If fila <> -1 Then
            If dgvSB.Rows.Count = 0 Then
                'no hay nada que guardar
                grabar = False
                Me.Close()
            Else
                'algo mal
                dgvSB.Rows(fila).Cells(col).Selected = True
            End If
        Else
            fila = CuadranDuraciones(dgvSB, texto, hh)
            If fila <> -1 Then
                resp = MsgBox("Se han detectado posibles incoherencias en los repartos de horas: " & vbNewLine & vbNewLine & texto & vbNewLine & vbNewLine & "Quiere continuar guardando?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "SCRUM Wizard")
                If resp = vbYes Then
                    grabar = True
                Else
                    'NO HACER NADA
                End If
            Else
                grabar = True
            End If
        End If

            If grabar Then
                numfilas = dgvSB.RowCount
                NumCols = dgvSB.ColumnCount


                ' todo listo a grabar
                Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)
                Dim trans As OleDbTransaction
                Dim comando As New OleDbCommand()

                Dim sql As String = ""
                Dim sql1 As String = ""

                comando.Connection = cnn
                cnn.Open()
                trans = cnn.BeginTransaction()
                comando.Connection = cnn
                comando.Transaction = trans

                For i = 0 To numfilas - 1

                    j = 0
                    texto = "|"

                    While hh(i, j) <> -1
                        texto = texto & Format((j + 1), "00") & "/" & Format(hh(i, j), "00") & "|"
                        j += 1
                    End While

                    sql = "UPDATE SBackLog SET "
                    sql = sql & "IdUser = " & DameIdUsuario(dgvSB.Rows(i).Cells(2).Value) & ", "
                    sql = sql & "IdSprint = " & dgvSB.Rows(i).Cells(3).Value & ", "
                    sql = sql & "Duracion = " & dgvSB.Rows(i).Cells(5).Value & ", "
                    sql = sql & "Estado = '" & dgvSB.Rows(i).Cells(4).Value & "', "
                    sql = sql & "DetalleDias = '" & texto & "' "
                    sql = sql & "WHERE ((IdProyecto = " & IDPROYECTO & ") AND (IdHistoria = " & CInt(dgvSB.Rows(i).Cells(0).Value) & "))"

                    sql1 = "UPDATE PBackLog SET "
                    sql1 = sql1 & "Estado = '" & dgvSB.Rows(i).Cells(4).Value & "', "
                    sql1 = sql1 & "Dias = " & dgvSB.Rows(i).Cells(5).Value & ", "
                    sql1 = sql1 & "NumSprint = " & dgvSB.Rows(i).Cells(3).Value & " "
                    sql1 = sql1 & "WHERE ((IdProyecto = " & IDPROYECTO & ") AND (IdHistoria = " & CInt(dgvSB.Rows(i).Cells(0).Value) & "))"

                    Try
                        'ejecuto sql
                        comando.CommandText = sql
                        comando.ExecuteNonQuery()

                        'ejecuto el sql 1
                        comando.CommandText = sql1
                        comando.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
                        i = numfilas + 1
                        trans.Rollback()
                    End Try

                Next i

                If i <> numfilas + 1 Then

                    trans.Commit()

                    ' quitar info y cerrar
                    Me.Close()
                End If

            End If

    End Sub
    Public Function CuadranDuraciones(dgv As DataGridView, ByRef t As String, ByRef hh(,) As Integer) As Integer
        Dim duracion, dduracion As Integer
        Dim v, q As Integer
        Dim fila As Integer
        Dim col As Integer
        Dim horas As Integer = 0
        Dim NumFilas, NumCols As Integer

        t = ""
        v = -1

        NumFilas = dgv.RowCount
        NumCols = dgv.ColumnCount

        For fila = 0 To NumFilas - 1

            dduracion = CInt(dgv.Rows(fila).Cells(5).Value)
            duracion = dgv.ColumnCount - 1

            'For col = 6 To 6 + duracion - 1
            For col = 6 To duracion
                q = col - 6
                If IsNumeric(dgv.Rows(fila).Cells(col).Value) Then
                    hh(fila, q) = CInt(dgv.Rows(fila).Cells(col).Value)
                    horas += CInt(dgv.Rows(fila).Cells(col).Value)
                    'Else
                    '   hh(fila, q) = -1
                    '  col = duracion + 3
                End If
            Next col
            hh(fila, q + 1) = -1
            If col + 1 = duracion Then hh(fila, col - 6) = -1

            If (dduracion * HDPry) <> horas Then
                t = t & "La duración de la Historia: " & dgv.Rows(fila).Cells(1).Value & " y su reparto por días no coincide (" & (dduracion * HDPry).ToString & "h <> " & horas.ToString & "h" & vbNewLine
                v = fila
            End If

            horas = 0

        Next fila


        Return v
    End Function
    Public Function VerificaCeldasSB(dgv As DataGridView, ByRef ccol As Integer) As Integer

        Dim duracion As Integer
        Dim v As Integer
        Dim fila As Integer
        Dim col As Integer
        Dim NumFilas, NumCols As Integer
        Dim parar As Boolean

        Dim car As String

        NumFilas = dgv.RowCount
        NumCols = dgv.ColumnCount

        For fila = 0 To NumFilas - 1
            For col = 2 To NumCols - 1
                Try
                    car = dgv.Rows(fila).Cells(col).Value
                Catch ex As Exception
                    car = ""
                End Try

                If Not IsNumeric(dgv.Rows(fila).Cells(5).Value) Then
                    MsgBox("La columna " & dgv.Columns(5).HeaderText & " solo admite valores númericos", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                    v = fila
                    ccol = col
                    parar = True
                    col = NumCols
                    fila = NumFilas
                Else
                    duracion = CInt(dgv.Rows(fila).Cells(5).Value)
                    If duracion > NumCols - 6 Then
                        MsgBox("La duración de la historia no puede superar la duración del sprint (" & (NumCols - 6).ToString & " días)", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        v = fila
                        ccol = col
                        parar = True
                        col = NumCols
                        fila = NumFilas
                    Else
                        parar = False
                    End If
                End If

                If ((col >= 6 And col < (6 + duracion)) Or col = 3 Or col = 5) And Not parar Then ' son las celdas de dia
                    'solo numeros
                    If IsNothing(car) Then
                        v = -1
                    Else
                        If Not (IsNumeric(car)) Then
                            If car = "" Then
                                v = -1
                            Else

                                MsgBox("La columna " & dgv.Columns(col).HeaderText & " solo admite valores númericos", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                                v = fila
                                ccol = col
                                col = NumCols
                                fila = NumFilas
                            End If
                        ElseIf col >= 6 And CInt(car) > HDPry Then
                            MsgBox("El valor de la columna " & dgv.Columns(col).HeaderText & " no puede ser superior al número de horas máximas por día (" & HDPry.ToString & ") establecido para este proyecto", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                            v = fila
                            ccol = col
                            col = NumCols
                            fila = NumFilas
                        Else
                            'TODO OK
                            v = -1
                        End If
                        End If
                ElseIf (col = 4 Or col = 2) And Not parar Then
                    If String.IsNullOrEmpty(car) Or String.IsNullOrWhiteSpace(car) Then
                        MsgBox("La columna " & dgv.Columns(col).HeaderText & " debe tener un valor", MsgBoxStyle.Exclamation, "SCRUM Wizard")
                        v = fila
                        ccol = col
                        col = NumCols
                        fila = NumFilas
                    Else
                        'TODO OK
                        v = -1
                    End If
                End If
            Next col
        Next fila


        Return v
    End Function

    Private Sub butListahAccionables_Click(sender As Object, e As EventArgs) Handles butListahAccionables.Click
        ' muestra la lista de las historias del PB para ese proyecto y sprint accionables
        dgvSB.Enabled = False
        butSalir.Enabled = False
        butGuardarSB.Enabled = False
        butListahAccionables.Enabled = False
        pnlHA.Location = dgvSB.Location

        pnlHA.Visible = True

    End Sub

    Public Sub CargaListaHstoriasAccionables(dgv As DataGridView)
        Dim cdp As New OleDbConnection(My.Settings.tfgConnectionString)

        Try

            cdp.Open()
            Dim sql As String
            sql = "SELECT NHistoria, Dias, NumSprint, CosteEstimado, ValorEstimado FROM PBacklog WHERE IdProyecto = " & IDPROYECTO & " AND Estado = 'Accionable'"
            Dim buscar As New OleDbCommand(sql, cdp)
            Dim existe As OleDbDataReader = buscar.ExecuteReader
            While existe.Read()
                dgv.Rows.Add(existe.GetValue(0), existe.GetValue(1), existe.GetValue(2), existe.GetValue(3), existe.GetValue(4))
            End While
            cdp.Close()

        Catch ex As Exception
            MsgBox("Ups!!! Problemas", MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try

    End Sub


    Private Sub butSHA_Click(sender As Object, e As EventArgs) Handles butSHA.Click
        dgvSB.Enabled = True
        butSalir.Enabled = True
        butGuardarSB.Enabled = True
        butListahAccionables.Enabled = True

        pnlHA.Visible = False
    End Sub

    Private Sub ControlarError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvSB.DataError

    End Sub
End Class