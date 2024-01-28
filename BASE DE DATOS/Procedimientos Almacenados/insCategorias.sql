CREATE DEFINER=`root`@`localhost` PROCEDURE `insCategorias`(
	in cCategoria varchar(250)
    )
BEGIN
	INSERT INTO Categorias (
		Categoria
)
	VALUES (cCategoria);
END