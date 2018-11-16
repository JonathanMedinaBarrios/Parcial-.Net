create function BuscarIdGrupo(varchar) returns Integer 
as 
$$
    SELECT id_grupo FROM grupos 
    where nombre = $1

$$
language SQl 