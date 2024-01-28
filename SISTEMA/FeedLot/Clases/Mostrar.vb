Imports MySql.Data.MySqlClient

Public Class Mostrar
    Public Function verCampos()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCampos"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Campos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCategoria()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCategoria"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar las categorias" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCorrales()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verCorrales"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los corrales" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleCorral()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verDetalleCorral"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los corrales" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleTropa()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verDetalleTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar Detalle Tropa" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verProductor()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verProductor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Productores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verProveedor()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verProveedor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Proveedores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTropa()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar las tropas" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verRacion()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verRacion"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar las raciones" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStock(ByVal IDT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verStock"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@ID"), MySqlParameter).Value = IDT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar el stock" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdTropa()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMaxIdTropa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Tropa no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdAlimentacion()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.verMaxIdAlimentacion"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Alimentacion no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consDetalleCorral(ByVal idDC As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropaCorral"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCorr"), MySqlParameter).Value = idDC

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar el detalle por corral" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDtCorrPorTropa(ByVal idDC As Integer, ByVal idDT As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consDetalleTropayCorral"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@IdDC"), MySqlParameter).Value = idDC
            CType(_cMd.Parameters("@IdDT"), MySqlParameter).Value = idDT

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar el detalle por corral" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlimentacion()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "feedlot.consAlimentacion"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Alimentacion no puede cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    'Public Function consStock(ByVal uNN As String)
    '    Try
    '        Dim _cMd As New MySqlCommand

    '        BDcnn()
    '        _cMd.CommandText = "conStock"
    '        _cMd.CommandType = CommandType.StoredProcedure
    '        _cMd.Connection = _cX

    '        MySqlCommandBuilder.DeriveParameters(_cMd)
    '        CType(_cMd.Parameters("@idUN"), MySqlParameter).Value = uNN

    '        Dim _dA As New MySqlDataAdapter(_cMd)
    '        Dim _Dt As New DataTable
    '        _dA.Fill(_Dt)
    '        BDxxx()

    '        Return _Dt
    '    Catch ex As MySqlException
    '        MsgBox("Error al cargar stocks" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
    '        Return Nothing
    '    Finally
    '        BDxxx()
    '    End Try
    'End Function

End Class
