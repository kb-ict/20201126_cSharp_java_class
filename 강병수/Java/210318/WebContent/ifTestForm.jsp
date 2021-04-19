<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>값을 입력하는 폼</title>
</head>
<body>
	<h2>숫자 값을 입력하세요.</h2>
	<!--
	<form method="post" action="/210318/calc/ifTestPro.jsp">
		<input type="text" name="number">
		<input type="submit" value="입력 완료">
	</form> -->
	<!--  
	<form method="post" action="calc/ifTestPro.jsp">
		<input type="text" name="number">
		<input type="submit" value="입력 완료">
	</form>
	-->
	<form method="post" action="http://localhost:8080/210318/calc/ifTestPro.jsp">
		<input type="text" name="number">
		<input type="submit" value="입력 완료">
	</form>
</body>
</html>