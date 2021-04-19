<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
    
<%@ page import="java.sql.Timestamp" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Top</title>
</head>
<body>
	<%
	Timestamp now = new Timestamp(System.currentTimeMillis());
	%>
	<h1>TOP 파일입니다.</h1>
	<%= now.toString() %>
</body>
</html>