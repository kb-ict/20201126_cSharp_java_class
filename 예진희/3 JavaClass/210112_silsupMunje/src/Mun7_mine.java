import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.StringTokenizer;

public class Mun7_mine {
	private String str = "";
	private String fileName = "";
	private String name = "";

	public Mun7_mine(String fileName) throws IOException {

		BufferedReader br = null;
		br = new BufferedReader(new FileReader(fileName));

		str = br.readLine();
		br.close();

		StringTokenizer stk = new StringTokenizer(str, "/");
		ArrayList<String> arrList = new ArrayList<>();
		while (stk.hasMoreTokens()) {
			name = stk.nextToken();
			arrList.add(name);
		}
		System.out.println("★ 문제7) 배열에 저장된 이름을 불러옵니다.");
		System.out.println("------------------------------------");
		for (int i = 0; i < arrList.size(); i++) {
			System.out.println(arrList.get(i));
		}
	}

	public String getFileName() {
		return fileName;
	}

	public void setFileName(String fileName) {
		this.fileName = fileName;
	}

}
