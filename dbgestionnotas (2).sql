-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 10, 2021 at 05:31 AM
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
-- Database: `dbgestionnotas`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbalumnos`
--
CREATE TABLE `tbalumnos` (tbusuarios
  `idAlumno` int(11) NOT NULL,
  `nombreAlumno` varchar(50) NOT NULL,
  `apellidoAlumno` varchar(50) NOT NULL,
  `idSeccion` int(11) NOT NULL,
  `idEstado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbalumno_seccion`
--

CREATE TABLE `tbalumno_seccion` (
  `idUnion` int(11) NOT NULL,
  `idAlumno` int(11) NOT NULL,
  `idSeccion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbestados`
--

CREATE TABLE `tbestados` (
  `idEstado` int(11) NOT NULL,
  `estado` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbmaestros`
--

CREATE TABLE `tbmaestros` (
  `idMaestro` int(11) NOT NULL,
  `nombreMaestro` varchar(50) NOT NULL,
  `apellidoMaestro` varchar(50) NOT NULL,
  `idMateria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

-- --------------------------------------------------------

--
-- Table structure for table `tbmateria_seccion`
--

CREATE TABLE `tbmateria_seccion` (
  `idUnion` int(11) NOT NULL,
  `idSeccion` int(11) NOT NULL,
  `idMateria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbnotas`
--

CREATE TABLE `tbnotas` (
  `idNota` int(11) NOT NULL,
  `idAlumno` int(12) NOT NULL,
  `idMateria` int(11) NOT NULL,
  `primerPerfil` double NOT NULL,
  `segundoPerfil` double NOT NULL,
  `TercerPerfil` double NOT NULL,
  `notaFinal` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbseccion`
--

CREATE TABLE `tbseccion` (
  `idSeccion` int(11) NOT NULL,
  `es_tecnica` tinyint(1) NOT NULL,
  `es_academica` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

INSERT INTO `tbnotas` (`idNota`, `idAlumno`, `idMateria`, `idPeriodo`, `nota`) VALUES
(76, 22, 3, 2, 9),
(77, 29, 4, 4, 9);

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
--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbalumnos`
--
ALTER TABLE `tbalumnos`
  ADD PRIMARY KEY (`idAlumno`),
  ADD KEY `FK_IdEstado` (`idEstado`),
  ADD KEY `FK_IdSeccion` (`idSeccion`);

--
-- Indexes for table `tbalumno_seccion`
--
ALTER TABLE `tbalumno_seccion`
  ADD PRIMARY KEY (`idUnion`),
  ADD KEY `FK_SeccionAlumno` (`idSeccion`),
  ADD KEY `FK_IdAlumnoSeccion` (`idAlumno`);

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
  ADD KEY `FK_IdMateriaMaestro` (`idMateria`);

--
-- Indexes for table `tbmaterias`
--
ALTER TABLE `tbmaterias`
  ADD PRIMARY KEY (`idMateria`);

--
-- Indexes for table `tbmateria_seccion`
--
ALTER TABLE `tbmateria_seccion`
  ADD PRIMARY KEY (`idUnion`),
  ADD KEY `FK_IdSeccionMateria` (`idSeccion`),
  ADD KEY `FK_IdMateria` (`idMateria`);

--
-- Indexes for table `tbnotas`
--
ALTER TABLE `tbnotas`
  ADD PRIMARY KEY (`idNota`),
  ADD KEY `FK_IdMateriaNota` (`idMateria`),
  ADD KEY `FK_IdAlumnoNota` (`idAlumno`);

--
-- Indexes for table `tbseccion`
--
ALTER TABLE `tbseccion`
  ADD PRIMARY KEY (`idSeccion`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbalumnos`
--
ALTER TABLE `tbalumnos`
  MODIFY `idAlumno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbalumno_seccion`
--
ALTER TABLE `tbalumno_seccion`
  MODIFY `idUnion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbmaestros`
--
ALTER TABLE `tbmaestros`
  MODIFY `idMaestro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbmaterias`
--
ALTER TABLE `tbmaterias`
  MODIFY `idMateria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbmateria_seccion`
--
ALTER TABLE `tbmateria_seccion`
  MODIFY `idUnion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbnotas`
--
ALTER TABLE `tbnotas`
  MODIFY `idNota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=76;

--
-- AUTO_INCREMENT for table `tbseccion`
--
ALTER TABLE `tbseccion`
  MODIFY `idSeccion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbalumnos`
--
ALTER TABLE `tbalumnos`
  ADD CONSTRAINT `FK_IdEstado` FOREIGN KEY (`idEstado`) REFERENCES `tbestados` (`idEstado`);

--
-- Constraints for table `tbalumno_seccion`
--
ALTER TABLE `tbalumno_seccion`
  ADD CONSTRAINT `FK_IdAlumnoSeccion` FOREIGN KEY (`idAlumno`) REFERENCES `tbalumnos` (`idAlumno`),
  ADD CONSTRAINT `FK_SeccionAlumno` FOREIGN KEY (`idSeccion`) REFERENCES `tbseccion` (`idSeccion`);

--
-- Constraints for table `tbmaestros`
--
ALTER TABLE `tbmaestros`
  ADD CONSTRAINT `FK_IdMateriaMaestro` FOREIGN KEY (`idMateria`) REFERENCES `tbmaterias` (`idMateria`);

--
-- Constraints for table `tbmateria_seccion`
--
ALTER TABLE `tbmateria_seccion`
  ADD CONSTRAINT `FK_IdMateria` FOREIGN KEY (`idMateria`) REFERENCES `tbmaterias` (`idMateria`),
  ADD CONSTRAINT `FK_IdSeccionMateria` FOREIGN KEY (`idSeccion`) REFERENCES `tbseccion` (`idSeccion`);

--
-- Constraints for table `tbnotas`
--
ALTER TABLE `tbnotas`
  ADD CONSTRAINT `FK_IdAlumnoNota` FOREIGN KEY (`idAlumno`) REFERENCES `tbalumnos` (`idAlumno`),
  ADD CONSTRAINT `FK_IdMateriaNota` FOREIGN KEY (`idMateria`) REFERENCES `tbmaterias` (`idMateria`);
COMMIT;


select * from tbusuarios;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
