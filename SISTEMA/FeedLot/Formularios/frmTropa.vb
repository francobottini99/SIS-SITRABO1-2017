Imports MySql.Data.MySqlClient

Public Class frmTropa

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
        cbxProd.Text = ""
        cbxCampo.Text = ""
        cbxProv.Text = ""
        txtNombre.Text = ""
        txtProc.Text = ""
        txtFec.Text = ""
        txtCab.Text = ""
        txtKgCab.Text = ""
        txtKgTropa.Text = ""
        txtIdCm.Text = ""
        txtIdPd.Text = ""
        txtIdPr.Text = ""
        dgvDatos.Columns.Clear()
        dgvDatos.Rows.Clear()
        txtCantidad.Text = ""
        cbxCategorias.Text = ""
        cbxCorral.Text = ""
        txtIdCatg.Text = ""
        txtObservaciones.Text = ""
        txtIdCorral.Text = ""
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtProc.SelectionLength = Len(txtProc.Text)
            txtProc.Select()
        End If
    End Sub

    Private Sub ttxtProc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFec.SelectionLength = Len(txtFec.Text)
            txtFec.Select()
        End If
    End Sub

    Private Sub txtFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCab.SelectionLength = Len(txtCab.Text)
            txtCab.Select()
        End If
    End Sub

    Private Sub txtKgCab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKgCab.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If Not IsNumeric(txtKgCab.Text) Then
                MsgBox("Error: Sólo se admiten valores numéricos", vbInformation, "Servico de Alertas")
                txtKgCab.Text = ""
                txtKgCab.Select()
            Else
                txtKgCab.Text = Format(CDbl(txtKgCab.Text), "#,##0.00")
                If txtCab.Text <> "" Then
                    txtKgTropa.Text = Format(CInt(CInt(txtCab.Text) * CDbl(txtKgCab.Text)), "#,##0")
                End If
                txtObservaciones.SelectionLength = Len(txtObservaciones.Text)
                txtObservaciones.Select()
            End If
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
                If txtKgCab.Text <> "" Then
                    txtKgTropa.Text = Format(CInt(CInt(txtCab.Text) * CDbl(txtKgCab.Text)), "#,##0")
                End If
                txtKgCab.SelectionLength = Len(txtKgCab.Text)
                txtKgCab.Select()
            End If
        End If
    End Sub

    Private Sub txtMail_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        cbxProd.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If cbxProd.Text = "" Then
                MsgBox("Error: El campo Corral de Ingreso es obligatorio... !", vbInformation, "Servico de Alertas")
                cbxCorral.Select()
            Else
                If cbxProd.Text = "" Then
                    MsgBox("Error: El campo Productor es obligatorio... !", vbInformation, "Servico de Alertas")
                    cbxProd.Select()
                Else
                    If cbxCampo.Text = "" Then
                        MsgBox("Error: El dato Campo es obligatorio... !", vbInformation, "Servico de Alertas")
                        cbxCampo.Select()
                    Else
                        If cbxProv.Text = "" Then
                            MsgBox("Error: El Campo Proveedor es obligatorio... !", vbInformation, "Servico de Alertas")
                            cbxProv.Select()
                        Else
                            If txtNombre.Text = "" Then
                                MsgBox("Error: El Campo Nombre Tropa es obligatorio... !", vbInformation, "Servico de Alertas")
                                txtNombre.Select()
                            Else
                                If txtProc.Text = "" Then
                                    MsgBox("Error: El Campo Procedencia es obligatorio... !", vbInformation, "Servico de Alertas")
                                    txtProc.Select()
                                Else
                                    If txtFec.Text = "" Then
                                        MsgBox("Error: El Campo Fecha Ingreso es obligatorio... !", vbInformation, "Servico de Alertas")
                                        txtFec.Select()
                                    Else
                                        If txtCab.Text = "" Then
                                            MsgBox("Error: El Campo Cabezas es obligatorio... !", vbInformation, "Servico de Alertas")
                                            txtCab.Select()
                                        Else
                                            If txtKgCab.Text = "" Then
                                                MsgBox("Error: El Campo Kg/Cabeza es obligatorio... !", vbInformation, "Servico de Alertas")
                                                txtKgCab.Select()
                                            Else
                                                Dim Cant As Integer = CInt(txtCab.Text)

                                                For i As Integer = 0 To dgvDatos.Rows.Count - 1
                                                    dgvDatos.CurrentCell = dgvDatos.Rows(i).Cells(1)
                                                    Cant = Cant - CInt(dgvDatos.Item("Cantidad", dgvDatos.CurrentRow.Index).Value())
                                                Next

                                                If Cant > 0 Then
                                                    MsgBox("Error: Quedan cabezan sin categoria... !", vbInformation, "Servico de Alertas")
                                                    cbxCategorias.Select()
                                                Else
                                                    If cbxCorral.Text = "" Then
                                                        MsgBox("Error: El Campo Corral de ingreso es obligatorio... !", vbInformation, "Servico de Alertas")
                                                        txtKgCab.Select()
                                                    Else
                                                        resP = MessageBox.Show("Grabar Alta de Tropa ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                                                        If resP = Windows.Forms.DialogResult.OK Then

                                                            G.Grabar("Tropa", "NoImagen", "feedlot.insTropa", txtNombre.Text, txtProc.Text, _
                                                                Format(CDate(txtFec.Text), "yyyy/MM/dd"), CInt(txtCab.Text), CDbl(txtKgCab.Text), _
                                                                 CInt(txtKgTropa.Text), CInt(txtIdPd.Text), CInt(txtIdCm.Text), CInt(txtIdPr.Text))

                                                            Dim _DtM As New DataTable
                                                            Dim _VerM As New Mostrar
                                                            Dim ulTid As Integer

                                                            _DtM = _VerM.verMaxIdTropa()

                                                            Dim _Row As DataRow = _DtM.Rows(_DtM.Rows.Count - 1)
                                                            If _Row("UltimoId").ToString = "" Then
                                                                ulTid = 0
                                                            Else
                                                                ulTid = _Row("UltimoId")
                                                            End If


                                                            G.Grabar("Stock", "NoImagen", "feedlot.modStock", Format(CDate(txtFec.Text), "yyyy/MM/dd"), CInt(txtCab.Text), _
                                                                0, 0, ulTid)

                                                            G.Grabar("Detalle_Corrales", "NoImagen", "feedlot.insDetalleCorral", CDbl(txtCab.Text), "-", _
                                                                CInt(txtIdCorral.Text), ulTid)

                                                            For i As Integer = 0 To dgvDatos.Rows.Count - 1
                                                                dgvDatos.CurrentCell = dgvDatos.Rows(i).Cells(0)

                                                                If txtObservaciones.Text = "" Then
                                                                    txtObservaciones.Text = "-"
                                                                End If

                                                                G.Grabar("Detalle_Tropa", "NoImagen", "feedlot.insDetalleTropa", CDbl(dgvDatos.Item("Cantidad", dgvDatos.CurrentRow.Index).Value()), txtObservaciones.Text, _
                                                                    ulTid, CInt(dgvDatos.Item("ID", dgvDatos.CurrentRow.Index).Value()))
                                                            Next

                                                            lblMsg.Text = "Tropa dada de alta..."

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

    Private Sub txtKgTropa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKgTropa.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub frmTropa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        Me.Text = "Sistema FeedLot - Alta de Tropas"

        _Dt = _Ver.verProductor
        For Each _Dr As DataRow In _Dt.Rows
            cbxProd.Items.Add(_Dr("RazonSocial"))
        Next

        _Dt = _Ver.verCampos
        For Each _Dr As DataRow In _Dt.Rows
            cbxCampo.Items.Add(_Dr("NombreCampo"))
        Next

        _Dt = _Ver.verProveedor
        For Each _Dr As DataRow In _Dt.Rows
            cbxProv.Items.Add(_Dr("RazonSocial"))
        Next

        _Dt = _Ver.verCategoria
        For Each _Dr As DataRow In _Dt.Rows
            cbxCategorias.Items.Add(_Dr("Categoria"))
        Next
    End Sub

    Private Sub cbxProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxProd.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCampo.SelectionLength = Len(cbxCampo.Text)
            cbxCampo.Select()
        End If
    End Sub

    Private Sub cbxProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProd.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verProductor
        txtIdPr.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("RazonSocial") = cbxProd.Text Then
                txtIdPd.Text = _Dr("idProductor")
            End If
        Next
    End Sub

    Private Sub cbxCampo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCampo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxProv.SelectionLength = Len(cbxProv.Text)
            cbxProv.Select()
        End If
    End Sub

    Private Sub cbxCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCampo.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCampos
        txtIdPr.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreCampo") = cbxCampo.Text Then
                txtIdCm.Text = _Dr("idCampo")
            End If
        Next

        _Dt = _Ver.verCorrales
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("CAMPO_idCampo") = txtIdCm.Text Then
                cbxCorral.Items.Add(_Dr("NombreCorral"))
            End If
        Next

    End Sub

    Private Sub cbxProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxProv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCorral.SelectionLength = Len(cbxCorral.Text)
            cbxCorral.Select()
        End If
    End Sub

    Private Sub cbxProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProv.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verProveedor
        txtIdPr.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("RazonSocial") = cbxProv.Text Then
                txtIdPr.Text = _Dr("idProveedor")
            End If
        Next
    End Sub

    Private Sub txtFec_Validated(sender As Object, e As EventArgs) Handles txtFec.Validated
        If Not txtFec.Text = "" Then
            If Not IsDate(txtFec.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbInformation, "Servico de Alertas")
                txtFec.Text = ""
                txtFec.Select()
            Else
                txtFec.Text = Format(CDate(txtFec.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub cbxCorral_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCorral.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNombre.SelectionLength = Len(txtNombre.Text)
            txtNombre.Select()
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

    Private Sub cbxCategorias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCategorias.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
        End If
    End Sub

    Private Sub cbxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategorias.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCategoria
        txtIdCatg.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("Categoria") = cbxCategorias.Text Then
                txtIdCatg.Text = _Dr("idCategorias")
            End If
        Next
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCategorias.SelectionLength = Len(cbxCategorias.Text)
            cbxCategorias.Select()
        End If
    End Sub

    Private Sub txtCantidad_Validated(sender As Object, e As EventArgs) Handles txtCantidad.Validated
        If Not txtCantidad.Text = "" Then
            If Not cbxCategorias.Text = "" Then
                If CInt(txtCantidad.Text) <= CInt(txtCab.Text) Then
                    If Not IsNumeric(txtCantidad.Text) Then
                        MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                        txtCantidad.Text = ""
                        txtCantidad.Select()
                    Else
                        Dim Cant As Integer = CInt(txtCab.Text)
                        Dim btn As New DataGridViewButtonColumn()

                        Cant = Cant - CInt(txtCantidad.Text)

                        dgvDatos.ColumnCount = 3
                        dgvDatos.Columns(0).Name = "Categoria"
                        dgvDatos.Columns(1).Name = "Cantidad"
                        dgvDatos.Columns(2).Name = "ID"
                        dgvDatos.Columns(2).Visible = False

                        dgvDatos.Columns.Add(btn)
                        btn.Text = "X"
                        btn.UseColumnTextForButtonValue = True

                        If dgvDatos.Rows.Count > 0 Then
                            For i As Integer = 0 To dgvDatos.Rows.Count - 1
                                dgvDatos.CurrentCell = dgvDatos.Rows(i).Cells(0)
                                If dgvDatos.Item("Categoria", dgvDatos.CurrentRow.Index).Value() = cbxCategorias.Text Then
                                    dgvDatos.Rows.Remove(Me.dgvDatos.CurrentRow)
                                End If
                            Next
                        End If

                        If dgvDatos.Rows.Count > 0 Then
                            For i As Integer = 0 To dgvDatos.Rows.Count - 1
                                dgvDatos.CurrentCell = dgvDatos.Rows(i).Cells(1)
                                Cant = Cant - CInt(dgvDatos.Item("Cantidad", dgvDatos.CurrentRow.Index).Value())
                            Next
                        End If

                        If Cant >= 0 Then
                            dgvDatos.Rows.Add(cbxCategorias.Text, txtCantidad.Text, txtIdCatg.Text)
                            txtCantidad.Text = ""
                        Else
                            MsgBox("Error: No hay ese numero de cabezas", vbInformation, "Servico de Alertas")
                            txtCantidad.Text = ""
                            txtCantidad.Select()
                        End If
                    End If
                Else
                    MsgBox("Error: No hay ese numero de cabezas", vbInformation, "Servico de Alertas")
                    txtCantidad.Text = ""
                    txtCantidad.Select()
                End If
            Else
                MsgBox("Error: No hay una categoria seleccionada", vbInformation, "Servico de Alertas")
                cbxCategorias.Text = ""
                cbxCategorias.Select()
            End If
        End If
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        If Me.dgvDatos.CurrentCell.GetType.ToString Like "*Button*" Then
            dgvDatos.Rows.Remove(dgvDatos.CurrentRow)
            dgvDatos.Refresh()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCategorias.SelectionLength = Len(cbxCategorias.Text)
            cbxCategorias.Select()
        End If
    End Sub
End Class