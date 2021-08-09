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

call verUser(2);

-- dar de baja
DELIMITER |
CREATE PROCEDURE bajaUser(in id int)
BEGIN
	update usuarios set usuarios.estado= 0 where usuarios.idUsuarios=id;
END
| 

call bajaUser(2);