<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Include 처리</title>
</head>
<body>
<%@ include file = "top.jsp" %>
<h2>top, bottom 영역 불러오기</h2>
<%@ include file = "bottom.jsp" %>
</body>
</html>