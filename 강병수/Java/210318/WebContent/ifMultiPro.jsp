<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
   <%
   //한글 처리
   request.setCharacterEncoding("utf-8");
   %>
<%
String name = request.getParameter("name");
String local = request.getParameter("local");
String tel = request.getParameter("tel");
out.println("tel: " + tel);
String localNum = "";

if (local.equals("서울")){
	localNum = "02";
	
}
else if (local.equals("대구")){
	localNum = "053";
	
}
else if (local.equals("부산")){
	localNum = "051";
}
out.println("<h2>" + name + "</h2>님의 전화번호는" 
		+ localNum + "-" + tel + "입니다." );
%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

</body>
</html>