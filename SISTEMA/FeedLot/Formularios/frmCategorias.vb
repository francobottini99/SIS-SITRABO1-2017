Imports MySql.Data.MySqlClient

Public Class frmCategorias

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Activar()
        gbxDatos.Enabled = True
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnSalir.Enabled = False
    End Sub

    Private Sub Cancelar()
        gbxDatos.Enabled = False
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True
        txtCategoria.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtCategoria.Text = "" Then
                MsgBox("Error: El campo categoria es obligatorio", vbInformation, "Servico de Alertas")
                txtCategoria.SelectionLength = Len(txtCategoria.Text)
                txtCategoria.Select()
            Else
                resP = MessageBox.Show("Grabar categoria ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resP = Windows.Forms.DialogResult.OK Then

                    G.Grabar("Categorias", "NoImagen", "feedlot.insCategorias", txtCategoria.Text)
                    lblMsg.Text = "Categoria guardada..."
                    Cancelar()
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Categoria no guardada..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        txtCategoria.Select()
    End Sub

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema FeedLot - Alta de Categorias"
    End Sub

    Private Sub txtCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoria.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub
End Class