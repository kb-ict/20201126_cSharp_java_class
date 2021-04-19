drop table department CASCADE CONSTRAINTS;
drop table employee;
drop table salgrade;

create table department (
    dno number(2) constraint pk_dept primary key,
    dname VARCHAR2(14),
    loc VARCHAR2(13));
    

create table employee(
    eno number(4) constraint pk_emp primary key,
    ename VARCHAR2(10),
    job VARCHAR2(9),
    manager number(4),
    hiredate date,
    salary number(7, 2),
    commission number(7, 2),
    dno number(2) constraint fk_dno references department);
    

create table salgrade(
    grade number,
    losal number,
    hisal number);
    
insert into department values (10, 'accounting', 'new york');
insert into department values (20, 'research', 'dallas');
insert into department values (30, 'sales', 'chicago');
insert into department values (40, 'operations', 'boston');

insert into employee values (7639, 'smith', 'clerk', 7902,
    to_date('17-12-1980', 'dd-mm-yyyy'), 800, null, 20);
insert into employee values (7499, 'allen', 'salesman', 7698,
    to_date('20-2-1981', 'dd-mm-yyyy'), 1600, 300, 30);
insert into employee values (7521, 'ward', 'salesman', 7698,
    to_date('22-2-1981', 'dd-mm-yyyy'), 1250, 500, 30);
insert into employee values (7566, 'jones', 'manager', 7839,
    to_date('2-4-1981', 'dd-mm-yyyy'), 2975, null, 20);
insert into employee values (7654, 'martin', 'salesman', 7698,
    to_date('28-9-1981', 'dd-mm-yyyy'), 1250, 1400, 30);
insert into employee values (7698, 'blake', 'manager', 7698,
    to_date('1-5-1981', 'dd-mm-yyyy'), 2850, null, 30);
insert into employee values (7782, 'clark', 'manager', 7839,
    to_date('9-6-1981', 'dd-mm-yyyy'), 2450, null, 10);
insert into employee values (7788, 'scott', 'analyst', 7566,
    to_date('13-7-1987', 'dd-mm-yyyy'), 3000, null, 20);
insert into employee values (7839, 'king', 'president', 5000,
    to_date('17-11-1981', 'dd-mm-yyyy'), 5000, null, 10);
insert into employee values (7844, 'turner', 'salesman', 7698,
    to_date('8-9-1981', 'dd-mm-yyyy'), 1500, 0, 30);
insert into employee values (7876, 'adams', 'clerk', 7788,
    to_date('13-7-1987', 'dd-mm-yyyy'), 1100, null, 20);
insert into employee values (7900, 'james', 'clerk', 7698,
    to_date('28-9-1981', 'dd-mm-yyyy'), 1250, 1400, 30);
insert into employee values (7902, 'ford', 'analyst', 7566,
    to_date('3-12-1981', 'dd-mm-yyyy'), 3000, null, 20);
insert into employee values (7934, 'miller', 'clerk', 7782,
    to_date('23-1-1982', 'dd-mm-yyyy'), 1300, null, 10);


insert into salgrade values (1, 700, 1200);    
insert into salgrade values (2, 1201, 1400);    
insert into salgrade values (3, 1401, 2000);    
insert into salgrade values (4, 2001, 3000);    
insert into salgrade values (5, 3001, 9999);    

--commit;
--rollback;