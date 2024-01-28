Imports MySql.Data.MySqlClient

Public Class frmCompras

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
        txtCostCabConIVA.Text = ""
        txtCostCabFinal.Text = ""
        txtCostCabSinIVA.Text = ""
        txtCostFinalTropa.Text = ""
        txtCostFlete.Text = ""
        txtCostKGConIVA.Text = ""
        txtCostKGFinal.Text = ""
        txtCostKGSinIVA.Text = ""
        txtCostOtros.Text = ""
        txtFecha.Text = ""
        txtFormaPago.Text = ""
        txtIVACab.Text = ""
        txtIVAKG.Text = ""
        cbxProv.Text = ""
        cbxTropa.Text = ""
        txtPesoTropa.Text = ""
        txtPesoXCab.Text = ""
        txtCantCab.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        cbxProv.Select()
    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        Me.Text = "Sistema FeedLot - Alta de Compra"

        _Dt = _Ver.verProveedor
        For Each _Dr As DataRow In _Dt.Rows
            cbxProv.Items.Add(_Dr("RazonSocial"))
        Next
    End Sub

    Private Sub txtFecha_Validated(sender As Object, e As EventArgs) Handles txtFecha.Validated
        If Not txtFecha.Text = "" Then
            If IsDate(txtFecha.Text) Then
                txtFecha.Text = Format(CDate(txtFecha.Text), "dd/MM/yyyy")
            Else
                MsgBox("Error: La fecha " & txtFecha.Text & " no es valida", vbInformation, "Servico de Alertas")
                txtFecha.Text = ""
                txtFecha.Select()
            End If
        End If

    End Sub

    Private Sub cbxProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxProv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxTropa.SelectionLength = Len(cbxTropa.Text)
            cbxTropa.Select()
        End If
    End Sub

    Private Sub cbxProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProv.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        cbxTropa.Items.Clear()
        cbxTropa.Text = ""
        txtPesoTropa.Text = ""
        txtPesoXCab.Text = ""
        txtCantCab.Text = ""
        txtFecha.Text = ""

        _Dt = _Ver.verProveedor
        txtIdPr.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("RazonSocial") = cbxProv.Text Then
                txtIdPr.Text = _Dr("idProveedor")
            End If
        Next

        _Dt = _Ver.verTropa
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("PROVEEDOR_idProveedor") = txtIdPr.Text Then
                cbxTropa.Items.Add(_Dr("NombreTropa"))
            End If
        Next
    End Sub

    Private Sub cbxTropa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTropa.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostKGSinIVA.SelectionLength = Len(txtCostKGSinIVA.Text)
            txtCostKGSinIVA.Select()
        End If
    End Sub

    Private Sub cbxTropa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTropa.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verTropa
        txtIdTropa.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreTropa") = cbxTropa.Text Then
                txtIdTropa.Text = _Dr("idTropa")
                txtCantCab.Text = _Dr("Cabezas")
                txtPesoXCab.Text = Format(CDbl(_Dr("PesoIngreso")), "#,##0.00 Kg")
                txtPesoTropa.Text = Format(CDbl(_Dr("TotalKgTropa")), "#,##0.00 Kg")
                txtFecha.Text = Format(CDate(_Dr("FechaIngreso")), "dd/MM/yyyy")
            End If
        Next
    End Sub

    Private Sub txtIVAKG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIVAKG.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostFlete.SelectionLength = Len(txtCostFlete.Text)
            txtCostFlete.Select()
        End If
    End Sub

    Private Sub txtCostFlete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostFlete.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostOtros.SelectionLength = Len(txtCostOtros.Text)
            txtCostOtros.Select()
        End If
    End Sub

    Private Sub txtCostOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostOtros.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFormaPago.SelectionLength = Len(txtFormaPago.Text)
            txtFormaPago.Select()
        End If
    End Sub

    Private Sub txtFormaPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFormaPago.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub txtIVAKG_Validated(sender As Object, e As EventArgs) Handles txtIVAKG.Validated
        If Not txtIVAKG.Text = "" Then
            If Not txtCostKGSinIVA.Text = "" Then
                If Not IsNumeric(txtIVAKG.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtIVAKG.Text = ""
                    txtIVAKG.Select()
                Else
                    txtIVACab.Text = txtIVAKG.Text

                    txtCostCabConIVA.Text = Format(CDbl(txtCostCabSinIVA.Text + ((txtCostCabSinIVA.Text * txtIVACab.Text) / 100)), "$ #,##0.00")
                    txtCostKGConIVA.Text = Format(CDbl(txtCostKGSinIVA.Text + ((txtCostKGSinIVA.Text * txtIVAKG.Text) / 100)), "$ #,##0.00")

                    txtIVAKG.Text = Format(CDbl(txtIVAKG.Text), "#,##0.00")
                    txtIVACab.Text = txtIVAKG.Text
                End If
            Else
                MsgBox("Error: No hay valor sobre el cual calcular el IVA", vbInformation, "Servico de Alertas")
                txtCostKGSinIVA.Text = ""
                txtIVAKG.Text = ""
                txtCostKGSinIVA.Select()
            End If
        End If
    End Sub

    Private Sub txtCostKGSinIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostKGSinIVA.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtIVAKG.SelectionLength = Len(txtIVAKG.Text)
            txtIVAKG.Select()
        End If
    End Sub

    Private Sub txtCostKGSinIVA_Validated(sender As Object, e As EventArgs) Handles txtCostKGSinIVA.Validated
        If Not txtCostKGSinIVA.Text = "" Then
            If Not cbxTropa.Text = "" Then
                If Not IsNumeric(txtCostKGSinIVA.Text) Then
                        MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                        txtCostKGSinIVA.Text = ""
                        txtCostKGSinIVA.Select()
                    Else
                        Dim _Dt As New DataTable
                        Dim _Ver As New Mostrar

                        _Dt = _Ver.verTropa
                        For Each _Dr As DataRow In _Dt.Rows
                            If _Dr("idTropa") = txtIdTropa.Text Then
                                txtCostCabSinIVA.Text = Format(CDbl(txtCostKGSinIVA.Text * (_Dr("TotalKgTropa") / _Dr("Cabezas"))), "$ #,##0.00")
                            End If
                        Next
                        txtCostKGSinIVA.Text = Format(CDbl(txtCostKGSinIVA.Text), "$ #,##0.00")
                    End If
            Else
                MsgBox("Error: No a seleccionado una tropa", vbInformation, "Servico de Alertas")
                txtCostKGSinIVA.Text = ""
                cbxTropa.Select()
            End If
        End If
    End Sub

    Private Sub txtCostFlete_Validated(sender As Object, e As EventArgs) Handles txtCostFlete.Validated
        If Not txtCostFlete.Text = "" Then
            If Not cbxTropa.Text = "" Then
                If Not IsNumeric(txtCostFlete.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtCostFlete.Text = ""
                    txtCostFlete.Select()
                Else
                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar

                    _Dt = _Ver.verTropa
                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("idTropa") = txtIdTropa.Text Then
                            txtCostKGFinal.Text = Format(CDbl(txtCostKGConIVA.Text + (txtCostFlete.Text / _Dr("TotalKgTropa"))), "$ #,##0.00")
                        End If
                    Next

                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("idTropa") = txtIdTropa.Text Then
                            txtCostCabFinal.Text = Format(CDbl(txtCostCabConIVA.Text + (txtCostFlete.Text / _Dr("Cabezas"))), "$ #,##0.00")
                        End If
                    Next

                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("idTropa") = txtIdTropa.Text Then
                            txtCostFinalTropa.Text = Format(CDbl((txtCostCabFinal.Text * _Dr("Cabezas")) + txtCostFlete.Text), "$ #,##0.00")
                        End If
                    Next

                    txtCostFlete.Text = Format(CDbl(txtCostFlete.Text), "$ #,##0.00")
                End If
            Else
                MsgBox("Error: No a seleccionado una tropa", vbInformation, "Servico de Alertas")
                txtCostFlete.Text = ""
                cbxTropa.Select()
            End If
        End If
    End Sub

    Private Sub txtCostOtros_Validated(sender As Object, e As EventArgs) Handles txtCostOtros.Validated
        If Not txtCostOtros.Text = "" Then
            If Not cbxTropa.Text = "" Then
                If Not IsNumeric(txtCostOtros.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtCostOtros.Text = ""
                    txtCostOtros.Select()
                Else
                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar

                    _Dt = _Ver.verTropa
                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("idTropa") = txtIdTropa.Text Then
                            txtCostKGFinal.Text = Format(CDbl(txtCostKGFinal.Text + (txtCostOtros.Text / _Dr("TotalKgTropa"))), "$ #,##0.00")
                        End If
                    Next

                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("idTropa") = txtIdTropa.Text Then
                            txtCostCabFinal.Text = Format(CDbl(txtCostCabFinal.Text + (txtCostOtros.Text / _Dr("Cabezas"))), "$ #,##0.00")
                        End If
                    Next

                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("idTropa") = txtIdTropa.Text Then
                            txtCostFinalTropa.Text = Format(CDbl((txtCostCabFinal.Text * _Dr("Cabezas")) + txtCostOtros.Text), "$ #,##0.00")
                        End If
                    Next

                    txtCostOtros.Text = Format(CDbl(txtCostOtros.Text), "$ #,##0.00")
                End If
            Else
                txtCostOtros.Text = "$ 0.00"
            End If
        Else
            MsgBox("Error: No a seleccionado una tropa", vbInformation, "Servico de Alertas")
            txtCostOtros.Text = ""
            cbxTropa.Select()
        End If
    End Sub

    Private Sub cbxTropa_Validated(sender As Object, e As EventArgs) Handles cbxTropa.Validated
        If Not cbxTropa.Text = "" And (txtPesoXCab.Text = "" Or txtPesoTropa.Text = "" Or txtCantCab.Text = "") Then
            MsgBox("Error: La tropa ingresada no se encuentra en la base de datos", vbInformation, "Servico de Alertas")
            cbxTropa.Text = ""
            cbxTropa.Select()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If cbxProv.Text = "" Then
                MsgBox("Error: El campo Proveedor es obligatorio... !", vbInformation, "Servico de Alertas")
                cbxProv.Select()
            Else
                If cbxTropa.Text = "" Then
                    MsgBox("Error: El campo Tropa es obligatorio... !", vbInformation, "Servico de Alertas")
                    cbxTropa.Select()
                Else
                    If txtFecha.Text = "" Then
                        MsgBox("Error: El campo Fecha es obligatorio... !", vbInformation, "Servico de Alertas")
                        txtFecha.Select()
                    Else
                        If txtCostKGSinIVA.Text = "" Then
                            MsgBox("Error: El campo Costo Por KG - Sin IVA es obligatorio... !", vbInformation, "Servico de Alertas")
                            txtCostKGSinIVA.Select()
                        Else
                            If txtIVAKG.Text = "" Then
                                MsgBox("Error: El campo Costo Por KG - IVA % es obligatorio... !", vbInformation, "Servico de Alertas")
                                txtIVAKG.Select()
                            Else
                                If txtCostFlete.Text = "" Then
                                    MsgBox("Error: El campo Costo Flete es obligatorio... !", vbInformation, "Servico de Alertas")
                                    txtCostFlete.Select()
                                Else
                                    If txtCostOtros.Text = "" Then
                                        MsgBox("Error: El campo Otros Costos es obligatorio... !", vbInformation, "Servico de Alertas")
                                        txtCostOtros.Select()
                                    Else
                                        If txtFormaPago.Text = "" Then
                                            MsgBox("Error: El campo Forma De Pago es obligatorio... !", vbInformation, "Servico de Alertas")
                                            txtFormaPago.Select()
                                        Else
                                            resP = MessageBox.Show("Grabar Alta de Compra ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                                            If resP = Windows.Forms.DialogResult.OK Then

                                                G.Grabar("Compras", "NoImagen", "feedlot.insCompra", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), CDbl(txtCostKGSinIVA.Text), _
                                                         CDbl(txtCostCabSinIVA.Text), CDbl(txtIVAKG.Text), CDbl(txtCostKGConIVA.Text), _
                                                         CDbl(txtCostCabConIVA.Text), CDbl(txtCostFlete.Text), CDbl(txtCostOtros.Text), CDbl(txtCostKGFinal.Text), _
                                                         CDbl(txtCostCabFinal.Text), CDbl(txtCostFinalTropa.Text), txtFormaPago.Text, CInt(txtIdTropa.Text), CInt(txtIdPr.Text))
                                                lblMsg.Text = "Compra dada de alta..."
                                                Cancelar()
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: La Compra no fue dado de alta..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

End Class