CREATE DEFINER=`root`@`localhost` PROCEDURE `consDetalleTropayCorral`(
	in idDC int(11),
    in idDT int(11)
)
BEGIN
	SELECT
		Corrales.idCorrales,
        Corrales.NombreCorral,
        Corrales.Superficie,
        Corrales.CabezasTotales,
        Tropa.idTropa,
        Tropa.NombreTropa,
        Tropa.OrigenProcedencia,
        Tropa.FechaIngreso,
        Tropa.Cabezas,
        Detalle_Tropa.IdDetTropa,
        Categorias.Categoria,
        Detalle_Tropa.Cabezas
	FROM
		Corrales JOIN Detalle_Corrales ON Corrales.IdCorrales = Detalle_Corrales.CORRALES_idCorrales
        JOIN Tropa ON Detalle_Corrales.TROPA_idTropa = Tropa.idTropa
        JOIN Detalle_Tropa ON Detalle_Tropa.TROPA_idTropa = Tropa.idTropa
        JOIN Categorias ON Detalle_Tropa.CATEGORIAS_idCategorias = Categorias.idCategorias
	WHERE
		Corrales.IdCorrales = idDC And Tropa.idTropa = idDT
	ORDER BY Tropa.IdTropa Asc;
END