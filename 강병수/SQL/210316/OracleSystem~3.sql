-- PL/SQL

set serveroutput on
declare
    v_eno number(4);
    v_ename employee.ename%type;
    
begin
    v_eno :=7788;
    v_ename := 'scott';
    dbms_output.put_line('사원번호           사원이름');
    dbms_output.put_line('-------------------------');
    dbms_output.put_line(v_eno||'             '||v_ename);
end;