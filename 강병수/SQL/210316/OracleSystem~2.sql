-- view
create or replace view v_emp (사원, 사원이름, 부서, 담당업무)
    as select eno, ename, dno, job
    from employee where job like 'salesman';