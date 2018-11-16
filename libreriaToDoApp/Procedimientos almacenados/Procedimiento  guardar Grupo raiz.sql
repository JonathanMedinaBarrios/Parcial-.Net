create function GuadarGrupoPadre(varchar,int) returns void 
as 
$$
	INSERT INTO Grupos(Nombre, Id_Usuario)
	           values ($1,$2)
$$
language SQL 