package jdbc0304;

import java.util.Scanner;

import jdbc0304.dao.JdbcController;
import jdbc0304.dao.JdbcForMySQL;

public class Main {

	public static final String CREATE_TABLE = "1";
	public static final String DEL_TABLE = "2";
	public static final String USE_TABLE = "3";
	public static final String SHOW_TABLES = "4";
	public static final String SHOW_TABLE_COLS = "5";
	public static final String INSERT_DATA = "6";
	public static final String VIEW_DATA = "7";
	public static final String UPDATE_DATA = "8";
	public static final String DEL_DATA = "9";
	public static final String MAIN_EXIT = "10";

	private static JdbcForMySQL db;
	private static JdbcController dbCtrl;
	public static Scanner s = new Scanner(System.in);



	public static void main(String[] args) {
		
		System.out.println("MySQL의 ID와 PW를 입력해주세요");
		System.out.println("예 (ID : root, PW : 1126) ");
		String id, pw;
		while(true) {
			System.out.print("ID : ");
			id = s.next();
			System.out.print("PW : ");
			pw = s.next();
			db = JdbcForMySQL.connection(id, pw);
			if(db == null) {
				System.out.println("데이터베이스에 연결이 안돼요 ㅠ ㅠ...");
			}
			else
				break;
		}
		dbCtrl = new JdbcController(db);

		while(!dbCtrl.tryUseDatabase()) {
			System.out.println("데이터베이스명을 확인해주세요..");
			System.out.println("다시 입력하세요\n\n\n\n\n\n\n\n");
		}
		System.out.println("\n\n\n\n\n\n\n\n");
		while(!dbCtrl.tryUseTable()) {
			System.out.println("테이블명이 잘못됬습니다. 또는 해당 테이블에는 Column이 존재하지 않습니다");
			System.out.println("다시 입력하세요\n\n\n\n\n\n\n\n");
		}






		while(true) {
			System.out.println("\n\n\n\n\n\n\n\n----------------------------------------");
			System.out.println("  데이터베이스 " + db.getDbName() +"를(을) 사용중입니다 :)");
			System.out.println((dbCtrl.getTable() != null)?
					"  테이블 " + dbCtrl.getTable().getTableName() +"를(을) 사용중입니다 :)" : "  메뉴 3번을 통해 어떤 테이블을 쓸지 정해주세요..");
			switch(menu()) {

			case Main.CREATE_TABLE:

				System.out.println("\n\n\n\n\n\n\n\n----------------------------------------");
				dbCtrl.showTables();
				System.out.println("----------------------------------------");



				System.out.println("생성할 테이블명을 정해주세요 !! 이미있는 테이블명과 중복안돼요 :)");
				dbCtrl.createTable(s.next(), new String[] {"id int", "addr varchar(10)"}, false);
				break;

			case Main.DEL_TABLE:

				System.out.println("\n\n\n\n\n\n\n\n----------------------------------------");
				dbCtrl.showTables();
				System.out.println("----------------------------------------");



				System.out.println("삭제할 테이블명을 정해주세요 !!");
				dbCtrl.dropTable(s.next(), false);
				break;

			case Main.USE_TABLE:

//				System.out.println("\n\n\n\n\n\n\n\n----------------------------------------");
//				dbCtrl.showTables();
//				System.out.println("----------------------------------------");



				System.out.println("사용할 테이블명을 정해주세요 !!");
				if(dbCtrl.tryUseTable())
					System.out.println(dbCtrl.getTable().getTableName() + "을(를) 이용합니다");
				else
					System.out.println("해당 테이블에는 Column이 존재하지 않습니다");
				break;

			case Main.SHOW_TABLES:

				dbCtrl.showTables();
				break;

			case Main.SHOW_TABLE_COLS:

				if(dbCtrl.getTable() == null) {
					System.out.println("3번 메뉴로 우선 테이블을 지정해주세요");
					break;
				}



				System.out.println("----------------------------------------");
				int cnt = 0;
				for (String col : dbCtrl.getTable().getColumns()) {
					System.out.println(++cnt + ". " + col);
				}
				System.out.println("----------------------------------------");


				break;

			case Main.INSERT_DATA:

				dbCtrl.insertData();
				break;

			case Main.VIEW_DATA:

				dbCtrl.selectAllCols();
				dbCtrl.getTable().printTableRows();
				break;

			case Main.UPDATE_DATA:

				dbCtrl.updateData();
				break;

			case Main.DEL_DATA:

				dbCtrl.deleteData();
				break;

			case Main.MAIN_EXIT:

				db.closeDB();
				s.close();
				System.exit(0);
				break;

			default:

				System.out.println("잘못된 입력 !!");
				break;
			}

			System.out.println("\n 계속하려면 아무키나 입력후 Enter를 치세용 :)");
			s.next();
		}


	}

	public static String menu() {
		System.out.println("----------------------------------------");
		System.out.println(" MySQL DB 관리 v1.0");
		System.out.println("----------------------------------------");
		System.out.println(" " + CREATE_TABLE + ". 테이블 생성");
		System.out.println(" " + DEL_TABLE + ". 테이블 삭제");
		System.out.println(" " + USE_TABLE + ". 테이블 선택");
		System.out.println(" " + SHOW_TABLES + ". 테이블 전체 보기");
		System.out.println(" " + SHOW_TABLE_COLS + ". 테이블 Columns 보기");
		System.out.println(" " + INSERT_DATA + ". 데이터 추가");
		System.out.println(" " + VIEW_DATA +". 데이터 보기");
		System.out.println(" " + UPDATE_DATA + ". 데이터 수정");
		System.out.println(" " + DEL_DATA + ". 데이터 삭제");
		System.out.println(" " + MAIN_EXIT + ". 종료");
		System.out.println("----------------------------------------");
		System.out.print("메인 메뉴 선택 : ");
		return s.next();
	}
}
