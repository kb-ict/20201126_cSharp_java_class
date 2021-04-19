select ename, dno from employee 
    where dno = (select dno from employee where ename='scott');
    