<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%
	request.setCharacterEncoding("utf-8");
int localNum = Integer.parseInt(request.getParameter("localNum"));
String localName = null;

switch (localNum) {
case 0:
	localName = "종로, 중구 용산";
	break;
case 1:
	localName = "도봉, 강북, 노원, 성북";
	break;
case 2:
	localName ="동대문, 성동, 중량, 광진";
	break;
case 3:
case 4:
case 5:
case 6:
	localName = "기타 지역들...";
	break;
}
out.println("선택한 지역은 <h2>" + localName + "</h2> 입니다.");
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