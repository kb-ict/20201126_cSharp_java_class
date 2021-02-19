import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;
import java.util.StringTokenizer;

public class MunArr7_2LibraryUse_MyPulee {

	public static void main(String[] args) {
		// ★★★★★★★ 그전에거 복습하면서 뒤에코드 새로짜기 ★★★★★★★
		Scanner s = new Scanner(System.in);

		while (true) {

			String str = null;
			int i = 0;
			String hap = "";

			String fileName = "d:/201223_munje7.txt";

			String line = "-----------------------------";
			System.out.println(line);
			System.out.println("파일 제어 프로그램 v1.1");
			System.out.println(line);
			System.out.println("1. 이름 생성하여 파일에 저장하기");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println(line);
			System.out.print("메뉴 선택 :");
			int menu = s.nextInt();

			switch (menu) {
			case 1:

				String last[] = { "김", "박", "이", "최", "장" };
				String first[] = { "바", "사", "아", "자", "차" };
				String mid[] = { "가", "나", "다", "라", "마" };

				String irum[] = new String[50];
				for (i = 0; i < irum.length; i++) {
					String one = last[(int) (Math.random() * 4)];
					String two = first[(int) (Math.random() * 4)];
					String three = mid[(int) (Math.random() * 4)];

					irum[i] = one + two + three + "/";
					hap = hap + irum[i];
				}

				BufferedOutputStream bs = null;
				try {
					bs = new BufferedOutputStream(new FileOutputStream(fileName));
					str = hap;
					bs.write(str.getBytes());
					bs.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				break;

			case 2:
				BufferedReader br = null;
				try {
					br = new BufferedReader(new FileReader("d:/201223_munje7.txt"));
					str = br.readLine();
					System.out.println("---파일에서 내용 읽어오기---");
//					System.out.println(str);
					
					br.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				System.out.println("파일명 : " + fileName);
//				System.out.println("읽은 내용: " + str);
				StringTokenizer stk = new StringTokenizer(str,"/");
				while(stk.hasMoreTokens()) {
					System.out.println(stk.nextToken());
				}
				
				System.out.println("파일 읽기가 성공하였습니다.");
				System.out.println(line);
				break;

			case 3:
				System.out.println("3. 종료");
				s.close();
				System.exit(0);

			default:
				System.out.println("잘못된 입력입니다.");

			}
		}

	}
}