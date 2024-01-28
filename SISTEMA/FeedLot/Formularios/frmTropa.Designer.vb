<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTropa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTropa))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtIdCatg = New System.Windows.Forms.Label()
        Me.txtIdCorral = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxCategorias = New System.Windows.Forms.ComboBox()
        Me.cbxCorral = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIdPr = New System.Windows.Forms.Label()
        Me.txtIdCm = New System.Windows.Forms.Label()
        Me.txtIdPd = New System.Windows.Forms.Label()
        Me.cbxProv = New System.Windows.Forms.ComboBox()
        Me.cbxCampo = New System.Windows.Forms.ComboBox()
        Me.cbxProd = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCab = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFec = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKgCab = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKgTropa = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.gbxDatos.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(501, 23)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ALTA DE TROPAS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(167, 562)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cabezas"
        '
        'lblMsg
        '
        Me.lblMsg.ForeColor = System.Drawing.Color.Teal
        Me.lblMsg.Location = New System.Drawing.Point(229, 539)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(284, 20)
        Me.lblMsg.TabIndex = 23
        Me.lblMsg.Text = "Presione Nuevo para agregar tropas..."
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(207, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Kg"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.txtObservaciones)
        Me.gbxDatos.Controls.Add(Me.txtIdCatg)
        Me.gbxDatos.Controls.Add(Me.txtIdCorral)
        Me.gbxDatos.Controls.Add(Me.dgvDatos)
        Me.gbxDatos.Controls.Add(Me.Label15)
        Me.gbxDatos.Controls.Add(Me.txtCantidad)
        Me.gbxDatos.Controls.Add(Me.Label14)
        Me.gbxDatos.Controls.Add(Me.cbxCategorias)
        Me.gbxDatos.Controls.Add(Me.cbxCorral)
        Me.gbxDatos.Controls.Add(Me.Label13)
        Me.gbxDatos.Controls.Add(Me.txtIdPr)
        Me.gbxDatos.Controls.Add(Me.txtIdCm)
        Me.gbxDatos.Controls.Add(Me.txtIdPd)
        Me.gbxDatos.Controls.Add(Me.cbxProv)
        Me.gbxDatos.Controls.Add(Me.cbxCampo)
        Me.gbxDatos.Controls.Add(Me.cbxProd)
        Me.gbxDatos.Controls.Add(Me.Label12)
        Me.gbxDatos.Controls.Add(Me.Label10)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Controls.Add(Me.Label11)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.txtCab)
        Me.gbxDatos.Controls.Add(Me.Label7)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.txtProc)
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.txtFec)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.txtKgCab)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtKgTropa)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(15, 35)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(498, 501)
        Me.gbxDatos.TabIndex = 25
        Me.gbxDatos.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 279)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(99, 276)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(384, 64)
        Me.txtObservaciones.TabIndex = 37
        '
        'txtIdCatg
        '
        Me.txtIdCatg.BackColor = System.Drawing.Color.Teal
        Me.txtIdCatg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdCatg.Location = New System.Drawing.Point(267, 198)
        Me.txtIdCatg.Name = "txtIdCatg"
        Me.txtIdCatg.Size = New System.Drawing.Size(105, 20)
        Me.txtIdCatg.TabIndex = 36
        Me.txtIdCatg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdCatg.Visible = False
        '
        'txtIdCorral
        '
        Me.txtIdCorral.BackColor = System.Drawing.Color.Teal
        Me.txtIdCorral.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdCorral.Location = New System.Drawing.Point(267, 172)
        Me.txtIdCorral.Name = "txtIdCorral"
        Me.txtIdCorral.Size = New System.Drawing.Size(105, 20)
        Me.txtIdCorral.TabIndex = 35
        Me.txtIdCorral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdCorral.Visible = False
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowDrop = True
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToResizeColumns = False
        Me.dgvDatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(9, 394)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvDatos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.dgvDatos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDatos.Size = New System.Drawing.Size(474, 101)
        Me.dgvDatos.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(411, 351)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(381, 367)
        Me.txtCantidad.MaxLength = 45
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(102, 20)
        Me.txtCantidad.TabIndex = 32
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 370)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Categoria"
        '
        'cbxCategorias
        '
        Me.cbxCategorias.FormattingEnabled = True
        Me.cbxCategorias.Location = New System.Drawing.Point(99, 367)
        Me.cbxCategorias.Name = "cbxCategorias"
        Me.cbxCategorias.Size = New System.Drawing.Size(276, 21)
        Me.cbxCategorias.TabIndex = 30
        '
        'cbxCorral
        '
        Me.cbxCorral.FormattingEnabled = True
        Me.cbxCorral.Location = New System.Drawing.Point(99, 93)
        Me.cbxCorral.Name = "cbxCorral"
        Me.cbxCorral.Size = New System.Drawing.Size(384, 21)
        Me.cbxCorral.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Corral de ingreso"
        '
        'txtIdPr
        '
        Me.txtIdPr.BackColor = System.Drawing.Color.Teal
        Me.txtIdPr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdPr.Location = New System.Drawing.Point(378, 227)
        Me.txtIdPr.Name = "txtIdPr"
        Me.txtIdPr.Size = New System.Drawing.Size(105, 20)
        Me.txtIdPr.TabIndex = 27
        Me.txtIdPr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdPr.Visible = False
        '
        'txtIdCm
        '
        Me.txtIdCm.BackColor = System.Drawing.Color.Teal
        Me.txtIdCm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdCm.Location = New System.Drawing.Point(378, 198)
        Me.txtIdCm.Name = "txtIdCm"
        Me.txtIdCm.Size = New System.Drawing.Size(105, 20)
        Me.txtIdCm.TabIndex = 26
        Me.txtIdCm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdCm.Visible = False
        '
        'txtIdPd
        '
        Me.txtIdPd.BackColor = System.Drawing.Color.Teal
        Me.txtIdPd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdPd.Location = New System.Drawing.Point(378, 172)
        Me.txtIdPd.Name = "txtIdPd"
        Me.txtIdPd.Size = New System.Drawing.Size(105, 20)
        Me.txtIdPd.TabIndex = 25
        Me.txtIdPd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdPd.Visible = False
        '
        'cbxProv
        '
        Me.cbxProv.FormattingEnabled = True
        Me.cbxProv.Location = New System.Drawing.Point(99, 66)
        Me.cbxProv.Name = "cbxProv"
        Me.cbxProv.Size = New System.Drawing.Size(384, 21)
        Me.cbxProv.TabIndex = 6
        '
        'cbxCampo
        '
        Me.cbxCampo.FormattingEnabled = True
        Me.cbxCampo.Location = New System.Drawing.Point(99, 38)
        Me.cbxCampo.Name = "cbxCampo"
        Me.cbxCampo.Size = New System.Drawing.Size(384, 21)
        Me.cbxCampo.TabIndex = 5
        '
        'cbxProd
        '
        Me.cbxProd.FormattingEnabled = True
        Me.cbxProd.Location = New System.Drawing.Point(99, 13)
        Me.cbxProd.Name = "cbxProd"
        Me.cbxProd.Size = New System.Drawing.Size(384, 21)
        Me.cbxProd.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Proveedor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Campo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Productor"
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(207, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Kg"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCab
        '
        Me.txtCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCab.Location = New System.Drawing.Point(99, 198)
        Me.txtCab.MaxLength = 250
        Me.txtCab.Name = "txtCab"
        Me.txtCab.Size = New System.Drawing.Size(102, 20)
        Me.txtCab.TabIndex = 10
        Me.txtCab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre Tropa"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(99, 120)
        Me.txtNombre.MaxLength = 250
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(384, 20)
        Me.txtNombre.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Kg Tropa"
        '
        'txtProc
        '
        Me.txtProc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtProc.Location = New System.Drawing.Point(99, 146)
        Me.txtProc.MaxLength = 250
        Me.txtProc.Name = "txtProc"
        Me.txtProc.Size = New System.Drawing.Size(384, 20)
        Me.txtProc.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Peso/Cab Ingreso"
        '
        'txtFec
        '
        Me.txtFec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFec.Location = New System.Drawing.Point(99, 172)
        Me.txtFec.MaxLength = 250
        Me.txtFec.Name = "txtFec"
        Me.txtFec.Size = New System.Drawing.Size(102, 20)
        Me.txtFec.TabIndex = 9
        Me.txtFec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha Ingreso"
        '
        'txtKgCab
        '
        Me.txtKgCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgCab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKgCab.Location = New System.Drawing.Point(99, 224)
        Me.txtKgCab.MaxLength = 45
        Me.txtKgCab.Name = "txtKgCab"
        Me.txtKgCab.Size = New System.Drawing.Size(102, 20)
        Me.txtKgCab.TabIndex = 11
        Me.txtKgCab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Procedencia"
        '
        'txtKgTropa
        '
        Me.txtKgTropa.Enabled = False
        Me.txtKgTropa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgTropa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKgTropa.Location = New System.Drawing.Point(99, 250)
        Me.txtKgTropa.MaxLength = 45
        Me.txtKgTropa.Name = "txtKgTropa"
        Me.txtKgTropa.Size = New System.Drawing.Size(102, 20)
        Me.txtKgTropa.TabIndex = 12
        Me.txtKgTropa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(86, 562)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(438, 562)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(5, 562)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmTropa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 588)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTropa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTropa"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtCab As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFec As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKgCab As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKgTropa As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxProv As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCampo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxProd As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIdCm As System.Windows.Forms.Label
    Friend WithEvents txtIdPd As System.Windows.Forms.Label
    Friend WithEvents txtIdPr As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbxCategorias As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCorral As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIdCatg As System.Windows.Forms.Label
    Friend WithEvents txtIdCorral As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
End Class
