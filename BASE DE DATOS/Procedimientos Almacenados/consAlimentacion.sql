CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlimentacion`(
)
BEGIN
	SELECT
		Productor.idProductor,
        Productor.RazonSocial,
        Corrales.idCorrales,
        Corrales.NombreCorral,
        Corrales.CabezasTotales,
        Detalle_Tropa.TROPA_idTropa,
        Detalle_Tropa.Cabezas,
        Detalle_Corrales.CabezasTropa,
        Alimentacion.Fecha,
        Alimentacion.KgRacion,
        Detalle_Alimentacion.KgGrano,
        Detalle_Alimentacion.KgConcentrado,
        Detalle_Alimentacion.KgFibra,
        Detalle_Alimentacion.KgOtros,
        Detalle_Alimentacion.ImporteGrano,
        Detalle_Alimentacion.ImporteConcentrado,
        Detalle_Alimentacion.ImporteFibra,
        Detalle_Alimentacion.ImporteOtros,
        Detalle_Alimentacion.ImporteTotal,
        Detalle_Alimentacion.PorcentajeGrano,
        Detalle_Alimentacion.PorcentajeConc,
        Detalle_Alimentacion.PorcentajeFibra,
        Detalle_Alimentacion.PorcentajeOtros
	FROM
		Detalle_Corrales JOIN Tropa ON Tropa.idTropa = Detalle_Corrales.TROPA_idTropa
        JOIN Detalle_Tropa ON Detalle_Tropa.TROPA_idTropa = Tropa.idTropa
		JOIN Productor ON Productor.idProductor = Tropa.PRODUCTOR_idProductor
        JOIN Corrales ON Corrales.idCorrales = Detalle_Corrales.CORRALES_idCorrales
        JOIN Alimentacion ON Alimentacion.CORRALES_idCorrales = Detalle_Corrales.CORRALES_idCorrales
        JOIN Detalle_Alimentacion ON Detalle_Alimentacion.ALIMENTACION_idAlimentacion = Alimentacion.idAlimentacion
	ORDER BY Alimentacion.Fecha Asc;
END