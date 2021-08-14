use cinevision;

insert into peliculas(Nombre,Clasificación,Genero,Subtitulado,Idioma,precio, sinopsis, estado) values("Rapidos y Furiosos 9", "T","Acción","Si","Español Latino",50,"Repollo",1);
insert into peliculas(Nombre,Clasificación,Genero,Subtitulado,Idioma,precio, sinopsis, estado) values("Spiderman 3", "T","Acción","Si","Español Latino",30,"Un clásico",1);
insert into peliculas(Nombre,Clasificación,Genero,Subtitulado,Idioma,precio, sinopsis, estado) values("COCO", "E","Aventura","No","Español Latino",40,"Sad",1);


/*CREATE TABLE `peliculas` (
  `idPeliculas` int auto_increment,
  `Nombre` varchar(45) DEFAULT NULL,
  `Clasificación` varchar(45) DEFAULT NULL,
  `Genero` varchar(45) DEFAULT NULL,
  `Subtitulado` varchar(45) DEFAULT NULL,
  `Idioma` varchar(45) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `sinopsis` varchar (100),
  `estado` tinyint default 1,
  PRIMARY KEY (`idPeliculas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;ENGINE=InnoDB DEFAULT CHARSET=utf8;*/


drop database cinevision;
/*Procedure de Insertar Película*/
DELIMITER //
create procedure insertPeli (in nom varchar(40), in  clas varchar(1), in gen varchar(30), in sub varchar(15), in lan varchar(15), in  precio int, in sinoPsis varchar (50), in esTado int) BEGIN 
		insert into peliculas (Nombre, Clasificacion, Genero, Subtitulado, Idioma, precio, sinopsis, estado) values (nom,clas,gen,sub,lan,precio,sinoPsis,esTado);
END//
-- drop procedure insertPeli;
-- use cinevision;

/*Procedures de Consulta*/
/*Consulta Individual*/

DELIMITER //
	CREATE PROCEDURE consultaInpeli (in id int) BEGIN
		select * from peliculas where id = peliculas.idPeliculas;
END//
 /*Consulta General*/
 DELIMITER // 
 CREATE PROCEDURE consultaGenpelis () BEGIN
	select * from peliculas;
END //

/*Procedure para Eliminar*/
DELIMITER // 
CREATE PROCEDURE elimPelis (in id int) BEGIN
	UPDATE peliculas set estado = 0 where id = idPeliculas;
    END//

/*Procedure para Actualizar*/
DELIMITER //
	CREATE PROCEDURE actuPelis (in id int,in nom varchar(40), in  clas varchar(1), in gen varchar(30), in sub varchar(15), in lan varchar(15), in  preciop int, in sinopsisp varchar (50), in estate int)
    UPDATE peliculas set Nombre = nom, Clasificación = clas, Genero = gen, Subtitulado = sub, Idioma = lan, precio = preciop, sinopsis = sinopsisp, estado = estate where id = idPeliculas;
END//    
select * from peliculas;

-- inserte pelis yd erechos

DELIMITER //
create procedure insertPeli (in nom varchar(45), in  clas varchar(45), in gen varchar(45), in sub varchar(45), in lan varchar(45), in  precio double, in sinoPsis varchar (100)) BEGIN 
		DECLARE cuenta INT;
        DECLARE estado INT;
        SET estado=1;
        
        insert into peliculas (Nombre, Clasificación, Genero, Subtitulado, Idioma, precio, sinopsis, estado) values (nom,clas,gen,sub,lan,precio,sinoPsis,1);
		SET cuenta = LAST_INSERT_ID(); -- obtiene el id de la peli que acabamos de insetar
        insert into derechos(fkPelicula, estadoDerechos) values(cuenta,0);
        -- select cuenta;
        
END//
-- drop procedure insertPeli;
-- 
select max(idPeliculas) from peliculas;
select * from peliculas;
select * from derechos;
call insertPeli('b','b','b','b','b','32.25','b');

DELIMITER //
create procedure cuentaPeli (OUT cantidad int) BEGIN 
		select count(*) from peliculas;
END//

-- Insertar factura

DELIMITER //
create procedure insertFactura (in codCliente int, in  metPago varchar(45), in subTotal double, in impuesto double, in est int) BEGIN 
        
        insert into factura (fkCliente,metodoPago,subTotal,impuesto,estado) values (codCliente,metPago,subTotal,impuesto, est);
        
END//

-- Consulta individual factura

DELIMITER //
	CREATE PROCEDURE consulFactura (in idf int) BEGIN
		select * from factura where idf = idFactura;
END//

-- Consulta general factura

DELIMITER //
	CREATE PROCEDURE consulFactura () BEGIN
		select idFactura, fkCliente, estado from factura;
END//

-- Dar de baja a una factura

DELIMITER //
	CREATE PROCEDURE elimFactura (in id int) BEGIN
		UPDATE factura set estado = 0 where id = idf;
END//

-- Insertar Cliente 
DELIMITER //
	CREATE PROCEDURE insertCliente(in nom varchar (45), in nitC varchar (45)) BEGIN
		INSERT INTO clientes (Nombre, Nit,Estado) values (nom, nitC,1);
END//

-- Conuslta individual Cliente 
DELIMITER //
	CREATE PROCEDURE consCliente(in id int) BEGIN
		select * from clienes where id = idClientes;
END//

-- Consulta general de clientes
DELIMITER //
	SELECT idClientes, Nombre, Estado from clientes;
END//

-- Actualizar Clientes
DELIMITER //
	CREATE PROCEDURE actuClientes (in id int, in nom varchar (45), in nitC varchar (45)) BEGIN
		UPDATE clientes set Nombre = nom, Nit = nitC where id = idClientes;
    
END//

-- Dar de baja a un cliente 
DELIMITER //
	CREATE PROCEDURE bajaCliente (in id int) BEGIN
		UPDATE cientes set Estado = 0;
END// 