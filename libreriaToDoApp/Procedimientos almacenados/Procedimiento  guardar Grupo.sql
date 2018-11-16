create function GuadarGrupoHijo(varchar,int, int) returns void 
as 
$$
	INSERT INTO Grupos(Nombre, Id_Usuario,Id_GrupoPadre)
	           values ($1,$2,$3)
$$
language SQL 