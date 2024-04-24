-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: gestao_de_avaria
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `contacto`
--

DROP TABLE IF EXISTS `contacto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contacto` (
  `NSA` int NOT NULL AUTO_INCREMENT,
  `NSA-Empresa` int DEFAULT NULL,
  `DtContact` date NOT NULL,
  `HrContacto` time NOT NULL,
  `Resumo` varchar(255) DEFAULT NULL,
  `Forma` varchar(50) NOT NULL,
  `InfoContacto` text,
  `NSA_Queixa` int NOT NULL,
  `NIF_Utilizador` varchar(9) NOT NULL,
  PRIMARY KEY (`NSA`),
  KEY `NSA_Queixa` (`NSA_Queixa`),
  KEY `NIF_Utilizador` (`NIF_Utilizador`),
  CONSTRAINT `contacto_ibfk_1` FOREIGN KEY (`NSA_Queixa`) REFERENCES `queixa` (`NSA`) ON DELETE CASCADE,
  CONSTRAINT `contacto_ibfk_2` FOREIGN KEY (`NIF_Utilizador`) REFERENCES `utilizador` (`NIF`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contacto`
--

LOCK TABLES `contacto` WRITE;
/*!40000 ALTER TABLE `contacto` DISABLE KEYS */;
/*!40000 ALTER TABLE `contacto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devolucao`
--

DROP TABLE IF EXISTS `devolucao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `devolucao` (
  `NSA` int NOT NULL AUTO_INCREMENT,
  `NSA_Queixa` int NOT NULL,
  `DtDevolucao` date NOT NULL,
  `DtEntrega` date NOT NULL,
  `NIF_Utilizador` varchar(9) NOT NULL,
  `NIFEE` varchar(9) NOT NULL,
  PRIMARY KEY (`NSA`),
  KEY `NSA_Queixa` (`NSA_Queixa`),
  KEY `NIF_Utilizador` (`NIF_Utilizador`),
  KEY `NIFEE` (`NIFEE`),
  CONSTRAINT `devolucao_ibfk_1` FOREIGN KEY (`NSA_Queixa`) REFERENCES `queixa` (`NSA`) ON DELETE CASCADE,
  CONSTRAINT `devolucao_ibfk_2` FOREIGN KEY (`NIF_Utilizador`) REFERENCES `utilizador` (`NIF`) ON DELETE CASCADE,
  CONSTRAINT `devolucao_ibfk_3` FOREIGN KEY (`NIFEE`) REFERENCES `utilizador` (`NIFEE`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucao`
--

LOCK TABLES `devolucao` WRITE;
/*!40000 ALTER TABLE `devolucao` DISABLE KEYS */;
/*!40000 ALTER TABLE `devolucao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `envio`
--

DROP TABLE IF EXISTS `envio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `envio` (
  `Referencia` int NOT NULL,
  `NSA_Queixa` int NOT NULL,
  `DtEnvio` date NOT NULL,
  `NSA_Transp` int NOT NULL,
  PRIMARY KEY (`Referencia`),
  KEY `NSA_Queixa` (`NSA_Queixa`),
  CONSTRAINT `envio_ibfk_1` FOREIGN KEY (`NSA_Queixa`) REFERENCES `queixa` (`NSA`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `envio`
--

LOCK TABLES `envio` WRITE;
/*!40000 ALTER TABLE `envio` DISABLE KEYS */;
/*!40000 ALTER TABLE `envio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equiprecebido`
--

DROP TABLE IF EXISTS `equiprecebido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equiprecebido` (
  `NSA` int NOT NULL AUTO_INCREMENT,
  `N-S` varchar(50) NOT NULL,
  `DtEntrada` date NOT NULL,
  `TipoEquip` varchar(255) DEFAULT NULL,
  `NSA_Queixa` int DEFAULT NULL,
  `Ref_Quei_Empr` text,
  PRIMARY KEY (`NSA`),
  KEY `N-S` (`N-S`),
  KEY `TipoEquip` (`TipoEquip`),
  KEY `NSA_Queixa` (`NSA_Queixa`),
  CONSTRAINT `equiprecebido_ibfk_1` FOREIGN KEY (`N-S`) REFERENCES `queixa` (`N-S`) ON DELETE CASCADE,
  CONSTRAINT `equiprecebido_ibfk_2` FOREIGN KEY (`TipoEquip`) REFERENCES `queixa` (`TipoEquip`) ON DELETE CASCADE,
  CONSTRAINT `equiprecebido_ibfk_3` FOREIGN KEY (`NSA_Queixa`) REFERENCES `queixa` (`NSA`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equiprecebido`
--

LOCK TABLES `equiprecebido` WRITE;
/*!40000 ALTER TABLE `equiprecebido` DISABLE KEYS */;
/*!40000 ALTER TABLE `equiprecebido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orcamento`
--

DROP TABLE IF EXISTS `orcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orcamento` (
  `NSA` int NOT NULL AUTO_INCREMENT,
  `NSA_Queixa` int DEFAULT NULL,
  `DtOrcamento` date NOT NULL,
  `Comunicado` varchar(255) DEFAULT NULL,
  `FormaCom` varchar(50) NOT NULL,
  `Resumo` text,
  `Resposta` text,
  `DtResposta` date DEFAULT NULL,
  `Pago` enum('Sim','Não') NOT NULL,
  `DtPagamento` date DEFAULT NULL,
  PRIMARY KEY (`NSA`),
  KEY `NSA_Queixa` (`NSA_Queixa`),
  CONSTRAINT `orcamento_ibfk_1` FOREIGN KEY (`NSA_Queixa`) REFERENCES `queixa` (`NSA`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orcamento`
--

LOCK TABLES `orcamento` WRITE;
/*!40000 ALTER TABLE `orcamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `orcamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `queixa`
--

DROP TABLE IF EXISTS `queixa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `queixa` (
  `NSA` int NOT NULL AUTO_INCREMENT,
  `NIF_Utilizador` varchar(9) NOT NULL,
  `TipoEquip` varchar(255) DEFAULT NULL,
  `N-S` varchar(50) NOT NULL,
  `DtQueixa` date NOT NULL,
  `Descricao` text NOT NULL,
  `Decisao` text,
  PRIMARY KEY (`NSA`),
  KEY `NIF_Utilizador` (`NIF_Utilizador`),
  KEY `idx_tipo_equip` (`TipoEquip`),
  KEY `idx_ns` (`N-S`),
  KEY `idx_nsa` (`NSA`),
  CONSTRAINT `queixa_ibfk_1` FOREIGN KEY (`NIF_Utilizador`) REFERENCES `utilizador` (`NIF`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queixa`
--

LOCK TABLES `queixa` WRITE;
/*!40000 ALTER TABLE `queixa` DISABLE KEYS */;
/*!40000 ALTER TABLE `queixa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilizador`
--

DROP TABLE IF EXISTS `utilizador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utilizador` (
  `NIF` varchar(9) NOT NULL,
  `Nome` varchar(255) NOT NULL,
  `Processo` int NOT NULL,
  `NIFEE` varchar(9) NOT NULL,
  `NomeEE` varchar(255) NOT NULL,
  `EmailEE` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`NIF`),
  KEY `idx_nif` (`NIF`),
  KEY `idx_nifee` (`NIFEE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilizador`
--

LOCK TABLES `utilizador` WRITE;
/*!40000 ALTER TABLE `utilizador` DISABLE KEYS */;
/*!40000 ALTER TABLE `utilizador` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-24 15:51:24
