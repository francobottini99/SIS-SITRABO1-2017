Public Class frmConsAlimentacion

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmConsAlimentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema FeedLot - Consulta de Alimentación"

        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.consAlimentacion

        dgvAlim.DataSource = _Dt

    End Sub
End Class