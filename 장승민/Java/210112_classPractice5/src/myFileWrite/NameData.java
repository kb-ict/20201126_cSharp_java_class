package myFileWrite;
import java.util.Random;

public class NameData {
	private String fullname = "";
	private String first[];
	private String mid[];
	private String last[];

	public NameData() {
		first = new String[] { "김", "박", "이", "최", "장" };
		mid = new String[] { "가", "나", "다", "라", "마" };
		last = new String[] { "바", "사", "아", "자", "차" };
	}

	public String random() {
		Random rd = new Random();
		for (int i = 0; i < 50; i++) {
			fullname = fullname + first[rd.nextInt(5)] + mid[rd.nextInt(5)] + last[rd.nextInt(5)] + "/";
		}
		return fullname;

	}

	public void systemOut() {
		System.out.println(random());

	}

}
