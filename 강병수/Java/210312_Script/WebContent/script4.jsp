<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%
	String param1 = request.getParameter("pa1");
	String param2 = request.getParameter("pa2");
	
	int num1 = Integer.parseInt(param1);
	int num2 = Integer.parseInt(param2);
%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<div><%=param1%> + <%=param2%> = <%=num1+num2 %></div>
</body>
</html>