import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class jdbcTest {

	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	static final int TABLE_CREATE = 1;
	static final int TABLE_DELETE = 2;
	static final int DATA_CREATE = 3;
	static final int SAMPLE_DATA = 4;
	static final int DATA_READ = 5;
	static final int DATA_MODIFY = 6;
	static final int DATA_DELETE = 7;
	static final int PROGRAM_EXIT = 8;
	
	static Scanner sc = new Scanner(System.in);
	public static void main(String[] args) {
		
		connectDB();
		while(true)
		{
			switch(menu(sc))
			{
			case TABLE_CREATE:
				createTable();
				break;
			case TABLE_DELETE:
				deleteTable();
				break;
			case DATA_CREATE:
				createData();
				break;
			case SAMPLE_DATA:
				sampleData();
				break;
			case DATA_READ:
				readData();
				break;
			case DATA_MODIFY:
				modifyData();
				break;
			case DATA_DELETE:
				deleteData();
				break;
			case PROGRAM_EXIT:
				sc.close();
				closeDB();
				System.exit(0);
				break;
			}
		}
	}

	public static int menu(Scanner sc)
	{
		System.out.println("=================");
		System.out.println("  MySQL DB 관리");
		System.out.println("=================");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 데이터 추가");
		System.out.println("4. 샘플 데이터 추가");
		System.out.println("5. 데이터 보기");
		System.out.println("6. 데이터 수정");
		System.out.println("7. 데이터 삭제");
		System.out.println("8. 프로그램 종료");
		System.out.println("=================");
		System.out.print("메뉴 번호 입력: ");
		return sc.nextInt();
	}
	
	public static void connectDB() {
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
	
	public static void closeDB() {
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
	
	public static void createTable() {
		String query = "create table card0304" + "(id INT(10) NOT NULL AUTO_INCREMENT,"
						+ "name VARCHAR(10) NOT NULL,"
						+ "age INT(3) NOT NULL,"
						+ "tel VARCHAR(20) NOT NULL,"
						+ "address VARCHAR(40) NOT NULL,"
						+ "email VARCHAR(30) NULL,"
						+ "date DATETIME NOT NULL,"
						+ "PRIMARY KEY(id))";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);
		}
	}
	
	public static void deleteTable() {
			String query = "drop table card0304";
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				checkError(e);
				}
	}

	// 수정, 추가, 삭제 쿼리 오류 발생
	public static void createData() {
		System.out.println("생성한 예제: INSERT INTO `card0304` (`id`, `name`, `age`, `tel`, `address`, `email`, `date`) "
				+ "VALUES (0, '고길동', 50, '011-877-4632', '서울특별시', 'go@gmail.com', NOW());");
		String query = "INSERT INTO 'card0304' ('id', 'name', 'age', 'tel', 'address', 'email', 'date') "
				+ "VALUES (0, '고길동', 50, '011-877-4632', '서울특별시', 'go@gmail.com', NOW());";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void sampleData() {
		String query = "INSERT INTO `card0304` (`id`, `name`, `age`, `tel`, `address`, `email`, `date`) VALUES" + 
				"(0, '고길동', 50, '011-877-4632', '서울특별시', 'go@gmail.com', NOW())," + 
				"(0, '둘리', 3, '010-1357-4525', '서울특별시', NULL, NOW())," +
				"(0, '또치', 2, '010-7821-1234', '서울특별시', 'ddochi@gmail.com', NOW())," +  
				"(0, '도우너', 3, '010-1354-4262', '깐따삐야별', 'donut@naver.com', NOW())," + 
				"(0, '마이콜', 24, '010-4321-1111', '대구광역시', 'michael@gmail.com', NOW())";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void readData() {
		String query = "select * from card0304";
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int count = 1;
				while (rs.next()) {
					System.out.print(count+"\t");
					System.out.print(rs.getString("name")+"\t");
					System.out.print(rs.getString("age")+"\t");
					System.out.print(rs.getString("tel")+"\t");
					System.out.print(rs.getString("address")+"\t");
					System.out.print(rs.getString("email")+"\t");
					System.out.println(rs.getString(7));
					count++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void modifyData() {
		System.out.println("수정한 예제: UPDATE card0304 SET name = '희동' WHERE name = '고길동';");
		String query = "UPDATE card0304 SET NAME = '희동' WHERE name = '고길동';";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void deleteData() {
		System.out.println("삭제한 예제: DELETE FROM card0304 WHERE name='또치';");
		String query = "DELETE FROM card0304 WHERE name = '또치';";
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
