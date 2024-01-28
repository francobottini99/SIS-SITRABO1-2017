CREATE DEFINER=`root`@`localhost` PROCEDURE `insVenta`(
	in vFecha date,
	in vCabezas double,
	in vKgTotales double,
    in vKgCabeza double,
	in vImpSinIVAKG double,
	in vImpSinIVACab double,
    in vIVA double,
    in vImpConIVAKG double,
    in vImpConIVACab double,
    in vImpTotal double,
    in vFlete double,
    in vOtros double,
    in vImpNETO double,
    in vIDTropa int(11)
)
BEGIN
	INSERT INTO Ventas (
		Fecha,
		Cabezas,
		KgVendidos,
        KgPorCabeza,
		PrecioVtaSinIvaPorKg,
		ImporteVtaSinIvaPorCabeza,
        AlicuotaIva,
        PrecioVtaConIvaPorKg,
        ImporteVtaConIvaPorCabeza,
        ImporteTotalVenta,
        Flete,
        OtrosCostos,
        ImporteNetoVenta,
        TROPA_idTropa
)
	VALUES (vFecha, vCabezas, vKgTotales, vKgCabeza, vImpSinIVAKG, vImpSinIVACab, vIVA, vImpConIVAKG, vImpConIVACab, vImpTotal, vFlete, vOtros, vImpNETO, vIDTropa);
END