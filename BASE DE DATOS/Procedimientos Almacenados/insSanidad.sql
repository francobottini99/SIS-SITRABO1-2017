CREATE DEFINER=`root`@`localhost` PROCEDURE `insSanidad`(
	in sFec date,
	in sTrat varchar(250),
	in sImp double,
	in sObs varchar(250),
    in sIdt int(11)
)
BEGIN
	INSERT INTO Sanidad (
		Fecha,
		Tratamiento,
		Importe,
		Observaciones,
        TROPA_idTropa
)
	VALUES (sFec, sTrat, sImp, sObs, sIdt);
END