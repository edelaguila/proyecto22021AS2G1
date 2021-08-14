-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-08-2021 a las 07:43:43
-- Versión del servidor: 8.0.23
-- Versión de PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cinevision`
--
CREATE DATABASE IF NOT EXISTS `cinevision` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `cinevision`;

DELIMITER $$
--
-- Procedimientos
--
CREATE PROCEDURE `actuPelis` (IN `id` INT, IN `nom` VARCHAR(40), IN `clas` VARCHAR(1), IN `gen` VARCHAR(30), IN `sub` VARCHAR(15), IN `lan` VARCHAR(15), IN `preciop` INT, IN `sinopsisp` VARCHAR(50), IN `estate` INT)  UPDATE peliculas set Nombre = nom, Clasificación = clas, Genero = gen, Subtitulado = sub, Idioma = lan, precio = preciop, sinopsis = sinopsisp, estado = estate where id = idPeliculas$$

CREATE PROCEDURE `actuUser` (IN `nusuario` VARCHAR(45), IN `npass` VARCHAR(45), IN `id` INT)  BEGIN
	update usuarios set Usuario=nusuario, Password=npass where idUsuarios=id;
END$$

CREATE PROCEDURE `bajaHorarioCin` (IN `id` INT)  BEGIN
	delete from horariocine where idhorarioCine=id;
END$$

CREATE PROCEDURE `bajaUser` (IN `id` INT)  BEGIN
	update usuarios set usuarios.estado= 0 where usuarios.idUsuarios=id;
END$$

CREATE PROCEDURE `conGenHorarioCi` ()  BEGIN
	select hc.idhorarioCine as id, pe.Nombre as Pelicula, ho.fechaHora as horario,
    sa.Descripción as descripcionSala
	from horariocine hc 
	INNER JOIN peliculas pe on pe.idPeliculas = hc.fkPelicula
	INNER JOIN horarios ho on ho.idHorario = hc.fkHorario
    INNER JOIN salas sa on sa.idSalas = hc.fkSala;
END$$

CREATE PROCEDURE `conGenHorarioCiInd` (IN `id` INT)  BEGIN
	select hc.idhorarioCine as id, pe.Nombre as Pelicula, ho.fechaHora as horario,
    sa.Descripción as descripcionSala
	from horariocine hc 
	INNER JOIN peliculas pe on pe.idPeliculas = hc.fkPelicula
	INNER JOIN horarios ho on ho.idHorario = hc.fkHorario
    INNER JOIN salas sa on sa.idSalas = hc.fkSala
    where hc.idhorarioCine=id;
END$$

CREATE PROCEDURE `consultaFiltraPelis` ()  BEGIN
	select idPeliculas as ID, Nombre, Clasificación, Genero, Subtitulado, Idioma, precio from peliculas;
END$$

CREATE PROCEDURE `consultaGen` ()  BEGIN
	select idUsuarios as ID, Usuario, estado from usuarios;
END$$

CREATE PROCEDURE `consultaGenCine` ()  BEGIN
	select idCines as ID, Nombre, Direccion from Cines;
END$$

CREATE PROCEDURE `consultaGenpelis` ()  BEGIN
	select * from peliculas;
END$$

CREATE PROCEDURE `consultaInpeli` (IN `id` INT)  BEGIN
		select * from peliculas where id = peliculas.idPeliculas;
END$$

CREATE PROCEDURE `consultaPriv` ()  BEGIN
	select idPrivilegios as id, descPrivilegio as Privilegio from privilegios;
END$$

CREATE PROCEDURE `elimPelis` (IN `id` INT)  BEGIN
	UPDATE peliculas set estado = 0 where id = idPeliculas;
    END$$

CREATE PROCEDURE `elPrivUs` (IN `idPriv` INT)  BEGIN
	delete from usuarioprivilegios where idusuarioPrivilegios=idPriv;
END$$

CREATE PROCEDURE `ingHorarioCi` (IN `peli` INT, IN `sala` INT, IN `hora` INT)  BEGIN
	insert into horariocine(fkPelicula,fkSala,fkHorario) values(peli,sala,hora);
END$$

CREATE PROCEDURE `ingPrivUs` (IN `idU` INT, IN `idP` INT)  BEGIN
	insert into usuarioprivilegios(fkUsuario,fkPrivilegio) values (idU,idP);
END$$

CREATE PROCEDURE `ingUser` (IN `usuario` VARCHAR(45), IN `pass` VARCHAR(45))  BEGIN
	insert into usuarios (Usuario, Password) values (usuario,pass);
END$$

CREATE PROCEDURE `insertPeli` (IN `nom` VARCHAR(45), IN `clas` VARCHAR(45), IN `gen` VARCHAR(45), IN `sub` VARCHAR(45), IN `lan` VARCHAR(45), IN `precio` DOUBLE, IN `sinoPsis` VARCHAR(100))  BEGIN 
		DECLARE cuenta INT;
        DECLARE estado INT;
        SET estado=1;
        
        insert into peliculas (Nombre, Clasificación, Genero, Subtitulado, Idioma, precio, sinopsis, estado) values (nom,clas,gen,sub,lan,precio,sinoPsis,1);
		SET cuenta = LAST_INSERT_ID(); -- obtiene el id de la peli que acabamos de insetar
        insert into derechos(fkPelicula, estadoDerechos) values(cuenta,0);
        -- select cuenta;
        
END$$

CREATE PROCEDURE `login` (IN `usuario` VARCHAR(45), IN `passwor` VARCHAR(45))  BEGIN
	select Usuario, usuarios.Password, usuarios.estado from usuarios where Usuario=usuario and Password=passwor; 
END$$

CREATE PROCEDURE `modifHorarioCi` (IN `peli` INT, IN `sala` INT, IN `hora` INT, IN `id` INT)  BEGIN
	update horariocine set fkPelicula=peli, fkSala=sala, fkHorario=hora where idhorarioCine=id;
END$$

CREATE PROCEDURE `modifPrivUs` (IN `idPriv` INT, IN `idP` INT)  BEGIN
	update usuarioprivilegios set fkPrivilegio=idP where idusuarioPrivilegios=idPriv;

END$$

CREATE PROCEDURE `privilegiosUsuarios` (IN `id` INT)  BEGIN
	select us.idusuarioPrivilegios as idRegistro, priv.descPrivilegio as tipo
	from usuarioprivilegios us 
	INNER JOIN privilegios priv on us.fkPrivilegio = priv.idPrivilegios
	where us.fkUsuario=id; 
END$$

CREATE PROCEDURE `verUser` (IN `id` INT)  BEGIN
	select Usuario, Password, Estado from usuarios where idUsuarios=id;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asientos`
--

CREATE TABLE `asientos` (
  `idAsientos` int NOT NULL,
  `fkSala` int NOT NULL,
  `Fila` int DEFAULT NULL,
  `Columna` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cines`
--

CREATE TABLE `cines` (
  `idCines` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cines`
--

INSERT INTO `cines` (`idCines`, `Nombre`, `Direccion`) VALUES
(1, 'Cine 1', '33 Calle 8-39 Zona 10'),
(2, 'Cine 2', '33 Calle 1-12 Zona 12'),
(3, 'Cine 3', '33 Calle 9-30 Zona 13'),
(4, 'XD', '33 Calle 9-30 Zona 20');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `idClientes` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Nit` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `derechos`
--

CREATE TABLE `derechos` (
  `idDerechos` int NOT NULL,
  `fkPelicula` int NOT NULL,
  `estadoDerechos` tinyint DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `derechos`
--

INSERT INTO `derechos` (`idDerechos`, `fkPelicula`, `estadoDerechos`) VALUES
(1, 9, 0),
(2, 10, 0),
(3, 11, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `idFactura` int NOT NULL,
  `fkCliente` int DEFAULT NULL,
  `metodoPago` varchar(45) DEFAULT NULL,
  `subTotal` double DEFAULT NULL,
  `impuesto` double DEFAULT NULL,
  `estado` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horariocine`
--

CREATE TABLE `horariocine` (
  `idhorarioCine` int NOT NULL,
  `fkPelicula` int DEFAULT NULL,
  `fkSala` int NOT NULL,
  `fkHorario` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horarios`
--

CREATE TABLE `horarios` (
  `idHorario` int NOT NULL,
  `fechaHora` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `horarios`
--

INSERT INTO `horarios` (`idHorario`, `fechaHora`) VALUES
(1, '2021-10-21 15:00:00'),
(2, '2027-12-03 01:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `peliculas`
--

CREATE TABLE `peliculas` (
  `idPeliculas` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Clasificación` varchar(45) DEFAULT NULL,
  `Genero` varchar(45) DEFAULT NULL,
  `Subtitulado` varchar(45) DEFAULT NULL,
  `Idioma` varchar(45) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `sinopsis` varchar(100) DEFAULT NULL,
  `estado` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `peliculas`
--

INSERT INTO `peliculas` (`idPeliculas`, `Nombre`, `Clasificación`, `Genero`, `Subtitulado`, `Idioma`, `precio`, `sinopsis`, `estado`) VALUES
(1, 'avengers', 'Adultos', 'peleas', 'No', 'latino', 400, 'No me quiero ir señor coordinador', 1),
(2, 'Dragon ball super broly', 'T', 'peleas', 'No', 'latino', 500, 'F por Goku', 1),
(3, 'No Game No Life Zero', 'T', 'Anime', 'Español', 'Japonés', 500, 'Precuela al anime No Game No Life', 1),
(4, 'Fate/stay night UBW', 'T', 'Anime', 'Español', 'Japonés', 450, 'Im the bone of my sword', 1),
(5, 'Rapidos y Furiosos 9', 'T', 'Acción', 'Si', 'Español Latino', 50, 'Repollo', 1),
(6, 'Spiderman 3', 'T', 'Acción', 'Si', 'Español Latino', 30, 'Un clásico', 1),
(7, 'COCO', 'E', 'Aventura', 'No', 'Español Latino', 40, 'Sad', 1),
(8, 'a', 'a', 'a', 'a', 'a', 30.25, 'a', 1),
(9, 'b', 'b', 'b', 'b', 'b', 32.25, 'b', 1),
(10, 'c', 'R', 'Comedia', 'NO', 'a', 12, 'a', 1),
(11, '7 Votos del exito', 'PG13', 'Ciencia Ficción', 'SI', 'Español', 250.5, 'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `privilegios`
--

CREATE TABLE `privilegios` (
  `idPrivilegios` int NOT NULL,
  `descPrivilegio` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `privilegios`
--

INSERT INTO `privilegios` (`idPrivilegios`, `descPrivilegio`) VALUES
(1, 'Administrador'),
(2, 'Reportes'),
(3, 'Taquilla');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registropuntos`
--

CREATE TABLE `registropuntos` (
  `idregistroPuntos` int NOT NULL,
  `fkCliente` int NOT NULL,
  `puntosAcum` int DEFAULT NULL,
  `puntosUsados` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reservaciones`
--

CREATE TABLE `reservaciones` (
  `idReservaciones` int NOT NULL,
  `fkAsientos` int NOT NULL,
  `subTotalAsiento` double DEFAULT NULL,
  `fkFactura` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salas`
--

CREATE TABLE `salas` (
  `idSalas` int NOT NULL,
  `fkCine` int NOT NULL,
  `Descripción` varchar(100) DEFAULT NULL,
  `formatoPeli` varchar(45) DEFAULT NULL,
  `puntos` int DEFAULT NULL,
  `precioSala` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `salas`
--

INSERT INTO `salas` (`idSalas`, `fkCine`, `Descripción`, `formatoPeli`, `puntos`, `precioSala`) VALUES
(1, 1, 'sala full hd 4+', 'mkv', 100, 100),
(2, 2, 'imax', 'mp4', 70, 70),
(3, 3, 'dolby atmosphere audio', 'flv', 65, 65),
(4, 4, '144p', 'gpo', 40, 40);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarioprivilegios`
--

CREATE TABLE `usuarioprivilegios` (
  `idusuarioPrivilegios` int NOT NULL,
  `fkUsuario` int NOT NULL,
  `fkPrivilegio` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuarioprivilegios`
--

INSERT INTO `usuarioprivilegios` (`idusuarioPrivilegios`, `fkUsuario`, `fkPrivilegio`) VALUES
(1, 1, 2),
(2, 2, 2),
(3, 3, 3),
(4, 3, 3),
(5, 3, 3),
(7, 1, 2),
(8, 1, 3),
(9, 1, 1),
(10, 1, 2),
(12, 7, 1),
(13, 1, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `idUsuarios` int NOT NULL,
  `Usuario` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `estado` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`idUsuarios`, `Usuario`, `Password`, `estado`) VALUES
(1, 'Nuevo name', 'Nuevo pass', 0),
(2, 'Rob', '456', 0),
(3, 'aaa', 'sss', 1),
(4, 'Prueba333', '123456', 1),
(5, 'Kevin', 'Kevin2', 1),
(6, 'zcxxz', 'zzzz', 1),
(7, 'abc', 'abc', 1),
(8, 'Noel1', 'Pruebas1', 0),
(9, 'Noel2', 'NNNN', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asientos`
--
ALTER TABLE `asientos`
  ADD PRIMARY KEY (`idAsientos`),
  ADD KEY `fkasieS` (`fkSala`);

--
-- Indices de la tabla `cines`
--
ALTER TABLE `cines`
  ADD PRIMARY KEY (`idCines`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idClientes`);

--
-- Indices de la tabla `derechos`
--
ALTER TABLE `derechos`
  ADD PRIMARY KEY (`idDerechos`),
  ADD KEY `fkpder` (`fkPelicula`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`idFactura`),
  ADD KEY `fkfacCl` (`fkCliente`);

--
-- Indices de la tabla `horariocine`
--
ALTER TABLE `horariocine`
  ADD PRIMARY KEY (`idhorarioCine`),
  ADD KEY `fkhcinP` (`fkPelicula`),
  ADD KEY `fkhcinSa` (`fkSala`),
  ADD KEY `fkHrr` (`fkHorario`);

--
-- Indices de la tabla `horarios`
--
ALTER TABLE `horarios`
  ADD PRIMARY KEY (`idHorario`);

--
-- Indices de la tabla `peliculas`
--
ALTER TABLE `peliculas`
  ADD PRIMARY KEY (`idPeliculas`);

--
-- Indices de la tabla `privilegios`
--
ALTER TABLE `privilegios`
  ADD PRIMARY KEY (`idPrivilegios`);

--
-- Indices de la tabla `registropuntos`
--
ALTER TABLE `registropuntos`
  ADD PRIMARY KEY (`idregistroPuntos`),
  ADD KEY `fkregCl` (`fkCliente`);

--
-- Indices de la tabla `reservaciones`
--
ALTER TABLE `reservaciones`
  ADD PRIMARY KEY (`idReservaciones`),
  ADD KEY `fkresas` (`fkAsientos`),
  ADD KEY `fkresfac` (`fkFactura`);

--
-- Indices de la tabla `salas`
--
ALTER TABLE `salas`
  ADD PRIMARY KEY (`idSalas`),
  ADD KEY `fk_cinS` (`fkCine`);

--
-- Indices de la tabla `usuarioprivilegios`
--
ALTER TABLE `usuarioprivilegios`
  ADD PRIMARY KEY (`idusuarioPrivilegios`),
  ADD KEY `fk_UserP` (`fkUsuario`),
  ADD KEY `fk_PrivP` (`fkPrivilegio`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idUsuarios`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `asientos`
--
ALTER TABLE `asientos`
  MODIFY `idAsientos` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `cines`
--
ALTER TABLE `cines`
  MODIFY `idCines` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `idClientes` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `derechos`
--
ALTER TABLE `derechos`
  MODIFY `idDerechos` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `idFactura` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `horariocine`
--
ALTER TABLE `horariocine`
  MODIFY `idhorarioCine` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `horarios`
--
ALTER TABLE `horarios`
  MODIFY `idHorario` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `peliculas`
--
ALTER TABLE `peliculas`
  MODIFY `idPeliculas` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `privilegios`
--
ALTER TABLE `privilegios`
  MODIFY `idPrivilegios` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `registropuntos`
--
ALTER TABLE `registropuntos`
  MODIFY `idregistroPuntos` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `reservaciones`
--
ALTER TABLE `reservaciones`
  MODIFY `idReservaciones` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `salas`
--
ALTER TABLE `salas`
  MODIFY `idSalas` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `usuarioprivilegios`
--
ALTER TABLE `usuarioprivilegios`
  MODIFY `idusuarioPrivilegios` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `idUsuarios` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `asientos`
--
ALTER TABLE `asientos`
  ADD CONSTRAINT `fkasieS` FOREIGN KEY (`fkSala`) REFERENCES `salas` (`idSalas`);

--
-- Filtros para la tabla `derechos`
--
ALTER TABLE `derechos`
  ADD CONSTRAINT `fkpder` FOREIGN KEY (`fkPelicula`) REFERENCES `peliculas` (`idPeliculas`);

--
-- Filtros para la tabla `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `fkfacCl` FOREIGN KEY (`fkCliente`) REFERENCES `clientes` (`idClientes`);

--
-- Filtros para la tabla `registropuntos`
--
ALTER TABLE `registropuntos`
  ADD CONSTRAINT `fkregCl` FOREIGN KEY (`fkCliente`) REFERENCES `clientes` (`idClientes`);

--
-- Filtros para la tabla `reservaciones`
--
ALTER TABLE `reservaciones`
  ADD CONSTRAINT `fkresas` FOREIGN KEY (`fkAsientos`) REFERENCES `asientos` (`idAsientos`),
  ADD CONSTRAINT `fkresfac` FOREIGN KEY (`fkFactura`) REFERENCES `factura` (`idFactura`);

--
-- Filtros para la tabla `salas`
--
ALTER TABLE `salas`
  ADD CONSTRAINT `fk_cinS` FOREIGN KEY (`fkCine`) REFERENCES `cines` (`idCines`);

--
-- Filtros para la tabla `usuarioprivilegios`
--
ALTER TABLE `usuarioprivilegios`
  ADD CONSTRAINT `fk_PrivP` FOREIGN KEY (`fkPrivilegio`) REFERENCES `privilegios` (`idPrivilegios`),
  ADD CONSTRAINT `fk_UserP` FOREIGN KEY (`fkUsuario`) REFERENCES `usuarios` (`idUsuarios`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
