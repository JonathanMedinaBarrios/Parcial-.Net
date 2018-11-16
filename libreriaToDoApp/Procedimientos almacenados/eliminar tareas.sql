create function EliminarTareas(int) returns void 
as 
$$
	DELETE FROM tareas WHERE id_tarea=$1
$$
language SQL 

