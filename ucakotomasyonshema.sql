-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: otomasyon
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `adminler`
--

DROP TABLE IF EXISTS `adminler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adminler` (
  `admin_id` int NOT NULL AUTO_INCREMENT,
  `admin_kullanici_adi` varchar(45) NOT NULL,
  `admin_sifre` varchar(45) NOT NULL,
  PRIMARY KEY (`admin_id`),
  UNIQUE KEY `idadminler_UNIQUE` (`admin_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adminler`
--

LOCK TABLES `adminler` WRITE;
/*!40000 ALTER TABLE `adminler` DISABLE KEYS */;
INSERT INTO `adminler` VALUES (1,'yekaranfil','12345'),(2,'saitkcbs','54321'),(3,'lamartune','12345');
/*!40000 ALTER TABLE `adminler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `biletler`
--

DROP TABLE IF EXISTS `biletler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `biletler` (
  `bilet_id` int NOT NULL AUTO_INCREMENT,
  `biletadi` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`bilet_id`)
) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `biletler`
--

LOCK TABLES `biletler` WRITE;
/*!40000 ALTER TABLE `biletler` DISABLE KEYS */;
INSERT INTO `biletler` VALUES (1,NULL),(2,NULL),(3,'a'),(4,'a'),(5,'a'),(6,'a'),(7,'a'),(8,'a'),(9,'a'),(10,'a'),(11,'a'),(12,'a'),(13,'a'),(14,'a'),(15,'a'),(16,'a'),(17,'a'),(18,'a'),(19,'a'),(20,'a'),(21,'a'),(22,'a'),(23,'a'),(24,'a'),(25,'a'),(26,'a'),(27,'a'),(28,'a'),(29,'a'),(30,'a'),(31,'a'),(32,'a'),(33,'a'),(34,'a'),(35,'a'),(36,'a'),(37,'a'),(38,'a'),(39,'a'),(40,'a'),(41,'a'),(42,'a'),(43,'a'),(44,'a'),(45,'a'),(46,'a'),(47,'a'),(48,'a'),(49,'a'),(50,'a'),(51,'a'),(52,'a'),(53,'a'),(54,'a'),(55,'a'),(56,'a'),(57,'a'),(58,'a'),(59,'a'),(60,'a'),(61,'a'),(62,'a'),(63,'a'),(64,'a'),(65,'a'),(66,'a'),(67,'a'),(68,'a'),(69,'a'),(70,'a'),(71,'a'),(72,'a'),(73,'a'),(74,'a'),(75,'a'),(76,'a'),(77,'a'),(78,'a'),(79,'a'),(80,'a'),(81,'a'),(82,'a'),(83,'a'),(84,'a'),(85,'a'),(86,'a'),(87,'a'),(88,'a'),(89,'a'),(90,'a'),(91,'a'),(92,'a'),(93,'a'),(94,'a'),(95,'a'),(96,'a'),(97,'a'),(98,'a'),(99,'a'),(100,'a'),(101,'a'),(102,'a'),(103,'a'),(104,'a'),(105,'a'),(106,'a'),(107,'a'),(108,'a'),(109,'a'),(110,'a'),(111,'a'),(112,'a'),(113,'a'),(114,'a'),(115,'a'),(116,'a'),(117,'a');
/*!40000 ALTER TABLE `biletler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `biletler_has_yolcular`
--

DROP TABLE IF EXISTS `biletler_has_yolcular`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `biletler_has_yolcular` (
  `biletler_bilet_id` int NOT NULL,
  `yolcular_yolcu_id` int NOT NULL,
  `ucuslar_ucus_id` int NOT NULL,
  `koltukno` varchar(45) DEFAULT NULL,
  `bilettur` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`biletler_bilet_id`,`yolcular_yolcu_id`),
  KEY `fk_biletler_has_yolcular_biletler1_idx` (`biletler_bilet_id`),
  KEY `fk_biletler_has_yolcular_ucuslar1_idx` (`ucuslar_ucus_id`),
  KEY `fk_biletler_has_yolcular_yolcular1_idx` (`yolcular_yolcu_id`),
  CONSTRAINT `fk_biletler_has_yolcular_biletler1` FOREIGN KEY (`biletler_bilet_id`) REFERENCES `biletler` (`bilet_id`),
  CONSTRAINT `fk_biletler_has_yolcular_ucuslar1` FOREIGN KEY (`ucuslar_ucus_id`) REFERENCES `ucuslar` (`ucus_id`),
  CONSTRAINT `fk_biletler_has_yolcular_yolcular1` FOREIGN KEY (`yolcular_yolcu_id`) REFERENCES `yolcular` (`yolcu_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `biletler_has_yolcular`
--

LOCK TABLES `biletler_has_yolcular` WRITE;
/*!40000 ALTER TABLE `biletler_has_yolcular` DISABLE KEYS */;
INSERT INTO `biletler_has_yolcular` VALUES (88,19,23,'6','EKONOMİ'),(90,19,23,'39','EKONOMİ'),(92,19,22,'22','BUSSİNES'),(93,19,22,'51','EKONOMİ'),(94,19,22,'34','EKONOMİ'),(95,19,22,'25','BUSSİNES'),(96,19,22,'36','EKONOMİ'),(97,19,22,'42','BUSSİNES'),(98,19,22,'29','EKONOMİ'),(99,19,22,'30','EKONOMİ'),(100,19,22,'14','EKONOMİ'),(101,19,29,'13','EKONOMİ'),(102,19,23,'36','EKONOMİ'),(103,19,23,'30','BUSSİNES'),(104,19,22,'25','BUSSİNES'),(115,19,22,'55','EKONOMİ'),(116,19,22,'21','BUSSİNES');
/*!40000 ALTER TABLE `biletler_has_yolcular` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cinsiyetler`
--

DROP TABLE IF EXISTS `cinsiyetler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cinsiyetler` (
  `cinsiyet_id` int NOT NULL AUTO_INCREMENT,
  `cinsiyet_adi` varchar(45) NOT NULL,
  PRIMARY KEY (`cinsiyet_id`),
  UNIQUE KEY `cinsiyet_id_UNIQUE` (`cinsiyet_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cinsiyetler`
--

LOCK TABLES `cinsiyetler` WRITE;
/*!40000 ALTER TABLE `cinsiyetler` DISABLE KEYS */;
INSERT INTO `cinsiyetler` VALUES (1,'belirtilmemis'),(2,'erkek'),(3,'kadin');
/*!40000 ALTER TABLE `cinsiyetler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `firmalar`
--

DROP TABLE IF EXISTS `firmalar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `firmalar` (
  `firmalar_id` int NOT NULL AUTO_INCREMENT,
  `firma_adi` varchar(45) NOT NULL,
  `firma_logo` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`firmalar_id`),
  UNIQUE KEY `firmalar_id_UNIQUE` (`firmalar_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `firmalar`
--

LOCK TABLES `firmalar` WRITE;
/*!40000 ALTER TABLE `firmalar` DISABLE KEYS */;
INSERT INTO `firmalar` VALUES (1,'Pegasus',NULL),(2,'Türk Hava Yolları',NULL),(3,'Sunexpress',NULL),(4,'AnadoluJet',NULL);
/*!40000 ALTER TABLE `firmalar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iptaltalebi`
--

DROP TABLE IF EXISTS `iptaltalebi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iptaltalebi` (
  `talep_id` int NOT NULL AUTO_INCREMENT,
  `biletid` varchar(45) DEFAULT NULL,
  `ucusid` varchar(45) DEFAULT NULL,
  `koltukid` varchar(45) DEFAULT NULL,
  `kisiid` varchar(45) DEFAULT NULL,
  `biletsinif` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`talep_id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iptaltalebi`
--

LOCK TABLES `iptaltalebi` WRITE;
/*!40000 ALTER TABLE `iptaltalebi` DISABLE KEYS */;
/*!40000 ALTER TABLE `iptaltalebi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `koltuklar`
--

DROP TABLE IF EXISTS `koltuklar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `koltuklar` (
  `koltuk_id` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`koltuk_id`),
  UNIQUE KEY `koltuk_id_UNIQUE` (`koltuk_id`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `koltuklar`
--

LOCK TABLES `koltuklar` WRITE;
/*!40000 ALTER TABLE `koltuklar` DISABLE KEYS */;
INSERT INTO `koltuklar` VALUES (1),(2),(3),(4),(5),(6),(7),(8),(9),(10),(11),(12),(13),(14),(15),(16),(17),(18),(19),(20),(21),(22),(23),(24),(25),(26),(27),(28),(29),(30),(31),(32),(33),(34),(35),(36),(37),(38),(39),(40),(41),(42),(43),(44),(45),(46),(47),(48),(49),(50),(51),(52),(53),(54),(55),(56),(57),(58),(59),(60),(61),(62),(63),(70),(71),(72);
/*!40000 ALTER TABLE `koltuklar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `koltuklar_has_ucaklar`
--

DROP TABLE IF EXISTS `koltuklar_has_ucaklar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `koltuklar_has_ucaklar` (
  `koltuklar_koltuk_id` int NOT NULL,
  `ucuslar_ucus_id` varchar(45) NOT NULL,
  `dolubos` varchar(10) DEFAULT NULL,
  `koltukidsi` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`koltukidsi`),
  KEY `fk_koltuklar_has_ucaklar_koltuklar1_idx` (`koltuklar_koltuk_id`),
  KEY `fk_koltuklar_has_ucaklar_ucuslar1_idx` (`ucuslar_ucus_id`),
  CONSTRAINT `fk_koltuklar_has_ucaklar_koltuklar1` FOREIGN KEY (`koltuklar_koltuk_id`) REFERENCES `koltuklar` (`koltuk_id`)
) ENGINE=InnoDB AUTO_INCREMENT=875 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `koltuklar_has_ucaklar`
--

LOCK TABLES `koltuklar_has_ucaklar` WRITE;
/*!40000 ALTER TABLE `koltuklar_has_ucaklar` DISABLE KEYS */;
INSERT INTO `koltuklar_has_ucaklar` VALUES (1,'20','BOS',307),(2,'20','BOS',308),(3,'20','BOS',309),(4,'20','BOS',310),(5,'20','BOS',311),(6,'20','BOS',312),(7,'20','BOS',313),(8,'20','BOS',314),(9,'20','BOS',315),(10,'20','BOS',316),(11,'20','BOS',317),(12,'20','BOS',318),(13,'20','BOS',319),(14,'20','BOS',320),(15,'20','BOS',321),(16,'20','BOS',322),(17,'20','BOS',323),(18,'20','BOS',324),(19,'20','BOS',325),(20,'20','BOS',326),(21,'20','BOS',327),(22,'20','BOS',328),(23,'20','BOS',329),(24,'20','BOS',330),(25,'20','BOS',331),(26,'20','BOS',332),(27,'20','BOS',333),(28,'20','BOS',334),(29,'20','BOS',335),(30,'20','BOS',336),(31,'20','BOS',337),(32,'20','BOS',338),(33,'20','BOS',339),(34,'20','BOS',340),(35,'20','BOS',341),(36,'20','BOS',342),(37,'20','BOS',343),(38,'20','BOS',344),(39,'20','BOS',345),(40,'20','BOS',346),(41,'20','BOS',347),(42,'20','BOS',348),(43,'20','BOS',349),(44,'20','BOS',350),(45,'20','BOS',351),(46,'20','BOS',352),(47,'20','BOS',353),(48,'20','BOS',354),(49,'20','BOS',355),(50,'20','BOS',356),(51,'20','BOS',357),(52,'20','BOS',358),(53,'20','BOS',359),(54,'20','BOS',360),(55,'20','BOS',361),(56,'20','BOS',362),(1,'21','BOS',363),(2,'21','BOS',364),(3,'21','BOS',365),(4,'21','BOS',366),(5,'21','BOS',367),(6,'21','BOS',368),(7,'21','BOS',369),(8,'21','BOS',370),(9,'21','BOS',371),(10,'21','BOS',372),(11,'21','BOS',373),(12,'21','BOS',374),(13,'21','BOS',375),(14,'21','BOS',376),(15,'21','BOS',377),(16,'21','BOS',378),(17,'21','BOS',379),(18,'21','BOS',380),(19,'21','BOS',381),(20,'21','BOS',382),(21,'21','BOS',383),(22,'21','BOS',384),(23,'21','BOS',385),(24,'21','BOS',386),(25,'21','BOS',387),(26,'21','BOS',388),(27,'21','BOS',389),(28,'21','BOS',390),(29,'21','BOS',391),(30,'21','BOS',392),(31,'21','BOS',393),(32,'21','BOS',394),(33,'21','BOS',395),(34,'21','BOS',396),(35,'21','BOS',397),(36,'21','BOS',398),(37,'21','BOS',399),(38,'21','BOS',400),(39,'21','BOS',401),(40,'21','BOS',402),(1,'22','BOS',403),(2,'22','BOS',404),(3,'22','BOS',405),(4,'22','BOS',406),(5,'22','BOS',407),(6,'22','BOS',408),(7,'22','BOS',409),(8,'22','BOS',410),(9,'22','BOS',411),(10,'22','BOS',412),(11,'22','BOS',413),(12,'22','BOS',414),(13,'22','BOS',415),(14,'22','DOLU',416),(15,'22','BOS',417),(16,'22','BOS',418),(17,'22','BOS',419),(18,'22','BOS',420),(19,'22','BOS',421),(20,'22','BOS',422),(21,'22','DOLU',423),(22,'22','DOLU',424),(23,'22','BOS',425),(24,'22','BOS',426),(25,'22','DOLU',427),(26,'22','BOS',428),(27,'22','BOS',429),(28,'22','BOS',430),(29,'22','DOLU',431),(30,'22','DOLU',432),(31,'22','BOS',433),(32,'22','BOS',434),(33,'22','BOS',435),(34,'22','DOLU',436),(35,'22','BOS',437),(36,'22','DOLU',438),(37,'22','BOS',439),(38,'22','BOS',440),(39,'22','BOS',441),(40,'22','BOS',442),(41,'22','BOS',443),(42,'22','DOLU',444),(43,'22','BOS',445),(44,'22','BOS',446),(45,'22','BOS',447),(46,'22','BOS',448),(47,'22','BOS',449),(48,'22','BOS',450),(49,'22','BOS',451),(50,'22','BOS',452),(51,'22','DOLU',453),(52,'22','BOS',454),(53,'22','BOS',455),(54,'22','BOS',456),(55,'22','DOLU',457),(56,'22','BOS',458),(1,'23','BOS',459),(2,'23','BOS',460),(3,'23','BOS',461),(4,'23','BOS',462),(5,'23','BOS',463),(6,'23','DOLU',464),(7,'23','BOS',465),(8,'23','BOS',466),(9,'23','BOS',467),(10,'23','BOS',468),(11,'23','BOS',469),(12,'23','BOS',470),(13,'23','BOS',471),(14,'23','BOS',472),(15,'23','BOS',473),(16,'23','BOS',474),(17,'23','BOS',475),(18,'23','BOS',476),(19,'23','BOS',477),(20,'23','BOS',478),(21,'23','BOS',479),(22,'23','BOS',480),(23,'23','BOS',481),(24,'23','BOS',482),(25,'23','BOS',483),(26,'23','BOS',484),(27,'23','BOS',485),(28,'23','BOS',486),(29,'23','BOS',487),(30,'23','DOLU',488),(31,'23','BOS',489),(32,'23','BOS',490),(33,'23','BOS',491),(34,'23','BOS',492),(35,'23','BOS',493),(36,'23','DOLU',494),(37,'23','BOS',495),(38,'23','BOS',496),(39,'23','DOLU',497),(40,'23','BOS',498),(1,'24','BOS',499),(2,'24','BOS',500),(3,'24','BOS',501),(4,'24','BOS',502),(5,'24','BOS',503),(6,'24','BOS',504),(7,'24','BOS',505),(8,'24','BOS',506),(9,'24','BOS',507),(10,'24','BOS',508),(11,'24','BOS',509),(12,'24','BOS',510),(13,'24','BOS',511),(14,'24','BOS',512),(15,'24','BOS',513),(16,'24','BOS',514),(17,'24','BOS',515),(18,'24','BOS',516),(19,'24','BOS',517),(20,'24','BOS',518),(21,'24','BOS',519),(22,'24','BOS',520),(23,'24','BOS',521),(24,'24','BOS',522),(25,'24','BOS',523),(26,'24','BOS',524),(27,'24','BOS',525),(28,'24','BOS',526),(29,'24','BOS',527),(30,'24','BOS',528),(31,'24','BOS',529),(32,'24','BOS',530),(33,'24','BOS',531),(34,'24','BOS',532),(35,'24','BOS',533),(36,'24','BOS',534),(37,'24','BOS',535),(38,'24','BOS',536),(39,'24','BOS',537),(40,'24','BOS',538),(41,'24','BOS',539),(42,'24','BOS',540),(43,'24','BOS',541),(44,'24','BOS',542),(45,'24','BOS',543),(46,'24','BOS',544),(47,'24','BOS',545),(48,'24','BOS',546),(49,'24','BOS',547),(50,'24','BOS',548),(51,'24','BOS',549),(52,'24','BOS',550),(53,'24','BOS',551),(54,'24','BOS',552),(55,'24','BOS',553),(56,'24','BOS',554),(57,'24','BOS',555),(58,'24','BOS',556),(59,'24','BOS',557),(60,'24','BOS',558),(61,'24','BOS',559),(62,'24','BOS',560),(63,'24','BOS',561),(1,'25','BOS',563),(2,'25','BOS',564),(3,'25','BOS',565),(4,'25','BOS',566),(5,'25','BOS',567),(6,'25','BOS',568),(7,'25','BOS',569),(8,'25','BOS',570),(9,'25','BOS',571),(10,'25','BOS',572),(11,'25','BOS',573),(12,'25','BOS',574),(13,'25','BOS',575),(14,'25','BOS',576),(15,'25','BOS',577),(16,'25','BOS',578),(17,'25','BOS',579),(18,'25','BOS',580),(19,'25','BOS',581),(20,'25','BOS',582),(21,'25','BOS',583),(22,'25','BOS',584),(23,'25','BOS',585),(24,'25','BOS',586),(25,'25','BOS',587),(26,'25','BOS',588),(27,'25','BOS',589),(28,'25','BOS',590),(29,'25','BOS',591),(30,'25','BOS',592),(31,'25','BOS',593),(32,'25','BOS',594),(33,'25','BOS',595),(34,'25','BOS',596),(35,'25','BOS',597),(36,'25','BOS',598),(37,'25','BOS',599),(38,'25','BOS',600),(39,'25','BOS',601),(40,'25','BOS',602),(41,'25','BOS',603),(42,'25','BOS',604),(43,'25','BOS',605),(44,'25','BOS',606),(45,'25','BOS',607),(46,'25','BOS',608),(47,'25','BOS',609),(48,'25','BOS',610),(49,'25','BOS',611),(50,'25','BOS',612),(51,'25','BOS',613),(52,'25','BOS',614),(53,'25','BOS',615),(54,'25','BOS',616),(55,'25','BOS',617),(56,'25','BOS',618),(57,'25','BOS',619),(58,'25','BOS',620),(59,'25','BOS',621),(60,'25','BOS',622),(61,'25','BOS',623),(62,'25','BOS',624),(63,'25','BOS',625),(1,'26','BOS',627),(2,'26','BOS',628),(3,'26','BOS',629),(4,'26','BOS',630),(5,'26','BOS',631),(6,'26','BOS',632),(7,'26','BOS',633),(8,'26','BOS',634),(9,'26','BOS',635),(10,'26','BOS',636),(11,'26','BOS',637),(12,'26','BOS',638),(13,'26','BOS',639),(14,'26','BOS',640),(15,'26','BOS',641),(16,'26','BOS',642),(17,'26','BOS',643),(18,'26','BOS',644),(19,'26','BOS',645),(20,'26','BOS',646),(21,'26','BOS',647),(22,'26','BOS',648),(23,'26','BOS',649),(24,'26','BOS',650),(25,'26','BOS',651),(26,'26','BOS',652),(27,'26','BOS',653),(28,'26','BOS',654),(29,'26','BOS',655),(30,'26','BOS',656),(31,'26','BOS',657),(32,'26','BOS',658),(33,'26','BOS',659),(34,'26','BOS',660),(35,'26','BOS',661),(36,'26','BOS',662),(37,'26','BOS',663),(38,'26','BOS',664),(39,'26','BOS',665),(40,'26','BOS',666),(1,'27','BOS',667),(2,'27','BOS',668),(3,'27','BOS',669),(4,'27','BOS',670),(5,'27','BOS',671),(6,'27','BOS',672),(7,'27','BOS',673),(8,'27','BOS',674),(9,'27','BOS',675),(10,'27','BOS',676),(11,'27','BOS',677),(12,'27','BOS',678),(13,'27','BOS',679),(14,'27','BOS',680),(15,'27','BOS',681),(16,'27','BOS',682),(17,'27','BOS',683),(18,'27','BOS',684),(19,'27','BOS',685),(20,'27','BOS',686),(21,'27','BOS',687),(22,'27','BOS',688),(23,'27','BOS',689),(24,'27','BOS',690),(25,'27','BOS',691),(26,'27','BOS',692),(27,'27','BOS',693),(28,'27','BOS',694),(29,'27','BOS',695),(30,'27','BOS',696),(31,'27','BOS',697),(32,'27','BOS',698),(33,'27','BOS',699),(34,'27','BOS',700),(35,'27','BOS',701),(36,'27','BOS',702),(37,'27','BOS',703),(38,'27','BOS',704),(39,'27','BOS',705),(40,'27','BOS',706),(1,'28','BOS',707),(2,'28','BOS',708),(3,'28','BOS',709),(4,'28','BOS',710),(5,'28','BOS',711),(6,'28','BOS',712),(7,'28','BOS',713),(8,'28','BOS',714),(9,'28','BOS',715),(10,'28','BOS',716),(11,'28','BOS',717),(12,'28','BOS',718),(13,'28','BOS',719),(14,'28','BOS',720),(15,'28','BOS',721),(16,'28','BOS',722),(17,'28','BOS',723),(18,'28','BOS',724),(19,'28','BOS',725),(20,'28','BOS',726),(21,'28','BOS',727),(22,'28','BOS',728),(23,'28','BOS',729),(24,'28','BOS',730),(25,'28','BOS',731),(26,'28','BOS',732),(27,'28','BOS',733),(28,'28','BOS',734),(29,'28','BOS',735),(30,'28','BOS',736),(31,'28','BOS',737),(32,'28','BOS',738),(33,'28','BOS',739),(34,'28','BOS',740),(35,'28','BOS',741),(36,'28','BOS',742),(37,'28','BOS',743),(38,'28','BOS',744),(39,'28','BOS',745),(40,'28','BOS',746),(1,'29','BOS',747),(2,'29','BOS',748),(3,'29','BOS',749),(4,'29','BOS',750),(5,'29','BOS',751),(6,'29','BOS',752),(7,'29','BOS',753),(8,'29','BOS',754),(9,'29','BOS',755),(10,'29','BOS',756),(11,'29','BOS',757),(12,'29','BOS',758),(13,'29','DOLU',759),(14,'29','BOS',760),(15,'29','BOS',761),(16,'29','BOS',762),(17,'29','BOS',763),(18,'29','BOS',764),(19,'29','BOS',765),(20,'29','BOS',766),(21,'29','BOS',767),(22,'29','BOS',768),(23,'29','BOS',769),(24,'29','BOS',770),(25,'29','BOS',771),(26,'29','BOS',772),(27,'29','BOS',773),(28,'29','BOS',774),(29,'29','BOS',775),(30,'29','BOS',776),(31,'29','BOS',777),(32,'29','BOS',778),(33,'29','BOS',779),(34,'29','BOS',780),(35,'29','BOS',781),(36,'29','BOS',782),(37,'29','BOS',783),(38,'29','BOS',784),(39,'29','BOS',785),(40,'29','BOS',786),(41,'29','BOS',787),(42,'29','BOS',788),(43,'29','BOS',789),(44,'29','BOS',790),(45,'29','BOS',791),(46,'29','BOS',792),(47,'29','BOS',793),(48,'29','BOS',794),(49,'29','BOS',795),(50,'29','BOS',796),(51,'29','BOS',797),(52,'29','BOS',798),(53,'29','BOS',799),(54,'29','BOS',800),(55,'29','BOS',801),(56,'29','BOS',802),(57,'29','BOS',803),(58,'29','BOS',804),(59,'29','BOS',805),(60,'29','BOS',806),(61,'29','BOS',807),(62,'29','BOS',808),(63,'29','BOS',809),(1,'30','BOS',811),(2,'30','BOS',812),(3,'30','BOS',813),(4,'30','BOS',814),(5,'30','BOS',815),(6,'30','BOS',816),(7,'30','BOS',817),(8,'30','BOS',818),(9,'30','BOS',819),(10,'30','BOS',820),(11,'30','BOS',821),(12,'30','BOS',822),(13,'30','BOS',823),(14,'30','BOS',824),(15,'30','BOS',825),(16,'30','BOS',826),(17,'30','BOS',827),(18,'30','BOS',828),(19,'30','BOS',829),(20,'30','BOS',830),(21,'30','BOS',831),(22,'30','BOS',832),(23,'30','BOS',833),(24,'30','BOS',834),(25,'30','BOS',835),(26,'30','BOS',836),(27,'30','BOS',837),(28,'30','BOS',838),(29,'30','BOS',839),(30,'30','BOS',840),(31,'30','BOS',841),(32,'30','BOS',842),(33,'30','BOS',843),(34,'30','BOS',844),(35,'30','BOS',845),(36,'30','BOS',846),(37,'30','BOS',847),(38,'30','BOS',848),(39,'30','BOS',849),(40,'30','BOS',850),(41,'30','BOS',851),(42,'30','BOS',852),(43,'30','BOS',853),(44,'30','BOS',854),(45,'30','BOS',855),(46,'30','BOS',856),(47,'30','BOS',857),(48,'30','BOS',858),(49,'30','BOS',859),(50,'30','BOS',860),(51,'30','BOS',861),(52,'30','BOS',862),(53,'30','BOS',863),(54,'30','BOS',864),(55,'30','BOS',865),(56,'30','BOS',866),(57,'30','BOS',867),(58,'30','BOS',868),(59,'30','BOS',869),(60,'30','BOS',870),(61,'30','BOS',871),(62,'30','BOS',872),(63,'30','BOS',873);
/*!40000 ALTER TABLE `koltuklar_has_ucaklar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sehirler`
--

DROP TABLE IF EXISTS `sehirler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sehirler` (
  `sehir_id` int NOT NULL AUTO_INCREMENT,
  `sehir_ad` varchar(100) NOT NULL,
  PRIMARY KEY (`sehir_id`),
  UNIQUE KEY `sehir_id_UNIQUE` (`sehir_id`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sehirler`
--

LOCK TABLES `sehirler` WRITE;
/*!40000 ALTER TABLE `sehirler` DISABLE KEYS */;
INSERT INTO `sehirler` VALUES (1,'Adana Havalimanı'),(2,'Ankara Esenboğa Havalimanı'),(3,'Alanya Gazipaşa Havalimanı'),(4,'Antalya Havalimanı'),(5,'Balıkesir Kocaseyit Havalimanı'),(6,'Bursa Yenişehir Havalimanı'),(7,'Denizli Çardak Havalimanı'),(8,'Diyarbakır Havalimanı'),(9,'Elazığ Havalimanı'),(10,'Erzurum Havalimanı'),(11,'Eskişehir Hasan Polatkan Havalimanı'),(12,'Gaziantep Havalimanı'),(13,'Hatay Havalimanı'),(14,'Isparta Süleyman Demirel Havalimanı'),(15,'İstanbul Yeni Havalimanı'),(16,'İstanbul Sabiha Gökçen Havalimanı'),(17,'İzmir Adnan Menderes Havalimanı'),(18,'Kars Harakani Havalimanı'),(19,'Kayseri Havalimanı'),(20,'Kocaeli Cengiz Topel Havalimanı'),(21,'Konya Havalimanı'),(22,'Kütahya Zafer Havalimanı'),(23,'Malatya Havalimanı'),(24,'Muğla Dalaman Havalimanı'),(25,'Muğla Milas-Bodrum Havalimanı'),(26,'Nevşehir Kapadokya Havalimanı'),(27,'Ordu Giresun Havalimanı'),(28,'Samsun Çarşamba Havalimanı'),(29,'Sinop Havalimanı'),(30,'Sivas Nuri Demirağ Havalimanı'),(31,'Şanlıurfa GAP Havalimanı'),(32,'Tekirdağ Çorlu Havalimanı'),(33,'Trabzon Havalimanı'),(34,'Van Ferit Melen Havalimanı'),(35,'Zonguldak Çaycuma Havalimanı'),(36,'Adıyaman Havalimanı'),(37,'Ağrı Ahmed-i Hani Havalimanı'),(38,'Amasya Merzifon Havalimanı'),(39,'Aydın Çıldır Havalimanı'),(40,'Balıkesir Merkez Havalimanı'),(41,'Batman Havalimanı'),(42,'Bingöl Havalimanı'),(43,'Bursa Yunuseli Havalimanı'),(44,'Gökçeada Havalimanı'),(45,'Erzincan Yıldırım Akbulut Havalimanı'),(46,'Sivrihisar Havacılık Merkezi S.H.M.'),(47,'Hakkâri Yüksekova Selahaddin Eyyubi Havalimanı'),(48,'Iğdır Şehit Bülent Aydın Havalimanı'),(49,'İstanbul Hezarfen Havalimanı'),(50,'Selçuk-Efes Havalimanı'),(51,'Kahramanmaraş Havalimanı'),(52,'Kastamonu Havalimanı'),(53,'Mardin Havalimanı'),(54,'Muş Havalimanı'),(55,'Siirt Havalimanı'),(56,'Şırnak Şerafettin Elçi Havalimanı'),(57,'Tokat Havalimanı');
/*!40000 ALTER TABLE `sehirler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sikayetler`
--

DROP TABLE IF EXISTS `sikayetler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sikayetler` (
  `sikayet_id` int NOT NULL AUTO_INCREMENT,
  `sikayet_metin` varchar(500) NOT NULL,
  `sikayet_mail` varchar(45) NOT NULL,
  PRIMARY KEY (`sikayet_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sikayetler`
--

LOCK TABLES `sikayetler` WRITE;
/*!40000 ALTER TABLE `sikayetler` DISABLE KEYS */;
INSERT INTO `sikayetler` VALUES (16,'DAHA FAZLA UÇUŞ EKLENSİN YURT DIŞI UÇUŞLARI DA OLSUN','y.emrekaranfil@gmail.com'),(17,'kmaolsjfmolasjkfoas','y.emrekaranfil@gmail.com');
/*!40000 ALTER TABLE `sikayetler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ucaklar`
--

DROP TABLE IF EXISTS `ucaklar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ucaklar` (
  `ucak_id` int NOT NULL AUTO_INCREMENT,
  `ucak_plaka` varchar(45) NOT NULL,
  `ucak_koltuksayisi` varchar(45) NOT NULL,
  `firmalar_firmalar_id` int NOT NULL,
  PRIMARY KEY (`ucak_id`,`firmalar_firmalar_id`),
  UNIQUE KEY `ucak_id_UNIQUE` (`ucak_id`),
  KEY `fk_ucaklar_firmalar_idx` (`firmalar_firmalar_id`),
  CONSTRAINT `fk_ucaklar_firmalar` FOREIGN KEY (`firmalar_firmalar_id`) REFERENCES `firmalar` (`firmalar_id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ucaklar`
--

LOCK TABLES `ucaklar` WRITE;
/*!40000 ALTER TABLE `ucaklar` DISABLE KEYS */;
INSERT INTO `ucaklar` VALUES (41,'THY555','56',2),(42,'AND555','40',4),(43,'SUN532','40',3),(46,'PGS562','56',1),(47,'PGS424','72',1),(48,'THY999','40',2),(49,'AND422','56',4),(50,'PGS852','40',1),(51,'SUN236','72',3),(52,'THY871','72',2);
/*!40000 ALTER TABLE `ucaklar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ucuslar`
--

DROP TABLE IF EXISTS `ucuslar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ucuslar` (
  `ucus_id` int NOT NULL AUTO_INCREMENT,
  `ucus_neredenID` varchar(45) NOT NULL,
  `ucus_nereyeID` varchar(45) NOT NULL,
  `ucus_saati` time NOT NULL,
  `ucus_tarih` date NOT NULL,
  `ucus_tahminsure` varchar(60) NOT NULL,
  `normal_bilet` varchar(45) NOT NULL,
  `bussines_bilet` varchar(45) NOT NULL,
  `ucaklar_ucak_id` int NOT NULL,
  `ucaklar_firmalar_firmalar_id` int NOT NULL,
  PRIMARY KEY (`ucus_id`,`ucaklar_ucak_id`,`ucaklar_firmalar_firmalar_id`),
  UNIQUE KEY `ucus_id_UNIQUE` (`ucus_id`),
  KEY `fk_ucuslar_ucaklar1_idx` (`ucaklar_ucak_id`,`ucaklar_firmalar_firmalar_id`),
  CONSTRAINT `fk_ucuslar_ucaklar1` FOREIGN KEY (`ucaklar_ucak_id`, `ucaklar_firmalar_firmalar_id`) REFERENCES `ucaklar` (`ucak_id`, `firmalar_firmalar_id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ucuslar`
--

LOCK TABLES `ucuslar` WRITE;
/*!40000 ALTER TABLE `ucuslar` DISABLE KEYS */;
INSERT INTO `ucuslar` VALUES (20,'1','36','21:00:00','2022-06-09','01:00','350','550',41,2),(21,'21','15','11:00:00','2022-06-10','02:00','400','800',42,4),(22,'21','4','08:00:00','2022-09-09','01:00','250','400',49,4),(23,'21','6','09:05:00','2022-06-10','01:30','225','450',50,1),(24,'36','4','02:10:00','2022-06-11','02:00','400','900',51,3),(26,'15','2','07:10:00','2022-06-11','02:00','800','1100',48,2),(27,'39','13','22:55:00','2022-06-19','02:05','250','500',42,4),(28,'33','21','04:20:00','2022-06-14','01:35','500','850',42,4),(29,'23','57','05:00:00','2022-06-09','01:15','350','600',51,3),(30,'1','4','11:00:00','2022-07-12','02:00','850','1500',52,2);
/*!40000 ALTER TABLE `ucuslar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yolcular`
--

DROP TABLE IF EXISTS `yolcular`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yolcular` (
  `yolcu_id` int NOT NULL AUTO_INCREMENT,
  `yolcu_adi` varchar(45) DEFAULT NULL,
  `yolcu_soyadi` varchar(45) DEFAULT NULL,
  `yolcu_tc` varchar(45) NOT NULL,
  `yolcu_telefon` varchar(45) DEFAULT NULL,
  `yolcu_dogumtarih` date DEFAULT NULL,
  `yolcu_mail` varchar(70) NOT NULL,
  `cinsiyetler_cinsiyet_id` int NOT NULL,
  `yolcu_sifre` varchar(16) NOT NULL,
  PRIMARY KEY (`yolcu_id`,`cinsiyetler_cinsiyet_id`),
  UNIQUE KEY `yolcu_id_UNIQUE` (`yolcu_id`),
  KEY `fk_yolcular_cinsiyetler1_idx` (`cinsiyetler_cinsiyet_id`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yolcular`
--

LOCK TABLES `yolcular` WRITE;
/*!40000 ALTER TABLE `yolcular` DISABLE KEYS */;
INSERT INTO `yolcular` VALUES (19,'Yusuf Emre ','Karanfil','11363704566',NULL,NULL,'y.emrekaranfil@gmail.com',0,'1234');
/*!40000 ALTER TABLE `yolcular` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-19 15:56:46
