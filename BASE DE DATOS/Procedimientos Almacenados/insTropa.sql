CREATE DEFINER=`root`@`localhost` PROCEDURE `insTropa`(
	in tNom varchar(250),
	in tProc varchar(250),
    in tFec date,
    in tCab int(11),
    in tKgCab double,
    in tKgt int(11),
    in tIdpd int(11),
    in tIdCam int(11),
    in tIdpv int(11)
)
BEGIN
	INSERT INTO Tropa (
		NombreTropa,
		OrigenProcedencia,
		FechaIngreso,
        Cabezas,
        PesoIngreso,
        TotalKgTropa,
        PRODUCTOR_idProductor,
        CAMPO_idCampo,
        PROVEEDOR_idProveedor
)
	VALUES (tNom, tProc, tFec, tCab, tKgCab, tKgt, tIdpd, tIdCam, tIdpv);
END