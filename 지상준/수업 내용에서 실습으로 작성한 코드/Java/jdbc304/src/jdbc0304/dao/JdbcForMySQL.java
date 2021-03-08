package jdbc0304.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

public class JdbcForMySQL {
	private Connection con = null;
	private Statement state = null;
	public Connection getCon() {
		return con;
	}
	public Statement getState() {
		return state;
	}



	private String userId;
	private String userPw;
	private String dbName;
	public String getUserId() {
		return userId;
	}
	public void setUserId(String userId) {
		this.userId = userId;
	}
	public String getUserPw() {
		return userPw;
	}
	public void setUserPw(String userPw) {
		this.userPw = userPw;
	}
	public String getDbName() {
		return dbName;
	}
	public void setDbName(String dbName) {
		this.dbName = dbName;
	}



	private final String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	private String dbUrl;



	// 생성자
	public JdbcForMySQL() throws ClassNotFoundException, SQLException {
		userId = "root";
		userPw = "1126";
		dbName ="testdb";

		dbUrl = "jdbc:mysql://localhost/"+ dbName + "?autoReconnect=true" + "&" + "serverTimezone=UTC";

		connectDB();
	}
	public JdbcForMySQL(String USER_ID, String USER_PW) throws ClassNotFoundException, SQLException {
		this.userId = USER_ID;
		this.userPw = USER_PW;

		dbUrl = "jdbc:mysql://localhost?autoReconnect=true&serverTimezone=UTC";
		connectDB();
	}
	public static JdbcForMySQL connection(String id, String pw) {
		try {
			return new JdbcForMySQL(id, pw);
		} catch (ClassNotFoundException e) {
			System.out.println("드라이버 오류 !!");
			return null;
		} catch (SQLException e) {
			System.out.println("USER_ID, USER_PW을 다시 확인하세요");
			return null;
		}
	}

	public void myExecuteUpdate(String query) {
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {

			switch(e.getErrorCode()) {
			case 1062:
				System.out.println("\n\n기본키는 중복될 수 없습니다!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				break;
			case 1049:
				System.out.println("Database 이름을 다시 확인해주세요 =ㅅ=...");
				break;
			case 1050:
				System.out.println("테이블이 이미 존재합니다");
				break;
			case 1051:
				System.out.println("삭제할 테이블이 존재하지 않습니다");
				break;
			case 1366:
				System.out.println("INT형에 잘못된 값 입력..");
				System.out.println(e.getMessage());
				break;
			default:
				System.out.println(e.getSQLState());
				System.out.println(e.getMessage());
				System.out.println(e.getErrorCode());
				//				System.out.println(e.getCause().toString());
				break;
			}
		}
	}

	public ResultSet myExecuteQuery(String query) {
		try {
			ResultSet rs = state.executeQuery(query);
			if(rs != null)
				return rs;
		} catch (SQLException e) {

			switch(e.getErrorCode()) {
			case 1146:
				System.out.println("Table 'input table name' doesn't exist");
				break;
			default:
				System.out.println(e.getSQLState());
				System.out.println(e.getMessage());
				System.out.println(e.getErrorCode());
				//				System.out.println(e.getCause().toString());
				break;
			}
		}
		return null;
	}

	public String[] getDatabasesName() {

		ResultSet rs = myExecuteQuery("SHOW DATABASES;");

		ArrayList<String> tmpResult = new ArrayList<String>();
		try {
			while(rs.next()) {
				// SELECT column_name << 질의문에서 열이 한개이다
				tmpResult.add(rs.getString(1));
			}
			rs.close();
		} catch (SQLException e) {
			System.out.println("getDatabasesName() : ResultSet의 메소드 사용중에 오류 났어용 ..");
		}

		return tmpResult.toArray(new String[tmpResult.size()]);
	}

	public String[] getTablesName() {

		ResultSet rs = myExecuteQuery("SHOW TABLES;");

		ArrayList<String> tmpResult = new ArrayList<String>();
		try {
			while(rs.next()) {
				// SELECT column_name << 질의문에서 열이 한개이다
				tmpResult.add(rs.getString(1));
			}
			rs.close();
		} catch (SQLException e) {
			System.out.println("getTablesName() : ResultSet의 메소드의 사용중에 오류 났어용 ..");
		}

		return tmpResult.toArray(new String[tmpResult.size()]);
	}

	public String[] getTableColumnsName(String tableName) {

		String query = "SELECT column_name "
				+ "FROM INFORMATION_SCHEMA.columns "
				+ "WHERE table_schema=" + "'" + dbName + "' "+"AND table_name=" + "'" + tableName + "' "
				+ "ORDER BY ordinal_position;";

		ResultSet rs = myExecuteQuery(query);

		ArrayList<String> tmpResult = new ArrayList<String>();
		try {
			while(rs.next()) {
				// SELECT column_name << 질의문에서 열이 한개이다
				tmpResult.add(rs.getString(1));
			}
			rs.close();
		} catch (SQLException e) {
			System.out.println("getTableColumns() : ResultSet의 메소드 사용중에 오류 났어용 ..");
		}

		return tmpResult.toArray(new String[tmpResult.size()]);
	}

	public String getTablePrimaryKeyName(String tableName) {
		ResultSet rs = myExecuteQuery("SHOW INDEXES IN "+ tableName +";");

		try {
			rs.next();
			return rs.getString("Column_name");
		} catch (SQLException e) {
			System.out.println("getTablePrimaryKeyName() : ResultSet의 메소드 사용중에 오류 났어용 ..");
			return "getTablePrimaryKeyName() : ResultSet의 메소드 사용중에 오류 났어용 ..";
		}
	}

	private void connectDB() throws ClassNotFoundException, SQLException {
		Class.forName(jdbcDriver);
		con = DriverManager.getConnection(dbUrl, userId, userPw);
		if (con != null) {
			state = con.createStatement();
			System.out.println("DB 접속 성공!");
		}
	}
	public void closeDB() {
		try {
			if(con != null) {
				con.close();
				System.out.println("DB 해제 성공!");
			}
		} catch (SQLException e) {
			System.out.println("DB 해제 실패 ㅠ ㅠ..");
		}
	}
}
