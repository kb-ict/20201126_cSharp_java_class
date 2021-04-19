<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%
	String info = application.getServerInfo();
	String path = application.getRealPath("/");
	application.log("로그 기록: ");
%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1>application 내장 객체</h1>
	웹 컨테이너 이름, 버전 정보: <%=info  %><p>
	웹 애플리케이션 폴더의 로컬 시스템 경로: <%=path %>
</body>
</html>