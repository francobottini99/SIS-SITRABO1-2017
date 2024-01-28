Imports MySql.Data.MySqlClient

Public Class frmVentas

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
        txtFecha.Text = ""
        lblDisp.Text = ""
        cbxTropa.Text = ""
        txtNCab.Text = ""
        txtPesoCab.Text = ""
        txtPesoTotal.Text = ""
        txtImpKGSinIVA.Text = ""
        txtIVAKG.Text = ""
        txtImpKGConIVA.Text = ""
        txtImpCabSinIVA.Text = ""
        txtIVACab.Text = ""
        txtImpCabConIVA.Text = ""
        txtCostFlete.Text = ""
        txtCostOtros.Text = ""
        txtImpVentaFinal.Text = ""
        txtImpNetoVenta.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        txtFecha.Select()
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt, _Dt2 As New DataTable
        Dim _Ver As New Mostrar
        Dim I As Integer = 1
        Dim Disp As Integer = 0

        Me.Text = "Sistema FeedLot - Alta de Venta"

        _Dt = _Ver.verTropa
        For Each _Dr As DataRow In _Dt.Rows
            _Dt2 = _Ver.verStock(I)

            For Each _Dr2 As DataRow In _Dt2.Rows
                Disp = (Disp + _Dr2("Ingresos")) - _Dr2("Egresos")
            Next

            If Disp > 0 Then
                cbxTropa.Items.Add(_Dr("NombreTropa"))
            End If

            I += 1
        Next


    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxTropa.SelectionLength = Len(cbxTropa.Text)
            cbxTropa.Select()
        End If
    End Sub

    Private Sub txtFecha_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFecha.Validating
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

    Private Sub cbxTropa_Validated(sender As Object, e As EventArgs) Handles cbxTropa.Validated
        If Not cbxTropa.Text = "" And (txtPesoCab.Text = "" Or lblDisp.Text = "") Then
            MsgBox("Error: La tropa ingresada no se encuentra en la base de datos", vbInformation, "Servico de Alertas")
            cbxTropa.Text = ""
            cbxTropa.Select()
        End If
    End Sub

    Private Sub cbxTropa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTropa.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNCab.SelectionLength = Len(txtNCab.Text)
            txtNCab.Select()
        End If
    End Sub

    Private Sub cbxTropa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTropa.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim Disp As Integer = 0

        _Dt = _Ver.verTropa

        txtIdTropa.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreTropa") = cbxTropa.Text Then
                txtIdTropa.Text = _Dr("idTropa")
                txtPesoCab.Text = Format(CDbl(_Dr("PesoIngreso")), "#,##0.00")
            End If
        Next

        _Dt = _Ver.verStock(CInt(txtIdTropa.Text))

        If _Dt.Rows.Count <> 0 Then
            For Each _Dr As DataRow In _Dt.Rows
                Disp = (Disp + _Dr("Ingresos")) - _Dr("Egresos")
            Next
        End If

        lblDisp.Text = Disp
    End Sub

    Private Sub txtNCab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNCab.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtImpKGSinIVA.SelectionLength = Len(txtImpKGSinIVA.Text)
            txtImpKGSinIVA.Select()
        End If
    End Sub

    Private Sub txtNCab_Validated(sender As Object, e As EventArgs) Handles txtNCab.Validated
        If Not txtNCab.Text = "" Then
            If Not IsNumeric(txtNCab.Text) Then
                MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                txtNCab.Text = ""
                txtNCab.Select()
            Else
                If CInt(txtNCab.Text) > CInt(lblDisp.Text) Then
                    MsgBox("Error: La tropa no cuenta con tantas cabezas", vbInformation, "Servico de Alertas")
                    txtNCab.Text = ""
                    txtNCab.Select()
                Else
                    txtPesoTotal.Text = Format(CDbl(txtPesoCab.Text) * CDbl(txtNCab.Text), "#,##0.00")
                End If
            End If
        End If
    End Sub

    Private Sub txtImpKGSinIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImpKGSinIVA.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtIVAKG.SelectionLength = Len(txtIVAKG.Text)
            txtIVAKG.Select()
        End If
    End Sub

    Private Sub txtImpKGSinIVA_Validated(sender As Object, e As EventArgs) Handles txtImpKGSinIVA.Validated
        If Not txtImpKGSinIVA.Text = "" Then
            If Not cbxTropa.Text = "" Then
                If Not IsNumeric(txtImpKGSinIVA.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtImpKGSinIVA.Text = ""
                    txtImpKGSinIVA.Select()
                Else
                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar

                    _Dt = _Ver.verTropa
                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("idTropa") = txtIdTropa.Text Then
                            txtImpCabSinIVA.Text = Format(CDbl(txtImpKGSinIVA.Text * (CDbl(txtPesoTotal.Text) / CDbl(txtNCab.Text))), "$ #,##0.00")
                        End If
                    Next

                    txtImpKGSinIVA.Text = Format(CDbl(txtImpKGSinIVA.Text), "$ #,##0.00")
                End If
            Else
                MsgBox("Error: No a seleccionado una tropa", vbInformation, "Servico de Alertas")
                txtImpKGSinIVA.Text = ""
                cbxTropa.Select()
            End If
        End If
    End Sub

    Private Sub txtIVAKG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIVAKG.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostFlete.SelectionLength = Len(txtCostFlete.Text)
            txtCostFlete.Select()
        End If
    End Sub

    Private Sub txtIVAKG_Validated(sender As Object, e As EventArgs) Handles txtIVAKG.Validated
        If Not txtIVAKG.Text = "" Then
            If Not txtImpKGSinIVA.Text = "" Then
                If Not IsNumeric(txtIVAKG.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtIVAKG.Text = ""
                    txtIVAKG.Select()
                Else
                    txtIVACab.Text = txtIVAKG.Text

                    txtImpCabConIVA.Text = Format(CDbl(txtImpCabSinIVA.Text + ((txtImpCabSinIVA.Text * txtIVACab.Text) / 100)), "$ #,##0.00")
                    txtImpKGConIVA.Text = Format(CDbl(txtImpKGSinIVA.Text + ((txtImpKGSinIVA.Text * txtIVAKG.Text) / 100)), "$ #,##0.00")
                    txtImpVentaFinal.Text = Format(CDbl((txtImpCabConIVA.Text * CInt(txtNCab.Text))), "$ #,##0.00")

                    txtIVAKG.Text = Format(CDbl(txtIVAKG.Text), "#,##0.00")
                    txtIVACab.Text = txtIVAKG.Text
                End If
            Else
                MsgBox("Error: No hay valor sobre el cual calcular el IVA", vbInformation, "Servico de Alertas")
                txtImpKGSinIVA.Text = ""
                txtIVAKG.Text = ""
                txtImpKGSinIVA.Select()
            End If
        End If
    End Sub

    Private Sub txtCostFlete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostFlete.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostOtros.SelectionLength = Len(txtCostOtros.Text)
            txtCostOtros.Select()
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
                    txtCostFlete.Text = Format(CDbl(txtCostFlete.Text), "$ #,##0.00")
                End If
            Else
                MsgBox("Error: No a seleccionado una tropa", vbInformation, "Servico de Alertas")
                txtCostFlete.Text = ""
                cbxTropa.Select()
            End If
        End If
    End Sub

    Private Sub txtCostOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostOtros.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
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
                    txtImpNetoVenta.Text = Format(CDbl(txtImpVentaFinal.Text - txtCostOtros.Text - txtCostFlete.Text), "$ #,##0.00")

                    txtCostOtros.Text = Format(CDbl(txtCostOtros.Text), "$ #,##0.00")
                End If
            Else
                MsgBox("Error: No a seleccionado una tropa", vbInformation, "Servico de Alertas")
                txtCostOtros.Text = ""
                cbxTropa.Select()
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtFecha.Text = "" Then
                MsgBox("Error: El campo Fecha es obligatorio... !", vbInformation, "Servico de Alertas")
                txtFecha.Select()
            Else
                If cbxTropa.Text = "" Then
                    MsgBox("Error: El campo Tropa es obligatorio... !", vbInformation, "Servico de Alertas")
                    cbxTropa.Select()
                Else
                    If txtNCab.Text = "" Then
                        MsgBox("Error: El campo N° De Cabezas es obligatorio... !", vbInformation, "Servico de Alertas")
                        txtNCab.Select()
                    Else
                        If txtImpKGSinIVA.Text = "" Then
                            MsgBox("Error: El campo Importe Por KG - Sin IVA es obligatorio... !", vbInformation, "Servico de Alertas")
                            txtImpKGSinIVA.Select()
                        Else
                            If txtIVAKG.Text = "" Then
                                MsgBox("Error: El campo Importe Por KG - IVA % es obligatorio... !", vbInformation, "Servico de Alertas")
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
                                        resP = MessageBox.Show("Grabar Alta de Venta ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                                        If resP = Windows.Forms.DialogResult.OK Then

                                            G.Grabar("Ventas", "NoImagen", "feedlot.insVenta", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), CDbl(txtNCab.Text), _
                                                     CDbl(txtPesoTotal.Text), CDbl(txtPesoCab.Text), CDbl(txtImpKGSinIVA.Text), _
                                                     CDbl(txtImpCabSinIVA.Text), CDbl(txtIVAKG.Text), CDbl(txtImpKGConIVA.Text), CDbl(txtImpCabConIVA.Text), _
                                                     CDbl(txtImpVentaFinal.Text), CDbl(txtCostFlete.Text), CDbl(txtCostOtros.Text), CDbl(txtImpNetoVenta.Text), CInt(txtIdTropa.Text))


                                            G.Grabar("Stock", "NoImagen", "feedlot.modStock", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), 0, _
                                                CInt(txtNCab.Text), 0, CInt(txtIdTropa.Text))

                                            lblMsg.Text = "Venta dada de alta..."
                                            Cancelar()
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
            lblMsg.Text = "Error: La venta no fue dado de alta..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub
End Class