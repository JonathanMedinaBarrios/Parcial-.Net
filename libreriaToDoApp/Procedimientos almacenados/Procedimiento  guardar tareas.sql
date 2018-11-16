CREATE OR REPLACE function insertarTareas(varchar,varchar,date,date,int,int) returns void 
as
$$
  INSERT INTO tareas(Nombre,Prioridad,fechaInicio ,fechaFinalizacion,porcentaje,Id_Grupo)
	 values($1,$2,$3,$4,$5,$6);
$$
language SQL ;