Public Class frmInfoSgtoS

    Private Sub butSalir_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        DGVInfoSgtoP.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub frmInfoSgtoS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub New(ByVal IdS As Integer)

        MyBase.New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Dim i As Integer
        Dim Terminados As Integer = 0
        Dim dterminados As Integer = 0
        Dim hterminados As Integer = 0
        Dim Pendientes As Integer = 0
        Dim hpendientes As Integer = 0
        Dim dpendientes As Integer = 0

        Dim p As New Point(50, 50)
        Me.Location = p

        If GeneraInformeSgtoSpr(DGVInfoSgtoP, IdS) Then
            txtTSprints.Text = DGVInfoSgtoP.RowCount
            For i = 0 To DGVInfoSgtoP.RowCount - 1
                If DGVInfoSgtoP.Rows(i).Cells(4).Value = "Terminado" Then
                    Terminados += 1
                    dterminados += CInt(Trim(Microsoft.VisualBasic.Left(DGVInfoSgtoP.Rows(i).Cells(2).Value, Len(DGVInfoSgtoP.Rows(i).Cells(2).Value) - 2)))
                    hterminados += CInt(Trim(Microsoft.VisualBasic.Left(DGVInfoSgtoP.Rows(i).Cells(3).Value, Len(DGVInfoSgtoP.Rows(i).Cells(3).Value) - 2)))
                Else
                    Pendientes += 1
                    dpendientes += CInt(Trim(Microsoft.VisualBasic.Left(DGVInfoSgtoP.Rows(i).Cells(2).Value, Len(DGVInfoSgtoP.Rows(i).Cells(2).Value) - 2)))
                    hpendientes += CInt(Trim(Microsoft.VisualBasic.Left(DGVInfoSgtoP.Rows(i).Cells(3).Value, Len(DGVInfoSgtoP.Rows(i).Cells(3).Value) - 2)))
                End If
            Next i

            txtNumSTerminados.Text = Terminados.ToString
            txtNumSPendientes.Text = Pendientes.ToString

            If CInt(txtNumSTerminados.Text) <> 0 Then
                txtDiasxSprint.Text = dterminados / CInt(txtNumSTerminados.Text)
                txtHxH.Text = hterminados / CInt(txtNumSTerminados.Text)
                If CInt(txtNumSPendientes.Text) = 0 Then
                Else
                    txtFproyectadaFin.Text = (CInt(txtDiasxSprint.Text) * CInt(txtNumSPendientes.Text)).ToString
                    txtHPF.Text = (CInt(txtHxH.Text) * CInt(txtNumSPendientes.Text)).ToString
                End If
            Else
                txtDiasxSprint.Text = "N/D"
                txtFproyectadaFin.Text = "N/D"
                txtHxH.Text = "N/D"
                txtHPF.Text = "N/D"
            End If

            txtDiasxSprint.Enabled = False
            txtFproyectadaFin.Enabled = False
            txtNumSPendientes.Enabled = False
            txtNumSTerminados.Enabled = False
            txtTSprints.Enabled = False
            txtHxH.Enabled = False
            txtHPF.Enabled = False

        Else

        End If
    End Sub
End Class