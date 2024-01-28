CREATE DEFINER=`root`@`localhost` PROCEDURE `insRacion`(
	in rNom varchar(250),
	in rGrano varchar(250),
    in rConcentrado varchar(250),
    in rFibra varchar(250),
    in rOtros varchar(250),
    in rCostGrano double,
    in rCostConcentrado double,
    in rCostFibra double,
    in rCostOtros double
)
BEGIN
	INSERT INTO Raciones (
		NombreRacion,
		Grano,
		Concentrado,
        Fibra,
        Otros,
        CostoGrano,
        CostoConcentrado,
        CostoFibra,
        CostoOtros
)
	VALUES (rNom, rGrano, rConcentrado, rFibra, rOtros, rCostGrano, rCostConcentrado, rCostFibra, rCostOtros);
END