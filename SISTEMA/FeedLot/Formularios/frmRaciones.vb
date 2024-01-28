Imports MySql.Data.MySqlClient

Public Class frmRaciones

    Private Sub Activar()
        gbxDatos.Enabled = True
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnSalir.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Activar()
        lblMsg.Text = "Ingrese datos..."
        txtNombre.Select()
    End Sub

    Private Sub Cancelar()
        gbxDatos.Enabled = False
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True
        txtNombre.Text = ""
        txtCostGrano.Text = ""
        txtCostConcentrado.Text = ""
        txtFibra.Text = ""
        txtGrano.Text = ""
        txtConcentrado.Text = ""
        txtCostOtros.Text = ""
        txtOtros.Text = ""
        txtCostFibra.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Cancelar()
        lblMsg.Text = "Operación cancelada por el usuario..."
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmRaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema FeedLot - Raciones"
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtGrano.SelectionLength = Len(txtGrano.Text)
            txtGrano.Select()
        End If
    End Sub

    Private Sub txtGrano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrano.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtGrano.Text = "" Then
                txtConcentrado.SelectionLength = Len(txtConcentrado.Text)
                txtConcentrado.Select()
                txtGrano.Text = "-"
                txtCostGrano.Text = "$ 0.00"
            Else
                txtCostGrano.SelectionLength = Len(txtCostGrano.Text)
                txtCostGrano.Select()
            End If
        End If
    End Sub

    Private Sub txtCostGrano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostGrano.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtCostGrano.Text = "" Then
                txtConcentrado.SelectionLength = Len(txtConcentrado.Text)
                txtConcentrado.Select()
                txtCostGrano.Text = "$ 0.00"
            ElseIf IsNumeric(txtCostGrano.Text) Then
                txtConcentrado.SelectionLength = Len(txtConcentrado.Text)
                txtConcentrado.Select()
                txtCostGrano.Text = Format(CDbl(txtCostGrano.Text), "$ #,##0.00")
            Else
                MsgBox("Error: Sólo se admiten valores numéricos", vbInformation, "Servico de Alertas")
                txtCostGrano.Text = ""
                txtCostGrano.Select()
            End If
        End If
    End Sub

    Private Sub txtConcentrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcentrado.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtConcentrado.Text = "" Then
                txtFibra.SelectionLength = Len(txtFibra.Text)
                txtFibra.Select()
                txtConcentrado.Text = "-"
                txtCostConcentrado.Text = "$ 0.00"
            Else
                txtCostConcentrado.SelectionLength = Len(txtCostConcentrado.Text)
                txtCostConcentrado.Select()
            End If
        End If
    End Sub

    Private Sub txtFibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFibra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtFibra.Text = "" Then
                txtOtros.SelectionLength = Len(txtOtros.Text)
                txtOtros.Select()
                txtFibra.Text = "-"
                txtCostFibra.Text = "$ 0.00"
            Else
                txtCostFibra.SelectionLength = Len(txtCostFibra.Text)
                txtCostFibra.Select()
            End If
        End If
    End Sub

    Private Sub txtCostConcentrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostConcentrado.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtCostConcentrado.Text = "" Then
                txtFibra.SelectionLength = Len(txtFibra.Text)
                txtFibra.Select()
                txtCostConcentrado.Text = "$ 0.00"
            ElseIf IsNumeric(txtCostConcentrado.Text) Then
                txtFibra.SelectionLength = Len(txtFibra.Text)
                txtFibra.Select()
                txtCostConcentrado.Text = Format(CDbl(txtCostConcentrado.Text), "$ #,##0.00")
            Else
                MsgBox("Error: Sólo se admiten valores numéricos", vbInformation, "Servico de Alertas")
                txtCostConcentrado.Text = ""
                txtCostConcentrado.Select()
            End If
        End If
    End Sub

    Private Sub txtCostFibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostFibra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtCostFibra.Text = "" Then
                txtOtros.SelectionLength = Len(txtOtros.Text)
                txtOtros.Select()
                txtCostFibra.Text = "$ 0.00"
            ElseIf IsNumeric(txtCostFibra.Text) Then
                txtOtros.SelectionLength = Len(txtOtros.Text)
                txtOtros.Select()
                txtCostFibra.Text = Format(CDbl(txtCostFibra.Text), "$ #,##0.00")
            Else
                MsgBox("Error: Sólo se admiten valores numéricos", vbInformation, "Servico de Alertas")
                txtCostFibra.Text = ""
                txtCostFibra.Select()
            End If
        End If
    End Sub

    Private Sub txtOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtros.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtOtros.Text = "" Then
                btnGuardar.Select()
                txtOtros.Text = "-"
                txtCostOtros.Text = "$ 0.00"
            Else
                txtCostOtros.SelectionLength = Len(txtCostOtros.Text)
                txtCostOtros.Select()
            End If
        End If
    End Sub

    Private Sub txtCostOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostOtros.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtCostOtros.Text = "" Then
                btnGuardar.Select()
                txtCostOtros.Text = "$ 0.00"
            ElseIf IsNumeric(txtCostOtros.Text) Then
                btnGuardar.Select()
                txtCostOtros.Text = Format(CDbl(txtCostOtros.Text), "$ #,##0.00")
            Else
                MsgBox("Error: Sólo se admiten valores numéricos", vbInformation, "Servico de Alertas")
                txtCostOtros.Text = ""
                txtCostOtros.Select()
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtNombre.Text = "" Then
                MsgBox("Error: Nombre Racion es un campo obligatorio.", vbInformation, "Servico de Alertas")
                txtNombre.Select()
            Else
                If txtGrano.Text = "" And txtFibra.Text = "" And txtConcentrado.Text = "" And txtOtros.Text = "" Then
                    MsgBox("Error: Al menos uno de los campos (Grano, Concentrado, Fibra y Oros) debe un valor.", vbInformation, "Servico de Alertas")
                Else
                    If Not IsNumeric(txtCostGrano.Text) Then
                        MsgBox("Error: El campo Costo Grano debe contener un valor numerico.", vbInformation, "Servico de Alertas")
                    Else
                        If Not IsNumeric(txtCostConcentrado.Text) Then
                            MsgBox("Error: El campo Costo Concentrado debe contener un valor numerico.", vbInformation, "Servico de Alertas")
                        Else
                            If Not IsNumeric(txtCostFibra.Text) Then
                                MsgBox("Error: El campo Costo Fibra debe contener un valor numerico.", vbInformation, "Servico de Alertas")
                            Else
                                If Not IsNumeric(txtCostOtros.Text) Then
                                    MsgBox("Error: El campo Costo Otros debe contener un valor numerico.", vbInformation, "Servico de Alertas")
                                Else
                                    resP = MessageBox.Show("Grabar Ración ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                                    If resP = Windows.Forms.DialogResult.OK Then

                                        G.Grabar("Raciones", "NoImagen", "feedlot.insRacion", txtNombre.Text, txtGrano.Text, txtConcentrado.Text, txtFibra.Text, txtOtros.Text, _
                                                 CDbl(txtCostGrano.Text), CDbl(txtCostConcentrado.Text), CDbl(txtCostFibra.Text), CDbl(txtCostOtros.Text))
                                        lblMsg.Text = "Racion guardada..."
                                        Cancelar()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Racion no guardada..."
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

End Class