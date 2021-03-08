package jdbc0304.dao;

import java.sql.ResultSet;
import java.sql.SQLException;

import jdbc0304.Main;
import jdbc0304.model.Table;
import jdbc0304.model.TableRow;

public class JdbcController {

	private JdbcForMySQL db = null;
	private Table table = null;
	public Table getTable() {
		if(table == null)
			throw new NullPointerException();
		return table;
	}

	public JdbcController(JdbcForMySQL db) {
		this.db = db;
	}

	public boolean tryUseDatabase() {

		System.out.println("--- Databases List ---");
		for (String dbName : db.getDatabasesName())
			System.out.println(dbName);
		System.out.println("----------------------");
		System.out.print("선택할 Database는? ");
		String dbName = Main.s.next();



		try {
			String query = "USE " + dbName + ";";
			db.getState().executeQuery(query);
		} catch (SQLException e) {
			// 에러코드 1049
			System.out.println("Database 이름을 다시 확인해주세요 =ㅅ=...");
			return false;
		}

		db.setDbName(dbName);
		return true;
	}

	public boolean tryUseTable() {

		System.out.println("----- Tables List -----");
		showTables();
		System.out.println("-----------------------");
		System.out.print("선택할 Table은? ");
		String tableName = Main.s.next();

		String[] cols = db.getTableColumnsName(tableName);
		if(cols.length == 0)
			return false;
		String pkName = db.getTablePrimaryKeyName(tableName);
		table = new Table(tableName, pkName, cols);
		if(table.getColumns().length == 0) {
			table = null;
			return false;
		}
		else
			return true;
	}

	public void showTables() {
		int i = 0;
		for (String string : db.getTablesName())
			System.out.println(++i + ".\t" + string);
	}

	public void createTable(String tableName, String[] args, boolean wannaUseDummy) {

		String dummyQuery = "create table addrbook ("
				+ " id INT(10) NOT NULL AUTO_INCREMENT,"
				+ " name VARCHAR(10) NOT NULL,"
				+ " age INT(3) NULL,"
				+ " tel VARCHAR(20) NULL,"
				+ " address VARCHAR(40) NULL,"
				+ " email VARCHAR(30) NULL,"
				+ " date DATETIME NOT NULL,"
				+ " PRIMARY KEY(id))";


		StringBuilder query = null;
		if(!wannaUseDummy) {
			query = new StringBuilder("create table " + tableName + " (");
			for(int i = 0; i < args.length; i++) {
				query.append(" " + args[i] + ",");
			}
			query.deleteCharAt(query.length() - 1);
			query.append(")");
		}


		db.myExecuteUpdate((wannaUseDummy) ? dummyQuery : query.toString());
	}

	public void dropTable(String tableName, boolean wannaUseDummy) {

		String dummyQuery = "drop table addrbook";


		String query = null;
		if(!wannaUseDummy)
			query = "drop table " + tableName;


		db.myExecuteUpdate((wannaUseDummy) ? dummyQuery : query);
	}

	public void insertData() {
		// String dummyQuery = "insert into t_user(user_nm, user_age, email, user_phone, user_addr, user_time) "
		// + "values('전우치', 200, 'jon@kakao.com', '010-1111-1234', '조선 두메 산골', now())";

		if(table == null) {
			System.out.println("선택된 테이블이 없습니다 =ㅅ=..");
			return;
		}

		String[] datas = scanRow();
		StringBuilder query = new StringBuilder("insert into " + table.getTableName() + "(");
		for (String col : table.getColumns()) {
			query.append(col + ",");
		}
		query.deleteCharAt(query.length() - 1);
		query.append(") ");

		query.append("values(");
		for (String row : datas) {
			query.append("'" + row + "',");
		}
		query.deleteCharAt(query.length() - 1);
		query.append(") ");

		db.myExecuteUpdate(query.toString());
	}

	public void selectAllCols() {
		// String dummyQuery = SELECT * FROM t_user;

		if(table == null) {
			System.out.println("선택된 테이블이 없습니다 =ㅅ=..");
			return;
		}

		table.setColumns(db.getTableColumnsName(table.getTableName()));
		String query = "SELECT * FROM " + table.getTableName();
		ResultSet rows = db.myExecuteQuery(query);

		TableRow row = null;
		table.clearRows();
		try {

			while(rows.next()) {
				int length = table.getColumns().length;
				row = new TableRow(length);
				for(int i = 0; i < length; i++) {
					row.setData(i, rows.getString(i + 1));
				}
				table.setRow(row);
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}


	}

	//	dbCtrl.selectCols(new String[] {db.getTablePrimaryKeyName(), "email"});
	public void selectCols(String[] colsName) {
		// String dummyQuery = SELECT i_user, user_nm FROM t_user;

		if(table == null) {
			System.out.println("선택된 테이블이 없습니다 =ㅅ=..");
			return;
		}

		StringBuilder query = new StringBuilder("SELECT ");
		for(int i = 0; i < colsName.length; i++) {
			query.append(colsName[i] + ",");
		}
		query.deleteCharAt(query.length() - 1);
		query.append(" FROM " + table.getTableName());

		ResultSet rows = db.myExecuteQuery(query.toString());

		table.setColumns(colsName);
		table.clearRows();
		TableRow row = null;
		try {

			while(rows.next()) {
				int length = colsName.length;
				row = new TableRow(length);
				for(int i = 0; i < length; i++) {
					row.setData(i, rows.getString(colsName[i]));
				}
				table.setRow(row);
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}

	}

	public void selectPrimaryKey() {
		// String dummyQuery = SELECT i_user FROM t_user;

		if(table == null) {
			System.out.println("선택된 테이블이 없습니다 =ㅅ=..");
			return;
		}

		String query = "SELECT " + table.getPrimaryKey() + " FROM " + table.getTableName();

		ResultSet rows = db.myExecuteQuery(query);

		table.setColumns(new String[] { table.getPrimaryKey() });
		table.clearRows();
		TableRow row = null;
		try {

			while(rows.next()) {
				int length = table.getColumns().length; // 기본키 하나만 선택함, lenth를 숫자 1로 하드코딩 가능
				row = new TableRow(length);
				for(int i = 0; i < length; i++) {
					row.setData(i, rows.getString(i + 1));
				}
				table.setRow(row);
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}

	}

	public void updateData() {

		if(table == null) {
			System.out.println("선택된 테이블이 없습니다 =ㅅ=..");
			return;
		}

		// String dummyQuery = "UPDATE t_user "
		//		+ "SET user_age=0,user_phone='없어..' "
		//		+ "WHERE i_user=1;";
		String pkValue = scanPrimaryKey();
		if(pkValue == null) {
			System.out.println("void deleteData() : 테이블에 데이터가 없습니다");
			return;
		}

		StringBuilder query = new StringBuilder("UPDATE " + table.getTableName() + " ");
		selectAllCols();
		String[] columns = table.getColumns();
		String[] datas = scanRow();
		query.append("SET ");
		for(int i = 0; i < columns.length; i++) {
			query.append(columns[i] + "=").append("'" + datas[i] + "',");
		}
		query.deleteCharAt(query.length() - 1).append(" ");
		query.append("WHERE ").append(table.getPrimaryKey()).append("=").append("'" + pkValue + "'");

		db.myExecuteUpdate(query.toString());
	}

	public void deleteData() {
		
		if(table == null) {
			System.out.println("선택된 테이블이 없습니다 =ㅅ=..");
			return;
		}
		
		// DELETE FROM t_user WHERE i_user='1234'
		String pkValue = scanPrimaryKey();
		if(pkValue == null) {
			System.out.println("void deleteData() : 테이블에 데이터가 없습니다");
			return;
		}
		String query = "DELETE FROM " + table.getTableName() + " WHERE " + table.getPrimaryKey() + "='" + pkValue + "'";
		
		db.myExecuteUpdate(query);
	}
	
	private String[] scanRow() {
		System.out.println("VARCHAR()와 INT 형식만 가능합니다. 차후에 타입에 따라 지정하는 기능을 추가해야합니다");
		String[] columns = table.getColumns();
		String[] datas = new String[columns.length];
		for(int i = 0; i < columns.length; i++) {
			System.out.print(columns[i] + "을(를) 입력해주세요 : ");
			datas[i] = Main.s.next();
		}
		return datas;
	}
	
	private String scanPrimaryKey() {
		selectPrimaryKey();
		table.printTableRows();
//		selectCols(new String[] {db.getTablePrimaryKeyName()});
		if(table.getRows().length == 0) {
			System.out.println("수정할 데이터가 존재하지 않습니다");
			return null;
		}

		System.out.println("------------------------------------------------------------");
		System.out.println(db.getTablePrimaryKeyName(table.getTableName()) + "가 기본키입니다, 수정할 기본키의 값은?");
		System.out.println("------------------------------------------------------------");

		boolean isMatch = false;
		String pkValue = null;
		while(!isMatch) {
			pkValue = Main.s.next();
			for (TableRow tr : table.getRows()) {
				if(tr.getData(table.getPrimaryKeyIndex()).equals(pkValue)) {
					isMatch = true;
					break;
				}
			}
			if(!isMatch)
				System.out.println("일치하는 값이 없습니다. 다시 선택하세요");
		}
		
		return pkValue;
	}
	
}
