select * from employee, department where employee.dno = department.dno;

select e.eno, e.ename, d.dname, e.dno from employee e, department d
    where e.dno = d.dno and e.eno = 7788;
    
select e.eno, e.ename, d.dname, dno
from employee e join department d using(dno)
where e.eno = 7788;

select e.eno, e.ename, d.dname, e.dno
    from employee e join department d
    on e.dno = d.dno where e.eno = 7788;
    
select e.ename, d.dname, e.salary, s.grade
    from employee e, department d, salgrade s
    where e.dno=d.dno and e.salary between s.losal and hisal;