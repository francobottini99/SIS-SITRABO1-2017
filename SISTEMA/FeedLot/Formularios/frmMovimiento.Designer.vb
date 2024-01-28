<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimiento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimiento))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblCabTIn = New System.Windows.Forms.Label()
        Me.lblCabTEg = New System.Windows.Forms.Label()
        Me.lblIDtropa = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCabDisp = New System.Windows.Forms.Label()
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDetCorral = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.cbxCorralEgreso = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCabezas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtIdCorralEegreso = New System.Windows.Forms.Label()
        Me.txtIdCorralIngr = New System.Windows.Forms.Label()
        Me.cbxCorralIng = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.gbxDatos.SuspendLayout()
        CType(Me.dgvDetCorral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(689, 23)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "MOVIMIENTOS INTERNOS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.lblCabTIn)
        Me.gbxDatos.Controls.Add(Me.lblCabTEg)
        Me.gbxDatos.Controls.Add(Me.lblIDtropa)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.txtCabDisp)
        Me.gbxDatos.Controls.Add(Me.lblSeleccion)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.dgvDetCorral)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.txtDetalle)
        Me.gbxDatos.Controls.Add(Me.cbxCorralEgreso)
        Me.gbxDatos.Controls.Add(Me.Label7)
        Me.gbxDatos.Controls.Add(Me.Label12)
        Me.gbxDatos.Controls.Add(Me.txtCabezas)
        Me.gbxDatos.Controls.Add(Me.Label10)
        Me.gbxDatos.Controls.Add(Me.txtFecha)
        Me.gbxDatos.Controls.Add(Me.txtIdCorralEegreso)
        Me.gbxDatos.Controls.Add(Me.txtIdCorralIngr)
        Me.gbxDatos.Controls.Add(Me.cbxCorralIng)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(12, 35)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(689, 369)
        Me.gbxDatos.TabIndex = 28
        Me.gbxDatos.TabStop = False
        '
        'lblCabTIn
        '
        Me.lblCabTIn.BackColor = System.Drawing.Color.Teal
        Me.lblCabTIn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCabTIn.Location = New System.Drawing.Point(423, 244)
        Me.lblCabTIn.Name = "lblCabTIn"
        Me.lblCabTIn.Size = New System.Drawing.Size(105, 20)
        Me.lblCabTIn.TabIndex = 84
        Me.lblCabTIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCabTIn.Visible = False
        '
        'lblCabTEg
        '
        Me.lblCabTEg.BackColor = System.Drawing.Color.Teal
        Me.lblCabTEg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCabTEg.Location = New System.Drawing.Point(423, 52)
        Me.lblCabTEg.Name = "lblCabTEg"
        Me.lblCabTEg.Size = New System.Drawing.Size(105, 20)
        Me.lblCabTEg.TabIndex = 83
        Me.lblCabTEg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCabTEg.Visible = False
        '
        'lblIDtropa
        '
        Me.lblIDtropa.BackColor = System.Drawing.Color.Teal
        Me.lblIDtropa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIDtropa.Location = New System.Drawing.Point(97, 18)
        Me.lblIDtropa.Name = "lblIDtropa"
        Me.lblIDtropa.Size = New System.Drawing.Size(105, 20)
        Me.lblIDtropa.TabIndex = 82
        Me.lblIDtropa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblIDtropa.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Observaciones"
        '
        'txtCabDisp
        '
        Me.txtCabDisp.BackColor = System.Drawing.Color.Teal
        Me.txtCabDisp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCabDisp.Location = New System.Drawing.Point(204, 272)
        Me.txtCabDisp.Name = "txtCabDisp"
        Me.txtCabDisp.Size = New System.Drawing.Size(105, 20)
        Me.txtCabDisp.TabIndex = 80
        Me.txtCabDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCabDisp.Visible = False
        '
        'lblSeleccion
        '
        Me.lblSeleccion.BackColor = System.Drawing.Color.Teal
        Me.lblSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccion.ForeColor = System.Drawing.Color.White
        Me.lblSeleccion.Location = New System.Drawing.Point(97, 222)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(586, 20)
        Me.lblSeleccion.TabIndex = 79
        Me.lblSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Selección"
        '
        'dgvDetCorral
        '
        Me.dgvDetCorral.AllowUserToAddRows = False
        Me.dgvDetCorral.AllowUserToDeleteRows = False
        Me.dgvDetCorral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetCorral.Location = New System.Drawing.Point(97, 80)
        Me.dgvDetCorral.Name = "dgvDetCorral"
        Me.dgvDetCorral.ReadOnly = True
        Me.dgvDetCorral.Size = New System.Drawing.Size(586, 136)
        Me.dgvDetCorral.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Detalle Tropas"
        '
        'txtDetalle
        '
        Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDetalle.Location = New System.Drawing.Point(97, 298)
        Me.txtDetalle.MaxLength = 250
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(422, 62)
        Me.txtDetalle.TabIndex = 75
        '
        'cbxCorralEgreso
        '
        Me.cbxCorralEgreso.FormattingEnabled = True
        Me.cbxCorralEgreso.Location = New System.Drawing.Point(97, 53)
        Me.cbxCorralEgreso.Name = "cbxCorralEgreso"
        Me.cbxCorralEgreso.Size = New System.Drawing.Size(209, 21)
        Me.cbxCorralEgreso.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Corral de Egreso"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Cabezas"
        '
        'txtCabezas
        '
        Me.txtCabezas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCabezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCabezas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCabezas.Location = New System.Drawing.Point(97, 272)
        Me.txtCabezas.MaxLength = 250
        Me.txtCabezas.Name = "txtCabezas"
        Me.txtCabezas.Size = New System.Drawing.Size(101, 20)
        Me.txtCabezas.TabIndex = 63
        Me.txtCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(541, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(584, 15)
        Me.txtFecha.MaxLength = 250
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(99, 20)
        Me.txtFecha.TabIndex = 39
        '
        'txtIdCorralEegreso
        '
        Me.txtIdCorralEegreso.BackColor = System.Drawing.Color.Teal
        Me.txtIdCorralEegreso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdCorralEegreso.Location = New System.Drawing.Point(312, 52)
        Me.txtIdCorralEegreso.Name = "txtIdCorralEegreso"
        Me.txtIdCorralEegreso.Size = New System.Drawing.Size(105, 20)
        Me.txtIdCorralEegreso.TabIndex = 27
        Me.txtIdCorralEegreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdCorralEegreso.Visible = False
        '
        'txtIdCorralIngr
        '
        Me.txtIdCorralIngr.BackColor = System.Drawing.Color.Teal
        Me.txtIdCorralIngr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdCorralIngr.Location = New System.Drawing.Point(312, 245)
        Me.txtIdCorralIngr.Name = "txtIdCorralIngr"
        Me.txtIdCorralIngr.Size = New System.Drawing.Size(105, 20)
        Me.txtIdCorralIngr.TabIndex = 26
        Me.txtIdCorralIngr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdCorralIngr.Visible = False
        '
        'cbxCorralIng
        '
        Me.cbxCorralIng.FormattingEnabled = True
        Me.cbxCorralIng.Location = New System.Drawing.Point(97, 245)
        Me.cbxCorralIng.Name = "cbxCorralIng"
        Me.cbxCorralIng.Size = New System.Drawing.Size(209, 21)
        Me.cbxCorralIng.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Corral de Ingreso"
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(174, 440)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.ForeColor = System.Drawing.Color.Teal
        Me.lblMsg.Location = New System.Drawing.Point(417, 407)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(284, 20)
        Me.lblMsg.TabIndex = 37
        Me.lblMsg.Text = "Presione Nuevo para agregar tropas..."
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(93, 440)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(620, 440)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 36
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 440)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 33
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 472)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbxDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMovimiento"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.dgvDetCorral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCabezas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCorralEegreso As System.Windows.Forms.Label
    Friend WithEvents txtIdCorralIngr As System.Windows.Forms.Label
    Friend WithEvents cbxCorralIng As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents cbxCorralEgreso As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgvDetCorral As System.Windows.Forms.DataGridView
    Friend WithEvents lblSeleccion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCabDisp As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblIDtropa As System.Windows.Forms.Label
    Friend WithEvents lblCabTEg As System.Windows.Forms.Label
    Friend WithEvents lblCabTIn As System.Windows.Forms.Label
End Class
