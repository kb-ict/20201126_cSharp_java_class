select sum(salary) as "�޿��Ѿ�",
    avg(salary) as "�޿����",
    max(salary) as "�ִ�޿�",
    min(salary) as "�ּұ޿�" from EMPLOYEE;
    
select count(*) as "��� ��" from employee;
select count(distinct job) as "���� ���� ����" from employee;
select dno as "�μ� ��ȣ", avg(salary) as "�޿� ���"
    from employee group by dno;
    
select dno, job, count(*), sum(salary) from employee
    group by dno, job order by dno, job;
    
select dno, max(salary) from employee group by dno having max(salary) >= 3000;

select * from employee, department where employee.dno = department.dno;    
