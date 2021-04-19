create table dept_copy as select * from department where 0 = 1;

insert into dept_copy values (10, 'accounting', 'new york');
insert into dept_copy (dno, loc, dname) values (20, 'dellas', 'research');

--create table seq_test(
--    id number primary key,
--    title varchar2(20)
--    );
--
--create sequence seq
--start with 1
--increment by 1
--nomaxvalue
--nominvalue;

--insert into seq_test values(seq.nextval, '타이틀1');
--insert into seq_test values(seq.nextval, '타이틀2');

--select * from user_sequences;

--drop sequence seq;

--update dept_copy set dname = 'programming' where dno = 10;
--update dept_copy set dname = 'hr';
--update dept_copy set dname = 'programming', loc = 'seoul' where dno = 10;

--update dept_copy set loc = (select loc from dept_copy where dno = 20)
--    where dno = 10;

--delete emp_copy where dno = (select dno from department where dname = 'sales');

--select * from employee where dno = 10;

--select * from employee where hiredate <= '1982/01/01';

--select * from employee where dno=10 and job='manager';
--select * from employee where dno=10 or job ='manager';
--select * from employee where not dno=10;

--select * from employee where salary between 1000 and 1500;

--select * from employee where commission in(300, 500, 1400);

--select * from employee where ename like 'f%'; -- 대소문자 구분

--_는 한 문자에 대한 wildcard 역할. '_a'는 a글자 앞에 1자만 아무것이나 올 수 있음.
--select * from employee where ename like '_a%';

--select * from employee where commission is null;
--select * from employee where commission is not null;

--select * from employee order by salary asc;
--select * from employee order by salary desc;
--select * from employee order by salary desc, ename asc;

--select sum(salary) as "급여총액",
--    avg(salary) as "급여평균",
--    max(salary) as "최대급여",
--    min(salary) as "최소급여" from employee;

--select count(*) as "사원의 수" from employee;

--select count(distinct job) as "직업 종류의 개수" from employee;

--select dno as "부서 번호", avg(salary) as "급여 평균" from employee group by dno;

--select dno, job, count(*), sum(salary) from employee
--    group by dno, job order by dno, job;

--select dno, max(salary) from employee group by dno having max(salary) >= 3000;

--select round(sysdate - hiredate) as "근무일수" from employee;

--select ename, sysdate, hiredate, trunc(months_between(sysdate,hiredate))from employee;

--select ename, hiredate, to_char(hiredate, 'yy-mm'),
--to_char(hiredate, 'yyyy/mm/dd day') from employee;

--select to_char(sysdate, 'yyyy/mm/dd, hh24:mi:ss') from dual;

--통화 기호
--L - 지역별 통화 기호(환산 안됨), 9 - 자리수가 맞지 않으면 빈자리 무시, 0 - 자리수가 맞지 않으면 0을 채움
--select ename, to_char(salary, 'L999,999') from employee;

--select ename, hiredate from employee where hiredate=to_date(19810220, 'yyyymmdd');

/* select ename, dno,
    CASE
        when dno = 10 then 'accounting'
        when dno = 20 then 'research'
        when dno = 30 then 'sales'
        when dno = 40 then 'operations'
        else 'default'
        end as "부서명"
    from employee order by dno; */
    
/* select eno, ename, job, salary, decode(job, 'analyst', salary + 200,
    'salesman', salary + 180,
    'manager', salary + 150,
    'clerk', salary + 100,
    salary) as "보너스 지급" from employee; */
    
/* select decode(dno, 10, 'accounting',
    20, 'research',
    30, 'sales',
    40, 'operations') as "부서명",
    decode(dno, 10, 'new york',
    20, 'dallas',
    30, 'chicago',
    40, 'boston') as "지역",
    count(*) as "사원수", round(avg(salary)) as "평균급여" from employee group by dno; */
    
-- select e.eno, e.ename, d.dname, e.dno from employee e, department d
-- where e.dno = d.dno and e.eno = 7788;

--select e.eno, e.ename, d.dname, dno from employee e join department d
--    using(dno) where e.eno = 7788;

--select e.eno, e.ename, d.dname, e.dno from employee e join department d
--    on e.dno = d.dno where e.eno = 7788;

--select e.ename, d.dname, e.salary, s.grade from employee e, department d,
--salgrade s
--    where e.dno = d.dno and salary between losal and hisal;

--select e.eno, e.ename, d.dname, dno from employee e natural join department d
--    where e.eno=7788;

--select e.ename as "사원", m.ename as "직속상관" from employee e, employee m
--where e.manager = m.eno;