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