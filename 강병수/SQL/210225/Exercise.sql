-- 1. DB 접속
/* mysql -uroot -p */

-- 2. 테이블 생성
CREATE TABLE namecard (NAME INT, address VARCHAR(80));

-- 3. 테이블에 데이터 입력하기

INSERT INTO namecard VALUES(0, '홍길동', '010-1358-4532', 'hong@gmail.com');

-- 4. 테이블에서 데이터 가져오기
-- 기본
SELECT * FROM namecard;
SELECT * FROM namecard WHERE NAME = '고길동';
SELECT NAME, phone, FROM namecard WHERE id=1;

-- where 검색조건(And, Or, Not, like, = , <, >, is null, is not null 등등)
SELECT * FROM namecard WHERE id=3;
SELECT * FROM namecard WHERE NAME IS NULL; /* null인 경우 */
SELECT * FROM namecard WHERE NAME kike '%길동'; /* %모든 */

-- order by로 정렬 사용하기
SELECT * FROM namecard ORDER BY NAME; /* 오름차순 정렬 */
SELECT * FROM namecard ORDER BY NAME DESC; /* 내림차순 정렬 */

-- join 사용하기 (두 개 이상의 테이블에서 data 가져오기)
SELECT * FROM USER /* 테이블명 */ JOIN db /* 테이블명 */ WHERE USER.user = db.user;  /* 소문자 user은 필드명 */

-- 5. delete(내용 지우기)

/* DELETE FROM namecard WHERE id = 7; */

-- 6. Update(내용 수정하기)

UPDATE namecard SET NAME = '박길동' WHERE NAME = '홍길동';
UPDATE namecard SET phone = '010-999-9999' WHERE NAME = '박길동';

-- 7. 테이블 교정하기

 ALTER TABLE namecard ADD email VARCHAR(50);

-- 테이블 필드 이름 변경하기

ALTER TABLE namecard CHANGE id NUMBER INT;

-- 테이블 필드 내용 변경하기

ALTER TABLE namecard MODIFY NUMBER INT NOT NULL AUTO_INCREMENT PRIMARY KEY;

-- 테이블 필드 삭제하기

ALTER TABLE namecard DROP email;

-- 기타

DROP TABLE namecard; /* 테이블 삭제 */
CREATE DATABASE phoneinfo; /*데이터베이스 생성 */
DROP DATABASE phoneinfo; /* 데이터베이스 삭제 */
