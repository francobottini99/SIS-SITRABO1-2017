Imports MySql.Data.MySqlClient

Public Class frmMovimiento

    Private Sub frmMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        Me.Text = "Sistema FeedLot - Movimientos Internos"

        _Dt = _Ver.verCorrales
        For Each _Dr As DataRow In _Dt.Rows
            cbxCorralEgreso.Items.Add(_Dr("NombreCorral"))
        Next

        _Dt = _Ver.verCorrales
        For Each _Dr As DataRow In _Dt.Rows
            cbxCorralIng.Items.Add(_Dr("NombreCorral"))
        Next
    End Sub

    Private Sub Cancelar()
        gbxDatos.Enabled = False
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True
        txtFecha.Text = ""
        cbxCorralIng.Text = ""
        cbxCorralEgreso.Text = ""
        txtCabezas.Text = ""
        txtIdCorralEegreso.Text = ""
        txtIdCorralIngr.Text = ""
        txtDetalle.Text = ""
        dgvDetCorral.DataSource = Nothing
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

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCorralEgreso.SelectionLength = Len(cbxCorralEgreso.Text)
            cbxCorralEgreso.Select()
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

    Private Sub cbxCorralIng_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCorralIng.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCabezas.SelectionLength = Len(txtCabezas.Text)
            txtCabezas.Select()
        End If
    End Sub

    Private Sub cbxCorralIng_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCorralIng.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCorrales
        txtIdCorralIngr.Text = ""
        lblCabTIn.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreCorral") = cbxCorralIng.Text Then
                txtIdCorralIngr.Text = _Dr("idCorrales")
                lblCabTIn.Text = _Dr("CabezasTotales")
            End If
        Next
    End Sub

    Private Sub cbxCorralEgreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCorralEgreso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCorralIng.SelectionLength = Len(cbxCorralIng.Text)
            cbxCorralIng.Select()
        End If
    End Sub

    Private Sub cbxCorralEgreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCorralEgreso.SelectedIndexChanged
        Dim _Dt, _Dt1 As New DataTable
        Dim _Ver, _Ver1 As New Mostrar
        Dim estiloEnc As New DataGridViewCellStyle()
        Dim textEnc As String = ""
        Dim X As Integer

        _Dt = _Ver.verCorrales
        txtIdCorralEegreso.Text = ""
        lblCabTEg.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreCorral") = cbxCorralEgreso.Text Then
                txtIdCorralEegreso.Text = _Dr("idCorrales")
                lblCabTEg.Text = _Dr("CabezasTotales")
                _Dt1 = _Ver1.consDetalleCorral(CInt(txtIdCorralEegreso.Text))
                dgvDetCorral.DataSource = _Dt1
                dgvDetCorral.Columns.Item("idCorrales").Visible = False
                dgvDetCorral.Columns.Item("NombreCorral").Visible = False
                dgvDetCorral.Columns.Item("Superficie").Visible = False
                dgvDetCorral.Columns.Item("CabezasTotales").Visible = False
                dgvDetCorral.Columns.Item("idTropa").Visible = False
                dgvDetCorral.Columns.Item("OrigenProcedencia").Visible = False
                dgvDetCorral.Columns.Item("idDetTropa").Visible = False

                estiloEnc.Font = New Font(dgvDetCorral.Font, FontStyle.Bold)
                dgvDetCorral.ColumnHeadersDefaultCellStyle = estiloEnc

                For X = 0 To 12
                    If X = 0 Or X = 2 Or X = 4 Or X = 9 Then
                        dgvDetCorral.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    ElseIf X = 2 Or X = 3 Or X = 8 Or X = 11 Or X = 12 Then
                        dgvDetCorral.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvDetCorral.Columns(X).DefaultCellStyle.Format = "#,##0.00"
                    ElseIf X = 7 Then
                        dgvDetCorral.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Else
                        dgvDetCorral.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If

                    Select Case X
                        Case 0
                            textEnc = "ID Corral"
                            dgvDetCorral.Columns(0).Width = 20
                        Case 1
                            textEnc = "Nombre Corr"
                            dgvDetCorral.Columns(1).Width = 80
                        Case 2
                            textEnc = "Sup M2"
                            dgvDetCorral.Columns(2).Width = 50
                        Case 3
                            textEnc = "Total Cab"
                            dgvDetCorral.Columns(3).Width = 70
                        Case 4
                            textEnc = "ID Tropa"
                            dgvDetCorral.Columns(4).Width = 50
                        Case 5
                            textEnc = "Nombre Tropa"
                            dgvDetCorral.Columns(5).Width = 100
                        Case 6
                            textEnc = "Procedencia"
                            dgvDetCorral.Columns(6).Width = 100
                        Case 7
                            textEnc = "Fec Ingreso"
                            dgvDetCorral.Columns(7).Width = 70
                        Case 8
                            textEnc = "Cab Tropa"
                            dgvDetCorral.Columns(8).Width = 70
                        Case 9
                            textEnc = "ID Det Tropa"
                            dgvDetCorral.Columns(9).Width = 50
                        Case 10
                            textEnc = "Categoria"
                            dgvDetCorral.Columns(10).Width = 80
                        Case 11
                            textEnc = "Cab Categoria"
                            dgvDetCorral.Columns(11).Width = 70
                        Case 12
                            textEnc = "Cab Tropa Corral"
                            dgvDetCorral.Columns(11).Width = 90
                    End Select
                    dgvDetCorral.Columns(X).HeaderText = textEnc
                Next X
            End If
        Next
    End Sub

    Private Sub cbxCorralEgreso_Validated(sender As Object, e As EventArgs) Handles cbxCorralEgreso.Validated
        If Not cbxCorralEgreso.Text = "" Then
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            _Dt = _Ver.verCorrales

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("NombreCorral") = cbxCorralEgreso.Text Then
                    cbxCorralIng.Items.Remove(_Dr("NombreCorral"))
                End If
            Next
        End If
    End Sub

    Private Sub txtCabezas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCabezas.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDetalle.SelectionLength = Len(txtDetalle.Text)
            txtDetalle.Select()
        End If
    End Sub

    Private Sub txtCabezas_Validated(sender As Object, e As EventArgs) Handles txtCabezas.Validated
        If Not txtCabezas.Text = "" Then
            If Not IsNumeric(txtCabezas.Text) Then
                MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                txtCabezas.Text = ""
                txtCabezas.Select()
            Else
                If CDbl(txtCabDisp.Text) < CDbl(txtCabezas.Text) Then
                    MsgBox("Error: Cantidad indicada supera a la disponible en esa categoría para esa tropa !", vbInformation, "Servico de Alertas")
                    txtCabezas.Text = ""
                    txtCabezas.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txtDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDetalle.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
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
                If cbxCorralIng.Text = "" Then
                    MsgBox("Error: El campo Corral de Ingreso es obligatorio... !", vbInformation, "Servico de Alertas")
                    cbxCorralIng.Select()
                Else
                    If cbxCorralEgreso.Text = "" Then
                        MsgBox("Error: El campo Corral de Egreso es obligatorio... !", vbInformation, "Servico de Alertas")
                        cbxCorralEgreso.Select()
                    Else
                        If txtCabezas.Text = "" Then
                            MsgBox("Error: El Campo Cabezas es obligatorio... !", vbInformation, "Servico de Alertas")
                            txtCabezas.Select()
                        Else
                            If txtDetalle.Text = "" Then
                                txtDetalle.Text = "-"
                            End If
                            resP = MessageBox.Show("Grabar Movimiento de Tropa ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            If resP = Windows.Forms.DialogResult.OK Then
                                G.Grabar("Movimientos", "NoImagen", "feedlot.insMovimiento", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), "Ingreso", _
                                    txtDetalle.Text, CInt(txtCabezas.Text), CInt(txtIdCorralIngr.Text), CInt(lblIDtropa.Text))

                                G.Grabar("Movimientos", "NoImagen", "feedlot.insMovimiento", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), "Egreso", _
                                    txtDetalle.Text, CInt(txtCabezas.Text), CInt(txtIdCorralEegreso.Text), CInt(lblIDtropa.Text))

                                Dim Cab As Integer

                                'GRABO EGRESOS EN CORRAL Y DETALLE CORRAL
                                Cab = CInt(txtCabDisp.Text) - CInt(txtCabezas.Text)
                                G.Grabar("Movimientos", "NoImagen", "feedlot.modDetCorral", CInt(txtIdCorralEegreso.Text), CInt(lblIDtropa.Text), _
                                    Cab)

                                Cab = CInt(lblCabTEg.Text) - CInt(txtCabezas.Text)
                                G.Grabar("Movimientos", "NoImagen", "feedlot.modCorral", CInt(txtIdCorralEegreso.Text), Cab)

                                'GRABO INGRESOS EN CORRAL Y DETALLE CORRAL

                                Dim _Dt As New DataTable
                                Dim _Ver As New Mostrar

                                _Dt = _Ver.verDtCorrPorTropa(CInt(txtIdCorralIngr.Text), CInt(lblIDtropa.Text))

                                If _Dt Is Nothing Then
                                    G.Grabar("Detalle_Corrales", "NoImagen", "feedlot.insDetalleCorral", CDbl(txtCabezas.Text), txtDetalle.Text, _
                                        CInt(txtIdCorralIngr.Text), CInt(lblIDtropa.Text))
                                Else
                                    Cab = CInt(txtCabDisp.Text) + CInt(txtCabezas.Text)
                                    G.Grabar("Movimientos", "NoImagen", "feedlot.modDetCorral", CInt(txtIdCorralIngr.Text), CInt(lblIDtropa.Text), _
                                        Cab)

                                    Cab = CInt(lblCabTIn.Text) + CInt(txtCabezas.Text)
                                    G.Grabar("Movimientos", "NoImagen", "feedlot.modCorral", CInt(txtIdCorralEegreso.Text), Cab)
                                End If
                                lblMsg.Text = "Movimiento guardado exitosamente..."

                                Cancelar()
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

    Private Sub dgvDetCorral_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetCorral.CellContentClick

    End Sub

    Private Sub dgvDetCorral_DoubleClick(sender As Object, e As EventArgs) Handles dgvDetCorral.DoubleClick
        If dgvDetCorral.DataSource IsNot Nothing Then
            lblSeleccion.Text = "Tropa = " & dgvDetCorral.SelectedCells.Item(5).Value & " / Categoria = " & dgvDetCorral.SelectedCells.Item(10).Value & " / Cabezas =" & dgvDetCorral.SelectedCells.Item(11).Value
            txtCabDisp.Text = dgvDetCorral.SelectedCells.Item(11).Value
            lblIDtropa.Text = dgvDetCorral.SelectedCells.Item(4).Value
            cbxCorralIng.Select()
        End If
    End Sub
End Class