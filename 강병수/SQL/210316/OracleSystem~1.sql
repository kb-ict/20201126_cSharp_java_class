select ename from employee where eno in
(select eno from employee where manager is null);

select eno, ename, job, salary from employee
    where salary < all (select salary from employee
    where job='salesman') and job <> 'salesman';
    
-- create table dept_copy as select * from department;

update dept_copy set loc = (select loc from dept_copy where dno=20)
    where dno=10;