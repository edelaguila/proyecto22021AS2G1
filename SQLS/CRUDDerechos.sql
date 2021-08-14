use cinevision;
select * from peliculas;

DELIMITER |
CREATE PROCEDURE consultaDerechosPeli()
BEGIN
	select idPeliculas as ID, nombre as Pelicula, estadoDerechos as estadoDerecho from 
    peliculas, derechos where idPeliculas=fkPelicula;
END
|
call consultaDerechosPeli();

DELIMITER |
CREATE PROCEDURE consultaDP(in id int)
BEGIN
	select idPeliculas as ID, nombre as Pelicula, clasificación, genero, sinopsis, estadoDerechos as estadoDerecho from 
    peliculas, derechos where idPeliculas=fkPelicula and idDerechos=id;
END
|
drop procedure consultaDP;
call consultaDP(10);

DELIMITER |
CREATE PROCEDURE elimPeliD(in id int)
BEGIN
	update derechos set estadoDerechos = 0 where idDerechos=id;
END
|
call elimPeliD(1);

DELIMITER |
CREATE PROCEDURE altaPeliD(in id int)
BEGIN
	update derechos set estadoDerechos = 1 where idDerechos=id;
END
|


select * from derechos;
select * from peliculas;
use cinevision;
-- horarios
-- ingreso de horarios

DELIMITER |
CREATE PROCEDURE ingresoHorario(in fecha varchar(25))
BEGIN
	insert into horarios(fechaHora) values (fecha);
END
|

-- formato fecha hora:
-- YY-MM-DD hh:mm:ss
insert into horarios(fechaHora) values ("2021-08-14 11:22:00");
select * from horarios;
call ingresoHorario("2021-08-14 15:00:00");

select * from salas;

DELIMITER |
CREATE PROCEDURE consultaSala()
BEGIN
	select idSalas as ID, Descripción, formatoPeli, nombre as cine, direccion from
    Salas, Cines where Salas.fkCine=Cines.idCines;
END
|

call consultaSala();

call conGenHorarioCi();

drop procedure conGenHorarioCi;

DELIMITER |
CREATE PROCEDURE `conGenHorarioCi`()
BEGIN
	select hc.idhorarioCine as ID, pe.Nombre as Pelicula, ho.fechaHora as Horario,
    sa.Descripción as Descripcion_Sala, sa.formatoPeli as Formato
	from horariocine hc 
	INNER JOIN peliculas pe on pe.idPeliculas = hc.fkPelicula
	INNER JOIN horarios ho on ho.idHorario = hc.fkHorario
    INNER JOIN salas sa on sa.idSalas = hc.fkSala;
END
|