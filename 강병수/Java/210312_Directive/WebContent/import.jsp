<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%@ page import="java.sql.Timestamp" %>
<%@ page import="java.util.Date" %>
<%@ page import="java.text.SimpleDateFormat" %>
<%@ page info="copyright by ��" %>
<%@ page session=true %>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Directive import �Ӽ�</title>
</head>
<body>
	<h2>page ��Ƽ�� - import �Ӽ�</h2>
	
	<%
		Timestamp now = new Timestamp(System.currentTimeMillis());
		SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
		String strDate = format.format(now);
		
		Date nowTime = new Date();
		SimpleDateFormat date = new SimpleDateFormat("yyyy��MM��dd�� a hh��mm��ss��");
	%>
	
	<h1>������ <%=strDate %>�Դϴ�.</h1>
	<h1>������ <%= date.format(nowTime) %>�Դϴ�.</h1>
	<h2>������: <%= getServletInfo() %></h2>
</body>
</html>