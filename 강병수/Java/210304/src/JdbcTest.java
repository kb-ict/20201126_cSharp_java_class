import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class JdbcTest {
	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";

	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";

	public static void main(String[] args) {
		connectDB();
		insertDB();
		showDB();
		closeDB();

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

	public static void insertDB() {
		// 첫번째 방법
		String query = String.format("insert into namecard values" + "(0, '홍길동', '010-1234-1234', '조선 한양 홍대감댁')");
		// 두번째 방법
		String name = "전우치";
		String phone = "010-6543-9874";
		String address = "조선 두메산골";
		String query2 = String.format("insert into namecard(name, phone, address)" + " values('%s', '%s', '%s')", name, phone, address);
		// 두 방법 중 한가지를 사용 한 후 아래 코드 입력
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	// DB 데이터 불러와 표시
	public static void showDB() {
		String query = "select * from namecard";
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int count = 0;
				while (rs.next()) {
					System.out.print(count+"\t");
					System.out.print(rs.getString("name")+"\t");
					System.out.print(rs.getString("phone")+"\t");
					System.out.println(rs.getString(4));
					count++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
}
