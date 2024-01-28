Imports MySql.Data.MySqlClient

Public Class frmProveedor
  
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
        txtDir.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtCP.Text = ""
        txtCuit.Text = ""
        txtTe.Text = ""
        txtMail.Text = ""
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDir.SelectionLength = Len(txtDir.Text)
            txtDir.Select()
        End If
    End Sub

    Private Sub txtDir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDir.KeyPress
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

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCuit.SelectionLength = Len(txtCuit.Text)
            txtCuit.Select()
        End If
    End Sub

    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema FeedLot - Alta de Proveesores"
    End Sub

    Private Sub txtProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCP.SelectionLength = Len(txtCP.Text)
            txtCP.Select()
        End If
    End Sub

    Private Sub txtTe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTe.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtMail.SelectionLength = Len(txtMail.Text)
            txtMail.Select()
        End If
    End Sub

    Private Sub txtMail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMail.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
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
                MsgBox("Error: Razón Social es un campo obligatorio.", vbInformation, "Servico de Alertas")
                txtNombre.Select()
            Else
                If txtDir.Text = "" Then
                    txtDir.Text = "-"
                End If
                If txtLoc.Text = "" Then
                    txtLoc.Text = "-"
                End If
                If txtProv.Text = "" Then
                    txtProv.Text = "-"
                End If
                If txtCP.Text = "" Then
                    txtCP.Text = "-"
                End If
                If txtCuit.Text = "" Then
                    txtCuit.Text = "-"
                End If
                If txtTe.Text = "" Then
                    txtTe.Text = "-"
                End If
                If txtMail.Text = "" Then
                    txtMail.Text = "-"
                End If
                resP = MessageBox.Show("Grabar Alta del Proveedor ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resP = Windows.Forms.DialogResult.OK Then

                    G.Grabar("Proveedor", "NoImagen", "feedlot.insProveedor", txtNombre.Text, txtDir.Text, txtLoc.Text, txtProv.Text, _
                             txtCP.Text, txtCuit.Text, txtTe.Text, txtMail.Text)
                    lblMsg.Text = "Proveedor dado de alta..."
                    Cancelar()
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Proveedor No fue dado de alta..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtTe.SelectionLength = Len(txtTe.Text)
            txtTe.Select()
        End If
    End Sub

    Private Sub txtCuit_Validated(sender As Object, e As EventArgs) Handles txtCuit.Validated
        Dim X As Integer
        Dim cuitSinGuion As String = ""
        Dim caracTer As String = ""
        Dim valCuit As New ValidaCUIT

        If txtCuit.Text <> "" Then
            For X = 1 To Len(txtCuit.Text)
                caracTer = Mid(txtCuit.Text, X, 1)
                If IsNumeric(caracTer) Then
                    cuitSinGuion = cuitSinGuion & caracTer
                End If
            Next X

            If Len(cuitSinGuion) <> 11 Then
                MsgBox("Error: Cuit Inválido!", vbExclamation)
                txtCuit.Text = ""
                txtCuit.Select()
            Else
                If valCuit.CUIT(cuitSinGuion) Then
                    Dim Ct1, Ct2, Ct3 As String
                    Ct1 = Mid(cuitSinGuion, 1, 2)
                    Ct2 = Mid(cuitSinGuion, 3, 8)
                    Ct3 = Mid(cuitSinGuion, 11, 1)
                    txtCuit.Text = Ct1 & "-" & Ct2 & "-" & Ct3
                Else
                    MsgBox("Error: Cuit Inválido!", vbExclamation)
                    txtCuit.Text = ""
                    txtCuit.Select()
                End If
            End If
        End If
    End Sub
End Class