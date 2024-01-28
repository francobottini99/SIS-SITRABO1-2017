CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleAlimentacion`(
	in daKgG double,
	in daKgC double,
    in daKgF double,
    in daKgO double,
    in daImpG double,
    in daImpC double,
    in daImpF double,
    in daImpO double,
    in daImpT double,
    in daPorcG double,
    in daPorcC double,
    in daPorcF double,
    in daPorcO double,
	in daIDA int(11)
    
)
BEGIN
	INSERT INTO detalle_alimentacion (
		KgGrano,
		KgConcentrado,
		KgFibra,
        KgOtros,
        ImporteGrano,
        ImporteConcentrado,
        ImporteFibra,
        ImporteOtros,
        ImporteTotal,
        PorcentajeGrano,
        PorcentajeConc,
        PorcentajeFibra,
        PorcentajeOtros,
        ALIMENTACION_idAlimentacion
)
	VALUES (daKgG, daKgC, daKgF, daKgO, daImpG, daImpC, daImpF, daImpO, daImpT, daPorcG, daPorcC, daPorcF, daPorcO, daIDA);
END