Imports MySql.Data.MySqlClient

Public Class frmAlimentacion
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
        cbxRacion.Text = ""
        cbxCorral.Text = ""
        txtKGGrano.Text = ""
        txtKGFibra.Text = ""
        txtKGConcentrado.Text = ""
        txtKGOtros.Text = ""
        txtKGTotal.Text = ""
        txtImpGrano.Text = ""
        txtImpFibra.Text = ""
        txtImpConcentrado.Text = ""
        txtImpOtros.Text = ""
        txtImpTotal.Text = ""
        txtIdCorral.Text = ""
        txtIdRacion.Text = ""
        txtPorcenGrano.Text = ""
        txtPorcenFibra.Text = ""
        txtPorcenConcentrado.Text = ""
        txtPorcenOtros.Text = ""
        txtObservaciones.Text = ""
        rdbMañana.Checked = False
        rdbTarde.Checked = False
        lblImpFibra.Text = ""
        lblImpGrano.Text = ""
        lblImpConcentrado.Text = ""
        lblImpOtros.Text = ""
        txtGrano.Text = ""
        txtFibra.Text = ""
        txtConcentrado.Text = ""
        txtOtros.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        txtFecha.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."
    End Sub

    Private Sub frmAlimentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        Me.Text = "Sistema FeedLot - Alimentacion"

        _Dt = _Ver.verCorrales
        For Each _Dr As DataRow In _Dt.Rows
            cbxCorral.Items.Add(_Dr("NombreCorral"))
        Next

        _Dt = _Ver.verRacion
        For Each _Dr As DataRow In _Dt.Rows
            cbxRacion.Items.Add(_Dr("NombreRacion"))
        Next
    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxRacion.SelectionLength = Len(cbxRacion.Text)
            cbxRacion.Select()
        End If
    End Sub

    Private Sub txtFecha_Validated(sender As Object, e As EventArgs) Handles txtFecha.Validated
        If Not txtFecha.Text = "" Then
            If Not IsDate(txtFecha.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbInformation, "Servico de Alertas")
                txtFecha.Text = ""
                txtFecha.Select()
            Else
                txtFecha.Text = Format(CDate(txtFecha.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub cbxRacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxRacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCorral.SelectionLength = Len(cbxCorral.Text)
            cbxCorral.Select()
        End If
    End Sub

    Private Sub cbxRacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRacion.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verRacion

        txtIdRacion.Text = ""
        txtIdRacion.Text = ""
        txtGrano.Text = ""
        txtFibra.Text = ""
        txtConcentrado.Text = ""
        txtOtros.Text = ""
        lblImpConcentrado.Text = ""
        lblImpFibra.Text = ""
        lblImpGrano.Text = ""
        lblImpOtros.Text = ""

        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreRacion") = cbxRacion.Text Then
                txtIdRacion.Text = _Dr("idRaciones")
                txtGrano.Text = _Dr("Grano")
                txtFibra.Text = _Dr("Fibra")
                txtConcentrado.Text = _Dr("Concentrado")
                txtOtros.Text = _Dr("Otros")
                lblImpGrano.Text = Format(CDbl(_Dr("CostoGrano")), "$ #,##0.00") & " x Kg"
                lblImpFibra.Text = Format(CDbl(_Dr("CostoFibra")), "$ #,##0.00") & " x Kg"
                lblImpConcentrado.Text = Format(CDbl(_Dr("CostoConcentrado")), "$ #,##0.00") & " x Kg"
                lblImpOtros.Text = Format(CDbl(_Dr("CostoOtros")), "$ #,##0.00") & " x Kg"
            End If
        Next
    End Sub

    Private Sub cbxCorral_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCorral.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtKGGrano.SelectionLength = Len(txtKGGrano.Text)
            txtKGGrano.Select()
        End If
    End Sub

    Private Sub cbxCorral_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCorral.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCorrales
        txtIdCorral.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreCorral") = cbxCorral.Text Then
                txtIdCorral.Text = _Dr("idCorrales")
            End If
        Next
    End Sub

    Private Sub txtKGGrano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGGrano.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtKGFibra.SelectionLength = Len(txtKGFibra.Text)
            txtKGFibra.Select()
        End If
    End Sub

    Private Sub CalcularPorcentaje()
        If Not txtKGGrano.Text = "" Then
            txtPorcenGrano.Text = Format((CDbl(txtKGGrano.Text) * 100) / CDbl(txtKGTotal.Text), "0.00")
        End If

        If Not txtKGFibra.Text = "" Then
            txtPorcenFibra.Text = Format((CDbl(txtKGFibra.Text) * 100) / CDbl(txtKGTotal.Text), "0.00 ")
        End If

        If Not txtKGConcentrado.Text = "" Then
            txtPorcenConcentrado.Text = Format((CDbl(txtKGConcentrado.Text) * 100) / CDbl(txtKGTotal.Text), "0.00")
        End If

        If Not txtKGOtros.Text = "" Then
            txtPorcenOtros.Text = Format((CDbl(txtKGOtros.Text) * 100) / CDbl(txtKGTotal.Text), "0.00")
        End If
    End Sub

    Private Sub CalcularTotal()
        Dim KGGrano As Double
        Dim KGFibra As Double
        Dim KGConcentrado As Double
        Dim KGOTros As Double

        If txtKGGrano.Text = "" Then
            KGGrano = 0
        Else
            KGGrano = CDbl(txtKGGrano.Text)
        End If

        If txtKGFibra.Text = "" Then
            KGFibra = 0
        Else
            KGFibra = CDbl(txtKGFibra.Text)
        End If

        If txtKGConcentrado.Text = "" Then
            KGConcentrado = 0
        Else
            KGConcentrado = CDbl(txtKGConcentrado.Text)
        End If

        If txtKGOtros.Text = "" Then
            KGOTros = 0
        Else
            KGOTros = CDbl(txtKGOtros.Text)
        End If

        txtKGTotal.Text = KGGrano + KGFibra + KGConcentrado + KGOTros
        Format(CDbl(txtKGTotal.Text), "#,##0.00")
    End Sub

    Private Sub CalcularImporte()
        Dim ImpGrano As Double
        Dim ImpFibra As Double
        Dim ImpConcentrado As Double
        Dim ImpOTros As Double

        If txtImpGrano.Text = "" Then
            ImpGrano = 0
        Else
            ImpGrano = CDbl(txtImpGrano.Text)
        End If

        If txtImpFibra.Text = "" Then
            ImpFibra = 0
        Else
            ImpFibra = CDbl(txtImpFibra.Text)
        End If

        If txtKGConcentrado.Text = "" Then
            ImpConcentrado = 0
        Else
            ImpConcentrado = CDbl(txtKGConcentrado.Text)
        End If

        If txtKGOtros.Text = "" Then
            ImpOTros = 0
        Else
            ImpOTros = CDbl(txtKGOtros.Text)
        End If

        txtImpTotal.Text = ImpGrano + ImpFibra + ImpConcentrado + ImpOTros
        txtImpTotal.Text = Format(CDbl(txtImpTotal.Text), "$ #,##0.00")
    End Sub

    Private Sub txtKGGrano_Validated(sender As Object, e As EventArgs) Handles txtKGGrano.Validated
        If Not txtKGGrano.Text = "" Then
            If cbxRacion.Text = "" Then
                MsgBox("Error: No hay una racion seleccionada", vbInformation, "Servico de Alertas")
                cbxRacion.Text = ""
                cbxRacion.Select()
            Else
                If Not IsNumeric(txtKGGrano.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtKGGrano.Text = ""
                    txtKGGrano.Select()
                Else
                    CalcularTotal()
                    CalcularPorcentaje()

                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar

                    _Dt = _Ver.verRacion

                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("NombreRacion") = cbxRacion.Text Then
                            txtImpGrano.Text = CDbl(_Dr("CostoGrano")) * CDbl(txtKGGrano.Text)
                        End If
                    Next

                    txtImpGrano.Text = Format(CDbl(txtImpGrano.Text), "$ #,##0.00")
                    Format(CDbl(txtKGGrano.Text), "#,##0.00")
                    CalcularImporte()
                End If
            End If
        End If
    End Sub

    Private Sub txtKGFibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGFibra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtKGConcentrado.SelectionLength = Len(txtKGConcentrado.Text)
            txtKGConcentrado.Select()
        End If
    End Sub

    Private Sub txtKGFibra_Validated(sender As Object, e As EventArgs) Handles txtKGFibra.Validated
        If Not txtKGFibra.Text = "" Then
            If cbxRacion.Text = "" Then
                MsgBox("Error: No hay una racion seleccionada", vbInformation, "Servico de Alertas")
                cbxRacion.Text = ""
                cbxRacion.Select()
            Else
                If Not IsNumeric(txtKGFibra.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtKGFibra.Text = ""
                    txtKGFibra.Select()
                Else
                    CalcularTotal()
                    CalcularPorcentaje()

                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar

                    _Dt = _Ver.verRacion

                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("NombreRacion") = cbxRacion.Text Then
                            txtImpFibra.Text = CDbl(_Dr("CostoFibra")) * CDbl(txtKGFibra.Text)
                        End If
                    Next

                    txtImpFibra.Text = Format(CDbl(txtImpFibra.Text), "$ #,##0.00")
                    Format(CDbl(txtKGFibra.Text), "#,##0.00")
                    CalcularImporte()
                End If
            End If
        End If
    End Sub

    Private Sub txtKGConcentrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGConcentrado.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtKGOtros.SelectionLength = Len(txtKGOtros.Text)
            txtKGOtros.Select()
        End If
    End Sub

    Private Sub txtKGConcentrado_Validated(sender As Object, e As EventArgs) Handles txtKGConcentrado.Validated
        If Not txtKGConcentrado.Text = "" Then
            If cbxRacion.Text = "" Then
                MsgBox("Error: No hay una racion seleccionada", vbInformation, "Servico de Alertas")
                cbxRacion.Text = ""
                cbxRacion.Select()
            Else
                If Not IsNumeric(txtKGConcentrado.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtKGConcentrado.Text = ""
                    txtKGConcentrado.Select()
                Else
                    CalcularTotal()
                    CalcularPorcentaje()

                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar

                    _Dt = _Ver.verRacion

                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("NombreRacion") = cbxRacion.Text Then
                            txtImpConcentrado.Text = CDbl(_Dr("CostoConcentrado")) * CDbl(txtKGConcentrado.Text)
                        End If
                    Next

                    txtImpConcentrado.Text = Format(CDbl(txtImpConcentrado.Text), "$ #,##0.00")
                    Format(CDbl(txtKGConcentrado.Text), "#,##0.00")
                    CalcularImporte()
                End If
            End If
        End If
    End Sub

    Private Sub txtKGOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGOtros.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObservaciones.SelectionLength = Len(txtObservaciones.Text)
            txtObservaciones.Select()
        End If
    End Sub

    Private Sub txtKGOtros_Validated(sender As Object, e As EventArgs) Handles txtKGOtros.Validated
        If Not txtKGOtros.Text = "" Then
            If cbxRacion.Text = "" Then
                MsgBox("Error: No hay una racion seleccionada", vbInformation, "Servico de Alertas")
                cbxRacion.Text = ""
                cbxRacion.Select()
            Else
                If Not IsNumeric(txtKGOtros.Text) Then
                    MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                    txtKGOtros.Text = ""
                    txtKGOtros.Select()
                Else
                    CalcularTotal()
                    CalcularPorcentaje()

                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar

                    _Dt = _Ver.verRacion

                    For Each _Dr As DataRow In _Dt.Rows
                        If _Dr("NombreRacion") = cbxRacion.Text Then
                            txtImpOtros.Text = CDbl(_Dr("CostoOtros")) * CDbl(txtKGOtros.Text)
                        End If
                    Next

                    txtImpOtros.Text = Format(CDbl(txtImpOtros.Text), "$ #,##0.00")
                    Format(CDbl(txtKGOtros.Text), "#,##0.00")
                    CalcularImporte()
                End If
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtFecha.Text = "" Then
                MsgBox("Error: El Fecha es obligatorio... !", vbInformation, "Servico de Alertas")
                txtFecha.Select()
            Else
                If cbxCorral.Text = "" Then
                    MsgBox("Error: El campo Corral es obligatorio... !", vbInformation, "Servico de Alertas")
                    cbxCorral.Select()
                Else
                    If cbxRacion.Text = "" Then
                        MsgBox("Error: El campo Racion es obligatorio... !", vbInformation, "Servico de Alertas")
                        cbxRacion.Select()
                    Else
                        If txtKGGrano.Text = "" Then
                            MsgBox("Error: El Campo Grano/KG es obligatorio... !", vbInformation, "Servico de Alertas")
                            txtKGGrano.Select()
                        Else
                            If txtKGFibra.Text = "" Then
                                MsgBox("Error: El Campo Fibra/KG es obligatorio... !", vbInformation, "Servico de Alertas")
                                txtKGFibra.Select()
                            Else
                                If txtKGConcentrado.Text = "" Then
                                    MsgBox("Error: El Campo Concentrado/KG es obligatorio... !", vbInformation, "Servico de Alertas")
                                    txtKGConcentrado.Select()
                                Else
                                    If txtKGOtros.Text = "" Then
                                        MsgBox("Error: El Campo Otros/KG es obligatorio... !", vbInformation, "Servico de Alertas")
                                        txtKGOtros.Select()
                                    Else
                                        If rdbMañana.Checked = False And rdbTarde.Checked = False Then
                                            MsgBox("Error: No ha seleccionado el turno... !", vbInformation, "Servico de Alertas")
                                        Else

                                            resP = MessageBox.Show("Grabar Alta de Tropa ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                                            If resP = Windows.Forms.DialogResult.OK Then
                                                Dim Turno As String

                                                If rdbMañana.Checked = True Then
                                                    Turno = "Mañana"
                                                Else
                                                    Turno = "Tarde"
                                                End If

                                                If txtObservaciones.Text = "" Then
                                                    txtObservaciones.Text = "-"
                                                End If

                                                G.Grabar("Alimentacion", "NoImagen", "feedlot.insAlimentacion", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), CDbl(txtKGTotal.Text), _
                                                  Turno, txtObservaciones.Text, CInt(txtIdRacion.Text), CInt(txtIdCorral.Text))

                                                Dim _DtM As New DataTable
                                                Dim _VerM As New Mostrar
                                                Dim ulTid As Integer

                                                _DtM = _VerM.verMaxIdAlimentacion()

                                                Dim _Row As DataRow = _DtM.Rows(_DtM.Rows.Count - 1)
                                                If _Row("UltimoId").ToString = "" Then
                                                    ulTid = 0
                                                Else
                                                    ulTid = _Row("UltimoId")
                                                End If


                                                G.Grabar("detalle_alimentacion", "NoImagen", "feedlot.insDetalleAlimentacion", CDbl(txtKGGrano.Text), CDbl(txtKGConcentrado.Text), _
                                                    CDbl(txtKGFibra.Text), CDbl(txtKGOtros.Text), CDbl(txtImpGrano.Text), CDbl(txtImpConcentrado.Text), _
                                                    CDbl(txtImpFibra.Text), CDbl(txtImpOtros.Text), CDbl(txtImpTotal.Text), CDbl(txtPorcenGrano.Text), _
                                                    CDbl(txtPorcenConcentrado.Text), CDbl(txtPorcenFibra.Text), CDbl(txtPorcenOtros.Text), ulTid)

                                                lblMsg.Text = "Alimentacion dada de alta..."

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
            lblMsg.Text = "Error: Tropa No fue dado de alta..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub
End Class