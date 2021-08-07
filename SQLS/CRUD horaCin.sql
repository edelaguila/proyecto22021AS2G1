use cinevision;

-- procedures para CRUD de horarioCine
desc horariocine;
-- antes, cambiaremos la tabla y agregamos horario por separado.

drop table horariocine;

create table horarios(
	idHorario int,
    fechaHora timestamp
);

ALTER TABLE horarios
  ADD PRIMARY KEY (idHorario);
  
ALTER TABLE horarios
  MODIFY idHorario int NOT NULL AUTO_INCREMENT;
  
-- tabla con los horarios por defecto del cine

CREATE TABLE `horariocine` (
  `idhorarioCine` int NOT NULL,
  `fkPelicula` int DEFAULT NULL,
  `fkSala` int NOT NULL,
  `fkHorario` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `horariocine`
  ADD PRIMARY KEY (`idhorarioCine`),
  ADD KEY `fkhcinP` (`fkPelicula`),
  ADD KEY `fkhcinSa` (`fkSala`),
  ADD KEY `fkHrr`(`fkHorario`);
  
ALTER TABLE `horariocine`
  MODIFY `idhorarioCine` int NOT NULL AUTO_INCREMENT;
  
-- con tablas para horarios y horariocine

-- procedures:
-- ingreso de horario:;

DELIMITER |
CREATE PROCEDURE ingHorarioCi(in peli int, in sala int, in hora int)
BEGIN
	insert into horariocine(fkPelicula,fkSala,fkHorario) values(peli,sala,hora);
END
| 

call ingHorarioCi(1,1,1);

-- modificacion de horario

DELIMITER |
CREATE PROCEDURE modifHorarioCi(in peli int, in sala int, in hora int, in id int)
BEGIN
	update horariocine set fkPelicula=peli, fkSala=sala, fkHorario=hora where idhorarioCine=id;
END
| 

call modifHorarioCi(1,1,1,1);

-- consulta general horarios:

DELIMITER |
CREATE PROCEDURE conGenHorarioCi()
BEGIN
	select hc.idhorarioCine as id, pe.Nombre as Pelicula, ho.fechaHora as horario 
	from horariocine hc 
	INNER JOIN peliculas pe on pe.idPeliculas = hc.fkPelicula
	INNER JOIN horarios ho on ho.idHorario = hc.fkHorario;
END
|

call conGenHorarioCi();
-- desc horarios;
/*select hc.idhorarioCine as id, pe.Nombre as Pelicula, ho.fechaHora as horario 
from horariocine hc 
INNER JOIN peliculas pe on pe.idPeliculas = hc.fkPelicula
INNER JOIN horarios ho on ho.idHorario = hc.fkHorario;
*/

-- consulta individual

DELIMITER |
CREATE PROCEDURE conGenHorarioCiInd(in id int)
BEGIN
	select hc.idhorarioCine as id, pe.Nombre as Pelicula, ho.fechaHora as horario 
	from horariocine hc 
	INNER JOIN peliculas pe on pe.idPeliculas = hc.fkPelicula
	INNER JOIN horarios ho on ho.idHorario = hc.fkHorario
    where hc.idhorarioCine=id;
END
|

call conGenHorarioCiInd(1);

-- consulta horarios
select fechaHora as horario from horarios;

-- insert de horarios:
insert into horarios(fechaHora) values ('2021-10-21 09:00:00');
insert into horarios(fechaHora) values ('2027-12-02 19:00:00');

-- insert de salas
insert into salas(fkCine, Descripción, formatoPeli, puntos, precioSala) values
(1,'sala full hd 4+','mkv',100,100.00),
(2,'imax','mp4',70,70.00),
(3,'dolby atmosphere audio','flv',65,65.00),
(4,'144p','gpo',40,40.00);

-- inser peli
insert into peliculas(Nombre,Clasificación,Genero,Subtitulado,Idioma,precio) values
('No Game No Life Zero','T','Anime','Español','Japonés',500.00),
('Fate/stay night UBW','T','Anime','Español','Japonés',450.00)

-- prueba de insert horariocine:
-- peli, sala, horario
call ingHorarioCi(1,1,1);
call ingHorarioCi(1,2,2);

call conGenHorarioCi();
call conGenHorarioCiInd(1);