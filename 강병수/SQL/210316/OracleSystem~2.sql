-- view
create or replace view v_emp (���, ����̸�, �μ�, ������)
    as select eno, ename, dno, job
    from employee where job like 'salesman';