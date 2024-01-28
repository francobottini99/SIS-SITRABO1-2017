<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.txtIVACab = New System.Windows.Forms.TextBox()
        Me.txtIVAKG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtImpKGConIVA = New System.Windows.Forms.TextBox()
        Me.txtImpCabConIVA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtImpKGSinIVA = New System.Windows.Forms.TextBox()
        Me.txtImpCabSinIVA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtImpNetoVenta = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtIdTropa = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cbxTropa = New System.Windows.Forms.ComboBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtPesoTotal = New System.Windows.Forms.TextBox()
        Me.txtImpVentaFinal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCostOtros = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNCab = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPesoCab = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCostFlete = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(427, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "ALTA DE VENTA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.lblDisp)
        Me.gbxDatos.Controls.Add(Me.txtIVACab)
        Me.gbxDatos.Controls.Add(Me.txtIVAKG)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.Label12)
        Me.gbxDatos.Controls.Add(Me.txtImpKGConIVA)
        Me.gbxDatos.Controls.Add(Me.txtImpCabConIVA)
        Me.gbxDatos.Controls.Add(Me.Label7)
        Me.gbxDatos.Controls.Add(Me.txtImpKGSinIVA)
        Me.gbxDatos.Controls.Add(Me.txtImpCabSinIVA)
        Me.gbxDatos.Controls.Add(Me.Label10)
        Me.gbxDatos.Controls.Add(Me.Label17)
        Me.gbxDatos.Controls.Add(Me.txtImpNetoVenta)
        Me.gbxDatos.Controls.Add(Me.Label24)
        Me.gbxDatos.Controls.Add(Me.txtIdTropa)
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.Label15)
        Me.gbxDatos.Controls.Add(Me.Label35)
        Me.gbxDatos.Controls.Add(Me.cbxTropa)
        Me.gbxDatos.Controls.Add(Me.txtFecha)
        Me.gbxDatos.Controls.Add(Me.Label33)
        Me.gbxDatos.Controls.Add(Me.txtPesoTotal)
        Me.gbxDatos.Controls.Add(Me.txtImpVentaFinal)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.Label13)
        Me.gbxDatos.Controls.Add(Me.Label11)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Controls.Add(Me.txtCostOtros)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.txtNCab)
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.txtPesoCab)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.txtCostFlete)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(12, 35)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(427, 336)
        Me.gbxDatos.TabIndex = 24
        Me.gbxDatos.TabStop = False
        '
        'lblDisp
        '
        Me.lblDisp.AutoSize = True
        Me.lblDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisp.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblDisp.Location = New System.Drawing.Point(167, 114)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(0, 13)
        Me.lblDisp.TabIndex = 68
        '
        'txtIVACab
        '
        Me.txtIVACab.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtIVACab.Enabled = False
        Me.txtIVACab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVACab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtIVACab.Location = New System.Drawing.Point(213, 181)
        Me.txtIVACab.MaxLength = 250
        Me.txtIVACab.Name = "txtIVACab"
        Me.txtIVACab.Size = New System.Drawing.Size(101, 20)
        Me.txtIVACab.TabIndex = 67
        Me.txtIVACab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVAKG
        '
        Me.txtIVAKG.BackColor = System.Drawing.SystemColors.Window
        Me.txtIVAKG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAKG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtIVAKG.Location = New System.Drawing.Point(213, 155)
        Me.txtIVAKG.MaxLength = 250
        Me.txtIVAKG.Name = "txtIVAKG"
        Me.txtIVAKG.Size = New System.Drawing.Size(101, 20)
        Me.txtIVAKG.TabIndex = 66
        Me.txtIVAKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "IVA %"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(348, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Con IVA"
        '
        'txtImpKGConIVA
        '
        Me.txtImpKGConIVA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpKGConIVA.Enabled = False
        Me.txtImpKGConIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpKGConIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpKGConIVA.Location = New System.Drawing.Point(320, 155)
        Me.txtImpKGConIVA.MaxLength = 250
        Me.txtImpKGConIVA.Name = "txtImpKGConIVA"
        Me.txtImpKGConIVA.Size = New System.Drawing.Size(101, 20)
        Me.txtImpKGConIVA.TabIndex = 62
        Me.txtImpKGConIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpCabConIVA
        '
        Me.txtImpCabConIVA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpCabConIVA.Enabled = False
        Me.txtImpCabConIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpCabConIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpCabConIVA.Location = New System.Drawing.Point(320, 181)
        Me.txtImpCabConIVA.MaxLength = 250
        Me.txtImpCabConIVA.Name = "txtImpCabConIVA"
        Me.txtImpCabConIVA.Size = New System.Drawing.Size(101, 20)
        Me.txtImpCabConIVA.TabIndex = 63
        Me.txtImpCabConIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(139, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Sin IVA"
        '
        'txtImpKGSinIVA
        '
        Me.txtImpKGSinIVA.BackColor = System.Drawing.SystemColors.Window
        Me.txtImpKGSinIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpKGSinIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpKGSinIVA.Location = New System.Drawing.Point(106, 155)
        Me.txtImpKGSinIVA.MaxLength = 250
        Me.txtImpKGSinIVA.Name = "txtImpKGSinIVA"
        Me.txtImpKGSinIVA.Size = New System.Drawing.Size(101, 20)
        Me.txtImpKGSinIVA.TabIndex = 57
        Me.txtImpKGSinIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpCabSinIVA
        '
        Me.txtImpCabSinIVA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpCabSinIVA.Enabled = False
        Me.txtImpCabSinIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpCabSinIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpCabSinIVA.Location = New System.Drawing.Point(106, 181)
        Me.txtImpCabSinIVA.MaxLength = 250
        Me.txtImpCabSinIVA.Name = "txtImpCabSinIVA"
        Me.txtImpCabSinIVA.Size = New System.Drawing.Size(101, 20)
        Me.txtImpCabSinIVA.TabIndex = 58
        Me.txtImpCabSinIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Importe por KG"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Importe por Cabeza"
        '
        'txtImpNetoVenta
        '
        Me.txtImpNetoVenta.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpNetoVenta.Enabled = False
        Me.txtImpNetoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpNetoVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpNetoVenta.Location = New System.Drawing.Point(139, 308)
        Me.txtImpNetoVenta.MaxLength = 45
        Me.txtImpNetoVenta.Name = "txtImpNetoVenta"
        Me.txtImpNetoVenta.Size = New System.Drawing.Size(104, 20)
        Me.txtImpNetoVenta.TabIndex = 56
        Me.txtImpNetoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(131, 114)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "DISP: "
        '
        'txtIdTropa
        '
        Me.txtIdTropa.BackColor = System.Drawing.Color.Teal
        Me.txtIdTropa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdTropa.Location = New System.Drawing.Point(348, 219)
        Me.txtIdTropa.Name = "txtIdTropa"
        Me.txtIdTropa.Size = New System.Drawing.Size(73, 20)
        Me.txtIdTropa.TabIndex = 42
        Me.txtIdTropa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdTropa.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(212, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Con IVA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(212, 223)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Con IVA"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(279, 22)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 13)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Fecha"
        '
        'cbxTropa
        '
        Me.cbxTropa.FormattingEnabled = True
        Me.cbxTropa.Location = New System.Drawing.Point(106, 51)
        Me.cbxTropa.Name = "cbxTropa"
        Me.cbxTropa.Size = New System.Drawing.Size(315, 21)
        Me.cbxTropa.TabIndex = 25
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(322, 19)
        Me.txtFecha.MaxLength = 250
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(99, 20)
        Me.txtFecha.TabIndex = 4
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 54)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(35, 13)
        Me.Label33.TabIndex = 19
        Me.Label33.Text = "Tropa"
        '
        'txtPesoTotal
        '
        Me.txtPesoTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPesoTotal.Enabled = False
        Me.txtPesoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPesoTotal.Location = New System.Drawing.Point(320, 91)
        Me.txtPesoTotal.MaxLength = 250
        Me.txtPesoTotal.Name = "txtPesoTotal"
        Me.txtPesoTotal.Size = New System.Drawing.Size(101, 20)
        Me.txtPesoTotal.TabIndex = 36
        Me.txtPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpVentaFinal
        '
        Me.txtImpVentaFinal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpVentaFinal.Enabled = False
        Me.txtImpVentaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpVentaFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpVentaFinal.Location = New System.Drawing.Point(139, 282)
        Me.txtImpVentaFinal.MaxLength = 45
        Me.txtImpVentaFinal.Name = "txtImpVentaFinal"
        Me.txtImpVentaFinal.Size = New System.Drawing.Size(104, 20)
        Me.txtImpVentaFinal.TabIndex = 35
        Me.txtImpVentaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Importe Total Venta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(336, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "KG TOTALES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(232, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "KG X CAB"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 223)
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
        Me.txtCostOtros.Location = New System.Drawing.Point(105, 246)
        Me.txtCostOtros.MaxLength = 45
        Me.txtCostOtros.Name = "txtCostOtros"
        Me.txtCostOtros.Size = New System.Drawing.Size(101, 20)
        Me.txtCostOtros.TabIndex = 10
        Me.txtCostOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Otros Costos"
        '
        'txtNCab
        '
        Me.txtNCab.BackColor = System.Drawing.SystemColors.Window
        Me.txtNCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNCab.Location = New System.Drawing.Point(106, 91)
        Me.txtNCab.MaxLength = 250
        Me.txtNCab.Name = "txtNCab"
        Me.txtNCab.Size = New System.Drawing.Size(101, 20)
        Me.txtNCab.TabIndex = 5
        Me.txtNCab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Importe NETO Venta"
        '
        'txtPesoCab
        '
        Me.txtPesoCab.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPesoCab.Enabled = False
        Me.txtPesoCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoCab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPesoCab.Location = New System.Drawing.Point(213, 91)
        Me.txtPesoCab.MaxLength = 250
        Me.txtPesoCab.Name = "txtPesoCab"
        Me.txtPesoCab.Size = New System.Drawing.Size(101, 20)
        Me.txtPesoCab.TabIndex = 6
        Me.txtPesoCab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "N° De Cabezas"
        '
        'txtCostFlete
        '
        Me.txtCostFlete.BackColor = System.Drawing.SystemColors.Window
        Me.txtCostFlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostFlete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCostFlete.Location = New System.Drawing.Point(104, 220)
        Me.txtCostFlete.MaxLength = 45
        Me.txtCostFlete.Name = "txtCostFlete"
        Me.txtCostFlete.Size = New System.Drawing.Size(102, 20)
        Me.txtCostFlete.TabIndex = 9
        Me.txtCostFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMsg
        '
        Me.lblMsg.ForeColor = System.Drawing.Color.Teal
        Me.lblMsg.Location = New System.Drawing.Point(155, 374)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(284, 20)
        Me.lblMsg.TabIndex = 44
        Me.lblMsg.Text = "Presione Nuevo para agregar una compra..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(11, 397)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 40
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(92, 397)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 41
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(364, 397)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 43
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(173, 397)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 42
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 423)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVentas"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdTropa As System.Windows.Forms.Label
    Friend WithEvents txtPesoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtImpVentaFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCostOtros As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNCab As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPesoCab As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCostFlete As System.Windows.Forms.TextBox
    Friend WithEvents cbxTropa As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtImpNetoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtIVACab As System.Windows.Forms.TextBox
    Friend WithEvents txtIVAKG As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtImpKGConIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtImpCabConIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtImpKGSinIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtImpCabSinIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblDisp As System.Windows.Forms.Label
End Class
