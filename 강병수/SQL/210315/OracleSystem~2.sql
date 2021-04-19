select sum(salary) as "급여총액",
    avg(salary) as "급여평균",
    max(salary) as "최대급여",
    min(salary) as "최소급여" from EMPLOYEE;
    
select count(*) as "사원 수" from employee;
select count(distinct job) as "직업 종류 개수" from employee;
select dno as "부서 번호", avg(salary) as "급여 평균"
    from employee group by dno;
    
select dno, job, count(*), sum(salary) from employee
    group by dno, job order by dno, job;
    
select dno, max(salary) from employee group by dno having max(salary) >= 3000;

select * from employee, department where employee.dno = department.dno;    
