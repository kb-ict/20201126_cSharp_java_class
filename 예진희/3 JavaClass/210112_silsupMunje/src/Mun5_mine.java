import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Random;
import java.util.StringTokenizer;

public class Mun5_mine {
	Random r = new Random();

	String last[] = { "김", "박", "이", "최", "장" };
	String first[] = { "바", "사", "아", "자", "차" };
	String mid[] = { "가", "나", "다", "라", "마" };

	String name[] = new String[50];
	String irumJujang = "";


	public Mun5_mine() {
		super();
	}

	public String makeName() {
		System.out.println("이름 50개를 저장합니다.\n--------------------------");
		for (int i = 0; i < name.length; i++) {
			String fullName = last[(int) (r.nextInt(5))] + mid[(int) (r.nextInt(5))] + first[(int) (r.nextInt(5))]
					+ "/";
			name[i] = fullName;
			irumJujang += name[i];
		}
//		System.out.println(irumJujang);
//		System.out.println("생성완료");
		
		return irumJujang;
	}

	public void printFunc() {
		System.out.println("\n\n이름 50개를 출력합니다.\n--------------------------");
		StringTokenizer st = new StringTokenizer(irumJujang, "/");
		while (st.hasMoreTokens()) {
			System.out.println(st.nextToken());
		}
	}
	
}
