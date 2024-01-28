Imports MySql.Data.MySqlClient

Public Class frmSanidad

    Private Sub frmSanidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        Me.Text = "Sistema FeedLot - Alta Sanidad"

        _Dt = _Ver.verTropa()
        For Each _Dr As DataRow In _Dt.Rows
            cbxTropa.Items.Add(_Dr("NombreTropa"))
        Next

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        cbxTropa.Select()
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
        'txtId.Text = ""
        cbxTropa.Text = ""
        txtFec.Text = ""
        txtTrat.Text = ""
        txtImporte.Text = ""
        txtObserv.Text = ""
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If cbxTropa.Text = "" Then
                MsgBox("Error: Nombre de Tropa es un campo obligatorio.", vbInformation, "Servico de Alertas")
                cbxTropa.Select()
            Else
                If txtFec.Text = "" Then
                    MsgBox("Error: Fecha es un campo obligatorio.", vbInformation, "Servico de Alertas")
                    txtFec.Select()
                Else
                    If txtTrat.Text = "" Then
                        MsgBox("Error: Tratamiento es un campo obligatorio.", vbInformation, "Servico de Alertas")
                        txtTrat.Select()
                    Else
                        If txtImporte.Text = "" Then
                            txtImporte.Text = 0
                        End If
                        If txtObserv.Text = "" Then
                            txtObserv.Text = "-"
                        End If
                        resP = MessageBox.Show("Grabar Alta de Sanidad ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If resP = Windows.Forms.DialogResult.OK Then

                            G.Grabar("Sanidad", "NoImagen", "feedlot.insSanidad", Format(CDate(txtFec.Text), "yyyy/MM/dd"), txtTrat.Text, CDbl(txtImporte.Text), _
                                     txtObserv.Text, CInt(lblIdTr.Text))
                            lblMsg.Text = "Sanidad cargada exitosamente..."
                            Cancelar()
                        End If
                    End If
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Sanidad No fue dada de alta..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try

    End Sub

    Private Sub cbxTropa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTropa.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verTropa
        lblIdTr.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreTropa") = cbxTropa.Text Then
                lblIdTr.Text = _Dr("idTropa")
            End If
        Next
    End Sub

    Private Sub cbxTropa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTropa.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFec.SelectionLength = Len(txtFec.Text)
            txtFec.Select()
        End If
    End Sub

    Private Sub txtFec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtTrat.SelectionLength = Len(txtTrat.Text)
            txtTrat.Select()
        End If
    End Sub

    Private Sub txtTrat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTrat.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtImporte.SelectionLength = Len(txtImporte.Text)
            txtImporte.Select()
        End If
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObserv.SelectionLength = Len(txtObserv.Text)
            txtObserv.Select()
        End If
    End Sub

    Private Sub txtObserv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObserv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub txtFec_Validated(sender As Object, e As EventArgs) Handles txtFec.Validated
        If Not txtFec.Text = "" Then
            If IsDate(txtFec.Text) Then
                txtFec.Text = Format(CDate(txtFec.Text), "dd/MM/yyyy")
            Else
                MsgBox("Error: La fecha " & txtFec.Text & " no es valida", vbInformation, "Servico de Alertas")
                txtFec.Text = ""
                txtFec.Select()
            End If
        End If
    End Sub

    Private Sub txtImporte_Validated(sender As Object, e As EventArgs) Handles txtImporte.Validated
        If Not txtImporte.Text = "" Then
            If Not IsNumeric(txtImporte.Text) Then
                MsgBox("Error: Este campo solo admite valores numericos", vbInformation, "Servico de Alertas")
                txtImporte.Text = ""
                txtImporte.Select()
            Else
                txtImporte.Text = Format(CDbl(txtImporte.Text), "$ #,##0.00")
            End If
        End If
    End Sub
End Class