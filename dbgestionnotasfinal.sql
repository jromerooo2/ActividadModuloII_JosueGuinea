-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 10, 2021 at 07:33 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbgestionnotas2`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbalumnos`
--

CREATE TABLE `tbalumnos` (
  `idAlumno` int(11) NOT NULL,
  `nombreAlumno` varchar(50) NOT NULL,
  `apellidoAlumno` varchar(50) NOT NULL,
  `idSeccion` int(11) NOT NULL,
  `idEstado` int(11) NOT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `idEspecialidad` int(11) DEFAULT NULL,
  `Nota` int(11) DEFAULT NULL,
  `userId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbalumnos`
--

INSERT INTO `tbalumnos` (`idAlumno`, `nombreAlumno`, `apellidoAlumno`, `idSeccion`, `idEstado`, `direccion`, `idEspecialidad`, `Nota`, `userId`) VALUES
(22, 'José', 'Merino', 2, 4, 'en el puente con david', 4, 10, 9),
(29, 'Santiago', 'Merino', 3, 4, 'no se we en mi casa junto a mi peluche', 6, 10, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbespecialidad`
--

CREATE TABLE `tbespecialidad` (
  `idEspecialidad` int(11) NOT NULL,
  `especialidad` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbespecialidad`
--

INSERT INTO `tbespecialidad` (`idEspecialidad`, `especialidad`) VALUES
(1, 'Mantenimiento Automotriz'),
(2, 'Desarrollo de Software'),
(3, 'Diseño Grafico'),
(4, 'Administrativo Contable'),
(5, 'Electromecánica'),
(6, 'Electrónica'),
(7, 'Arquitectura');

-- --------------------------------------------------------

--
-- Table structure for table `tbestados`
--

CREATE TABLE `tbestados` (
  `idEstado` int(11) NOT NULL,
  `estado` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbestados`
--

INSERT INTO `tbestados` (`idEstado`, `estado`) VALUES
(1, 'Suspendido'),
(2, 'Aprobado'),
(3, 'Expulsado'),
(4, 'Reprobado');

-- --------------------------------------------------------

--
-- Table structure for table `tbmaestros`
--

CREATE TABLE `tbmaestros` (
  `idMaestro` int(11) NOT NULL,
  `nombreMaestro` varchar(50) NOT NULL,
  `apellidoMaestro` varchar(50) NOT NULL,
  `idMateria` int(11) NOT NULL,
  `userId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbmaestros`
--

INSERT INTO `tbmaestros` (`idMaestro`, `nombreMaestro`, `apellidoMaestro`, `idMateria`, `userId`) VALUES
(9, 'Juan', 'Ramos', 1, 8);

-- --------------------------------------------------------

--
-- Table structure for table `tbmaterias`
--

CREATE TABLE `tbmaterias` (
  `idMateria` int(11) NOT NULL,
  `nombreMateria` varchar(50) NOT NULL,
  `es_tecnica` tinyint(1) NOT NULL,
  `es_academica` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbmaterias`
--

INSERT INTO `tbmaterias` (`idMateria`, `nombreMateria`, `es_tecnica`, `es_academica`) VALUES
(1, 'Lenguaje', 1, 0),
(2, 'Matematicas', 1, 0),
(3, 'Ciencias', 1, 0),
(4, 'Sociales', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbnotas`
--

CREATE TABLE `tbnotas` (
  `idNota` int(11) NOT NULL,
  `idAlumno` int(12) NOT NULL,
  `idMateria` int(11) NOT NULL,
  `idPeriodo` int(11) DEFAULT NULL,
  `nota` int(16) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbnotas`
--

INSERT INTO `tbnotas` (`idNota`, `idAlumno`, `idMateria`, `idPeriodo`, `nota`) VALUES
(76, 22, 3, 2, 9),
(77, 29, 4, 4, 9);

-- --------------------------------------------------------

--
-- Table structure for table `tbperiodos`
--

CREATE TABLE `tbperiodos` (
  `idPeriodo` int(11) NOT NULL,
  `periodo` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbperiodos`
--

INSERT INTO `tbperiodos` (`idPeriodo`, `periodo`) VALUES
(1, 'Primer Periodo'),
(2, 'Segundo Periodo'),
(3, 'Tercer Periodo'),
(4, 'Cuarto Periodo');

-- --------------------------------------------------------

--
-- Table structure for table `tbusuarios`
--

CREATE TABLE `tbusuarios` (
  `userId` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `passwordUsuario` varchar(250) NOT NULL,
  `rolUsuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbusuarios`
--

INSERT INTO `tbusuarios` (`userId`, `usuario`, `passwordUsuario`, `rolUsuario`) VALUES
(5, 'jromerooo2', '81dc9bdb52d04dc20036dbd8313ed055', 2),
(7, 'admin', '81dc9bdb52d04dc20036dbd8313ed055', 2),
(8, 'test', '81dc9bdb52d04dc20036dbd8313ed055', 1),
(9, 'estudiante', '81dc9bdb52d04dc20036dbd8313ed055', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbalumnos`
--
ALTER TABLE `tbalumnos`
  ADD PRIMARY KEY (`idAlumno`),
  ADD KEY `FK_IdEstado` (`idEstado`),
  ADD KEY `FK_IdSeccion` (`idSeccion`),
  ADD KEY `fk_especialidad` (`idEspecialidad`),
  ADD KEY `FK_userid` (`userId`);

--
-- Indexes for table `tbespecialidad`
--
ALTER TABLE `tbespecialidad`
  ADD PRIMARY KEY (`idEspecialidad`);

--
-- Indexes for table `tbestados`
--
ALTER TABLE `tbestados`
  ADD PRIMARY KEY (`idEstado`);

--
-- Indexes for table `tbmaestros`
--
ALTER TABLE `tbmaestros`
  ADD PRIMARY KEY (`idMaestro`),
  ADD KEY `FK_IdMateriaMaestro` (`idMateria`),
  ADD KEY `FK_userid_maestros` (`userId`);

--
-- Indexes for table `tbmaterias`
--
ALTER TABLE `tbmaterias`
  ADD PRIMARY KEY (`idMateria`);

--
-- Indexes for table `tbnotas`
--
ALTER TABLE `tbnotas`
  ADD PRIMARY KEY (`idNota`),
  ADD KEY `FK_IdMateriaNota` (`idMateria`),
  ADD KEY `FK_IdAlumnoNota` (`idAlumno`),
  ADD KEY `fk_nota_periodo` (`idPeriodo`);

--
-- Indexes for table `tbperiodos`
--
ALTER TABLE `tbperiodos`
  ADD PRIMARY KEY (`idPeriodo`);

--
-- Indexes for table `tbusuarios`
--
ALTER TABLE `tbusuarios`
  ADD PRIMARY KEY (`userId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbalumnos`
--
ALTER TABLE `tbalumnos`
  MODIFY `idAlumno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tbespecialidad`
--
ALTER TABLE `tbespecialidad`
  MODIFY `idEspecialidad` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbestados`
--
ALTER TABLE `tbestados`
  MODIFY `idEstado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbmaestros`
--
ALTER TABLE `tbmaestros`
  MODIFY `idMaestro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `tbmaterias`
--
ALTER TABLE `tbmaterias`
  MODIFY `idMateria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `tbnotas`
--
ALTER TABLE `tbnotas`
  MODIFY `idNota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;

--
-- AUTO_INCREMENT for table `tbperiodos`
--
ALTER TABLE `tbperiodos`
  MODIFY `idPeriodo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `tbusuarios`
--
ALTER TABLE `tbusuarios`
  MODIFY `userId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbalumnos`
--
ALTER TABLE `tbalumnos`
  ADD CONSTRAINT `FK_IdEstado` FOREIGN KEY (`idEstado`) REFERENCES `tbestados` (`idEstado`),
  ADD CONSTRAINT `FK_userid` FOREIGN KEY (`userId`) REFERENCES `tbusuarios` (`userId`),
  ADD CONSTRAINT `fk_especialidad` FOREIGN KEY (`idEspecialidad`) REFERENCES `tbespecialidad` (`idEspecialidad`);

--
-- Constraints for table `tbmaestros`
--
ALTER TABLE `tbmaestros`
  ADD CONSTRAINT `FK_IdMateriaMaestro` FOREIGN KEY (`idMateria`) REFERENCES `tbmaterias` (`idMateria`),
  ADD CONSTRAINT `FK_userid_maestros` FOREIGN KEY (`userId`) REFERENCES `tbusuarios` (`userId`);

--
-- Constraints for table `tbnotas`
--
ALTER TABLE `tbnotas`
  ADD CONSTRAINT `FK_IdAlumnoNota` FOREIGN KEY (`idAlumno`) REFERENCES `tbalumnos` (`idAlumno`),
  ADD CONSTRAINT `FK_IdMateriaNota` FOREIGN KEY (`idMateria`) REFERENCES `tbmaterias` (`idMateria`),
  ADD CONSTRAINT `fk_nota_periodo` FOREIGN KEY (`idPeriodo`) REFERENCES `tbperiodos` (`idPeriodo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
