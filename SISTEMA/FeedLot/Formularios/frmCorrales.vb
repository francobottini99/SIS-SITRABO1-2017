Imports MySql.Data.MySqlClient

Public Class frmCorrales
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
        txtId.Text = ""
        cbxCampo.Text = ""
        txtNom.Text = ""
        txtHas.Text = ""
        txtCab.Text = ""
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
                txtCab.SelectionLength = Len(txtCab.Text)
                txtCab.Select()
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        cbxCampo.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If cbxCampo.Text = "" Then
                MsgBox("Error: Nombre de Campo es un campo obligatorio.", vbInformation, "Servico de Alertas")
                cbxCampo.Select()
            Else
                If txtNom.Text = "" Then
                    MsgBox("Error: Nombre de Corral es un campo obligatorio.", vbInformation, "Servico de Alertas")
                    txtNom.Select()
                Else
                    If txtHas.Text = "" Then
                        txtHas.Text = "0"
                    End If
                    If txtCab.Text = "" Then
                        txtCab.Text = "0"
                    End If
                    resP = MessageBox.Show("Grabar Alta del Corral ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If resP = Windows.Forms.DialogResult.OK Then

                        G.Grabar("Campos", "NoImagen", "feedlot.insCorrales", txtNom.Text, CInt(txtHas.Text), CInt(txtCab.Text), _
                                 CInt(txtId.Text))
                        lblMsg.Text = "Corral dado de alta..."
                        Cancelar()
                    End If
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Corral No fue dado de alta..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub frmCorrales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        Me.Text = "Sistema FeedLot - Alta de Corrales"

        _Dt = _Ver.verCampos
        For Each _Dr As DataRow In _Dt.Rows
            cbxCampo.Items.Add(_Dr("NombreCampo"))
        Next

    End Sub

    Private Sub cbxCampo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCampo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNom.SelectionLength = Len(txtNom.Text)
            txtNom.Select()
        End If
    End Sub

    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtHas.SelectionLength = Len(txtHas.Text)
            txtHas.Select()
        End If
    End Sub

    Private Sub txtCab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCab.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If Not IsNumeric(txtCab.Text) Then
                MsgBox("Error: Sólo se admiten valores numéricos", vbInformation, "Servico de Alertas")
                txtCab.Text = ""
                txtCab.Select()
            Else
                txtCab.Text = Format(CInt(txtCab.Text), "#,##0")
                btnGuardar.Select()
            End If
        End If
    End Sub

    Private Sub cbxCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCampo.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCampos
        txtId.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreCampo") = cbxCampo.Text Then
                txtId.Text = _Dr("IdCampo")
            End If
        Next
    End Sub

End Class