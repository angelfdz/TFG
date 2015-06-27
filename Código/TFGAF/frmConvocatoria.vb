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
Public Class frmConvocatoria

    Private Sub frmConvocatoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Public Sub New(ByVal cual As String, ByVal NPry As String)

        MyBase.New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Dim punto As New Point(75, 75)
        Me.Location = punto
        Me.Width = 278
        Me.pnlConvocatoria.Width = 248


        Dim sql As String

        sql = "SELECT IdSprint, FComienzo FROM Sprints WHERE ((IdProyecto = " & IDPROYECTO
        sql = sql & ") AND (Cerrado = False) AND (Notificado = False)) ORDER BY FComienzo"


        If String.Equals(cual, "Planificacion") Then
            lblTitulo.Text = "Convocatoria de SPM"
        ElseIf String.Equals(cual, "Revision") Then
            lblTitulo.Text = "Convocatoria de SRM"
        ElseIf String.Equals(cual, "Diaria") Then
            lblTitulo.Text = "Convocatoria de DS"
        ElseIf String.Equals(cual, "Retrospectiva") Then
            lblTitulo.Text = "Convocatoria de STM"
        End If
        lblTitulo.Tag = NPry

        Dim cnn As New OleDbConnection(My.Settings.tfgConnectionString)

        Try
            cnn.Open()
            Dim bbuscar As New OleDbCommand(sql, cnn)
            Dim ppb As OleDbDataReader = bbuscar.ExecuteReader

            If ppb.HasRows Then
                While ppb.Read()
                    DGVLSDisp.Rows.Add(ppb.GetValue(0).ToString, Microsoft.VisualBasic.Left(ppb.GetValue(1).ToString, 10))
                End While
                cnn.Close()
            Else
                ' MsgBox("El proyecto no tiene aún Sprint definidos", MsgBoxStyle.Information, "SCRUM Master")
                DGVLSDisp.Rows.Add("No tiene aún sprints", "")
            End If

        Catch ex As Exception
            MsgBox("Ups!!! Problemas" & ex.Message, MsgBoxStyle.Critical, "SCRUM Wizard")
        End Try
        Me.Tag = cual

    End Sub

    Private Sub Cerrar(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Tag = ""
    End Sub

    Private Sub butSalir_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        Dim resp As Integer

        If butSalir.Text = "Volver" Then
            butSalir.Text = "Salir"
            Dim pto As New Point(163, 10)
            butSalir.Location = pto
            Me.Width = 278
            pnlConvocatoria.Width = 248
            pnlDetalleConvocatoria.Enabled = False
            txtProyecto.Text = ""
            txtDReunion.Text = ""
            txtFComienzo.Text = ""
            txtFReunion.Text = ""
            txtSprint.Text = ""
            DGVAsistentes.Rows.Clear()
            DGVAsistentes.EndEdit()
            butEnviar.Enabled = False
            butAbandonar.Enabled = False
            butSeleccionar.Enabled = True
            pnlConvocatoria.Enabled = True
            DGVLSDisp.Enabled = True

        Else


            If DGVLSDisp.Rows(0).Cells(0).Value = "No tiene aún sprints" Or Me.Width = 278 Then
                resp = vbYes
            Else
                resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
            End If

            If resp = vbYes Then

                Dim pto As New Point(163, 10)
                butSalir.Location = pto
                Me.Width = 278
                pnlConvocatoria.Width = 248
                pnlDetalleConvocatoria.Enabled = False
                txtProyecto.Text = ""
                txtDReunion.Text = ""
                txtFComienzo.Text = ""
                txtFReunion.Text = ""
                txtSprint.Text = ""
                DGVAsistentes.Rows.Clear()
                DGVAsistentes.EndEdit()
                butEnviar.Enabled = False
                butAbandonar.Enabled = False
                Me.Close()

            Else
            'seguir aqui
            End If
        End If
    End Sub


    Private Sub butSeleccionar_Click(sender As Object, e As EventArgs) Handles butSeleccionar.Click
        Dim cual As String
        Dim fecha As Date
        Dim quien As String
        Dim reunion(3) As String
        Dim r As Integer


        If DGVLSDisp.Rows(0).Cells(0).Value = "No tiene aún sprints" Then
            butSalir.PerformClick()
        Else

            Dim pto As New Point(647, 10)
            butSalir.Location = pto
            Me.Width = 769

            cual = Me.Tag

            pnlConvocatoria.Width = 745
            pnlDetalleConvocatoria.Enabled = True

            txtProyecto.Text = lblTitulo.Tag

            txtFComienzo.Text = DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(1).Value
            If String.Equals(cual, "Planificacion") Then
                txtDReunion.Text = DameCadenaFormateada(DuracionSPM(DameDuracionSprint(CInt(DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value))))
                txtFReunion.Text = DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(1).Value
                lblFReunion.Text = "Fec.Reunión:"
            ElseIf String.Equals(cual, "Revision") Then
                txtDReunion.Text = DameCadenaFormateada(DuracionSR(DameDuracionSprint(CInt(DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value))).ToString)
                fecha = DateAdd(DateInterval.Day, DameDuracionSprint(CDbl(CInt(DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value))) - 2, CDate(txtFComienzo.Text))
                txtFReunion.Text = Microsoft.VisualBasic.Left(fecha.ToString, 10)
                lblFReunion.Text = "Fec.Reunión:"
            ElseIf String.Equals(cual, "Diaria") Then
                txtDReunion.Text = DameCadenaFormateada(15 / 100)
                lblFReunion.Text = "1a.Reunión:"
                fecha = DateAdd(DateInterval.Day, CDbl(1), CDate(txtFComienzo.Text))
                txtFReunion.Text = Microsoft.VisualBasic.Left(fecha.ToString, 10)
            ElseIf String.Equals(cual, "Retrospectiva") Then
                txtDReunion.Text = DameCadenaFormateada(DuracionSRetro(DameDuracionSprint(CInt(DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value))).ToString)
                fecha = DateAdd(DateInterval.Day, DameDuracionSprint(CDbl(CInt(DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value))) - 1, CDate(txtFComienzo.Text))
                txtFReunion.Text = Microsoft.VisualBasic.Left(fecha.ToString, 10)
                lblFReunion.Text = "Fec.Reunión:"
            End If


            txtSprint.Text = DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value
            txtHReunion.Text = "09:00"

            If cual = "Diaria" Then quien = "DT" Else quien = "ST"
            If AsistentesConocatoria(DGVAsistentes, quien) = -1 Then
                'problemas
            End If

            If YaNotificado(CInt(DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value)) Then
                rbtYEnviadoN.Checked = True
                rbtYEnviadoS.Checked = False
            Else

                r = SeHaNotificado(cual, CInt(DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value), reunion)

                If r = 0 Then ' nada notificado aún
                    rbtYEnviadoN.Checked = True
                    rbtYEnviadoS.Checked = False
                ElseIf r = 15 Then 'todo ya notificado (no se debe volver a enviar)
                    rbtYEnviadoN.Checked = False
                    rbtYEnviadoS.Checked = True
                Else ' hay que analizar cada caso
                    If cual = "Planificacion" Then
                        If CInt(reunion(3)) = 1 Then
                            'ya notificado
                            butSalir.Text = "Volver"
                            rbtYEnviadoS.Checked = True
                            rbtYEnviadoN.Checked = False
                            pnlDetalleConvocatoria.Enabled = False
                        Else
                            'aún sin notificar
                            'ya notificado
                            butSalir.Text = "Salir"
                            rbtYEnviadoS.Checked = False
                            rbtYEnviadoN.Checked = True
                            pnlDetalleConvocatoria.Enabled = True
                        End If
                    ElseIf cual = "Diaria" Then
                        If CInt(reunion(2)) = 1 Then
                            'ya notificado
                            butSalir.Text = "Volver"
                            rbtYEnviadoS.Checked = True
                            rbtYEnviadoN.Checked = False
                            pnlDetalleConvocatoria.Enabled = False
                        Else
                            'aún sin notificar
                            'ya notificado
                            butSalir.Text = "Salir"
                            rbtYEnviadoS.Checked = False
                            rbtYEnviadoN.Checked = True
                            pnlDetalleConvocatoria.Enabled = True
                        End If
                    ElseIf cual = "Revision" Then
                        If CInt(reunion(1)) = 1 Then
                            'ya notificado
                            butSalir.Text = "Volver"
                            rbtYEnviadoS.Checked = True
                            rbtYEnviadoN.Checked = False
                            pnlDetalleConvocatoria.Enabled = False
                        Else
                            'aún sin notificar
                            'ya notificado
                            butSalir.Text = "Salir"
                            rbtYEnviadoS.Checked = False
                            rbtYEnviadoN.Checked = True
                            pnlDetalleConvocatoria.Enabled = True
                        End If
                    ElseIf cual = "Retrospectiva" Then
                        If CInt(reunion(0)) = 1 Then
                            'ya notificado
                            butSalir.Text = "Volver"
                            rbtYEnviadoS.Checked = True
                            rbtYEnviadoN.Checked = False
                            pnlDetalleConvocatoria.Enabled = False
                        Else
                            'aún sin notificar
                            'ya notificado
                            butSalir.Text = "Salir"
                            rbtYEnviadoS.Checked = False
                            rbtYEnviadoN.Checked = True
                            pnlDetalleConvocatoria.Enabled = True
                        End If
                    End If

                End If
            End If


            txtProyecto.Enabled = False
            txtFComienzo.Enabled = False
            txtSprint.Enabled = False

            butEnviar.Enabled = True
            butAbandonar.Enabled = True

            butSeleccionar.Enabled = False
            DGVLSDisp.Enabled = False

        End If

    End Sub

    Private Sub butAbandonar_Click(sender As Object, e As EventArgs) Handles butAbandonar.Click
        Dim resp As Integer

        resp = MsgBox("Si no ha guardado sus cambios, hágalo antes de salir. De otra forma perderá los posibles cambios realizados." & vbNewLine & vbNewLine & "Desea Salir de todas formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SCRUM Wizard")
        If resp = vbYes Then
            Dim pto As New Point(163, 10)
            butSalir.Location = pto
            Me.Width = 278
            pnlConvocatoria.Width = 248
            pnlDetalleConvocatoria.Enabled = False
            txtProyecto.Text = ""
            txtDReunion.Text = ""
            txtFComienzo.Text = ""
            txtFReunion.Text = ""
            txtSprint.Text = ""
            DGVAsistentes.Rows.Clear()
            DGVAsistentes.EndEdit()
            butEnviar.Enabled = False
            butAbandonar.Enabled = False
            DGVLSDisp.Enabled = True
            butSeleccionar.Enabled = True
        Else
        End If

    End Sub

    Private Sub butEnviar_Click(sender As Object, e As EventArgs) Handles butEnviar.Click
        Dim cual As String
        Dim IdS As Integer
        Dim Fecha As Date
        Dim hora As Date
        Dim duracion As String
        Dim r As Integer
        Dim reunion(3) As String

        cual = Me.Tag
        IdS = CInt(DGVLSDisp.Rows(DGVLSDisp.CurrentCell.RowIndex).Cells(0).Value)
        Fecha = CDate(txtFReunion.Text)
        hora = CDate(txtHReunion.Text)
        duracion = txtDReunion.Text

        r = DameValorAuxiliarSprint(IdS)


        If rbtYEnviadoN.Checked = True Then
            If EnviarNotificaciones(cual, IdS, Fecha, DGVAsistentes, hora, duracion, r) Then

                'todo bien
                Dim pto As New Point(163, 10)
                butSalir.Location = pto
                Me.Width = 278
                pnlConvocatoria.Width = 248
                pnlDetalleConvocatoria.Enabled = False
                txtProyecto.Text = ""
                txtDReunion.Text = ""
                txtFComienzo.Text = ""
                txtFReunion.Text = ""
                txtSprint.Text = ""
                DGVAsistentes.Rows.Clear()
                DGVAsistentes.EndEdit()
                butEnviar.Enabled = False
                butAbandonar.Enabled = False
                DGVLSDisp.Enabled = True
                butSeleccionar.Enabled = True

            Else
                ' algún problema
            End If
        Else
            'no hacer nada pues ya está enviado
            MsgBox("Conovocatoria de reunión ya enviada", MsgBoxStyle.Information, "SCRUM Wizard")
        End If


    End Sub

End Class