package com.KBS.DB.control;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import com.KBS.DB.model.AddressBook;

public class Control {
	Scanner sc = new Scanner(System.in);
	public Connection con;
	public Statement state;
	final String USER_ID = "root";
	final String USER_PW = "1126";
	final String DBNAME = "mydb";
	String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	

	public void connectDB() {
		try {
			Class.forName(jdbcDriver).newInstance();
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB 접속 성공");
			}
		} catch (InstantiationException e) {
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void closeDB() {
		try {
			if (con != null) {
				state.close();
				con.close();
				System.out.println("DB 접속 해제");
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void createTable() {
		String query = "create table card0304" + "(id INT(10) NOT NULL AUTO_INCREMENT," + "name VARCHAR(10) NOT NULL,"
				+ "age INT(3) NOT NULL," + "tel VARCHAR(20) NOT NULL," + "address VARCHAR(40) NOT NULL,"
				+ "email VARCHAR(30) NULL," + "date DATETIME NOT NULL," + "PRIMARY KEY(id))";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);
		}
	}

	public void deleteTable() {
		String query = "drop table card0304";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);
		}
	}
	
	public void createData(AddressBook ab) {
		String query2 = String.format("insert into card0304(name, age, tel, address, email, date)" + " values('%s', '%d', '%s', '%s', '%s', now())", ab.getName(), ab.getAge(), 
				ab.getTel(), ab.getAddress(), ab.getEmail());
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}


	/* public void sampleData() {
		String query = "INSERT INTO `card0304` (`id`, `name`, `age`, `tel`, `address`, `email`, `date`) VALUES"
				+ "(0, '고길동', 50, '011-877-4632', '서울특별시', 'go@gmail.com', NOW()),"
				+ "(0, '둘리', 3, '010-1357-4525', '서울특별시', NULL, NOW()),"
				+ "(0, '또치', 2, '010-7821-1234', '서울특별시', 'ddochi@gmail.com', NOW()),"
				+ "(0, '도우너', 3, '010-1354-4262', '깐따삐야별', 'donut@naver.com', NOW()),"
				+ "(0, '마이콜', 24, '010-4321-1111', '대구광역시', 'michael@gmail.com', NOW())";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	} */

	public void readData() {
		String query = "select * from card0304";
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int count = 1;
				while (rs.next()) {
					System.out.print(count + "\t");
					System.out.print(rs.getString("name") + "\t");
					System.out.print(rs.getString("age") + "\t");
					System.out.print(rs.getString("tel") + "\t");
					System.out.print(rs.getString("address") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.println(rs.getString(7));
					count++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public void modifyData() {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.println("=================");
		System.out.println("    데이터 수정");
		System.out.println("=================");
		System.out.print("수정할 데이터의 ID: ");
		int id = sc.nextInt();
		System.out.print("이름: ");
		String name = sc.next();
		System.out.print("나이: ");
		int age = sc.nextInt();
		System.out.print("전화: ");
		String tel = sc.next();
		System.out.print("주소: ");
		String address = null;
		try {
			address = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print("이메일: ");
		String email = sc.next();
		String query = String.format("UPDATE card0304 SET name = '%s', age = %d, tel = '%s', address = '%s', email = '%s', date = NOW() WHERE id = '%d';", name, age, tel, address, email, id);
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	
	public void deleteData() {
		System.out.println("=================");
		System.out.println("    데이터 삭제");
		System.out.println("=================");
		System.out.print("삭제할 데이터의 ID: ");
		String query = String.format("DELETE FROM card0304 WHERE id = %d;", sc.nextInt());
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void checkError(SQLException e) {
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("해당 이름의 테이블이 이미 존재함");
			break;
		case 1051:
			System.out.println("삭제할 테이블이 존재하지 않음");
			break;
		}
	}

}
