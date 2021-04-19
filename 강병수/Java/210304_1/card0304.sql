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


-- mydb 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydb`;

-- 테이블 mydb.card0304 구조 내보내기
CREATE TABLE IF NOT EXISTS `card0304` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(10) NOT NULL,
  `age` int NOT NULL,
  `tel` varchar(20) NOT NULL,
  `address` varchar(40) NOT NULL,
  `email` varchar(30) DEFAULT NULL,
  `date` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 mydb.card0304:~0 rows (대략적) 내보내기
DELETE FROM `card0304`;
/*!40000 ALTER TABLE `card0304` DISABLE KEYS */;
INSERT INTO `card0304` (`id`, `name`, `age`, `tel`, `address`, `email`, `date`) VALUES
	(1, '고길동', 50, '011-877-4632', '서울특별시', 'go@gmail.com', '2021-03-04 15:14:12'),
	(2, '둘리', 3, '010-1357-4525', '서울특별시', NULL, '2021-03-04 15:14:48'),
	(3, '또치', 2, '010-7821-1234', '서울특별시', 'ddochi@gmail.com', '2021-03-04 15:15:11'),
	(4, '도우너', 3, '010-1354-4262', '깐따삐야별', 'donut@naver.com', '2021-03-04 15:15:38'),
	(5, '마이콜', 24, '010-4321-1111', '대구광역시', 'michael@gmail.com', '2021-03-04 15:16:02');
/*!40000 ALTER TABLE `card0304` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
