CREATE DEFINER=`root`@`localhost` PROCEDURE `verDtCorrPorTropa`(
	in IdC int(11),
	in Idt int(11)
)
BEGIN
	SELECT
		*
	FROM
		Detalle_Corrales
	WHERE
		CORRALES_idCorrales = IdC And TROPA_idTropa = Idt;
END