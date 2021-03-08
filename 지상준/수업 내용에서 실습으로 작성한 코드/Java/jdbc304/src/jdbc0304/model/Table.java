package jdbc0304.model;

import java.util.ArrayList;

public class Table {
	private String tableName = null;
	private String primaryKey = null;
	protected String[] columns = null;
	private ArrayList<TableRow> rows = null;

	public int getPrimaryKeyIndex() {
		for(int i = 0; i < columns.length; i++) {
			if(columns[i].endsWith(primaryKey))
				return i;
		}
		return -1;
	}

	// 생성자
	public Table(String tableName, String primaryKey, String[] columns) {
		this.tableName = tableName;
		this.primaryKey = primaryKey;
		this.columns = columns;
		this.rows = new ArrayList<TableRow>();
	}

	// getter setter
	public String getTableName() {
		return tableName;
	}
	public void setTableName(String tableName) {
		this.tableName = tableName;
	}
	public String getPrimaryKey() {
		return primaryKey;
	}
	public void setPrimaryKey(String primaryKey) {
		this.primaryKey = primaryKey;
	}

	public String[] getColumns() {
		return columns;
	}
	public void setColumns(String[] columns) {
		rows.clear();
		this.columns = columns;
	}

	public void setRow(TableRow row) {
		this.rows.add(row);
	}
	public void setRow(String[] datas) {
		try {
			this.rows.add(new TableRow(datas, columns.length));
		} catch (TableRowException e) {
			System.out.println("행추가하다가 실패했어용 ㅠ ㅠ");
		}
	}
	public TableRow[] getRows() {
		return rows.toArray(new TableRow[rows.size()]);
	}
	public void clearRows() {
		rows.clear();
	}
	
	public void printTableRows() {
		StringBuilder sb;
		System.out.println("\n\n─────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
		for(int i = 0; i < columns.length; i++) {
			sb = new StringBuilder(columns[i])
					.append((columns[i].length() < 7)? "\t\t│" : "\t│");
			System.out.print(sb);
		}
		System.out.println("\n─────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
		
		for (TableRow tableRow : rows) {
			for (String data : tableRow.getDatas()) {
				sb = new StringBuilder(data)
						.append((data.length() < 7)? "\t\t│" : "\t│");
				System.out.print(sb);
			}
			System.out.println();
		}


	}

}
