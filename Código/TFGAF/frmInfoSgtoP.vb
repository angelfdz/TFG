Public Class frmInfoSgtoP

    Private Sub butSalir_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        DGVInfoSgtoP.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub frmInfoSgtoP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim Terminados As Integer = 0
        Dim Pendientes As Integer = 0
        Dim p As New Point(50, 50)
        Me.Location = p

        If GeneraInformeSgtoPry(DGVInfoSgtoP) Then
            txtTSprints.Text = DGVInfoSgtoP.RowCount
            For i = 0 To DGVInfoSgtoP.RowCount - 1
                If DGVInfoSgtoP.Rows(i).Cells(3).Value = "Cerrado" Then
                    Terminados += 1
                End If
            Next i
            Pendientes = DGVInfoSgtoP.RowCount - Terminados
            txtNumSTerminados.Text = Terminados.ToString
            txtNumSPendientes.Text = Pendientes.ToString

            If CInt(txtNumSTerminados.Text) <> 0 Then
                txtDiasxSprint.Text = Math.Abs(DateDiff(DateInterval.Day, Now(), DameFCProyecto())) / CInt(txtNumSTerminados.Text)
                If CInt(txtNumSPendientes.Text) = 0 Then
                Else
                    txtFproyectadaFin.Text = Trim(Microsoft.VisualBasic.Left(DateAdd(DateInterval.Day, CDbl(txtDiasxSprint.Text) * CDbl(txtNumSPendientes.Text), Now()), 10))
                End If
            Else
                txtDiasxSprint.Text = "N/D"
                txtFproyectadaFin.Text = "N/D"
            End If

            txtDiasxSprint.Enabled = False
            txtFproyectadaFin.Enabled = False
            txtNumSPendientes.Enabled = False
            txtNumSTerminados.Enabled = False
            txtTSprints.Enabled = False

        Else

        End If

    End Sub
End Class