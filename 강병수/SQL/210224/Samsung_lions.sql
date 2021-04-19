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


-- ex210224 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `ex210224` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ex210224`;

-- 테이블 ex210224.samsung_lions 구조 내보내기
CREATE TABLE IF NOT EXISTS `samsung_lions` (
  `number` varchar(50) DEFAULT NULL,
  `name` varchar(20) NOT NULL,
  `position` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `comment` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 ex210224.samsung_lions:~112 rows (대략적) 내보내기
/*!40000 ALTER TABLE `samsung_lions` DISABLE KEYS */;
INSERT IGNORE INTO `samsung_lions` (`number`, `name`, `position`, `comment`) VALUES
	('71', '조동찬', '1군 수비코치', NULL),
	('72', '이윤효', '육성군 야수코치', NULL),
	('73', '윤성철', '트레이닝 코치', NULL),
	('74', '박한이', '육성군 코치', NULL),
	('75', '조규제', '육성군 투수코치', NULL),
	('76', '이영수', '1군 타격보조코치', NULL),
	('77', '김종훈', '2군 타격코치', NULL),
	('78', '강봉규', '2군 주루&외야수비코치', NULL),
	('79', '박진만', '1군 작전코치(3루)', NULL),
	('80', '황승현', '트레이닝 코치', NULL),
	('81', '권요경', '트레이닝 코치', NULL),
	('82', '김현규', '트레이닝 코치', NULL),
	('83', '윤석훈', '트레이닝 코치', NULL),
	('84', '이상일', '트레이닝 코치', NULL),
	('85', '최태원', '1군 수석코치', NULL),
	('89', '이정식', '1군 배터리코치', NULL),
	('87', '김용달', '1군 타격코치', NULL),
	('88', '오치아이', '2군 감독', NULL),
	('70', '허삼영', '1군 감독', NULL),
	('90', '권오원', '2군 투수코치', NULL),
	('95', '전일우', '트레이닝 코치', NULL),
	('96', '류호인', '트레이닝 코치', NULL),
	('97', '강명구', '1군 주루코치(1루)', NULL),
	('98', '채상병', '2군 배터리코치', NULL),
	('12', '김민수', '우투우타 포수', NULL),
	('0', '김재현', '유격수', NULL),
	('4', '뷰캐넌', '우투우타', NULL),
	('11', '홍정우', '우투우타', NULL),
	('15', '양창섭', '우투우타', NULL),
	('17', '김대우', '우투우타(언)', NULL),
	('18', '심창민', '우투우타(사)', NULL),
	('19', '구준범', '좌투좌타', NULL),
	('20', '이승현', '우투우타', NULL),
	('21', '오승환', '우투우타', NULL),
	('23', '장필준', '우투우타', NULL),
	('25', '김윤수', '우투우타', NULL),
	('28', '임대한', '우투좌타', NULL),
	('29', '백정현', '좌투좌타', NULL),
	('30', '홍원표', '우투우타', NULL),
	('86', '한흥일', '트레이닝 코치', NULL),
	('39', '라이블리', '우투우타', NULL),
	('40', '최지광', '우투우타', NULL),
	('41', '봉민호', '좌투좌타', NULL),
	('43', '장지훈', '우투우타', NULL),
	('45', '이재익', '좌투좌타', NULL),
	('46', '원태인', '우투좌타', NULL),
	('49', '허윤동', '좌투좌타', NULL),
	('50', '박세응', '좌투좌타', NULL),
	('51', '최충연', '우투우타', NULL),
	('54', '이승현', '좌투좌타', NULL),
	('56', '최재흥', '좌투좌타', NULL),
	('57', '임현준', '좌투좌타(언)', NULL),
	('59', '이상민', '좌투좌타', NULL),
	('60', '이재희', '우투좌타', NULL),
	('61', '황동재', '우투우타', NULL),
	('62', '홍무원', '우투우타', NULL),
	('64', '이승민', '좌투좌타', NULL),
	('101', '박주혁', '우투우타', '육성선수'),
	('37', '노성호', '좌투좌타', NULL),
	('104', '김준우', '우투좌타', '육성선수'),
	('106', '김동찬', '우투우타', '육성선수'),
	('108', '홍승원', '우투우타', '육성선수'),
	('111', '이기용', '좌투좌타', '육성선수'),
	('112', '한연욱', '우투우타(사)', '육성선수'),
	('102', '김결의', '우투우타 포수', '육성선수'),
	('100', '이수민', '좌투좌타', '육성선수'),
	('27', '김응민', '우투우타 포수', NULL),
	('42', '김도환', '우투우타 포수', NULL),
	('47', '강민호', '우투우타 포수', NULL),
	('48', '권정웅', '우투우타 포수', NULL),
	('99', '황두성', '1군 불펜코치', NULL),
	('109', '김세민', '우투우타 포수', '육성선수'),
	('119', '조경원', '좌투좌타', '육성선수'),
	('6', '강한울', '2루수', NULL),
	('7', '김상수', '2루수,유격수', NULL),
	('8', '김호재', '3루수', NULL),
	('9', '김성표', '2루수', NULL),
	('14', '안주형', '2루수', NULL),
	('16', '이원석', '3루수', NULL),
	('26', '이성규', '1루수', NULL),
	('2', '우규민', '우투좌타', NULL),
	('31', '양우현', '2루수', NULL),
	('32', '최형진', '3루수', NULL),
	('44', '오재일', '1루수', NULL),
	('53', '이학주', '유격수', NULL),
	('58', '김지찬', '2루수', NULL),
	('24', '백승민', '1루수', NULL),
	('107', '이창용', '우투우타 내야수', '육성선수'),
	('66', '오현석', '우투좌타 내야수', NULL),
	('115', '김태수', '2루수', '육성선수'),
	('116', '이해승', '유격수', '육성선수'),
	('103', '김동진', '우투좌타 내야수', '육성선수'),
	('5', '구자욱', '우익수', NULL),
	('13', '박해민', '중견수', NULL),
	('34', '김헌곤', '좌익수', NULL),
	('35', '이태훈', '좌익수', NULL),
	('38', '김동엽', '좌익수', NULL),
	('52', '송준석', '좌익수', NULL),
	('55', '이성곤', '우익수', NULL),
	('63', '피렐라', '좌익수', NULL),
	('65', '박승규', '중견수', NULL),
	('67', '김성윤', '중견수', NULL),
	('68', '주한울', '우투우타 외야수', NULL),
	('3', '이현동', '좌익수', NULL),
	('105', '김경민', '우투우타 외야수', '육성선수'),
	('117', '김현준', '좌투좌타 외야수', '육성선수'),
	('00', '최선호', '중견수', '육성선수'),
	(NULL, '정진수', '우투좌타 포수', NULL),
	(NULL, '김재걸', '2군 수비&작전코치', NULL),
	('10', '양준혁', '지명타자', '영구결번'),
	('22', '이만수', '우투우타 포수', '영구결번'),
	('36', '이승엽', '지명타자', '영구결번');
/*!40000 ALTER TABLE `samsung_lions` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
