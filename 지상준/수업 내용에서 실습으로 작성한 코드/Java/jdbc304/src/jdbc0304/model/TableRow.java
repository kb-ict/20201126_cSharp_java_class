package jdbc0304.model;

public class TableRow {
	private String[] datas;
	public void setData(int index, String data) {
		datas[index] = data;
	}
	public String getData(int index) {
		return datas[index];
	}
	public String[] getDatas() {
		return datas;
	}
	
	public TableRow(int colSize) {
		datas = new String[colSize];
	}
	public TableRow(String[] datas, int colSize) throws TableRowException {
		if(colSize == 0) {
			System.out.println("table의 columns 설정이 우선되어야 합니다 ~!!");
			throw new TableRowException();
		}
		else if(colSize != datas.length) {
			System.out.println("table의 columns와 datas의 갯수가 다릅니다 ~!!!!!!");
			throw new TableRowException();
		}
		
		this.datas = datas;
	}
	
	// ResultSet의 getString메소드처럼 인덱스가 0부터가아니라 1부터 시작하게끔 만들기 ~!!
	public String getString(int columnIndex) throws TableRowException {
		try {
			return datas[columnIndex - 1];
		} catch (Exception ArrayIndexOutOfBoundsException) {
			System.out.println("데이터의 범위 밖입니다.. (1 ~ " + datas.length + "까지 입력하세요)");
			throw new TableRowException();
		}
	}
}

@SuppressWarnings("serial")
class TableRowException extends Exception {
}
