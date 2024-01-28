<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPesoXCab = New System.Windows.Forms.TextBox()
        Me.txtPesoTropa = New System.Windows.Forms.TextBox()
        Me.txtCantCab = New System.Windows.Forms.TextBox()
        Me.txtIdPr = New System.Windows.Forms.Label()
        Me.txtIdTropa = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.txtIVACab = New System.Windows.Forms.TextBox()
        Me.txtIVAKG = New System.Windows.Forms.TextBox()
        Me.txtCostFinalTropa = New System.Windows.Forms.TextBox()
        Me.txtCostCabFinal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCostKGFinal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCostKGConIVA = New System.Windows.Forms.TextBox()
        Me.txtCostCabConIVA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxTropa = New System.Windows.Forms.ComboBox()
        Me.cbxProv = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCostOtros = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCostKGSinIVA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCostCabSinIVA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCostFlete = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(470, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ALTA DE COMPRA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 454)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(93, 454)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(404, 454)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(174, 454)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.Label20)
        Me.gbxDatos.Controls.Add(Me.Label19)
        Me.gbxDatos.Controls.Add(Me.Label18)
        Me.gbxDatos.Controls.Add(Me.Label17)
        Me.gbxDatos.Controls.Add(Me.txtPesoXCab)
        Me.gbxDatos.Controls.Add(Me.txtPesoTropa)
        Me.gbxDatos.Controls.Add(Me.txtCantCab)
        Me.gbxDatos.Controls.Add(Me.txtIdPr)
        Me.gbxDatos.Controls.Add(Me.txtIdTropa)
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.Label15)
        Me.gbxDatos.Controls.Add(Me.txtFormaPago)
        Me.gbxDatos.Controls.Add(Me.txtIVACab)
        Me.gbxDatos.Controls.Add(Me.txtIVAKG)
        Me.gbxDatos.Controls.Add(Me.txtCostFinalTropa)
        Me.gbxDatos.Controls.Add(Me.txtCostCabFinal)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.Label14)
        Me.gbxDatos.Controls.Add(Me.Label13)
        Me.gbxDatos.Controls.Add(Me.txtCostKGFinal)
        Me.gbxDatos.Controls.Add(Me.Label12)
        Me.gbxDatos.Controls.Add(Me.txtCostKGConIVA)
        Me.gbxDatos.Controls.Add(Me.txtCostCabConIVA)
        Me.gbxDatos.Controls.Add(Me.Label11)
        Me.gbxDatos.Controls.Add(Me.cbxTropa)
        Me.gbxDatos.Controls.Add(Me.cbxProv)
        Me.gbxDatos.Controls.Add(Me.Label10)
        Me.gbxDatos.Controls.Add(Me.Label7)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Controls.Add(Me.txtCostOtros)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.txtFecha)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.txtCostKGSinIVA)
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.txtCostCabSinIVA)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtCostFlete)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(12, 36)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(467, 392)
        Me.gbxDatos.TabIndex = 23
        Me.gbxDatos.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 343)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 13)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Costo Final por Cabeza"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(310, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 13)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Peso Total Tropa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(195, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Peso por Cabeza"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(70, 129)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 13)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Cantidad de Cabezas"
        '
        'txtPesoXCab
        '
        Me.txtPesoXCab.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPesoXCab.Enabled = False
        Me.txtPesoXCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoXCab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPesoXCab.Location = New System.Drawing.Point(185, 106)
        Me.txtPesoXCab.MaxLength = 250
        Me.txtPesoXCab.Name = "txtPesoXCab"
        Me.txtPesoXCab.Size = New System.Drawing.Size(109, 20)
        Me.txtPesoXCab.TabIndex = 46
        Me.txtPesoXCab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPesoTropa
        '
        Me.txtPesoTropa.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPesoTropa.Enabled = False
        Me.txtPesoTropa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoTropa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPesoTropa.Location = New System.Drawing.Point(300, 106)
        Me.txtPesoTropa.MaxLength = 250
        Me.txtPesoTropa.Name = "txtPesoTropa"
        Me.txtPesoTropa.Size = New System.Drawing.Size(109, 20)
        Me.txtPesoTropa.TabIndex = 45
        Me.txtPesoTropa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantCab
        '
        Me.txtCantCab.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCantCab.Enabled = False
        Me.txtCantCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantCab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCantCab.Location = New System.Drawing.Point(70, 106)
        Me.txtCantCab.MaxLength = 250
        Me.txtCantCab.Name = "txtCantCab"
        Me.txtCantCab.Size = New System.Drawing.Size(109, 20)
        Me.txtCantCab.TabIndex = 44
        Me.txtCantCab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIdPr
        '
        Me.txtIdPr.BackColor = System.Drawing.Color.Teal
        Me.txtIdPr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdPr.Location = New System.Drawing.Point(346, 262)
        Me.txtIdPr.Name = "txtIdPr"
        Me.txtIdPr.Size = New System.Drawing.Size(73, 20)
        Me.txtIdPr.TabIndex = 43
        Me.txtIdPr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdPr.Visible = False
        '
        'txtIdTropa
        '
        Me.txtIdTropa.BackColor = System.Drawing.Color.Teal
        Me.txtIdTropa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdTropa.Location = New System.Drawing.Point(346, 289)
        Me.txtIdTropa.Name = "txtIdTropa"
        Me.txtIdTropa.Size = New System.Drawing.Size(73, 20)
        Me.txtIdTropa.TabIndex = 42
        Me.txtIdTropa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdTropa.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(213, 270)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Con IVA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(213, 244)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Con IVA"
        '
        'txtFormaPago
        '
        Me.txtFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFormaPago.Location = New System.Drawing.Point(323, 366)
        Me.txtFormaPago.MaxLength = 250
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.Size = New System.Drawing.Size(138, 20)
        Me.txtFormaPago.TabIndex = 38
        '
        'txtIVACab
        '
        Me.txtIVACab.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtIVACab.Enabled = False
        Me.txtIVACab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVACab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtIVACab.Location = New System.Drawing.Point(211, 207)
        Me.txtIVACab.MaxLength = 250
        Me.txtIVACab.Name = "txtIVACab"
        Me.txtIVACab.Size = New System.Drawing.Size(101, 20)
        Me.txtIVACab.TabIndex = 37
        Me.txtIVACab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVAKG
        '
        Me.txtIVAKG.BackColor = System.Drawing.SystemColors.Window
        Me.txtIVAKG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAKG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtIVAKG.Location = New System.Drawing.Point(211, 181)
        Me.txtIVAKG.MaxLength = 250
        Me.txtIVAKG.Name = "txtIVAKG"
        Me.txtIVAKG.Size = New System.Drawing.Size(101, 20)
        Me.txtIVAKG.TabIndex = 36
        Me.txtIVAKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostFinalTropa
        '
        Me.txtCostFinalTropa.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCostFinalTropa.Enabled = False
        Me.txtCostFinalTropa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostFinalTropa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostFinalTropa.Location = New System.Drawing.Point(122, 366)
        Me.txtCostFinalTropa.MaxLength = 45
        Me.txtCostFinalTropa.Name = "txtCostFinalTropa"
        Me.txtCostFinalTropa.Size = New System.Drawing.Size(104, 20)
        Me.txtCostFinalTropa.TabIndex = 35
        Me.txtCostFinalTropa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostCabFinal
        '
        Me.txtCostCabFinal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCostCabFinal.Enabled = False
        Me.txtCostCabFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostCabFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostCabFinal.Location = New System.Drawing.Point(122, 340)
        Me.txtCostCabFinal.MaxLength = 45
        Me.txtCostCabFinal.Name = "txtCostCabFinal"
        Me.txtCostCabFinal.Size = New System.Drawing.Size(104, 20)
        Me.txtCostCabFinal.TabIndex = 33
        Me.txtCostCabFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Costo Total Tropa"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 317)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Costo Final por KG"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(248, 165)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "IVA %"
        '
        'txtCostKGFinal
        '
        Me.txtCostKGFinal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCostKGFinal.Enabled = False
        Me.txtCostKGFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostKGFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostKGFinal.Location = New System.Drawing.Point(122, 314)
        Me.txtCostKGFinal.MaxLength = 45
        Me.txtCostKGFinal.Name = "txtCostKGFinal"
        Me.txtCostKGFinal.Size = New System.Drawing.Size(104, 20)
        Me.txtCostKGFinal.TabIndex = 30
        Me.txtCostKGFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(346, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Con IVA"
        '
        'txtCostKGConIVA
        '
        Me.txtCostKGConIVA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCostKGConIVA.Enabled = False
        Me.txtCostKGConIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostKGConIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostKGConIVA.Location = New System.Drawing.Point(318, 181)
        Me.txtCostKGConIVA.MaxLength = 250
        Me.txtCostKGConIVA.Name = "txtCostKGConIVA"
        Me.txtCostKGConIVA.Size = New System.Drawing.Size(101, 20)
        Me.txtCostKGConIVA.TabIndex = 27
        Me.txtCostKGConIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostCabConIVA
        '
        Me.txtCostCabConIVA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCostCabConIVA.Enabled = False
        Me.txtCostCabConIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostCabConIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostCabConIVA.Location = New System.Drawing.Point(318, 207)
        Me.txtCostCabConIVA.MaxLength = 250
        Me.txtCostCabConIVA.Name = "txtCostCabConIVA"
        Me.txtCostCabConIVA.Size = New System.Drawing.Size(101, 20)
        Me.txtCostCabConIVA.TabIndex = 28
        Me.txtCostCabConIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(137, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Sin IVA"
        '
        'cbxTropa
        '
        Me.cbxTropa.FormattingEnabled = True
        Me.cbxTropa.Location = New System.Drawing.Point(69, 79)
        Me.cbxTropa.Name = "cbxTropa"
        Me.cbxTropa.Size = New System.Drawing.Size(341, 21)
        Me.cbxTropa.TabIndex = 25
        '
        'cbxProv
        '
        Me.cbxProv.FormattingEnabled = True
        Me.cbxProv.Location = New System.Drawing.Point(69, 52)
        Me.cbxProv.Name = "cbxProv"
        Me.cbxProv.Size = New System.Drawing.Size(341, 21)
        Me.cbxProv.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Tropa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Proveedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Costo Flete"
        '
        'txtCostOtros
        '
        Me.txtCostOtros.BackColor = System.Drawing.SystemColors.Window
        Me.txtCostOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostOtros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostOtros.Location = New System.Drawing.Point(106, 267)
        Me.txtCostOtros.MaxLength = 45
        Me.txtCostOtros.Name = "txtCostOtros"
        Me.txtCostOtros.Size = New System.Drawing.Size(101, 20)
        Me.txtCostOtros.TabIndex = 10
        Me.txtCostOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(362, 19)
        Me.txtFecha.MaxLength = 250
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(99, 20)
        Me.txtFecha.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Otros Costos"
        '
        'txtCostKGSinIVA
        '
        Me.txtCostKGSinIVA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCostKGSinIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostKGSinIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostKGSinIVA.Location = New System.Drawing.Point(104, 181)
        Me.txtCostKGSinIVA.MaxLength = 250
        Me.txtCostKGSinIVA.Name = "txtCostKGSinIVA"
        Me.txtCostKGSinIVA.Size = New System.Drawing.Size(101, 20)
        Me.txtCostKGSinIVA.TabIndex = 5
        Me.txtCostKGSinIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Forma de Pago"
        '
        'txtCostCabSinIVA
        '
        Me.txtCostCabSinIVA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCostCabSinIVA.Enabled = False
        Me.txtCostCabSinIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostCabSinIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostCabSinIVA.Location = New System.Drawing.Point(104, 207)
        Me.txtCostCabSinIVA.MaxLength = 250
        Me.txtCostCabSinIVA.Name = "txtCostCabSinIVA"
        Me.txtCostCabSinIVA.Size = New System.Drawing.Size(101, 20)
        Me.txtCostCabSinIVA.TabIndex = 6
        Me.txtCostCabSinIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Costo por KG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Costo por Cabeza"
        '
        'txtCostFlete
        '
        Me.txtCostFlete.BackColor = System.Drawing.SystemColors.Window
        Me.txtCostFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostFlete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostFlete.Location = New System.Drawing.Point(105, 241)
        Me.txtCostFlete.MaxLength = 45
        Me.txtCostFlete.Name = "txtCostFlete"
        Me.txtCostFlete.Size = New System.Drawing.Size(102, 20)
        Me.txtCostFlete.TabIndex = 9
        Me.txtCostFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMsg
        '
        Me.lblMsg.ForeColor = System.Drawing.Color.Teal
        Me.lblMsg.Location = New System.Drawing.Point(195, 431)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(284, 20)
        Me.lblMsg.TabIndex = 39
        Me.lblMsg.Text = "Presione Nuevo para agregar una compra..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 479)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCompras"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCostOtros As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCostKGSinIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCostCabSinIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCostFlete As System.Windows.Forms.TextBox
    Friend WithEvents cbxTropa As System.Windows.Forms.ComboBox
    Friend WithEvents cbxProv As System.Windows.Forms.ComboBox
    Friend WithEvents txtCostFinalTropa As System.Windows.Forms.TextBox
    Friend WithEvents txtCostCabFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCostKGFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCostKGConIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtCostCabConIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtIVACab As System.Windows.Forms.TextBox
    Friend WithEvents txtIVAKG As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtIdPr As System.Windows.Forms.Label
    Friend WithEvents txtIdTropa As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPesoXCab As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoTropa As System.Windows.Forms.TextBox
    Friend WithEvents txtCantCab As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
