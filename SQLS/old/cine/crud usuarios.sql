use cinevision;

insert into usuarios (Usuario,Password) values ('Noel','123456');
-- ^insercion


select idUsuarios as ID, Usuario, estado from usuarios;
-- ^consulta general

update usuarios set usuarios.Usuario='Nuevo name', usuarios.Password='Nuevo pass' where usuarios.idUsuarios='1';
-- ^ update 

update usuarios set usuarios.estado= 0 where usuarios.idUsuarios='1';
-- ^ dar de baja


-- prueba con procedures:
-- ingresar
DELIMITER |
CREATE PROCEDURE ingUser(in usuario varchar(45), in pass varchar(45))
BEGIN
	insert into usuarios (Usuario, Password) values (usuario,pass);
END
| 

call ingUser('Probando','123');

-- consultar general
DELIMITER |
CREATE PROCEDURE consultaGen()
BEGIN
	select idUsuarios as ID, Usuario, estado from usuarios;
END
| 

call consultaGen();

-- modificar
DELIMITER |
CREATE PROCEDURE actuUser(in nusuario varchar(45), in npass varchar(45), in id int)
BEGIN
	update usuarios set Usuario=nusuario, Password=npass where idUsuarios=id;
END
| 

call actuUser('Rob','456','2');

-- consulta modificar
DELIMITER |
CREATE PROCEDURE verUser(in id int)
BEGIN
	select Usuario, Password, Estado from usuarios where idUsuarios=id;
END
| 

use cinevision;
call verUser(1);

-- dar de baja
DELIMITER |
CREATE PROCEDURE bajaUser(in id int)
BEGIN
	update usuarios set usuarios.estado= 0 where usuarios.idUsuarios=id;
END
| 

call bajaUser(2);






-- privilegios (TIPOS)
DELIMITER |
CREATE PROCEDURE consultaPriv()
BEGIN
	select idPrivilegios as id, descPrivilegio as Privilegio from privilegios;
END
| 

-- drop procedure consultaPriv;
call consultaPriv();
use cinevision;
insert into privilegios(descPrivilegio) values('Administrador'),('Reportes'),('Taquilla');

-- call privilegiosUsuarios

desc usuarioprivilegios;

select us.idusuarioPrivilegios as idPriv, priv.descPrivilegio as tipo
from usuarioprivilegios us 
INNER JOIN privilegios priv on us.fkPrivilegio = priv.idPrivilegios
where us.fkUsuario=3; 

call consultaGen();
insert into usuarioprivilegios(fkUsuario,fkPrivilegio) values (1,1),(2,2),(3,3);
select * from usuarioprivilegios us INNER JOIN privilegios priv on  us.fkPrivilegio = priv.idPrivilegios;

-- llamada a un privilegio usuairo
DELIMITER |
CREATE PROCEDURE privilegiosUsuarios(in id int)
BEGIN
	select us.idusuarioPrivilegios as idPriv, priv.descPrivilegio as tipo
	from usuarioprivilegios us 
	INNER JOIN privilegios priv on us.fkPrivilegio = priv.idPrivilegios
	where us.fkUsuario=id; 
END
| 
call privilegiosUsuarios(3);


/*
CREATE TABLE IF NOT EXISTS `Cines` (
  `idCines` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NULL,
  `Direccion` VARCHAR(45) NULL,
  PRIMARY KEY (`idCines`)
)
ENGINE = InnoDB;

*/



insert into Cines values(1,'Cine 1','33 Calle 8-39 Zona 10');
insert into Cines values(2,'Cine 2','33 Calle 1-12 Zona 12');
insert into Cines values(3,'Cine 3','33 Calle 9-30 Zona 13');
insert into Cines values(4,'XD','33 Calle 9-30 Zona 20');

DELIMITER |
CREATE PROCEDURE consultaGenCine()
BEGIN
	select idCines as ID, Nombre, Direccion from Cines;
END
| 

call consultaGenCine();