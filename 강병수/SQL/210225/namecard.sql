-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        8.0.22 - MySQL Community Server - GPL
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- ex210225 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `ex210225` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ex210225`;

-- 테이블 ex210225.namecard 구조 내보내기
CREATE TABLE IF NOT EXISTS `namecard` (
  `NUMBER` int NOT NULL,
  `name` varchar(20) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`NUMBER`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 ex210225.namecard:~0 rows (대략적) 내보내기
DELETE FROM `namecard`;
/*!40000 ALTER TABLE `namecard` DISABLE KEYS */;
INSERT INTO `namecard` (`NUMBER`, `name`, `phone`, `email`) VALUES
	(1, '박길동', '010-999-9999', NULL),
	(2, '고길동', '010-5678-5768', NULL),
	(3, '둘리', '010-5551-3125', NULL),
	(4, '또치', '011-579-1354', NULL),
	(5, '마이콜', '019-123-789', NULL),
	(6, '희동이', '', NULL),
	(7, '도우너', '010-4523-4811', NULL);
/*!40000 ALTER TABLE `namecard` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
