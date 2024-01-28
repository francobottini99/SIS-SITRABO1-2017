CREATE DEFINER=`root`@`localhost` PROCEDURE `insCompra`(
	in cFecha date,
	in cCostSinIVAKG double,
	in cCostSinIVACab double,
    in cAliCuotaIVA double,
	in cCostConIVAKG double,
	in cCostConIVACab double,
    in cCostFlete double,
    in cCostOtros double,
    in cCostFinalKG double,
    in cCostFinalCab double,
    in cCostFinalTropa double,
    in cFormaPago varchar(250),
    in cIDTropa int(11),
    in cIDProv int(11)
)
BEGIN
	INSERT INTO Compras (
		Fecha,
		CostoSinIvaPorKg,
		CostoSinIvaPorCabeza,
        AlicuotaIVA,
		CostoConIvaPorKg,
		CostoConIvaPorCabeza,
        CostoConIvaFlete,
        OtrosCostos,
        CostoFinalPorKg,
        CostoFinalPorCabeza,
        CostoTotalTropa,
        FormaPago,
        TROPA_idTropa,
        PROVEEDOR_idProveedor
)
	VALUES (cFecha, cCostSinIVAKG, cCostSinIVACab, cAliCuotaIVA, cCostConIVAKG, cCostConIVACab, cCostFlete, cCostOtros, cCostFinalKG, cCostFinalCab, cCostFinalTropa, cFormaPago, cIDTropa, cIDProv);
END