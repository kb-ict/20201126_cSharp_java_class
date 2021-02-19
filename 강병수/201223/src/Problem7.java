import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;
import java.util.StringTokenizer;

//못품
public class Problem7 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		final String last[] = { "김", "박", "이", "최", "장" };
		final String first[] = { "바", "사", "아", "자", "차" };
		final String mid[] = { "가", "나", "다", "라", "마" };
		String [] FullName = new String[50];
		while (true) {
			System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
			System.out.println("파일 제어 프로그램 v1.1");
			System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
			System.out.println("1. 이름 생성하여 파일에 저장하기");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
			System.out.print("메뉴 선택: ");
			int num = sc.nextInt();
			switch (num) {
			case 1:
				
				for (int i = 0; i<50; i++) {
					BufferedOutputStream bs;
					String str = null;
					bs = new BufferedOutputStream(new FileOutputStream("d:/test1.txt"));
					FullName[i] = last[(int)(Math.random()*5)] +
									mid[(int)(Math.random()*5)] +
									first[(int)(Math.random()*5)];
					bs.write(FullName[i].getBytes());
					bs.write("/".getBytes());
//					System.out.println(FullName[i]);
				}
				bs.close();
				System.out.println("정상적으로 파일 쓰기 완료");
				break;
			case 2:
				String str="홍길동/김길동/최길동";
				StringTokenizer stk =
						new StringTokenizer(str,"/");
				while(stk.hasMoreTokens()) {
					System.out.println(stk.nextToken());
				}
				break;
			case 3:
				System.out.println("프로그램 종료");
				sc.close();
				System.exit(0);
				break;
			default:
				System.out.println("잘못된 메뉴 입력!");
				break;

			}
		}
	}

}
