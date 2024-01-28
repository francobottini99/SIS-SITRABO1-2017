CREATE DEFINER=`root`@`localhost` PROCEDURE `insCorrales`(
	in cNom varchar(250),
	in cSup int(11),
    in cCab int(11),
    in cIdCam int(11)
)
BEGIN
	INSERT INTO Corrales (
		NombreCorral,
		Superficie,
		CabezasTotales,
        CAMPO_idCampo
)
	VALUES (cNom, cSup, cCab, cIdCam);
END