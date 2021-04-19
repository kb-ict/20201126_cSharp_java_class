<%@page import="com.KBS.web.dto.Product"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>

<jsp:useBean id="productDAO" class="com.KBS.web.dao.ProductRepo"
	scope="session">
</jsp:useBean>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<title>제품 목록</title>
</head>
<body>
	<jsp:include page="menu.jsp" />
	<div class="jumbotron">
		<div class="container">
			<h1 class="display-3">제품 리스트</h1>
		</div>
	</div>
	<%
		ArrayList<Product> list = productDAO.getAllProduct();
	%>
	<div class="container">
		<div class="row" align="center">
			<%
				for (int i = 0; i <list.size(); i++) {
				Product product = list.get(i);
				System.out.println(product.getPname());
			%>
			<c:set var="price" value="<%=product.getUnitPrice() %>" />
			<div class="col-md-4">
				<h3><%=product.getPname() %></h3>
				<p><%=product.getDescription() %><p>
				<p><%=product.getUnitPrice() %>원</p>
				<p><a href="products.jsp?id=<%=product.getProductId() %>"
					class="btn btn-secondary" role="button">상세 정보 &raquo;</a>
			</div>
			<% } %>
		</div>
	</div>
	<jsp:include page="footer.jsp" />
</body>
</html>