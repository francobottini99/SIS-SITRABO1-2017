CREATE DEFINER=`root`@`localhost` PROCEDURE `insProductor`(
	in pNom varchar(250),
	in pDir varchar(250),
	in pLoc varchar(250),
	in pCP varchar(45),
	in pCuit varchar(45)
)
BEGIN
	INSERT INTO Productor (
		RazonSocial,
		Direccion,
		Localidad,
		CP,
		CUIT
)
	VALUES (pNom, pDir, pLoc, pCP, pCuit);
END