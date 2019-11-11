CREATE PROCEDURE PHANTRANG_DANHMUC (@currentPage int, @pageSize int)
AS
BEGIN
	DECLARE @rowSelect int =(@currentPage * @pageSize)
	DECLARE @rowExcept int=(@currentPage -1)*@pageSize;

	SELECT TOP(@rowSelect) *from danhmuc
	EXCEPT
	SELECT TOP(@rowExcept) *from danhmuc
END