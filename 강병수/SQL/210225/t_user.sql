-- 테이블의 모든 데이터를 삭제
-- DELETE FROM t_user;
samsung_lions
-- 테이블 자체를 삭제
-- DROP TABLE t_user;

 -- SELECT user_nm, user_age, r_dt FROM t_user;
 -- 모든 컬럼의 정보 출력
 
 -- 내림차순 정렬
/*SELECT i_user, user_nm, user_age FROM t_user
WHERE user_age > 50 AND user_age < 102
ORDER BY user_age DESC;

-- 오름차순 정렬
SELECT i_user, user_nm, user_age AS "나이(세)" FROM t_user
WHERE user_age > 50 AND user_age < 102
ORDER BY user_age ASC;*/

/*SELECT i_user, user_nm, user_age FROM t_user
WHERE	user_age IN (20, 22, 100)
ORDER BY i_user;

SELECT i_user, user_nm, user_age FROM t_user
WHERE	user_age IN (20, 22, 100)
ORDER BY user_age DESC, user_nm ASC;

SELECT user_nm AS "성명", user_age AS "나이"
FROM t_user WHERE user_age BETWEEN 20 AND 100
ORDER BY i_user DESC;

SELECT user_nm AS "성명", user_age AS "나이"
FROM t_user WHERE user_age BETWEEN >=20 AND user_age <= 100
ORDER BY i_user DESC; */

SELECT user_nm AS "성명", user_age AS "나이"
FROM t_user WHERE user_nm LIKE '김__'
ORDER BY user_age DESC;

-- mysql 함수
SELECT SUM(user_age) AS '나이의 총합계' FROM t_user;
SELECT max(user_age) AS '가장 나이가 많은saratoga93 사람' FROM t_user;
SELECT min(user_age) AS '가장 나이가 적은 사람' FROM t_user;
SELECT avg(user_age) AS '평균 나이' FROM t_user;
SELECT count(user_age) AS '데이터 갯수' FROM t_user;