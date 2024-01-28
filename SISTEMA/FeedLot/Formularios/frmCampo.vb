Imports MySql.Data.MySqlClient

Public Class frmCampo

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
        txtNombre.Text = ""
        txtProp.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtHas.Text = ""
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtProp.SelectionLength = Len(txtProp.Text)
            txtProp.Select()
        End If
    End Sub

    Private Sub txtProp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProp.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLoc.SelectionLength = Len(txtLoc.Text)
            txtLoc.Select()
        End If
    End Sub

    Private Sub txtLoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtProv.SelectionLength = Len(txtProv.Text)
            txtProv.Select()
        End If
    End Sub

    Private Sub txtHas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHas.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If Not IsNumeric(txtHas.Text) Then
                MsgBox("Error: Sólo se admiten valores numéricos", vbInformation, "Servico de Alertas")
                txtHas.Text = ""
                txtHas.Select()
            Else
                txtHas.Text = Format(CInt(txtHas.Text), "#,##0")
                btnGuardar.Select()
            End If
        End If
    End Sub

    Private Sub txtProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtHas.SelectionLength = Len(txtHas.Text)
            txtHas.Select()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        txtNombre.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtNombre.Text = "" Then
                MsgBox("Error: Nombre Campo es un campo obligatorio.", vbInformation, "Servico de Alertas")
                txtNombre.Select()
            Else
                If txtProp.Text = "" Then
                    txtProp.Text = "-"
                End If
                If txtLoc.Text = "" Then
                    txtLoc.Text = "-"
                End If
                If txtProv.Text = "" Then
                    txtProv.Text = "-"
                End If
                If txtHas.Text = "" Then
                    txtHas.Text = "0"
                End If
                resP = MessageBox.Show("Grabar Alta del Campo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resP = Windows.Forms.DialogResult.OK Then

                    G.Grabar("Campos", "NoImagen", "feedlot.insCampos", txtNombre.Text, txtProp.Text, txtLoc.Text, txtProv.Text, _
                             CInt(txtHas.Text))
                    lblMsg.Text = "Campo dado de alta..."
                    Cancelar()
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Campo No fue dado de alta..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub frmCampo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema FeedLot - Alta de Campos"
    End Sub

    Private Sub txtHas_TextChanged(sender As Object, e As EventArgs) Handles txtHas.TextChanged

    End Sub
End Class