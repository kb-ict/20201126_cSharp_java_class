<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%@ page import="java.sql.Timestamp" %>
<%@ page import="java.util.Date" %>
<%@ page import="java.text.SimpleDateFormat" %>
<%@ page info="copyright by ㅋ" %>
<%@ page session=true %>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Directive import 속성</title>
</head>
<body>
	<h2>page 디렉티브 - import 속성</h2>
	
	<%
		Timestamp now = new Timestamp(System.currentTimeMillis());
		SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
		String strDate = format.format(now);
		
		Date nowTime = new Date();
		SimpleDateFormat date = new SimpleDateFormat("yyyy년MM월dd일 a hh시mm분ss초");
	%>
	
	<h1>오늘은 <%=strDate %>입니다.</h1>
	<h1>오늘은 <%= date.format(nowTime) %>입니다.</h1>
	<h2>저작자: <%= getServletInfo() %></h2>
</body>
</html>