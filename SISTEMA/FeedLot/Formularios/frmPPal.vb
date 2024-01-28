Imports System.Windows.Forms
Imports MySql.Data.MySqlClient


Public Class frmPPal

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmPPal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "SISTEMA DE GESTION Y ADMINISTRACION DE FEED LOT"

        Try
            BDcnn()

            'Configurando mis separadores personales
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
            System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        Catch ex As MySqlException
            MsgBox("Servidor no disponible!" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
        End Try

    End Sub

    Private Sub ProductorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductorToolStripMenuItem.Click
        frmProductor.MdiParent = Me
        frmProductor.Show()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        frmProveedor.MdiParent = Me
        frmProveedor.Show()
    End Sub

    Private Sub CampoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CampoToolStripMenuItem.Click
        frmCampo.MdiParent = Me
        frmCampo.Show()
    End Sub

    Private Sub CorralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorralesToolStripMenuItem.Click
        frmCorrales.MdiParent = Me
        frmCorrales.Show()
    End Sub

    Private Sub TropaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TropaToolStripMenuItem1.Click
        frmTropa.MdiParent = Me
        frmTropa.Show()
    End Sub

    Private Sub RacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RacionesToolStripMenuItem.Click
        frmRaciones.MdiParent = Me
        frmRaciones.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        frmCategorias.MdiParent = Me
        frmCategorias.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        frmCompras.MdiParent = Me
        frmCompras.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        frmVentas.MdiParent = Me
        frmVentas.Show()
    End Sub

    Private Sub AlimentacionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlimentacionToolStripMenuItem1.Click
        frmAlimentacion.MdiParent = Me
        frmAlimentacion.Show()
    End Sub

    Private Sub MovimientosInternosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosInternosToolStripMenuItem.Click
        frmMovimiento.MdiParent = Me
        frmMovimiento.Show()
    End Sub

    Private Sub SanidadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SanidadToolStripMenuItem1.Click
        frmSanidad.MdiParent = Me
        frmSanidad.Show()
    End Sub

    Private Sub ConsultarAlimentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarAlimentaciónToolStripMenuItem.Click
        frmConsAlimentacion.MdiParent = Me
        frmConsAlimentacion.Show()
    End Sub
End Class
