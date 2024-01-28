CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetCorral`(
	in IdC int(11),
	in Idt int(11),
    in mCabT int(11)
)
BEGIN
	UPDATE Detalle_Corrales
	SET 
		CabezasTropa = mCabT
	WHERE 
		CORRALES_idCorrales = IdC And TROPA_idTropa = Idt;
END