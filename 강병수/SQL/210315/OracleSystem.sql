drop table t_student;

create table t_student(sid INT, student_nm VARCHAR(10) not null,
    student_addr VARCHAR(50) not null, lecture_nm VARCHAR(20) not null,
    PRIMARY key(sid));
    
    
insert into t_student (sid, student_nm, student_addr, lecture_nm) values (100, 'ȫ�浿', '�뱸������', '�˼���');
insert into t_student (sid, student_nm, student_addr, lecture_nm) values (101, 'ȫ�浿', '�뱸������', '�ü���');
insert into t_student (sid, student_nm, student_addr, lecture_nm) values (102, 'ȫ�浿', '�뱸������', 'â����');

--Ʈ����� -> commit (DB�� ���������� �ݿ�)
--�ѹ�(rollback) -> �����·� ����

drop table t_lecture;

create table t_lecture (lecture_nm VARCHAR2(30) primary key,
class_location varchar2(20) not null);

insert into t_lecture (lecture_nm, class_location) values ('�˼���', '���а� 301ȣ');
insert into t_lecture (lecture_nm, class_location) values ('�ü���', '���а� 302ȣ');
insert into t_lecture (lecture_nm, class_location) values ('â����', '���а� 303ȣ');

drop table t_grade;

create table t_grade (
    sid int not null,
    lecture_nm varchar2(30) not null,
    student_grade int not null,
    PRIMARY KEY(sid, lecture_nm)
--    FOREIGN KEY(sid) REFERENCES t_student(sid),
--    FOREIGN KEY(lecture_nm) REFERENCES t_lecture(lecture_nm)
    );

insert into t_grade (sid, lecture_nm, student_grade)
    values(400, '�ü���', 3);
/*    
drop table t_hobby;

create table t_hobby(
    sid_h int not null,
    hobby varchar2(20) not null,
    primary key(sid, hobby),
    foreign key(sid) references t_student(sid));
    
insert into t_sdutent (sid, student_nm, student_addr, lecture_nm)
values(103, '�ֱ浿', '����Ư����', 'â����');
insert into t_hobby(sid, hobby) values (500, '����');
insert into t_hobby(sid, hobby) values (500, '�丮');
*/    

create table t_customer (
    i_customer int,
    customer_nm VARCHAR2(20) not null,
    primary key(i_customer));
    
insert into t_customer (i_customer, customer_nm)
values (100, 'ȫ�浿');

create table t_netflix(
    i_customer integer,
    cus_watching varchar2(20) not null,
    watching_dt date default now(),
    primary key(i_customer, cus_watching),
    foreign key(i_customer) references t_customer(i_customer));

insert into t_netflix (i_customer, cus,watching)
    values(200, '�� ī�̳�');