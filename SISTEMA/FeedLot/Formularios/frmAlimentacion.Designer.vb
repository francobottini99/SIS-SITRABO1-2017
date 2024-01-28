<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlimentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlimentacion))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.cbxRacion = New System.Windows.Forms.ComboBox()
        Me.txtIdRacion = New System.Windows.Forms.Label()
        Me.txtIdCorral = New System.Windows.Forms.Label()
        Me.cbxCorral = New System.Windows.Forms.ComboBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtKGGrano = New System.Windows.Forms.TextBox()
        Me.txtImpConcentrado = New System.Windows.Forms.TextBox()
        Me.txtImpFibra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKGConcentrado = New System.Windows.Forms.TextBox()
        Me.txtKGFibra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImpGrano = New System.Windows.Forms.TextBox()
        Me.txtPorcenConcentrado = New System.Windows.Forms.TextBox()
        Me.txtPorcenFibra = New System.Windows.Forms.TextBox()
        Me.txtPorcenGrano = New System.Windows.Forms.TextBox()
        Me.txtKGOtros = New System.Windows.Forms.TextBox()
        Me.txtImpOtros = New System.Windows.Forms.TextBox()
        Me.txtPorcenOtros = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtImpTotal = New System.Windows.Forms.TextBox()
        Me.txtKGTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdbMañana = New System.Windows.Forms.RadioButton()
        Me.rdbTarde = New System.Windows.Forms.RadioButton()
        Me.txtGrano = New System.Windows.Forms.TextBox()
        Me.txtFibra = New System.Windows.Forms.TextBox()
        Me.txtConcentrado = New System.Windows.Forms.TextBox()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblImpGrano = New System.Windows.Forms.Label()
        Me.lblImpFibra = New System.Windows.Forms.Label()
        Me.lblImpConcentrado = New System.Windows.Forms.Label()
        Me.lblImpOtros = New System.Windows.Forms.Label()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(174, 477)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.ForeColor = System.Drawing.Color.Teal
        Me.lblMsg.Location = New System.Drawing.Point(256, 454)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(284, 20)
        Me.lblMsg.TabIndex = 32
        Me.lblMsg.Text = "Presione Nuevo para agregar tropas..."
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(93, 477)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(465, 477)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 477)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 28
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Racion"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(13, 136)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(34, 13)
        Me.label.TabIndex = 20
        Me.label.Text = "Corral"
        '
        'cbxRacion
        '
        Me.cbxRacion.FormattingEnabled = True
        Me.cbxRacion.Location = New System.Drawing.Point(99, 53)
        Me.cbxRacion.Name = "cbxRacion"
        Me.cbxRacion.Size = New System.Drawing.Size(422, 21)
        Me.cbxRacion.TabIndex = 4
        '
        'txtIdRacion
        '
        Me.txtIdRacion.BackColor = System.Drawing.Color.Teal
        Me.txtIdRacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdRacion.Location = New System.Drawing.Point(9, 15)
        Me.txtIdRacion.Name = "txtIdRacion"
        Me.txtIdRacion.Size = New System.Drawing.Size(105, 20)
        Me.txtIdRacion.TabIndex = 26
        Me.txtIdRacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdRacion.Visible = False
        '
        'txtIdCorral
        '
        Me.txtIdCorral.BackColor = System.Drawing.Color.Teal
        Me.txtIdCorral.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdCorral.Location = New System.Drawing.Point(120, 15)
        Me.txtIdCorral.Name = "txtIdCorral"
        Me.txtIdCorral.Size = New System.Drawing.Size(105, 20)
        Me.txtIdCorral.TabIndex = 27
        Me.txtIdCorral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIdCorral.Visible = False
        '
        'cbxCorral
        '
        Me.cbxCorral.FormattingEnabled = True
        Me.cbxCorral.Location = New System.Drawing.Point(99, 133)
        Me.cbxCorral.Name = "cbxCorral"
        Me.cbxCorral.Size = New System.Drawing.Size(422, 21)
        Me.cbxCorral.TabIndex = 29
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 346)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(413, 64)
        Me.txtObservaciones.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 349)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Observaciones"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(423, 16)
        Me.txtFecha.MaxLength = 250
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(99, 20)
        Me.txtFecha.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(380, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Fecha"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 213)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Fibra"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 187)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Grano"
        '
        'txtKGGrano
        '
        Me.txtKGGrano.BackColor = System.Drawing.SystemColors.Window
        Me.txtKGGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKGGrano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKGGrano.Location = New System.Drawing.Point(107, 184)
        Me.txtKGGrano.MaxLength = 250
        Me.txtKGGrano.Name = "txtKGGrano"
        Me.txtKGGrano.Size = New System.Drawing.Size(101, 20)
        Me.txtKGGrano.TabIndex = 41
        Me.txtKGGrano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpConcentrado
        '
        Me.txtImpConcentrado.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpConcentrado.Enabled = False
        Me.txtImpConcentrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpConcentrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpConcentrado.Location = New System.Drawing.Point(214, 236)
        Me.txtImpConcentrado.MaxLength = 250
        Me.txtImpConcentrado.Name = "txtImpConcentrado"
        Me.txtImpConcentrado.Size = New System.Drawing.Size(101, 20)
        Me.txtImpConcentrado.TabIndex = 47
        Me.txtImpConcentrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpFibra
        '
        Me.txtImpFibra.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpFibra.Enabled = False
        Me.txtImpFibra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpFibra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpFibra.Location = New System.Drawing.Point(214, 210)
        Me.txtImpFibra.MaxLength = 250
        Me.txtImpFibra.Name = "txtImpFibra"
        Me.txtImpFibra.Size = New System.Drawing.Size(101, 20)
        Me.txtImpFibra.TabIndex = 51
        Me.txtImpFibra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Concentrado"
        '
        'txtKGConcentrado
        '
        Me.txtKGConcentrado.BackColor = System.Drawing.SystemColors.Window
        Me.txtKGConcentrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKGConcentrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKGConcentrado.Location = New System.Drawing.Point(107, 236)
        Me.txtKGConcentrado.MaxLength = 250
        Me.txtKGConcentrado.Name = "txtKGConcentrado"
        Me.txtKGConcentrado.Size = New System.Drawing.Size(101, 20)
        Me.txtKGConcentrado.TabIndex = 53
        Me.txtKGConcentrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKGFibra
        '
        Me.txtKGFibra.BackColor = System.Drawing.SystemColors.Window
        Me.txtKGFibra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKGFibra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKGFibra.Location = New System.Drawing.Point(107, 210)
        Me.txtKGFibra.MaxLength = 250
        Me.txtKGFibra.Name = "txtKGFibra"
        Me.txtKGFibra.Size = New System.Drawing.Size(101, 20)
        Me.txtKGFibra.TabIndex = 54
        Me.txtKGFibra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "KG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Impote"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Porcentaje %"
        '
        'txtImpGrano
        '
        Me.txtImpGrano.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpGrano.Enabled = False
        Me.txtImpGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpGrano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpGrano.Location = New System.Drawing.Point(214, 184)
        Me.txtImpGrano.MaxLength = 250
        Me.txtImpGrano.Name = "txtImpGrano"
        Me.txtImpGrano.Size = New System.Drawing.Size(101, 20)
        Me.txtImpGrano.TabIndex = 59
        Me.txtImpGrano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPorcenConcentrado
        '
        Me.txtPorcenConcentrado.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPorcenConcentrado.Enabled = False
        Me.txtPorcenConcentrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcenConcentrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPorcenConcentrado.Location = New System.Drawing.Point(321, 236)
        Me.txtPorcenConcentrado.MaxLength = 250
        Me.txtPorcenConcentrado.Name = "txtPorcenConcentrado"
        Me.txtPorcenConcentrado.Size = New System.Drawing.Size(101, 20)
        Me.txtPorcenConcentrado.TabIndex = 60
        Me.txtPorcenConcentrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPorcenFibra
        '
        Me.txtPorcenFibra.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPorcenFibra.Enabled = False
        Me.txtPorcenFibra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcenFibra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPorcenFibra.Location = New System.Drawing.Point(321, 210)
        Me.txtPorcenFibra.MaxLength = 250
        Me.txtPorcenFibra.Name = "txtPorcenFibra"
        Me.txtPorcenFibra.Size = New System.Drawing.Size(101, 20)
        Me.txtPorcenFibra.TabIndex = 61
        Me.txtPorcenFibra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPorcenGrano
        '
        Me.txtPorcenGrano.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPorcenGrano.Enabled = False
        Me.txtPorcenGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcenGrano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPorcenGrano.Location = New System.Drawing.Point(321, 184)
        Me.txtPorcenGrano.MaxLength = 250
        Me.txtPorcenGrano.Name = "txtPorcenGrano"
        Me.txtPorcenGrano.Size = New System.Drawing.Size(101, 20)
        Me.txtPorcenGrano.TabIndex = 62
        Me.txtPorcenGrano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKGOtros
        '
        Me.txtKGOtros.BackColor = System.Drawing.SystemColors.Window
        Me.txtKGOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKGOtros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKGOtros.Location = New System.Drawing.Point(108, 262)
        Me.txtKGOtros.MaxLength = 250
        Me.txtKGOtros.Name = "txtKGOtros"
        Me.txtKGOtros.Size = New System.Drawing.Size(101, 20)
        Me.txtKGOtros.TabIndex = 63
        Me.txtKGOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpOtros
        '
        Me.txtImpOtros.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpOtros.Enabled = False
        Me.txtImpOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpOtros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpOtros.Location = New System.Drawing.Point(214, 262)
        Me.txtImpOtros.MaxLength = 250
        Me.txtImpOtros.Name = "txtImpOtros"
        Me.txtImpOtros.Size = New System.Drawing.Size(101, 20)
        Me.txtImpOtros.TabIndex = 64
        Me.txtImpOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPorcenOtros
        '
        Me.txtPorcenOtros.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPorcenOtros.Enabled = False
        Me.txtPorcenOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcenOtros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPorcenOtros.Location = New System.Drawing.Point(321, 262)
        Me.txtPorcenOtros.MaxLength = 250
        Me.txtPorcenOtros.Name = "txtPorcenOtros"
        Me.txtPorcenOtros.Size = New System.Drawing.Size(101, 20)
        Me.txtPorcenOtros.TabIndex = 65
        Me.txtPorcenOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Otros"
        '
        'txtImpTotal
        '
        Me.txtImpTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtImpTotal.Enabled = False
        Me.txtImpTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImpTotal.Location = New System.Drawing.Point(214, 288)
        Me.txtImpTotal.MaxLength = 250
        Me.txtImpTotal.Name = "txtImpTotal"
        Me.txtImpTotal.Size = New System.Drawing.Size(101, 20)
        Me.txtImpTotal.TabIndex = 67
        Me.txtImpTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKGTotal
        '
        Me.txtKGTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtKGTotal.Enabled = False
        Me.txtKGTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKGTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKGTotal.Location = New System.Drawing.Point(108, 288)
        Me.txtKGTotal.MaxLength = 250
        Me.txtKGTotal.Name = "txtKGTotal"
        Me.txtKGTotal.Size = New System.Drawing.Size(101, 20)
        Me.txtKGTotal.TabIndex = 68
        Me.txtKGTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Turno"
        '
        'rdbMañana
        '
        Me.rdbMañana.AutoSize = True
        Me.rdbMañana.Location = New System.Drawing.Point(108, 319)
        Me.rdbMañana.Name = "rdbMañana"
        Me.rdbMañana.Size = New System.Drawing.Size(64, 17)
        Me.rdbMañana.TabIndex = 71
        Me.rdbMañana.TabStop = True
        Me.rdbMañana.Text = "Mañana"
        Me.rdbMañana.UseVisualStyleBackColor = True
        '
        'rdbTarde
        '
        Me.rdbTarde.AutoSize = True
        Me.rdbTarde.Location = New System.Drawing.Point(178, 319)
        Me.rdbTarde.Name = "rdbTarde"
        Me.rdbTarde.Size = New System.Drawing.Size(53, 17)
        Me.rdbTarde.TabIndex = 72
        Me.rdbTarde.TabStop = True
        Me.rdbTarde.Text = "Tarde"
        Me.rdbTarde.UseVisualStyleBackColor = True
        '
        'txtGrano
        '
        Me.txtGrano.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGrano.Enabled = False
        Me.txtGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrano.ForeColor = System.Drawing.Color.Black
        Me.txtGrano.Location = New System.Drawing.Point(99, 91)
        Me.txtGrano.MaxLength = 250
        Me.txtGrano.Name = "txtGrano"
        Me.txtGrano.Size = New System.Drawing.Size(101, 18)
        Me.txtGrano.TabIndex = 73
        '
        'txtFibra
        '
        Me.txtFibra.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtFibra.Enabled = False
        Me.txtFibra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFibra.ForeColor = System.Drawing.Color.Black
        Me.txtFibra.Location = New System.Drawing.Point(206, 91)
        Me.txtFibra.MaxLength = 250
        Me.txtFibra.Name = "txtFibra"
        Me.txtFibra.Size = New System.Drawing.Size(101, 18)
        Me.txtFibra.TabIndex = 74
        '
        'txtConcentrado
        '
        Me.txtConcentrado.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtConcentrado.Enabled = False
        Me.txtConcentrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcentrado.ForeColor = System.Drawing.Color.Black
        Me.txtConcentrado.Location = New System.Drawing.Point(313, 91)
        Me.txtConcentrado.MaxLength = 250
        Me.txtConcentrado.Name = "txtConcentrado"
        Me.txtConcentrado.Size = New System.Drawing.Size(101, 18)
        Me.txtConcentrado.TabIndex = 75
        '
        'txtOtros
        '
        Me.txtOtros.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtOtros.Enabled = False
        Me.txtOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtros.ForeColor = System.Drawing.Color.Black
        Me.txtOtros.Location = New System.Drawing.Point(420, 91)
        Me.txtOtros.MaxLength = 250
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(101, 18)
        Me.txtOtros.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(134, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Grano"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(244, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Fibra"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(327, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Concentrado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(460, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Otro"
        '
        'lblImpGrano
        '
        Me.lblImpGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpGrano.Location = New System.Drawing.Point(99, 113)
        Me.lblImpGrano.Name = "lblImpGrano"
        Me.lblImpGrano.Size = New System.Drawing.Size(101, 20)
        Me.lblImpGrano.TabIndex = 81
        Me.lblImpGrano.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblImpFibra
        '
        Me.lblImpFibra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpFibra.Location = New System.Drawing.Point(206, 113)
        Me.lblImpFibra.Name = "lblImpFibra"
        Me.lblImpFibra.Size = New System.Drawing.Size(101, 20)
        Me.lblImpFibra.TabIndex = 82
        Me.lblImpFibra.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblImpConcentrado
        '
        Me.lblImpConcentrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpConcentrado.Location = New System.Drawing.Point(313, 113)
        Me.lblImpConcentrado.Name = "lblImpConcentrado"
        Me.lblImpConcentrado.Size = New System.Drawing.Size(101, 20)
        Me.lblImpConcentrado.TabIndex = 83
        Me.lblImpConcentrado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblImpOtros
        '
        Me.lblImpOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpOtros.Location = New System.Drawing.Point(420, 113)
        Me.lblImpOtros.Name = "lblImpOtros"
        Me.lblImpOtros.Size = New System.Drawing.Size(101, 20)
        Me.lblImpOtros.TabIndex = 84
        Me.lblImpOtros.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.lblImpOtros)
        Me.gbxDatos.Controls.Add(Me.lblImpConcentrado)
        Me.gbxDatos.Controls.Add(Me.lblImpFibra)
        Me.gbxDatos.Controls.Add(Me.lblImpGrano)
        Me.gbxDatos.Controls.Add(Me.Label14)
        Me.gbxDatos.Controls.Add(Me.Label13)
        Me.gbxDatos.Controls.Add(Me.Label11)
        Me.gbxDatos.Controls.Add(Me.Label7)
        Me.gbxDatos.Controls.Add(Me.txtOtros)
        Me.gbxDatos.Controls.Add(Me.txtConcentrado)
        Me.gbxDatos.Controls.Add(Me.txtFibra)
        Me.gbxDatos.Controls.Add(Me.txtGrano)
        Me.gbxDatos.Controls.Add(Me.rdbTarde)
        Me.gbxDatos.Controls.Add(Me.rdbMañana)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.txtKGTotal)
        Me.gbxDatos.Controls.Add(Me.txtImpTotal)
        Me.gbxDatos.Controls.Add(Me.Label12)
        Me.gbxDatos.Controls.Add(Me.txtPorcenOtros)
        Me.gbxDatos.Controls.Add(Me.txtImpOtros)
        Me.gbxDatos.Controls.Add(Me.txtKGOtros)
        Me.gbxDatos.Controls.Add(Me.txtPorcenGrano)
        Me.gbxDatos.Controls.Add(Me.txtPorcenFibra)
        Me.gbxDatos.Controls.Add(Me.txtPorcenConcentrado)
        Me.gbxDatos.Controls.Add(Me.txtImpGrano)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtKGFibra)
        Me.gbxDatos.Controls.Add(Me.txtKGConcentrado)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.txtImpFibra)
        Me.gbxDatos.Controls.Add(Me.txtImpConcentrado)
        Me.gbxDatos.Controls.Add(Me.txtKGGrano)
        Me.gbxDatos.Controls.Add(Me.Label18)
        Me.gbxDatos.Controls.Add(Me.Label19)
        Me.gbxDatos.Controls.Add(Me.Label10)
        Me.gbxDatos.Controls.Add(Me.txtFecha)
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.txtObservaciones)
        Me.gbxDatos.Controls.Add(Me.cbxCorral)
        Me.gbxDatos.Controls.Add(Me.txtIdCorral)
        Me.gbxDatos.Controls.Add(Me.txtIdRacion)
        Me.gbxDatos.Controls.Add(Me.cbxRacion)
        Me.gbxDatos.Controls.Add(Me.label)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(12, 35)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(528, 416)
        Me.gbxDatos.TabIndex = 26
        Me.gbxDatos.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(528, 23)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ALIMENTACION"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAlimentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 503)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbxDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlimentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAlimentacion"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents cbxRacion As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdRacion As System.Windows.Forms.Label
    Friend WithEvents txtIdCorral As System.Windows.Forms.Label
    Friend WithEvents cbxCorral As System.Windows.Forms.ComboBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtKGGrano As System.Windows.Forms.TextBox
    Friend WithEvents txtImpConcentrado As System.Windows.Forms.TextBox
    Friend WithEvents txtImpFibra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKGConcentrado As System.Windows.Forms.TextBox
    Friend WithEvents txtKGFibra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtImpGrano As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcenConcentrado As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcenFibra As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcenGrano As System.Windows.Forms.TextBox
    Friend WithEvents txtKGOtros As System.Windows.Forms.TextBox
    Friend WithEvents txtImpOtros As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcenOtros As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtImpTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtKGTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdbMañana As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTarde As System.Windows.Forms.RadioButton
    Friend WithEvents txtGrano As System.Windows.Forms.TextBox
    Friend WithEvents txtFibra As System.Windows.Forms.TextBox
    Friend WithEvents txtConcentrado As System.Windows.Forms.TextBox
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblImpGrano As System.Windows.Forms.Label
    Friend WithEvents lblImpFibra As System.Windows.Forms.Label
    Friend WithEvents lblImpConcentrado As System.Windows.Forms.Label
    Friend WithEvents lblImpOtros As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
