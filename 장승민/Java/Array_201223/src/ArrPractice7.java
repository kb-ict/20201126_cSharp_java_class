import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;
import java.util.StringTokenizer;

public class ArrPractice7 {

	public static void main(String[] args) {
		Random rd = new Random();
		while (true) {
			String line = "----------------------------";
			System.out.println(line);
			System.out.println("파일 제어 프로그램 v1.1");
			System.out.println(line);
			System.out.println("1. 이름 생성하여 파일에 저장하기");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.print("메뉴 선택 : ");
			Scanner sc = new Scanner(System.in);
			int menu = sc.nextInt();

			String last[] = { "김", "박", "이", "최", "장" };
			String first[] = { "바", "사", "아", "자", "차" };
			String mid[] = { "가", "나", "다", "라", "마" };
			String full[] = new String[3];
			String name = "";

			for (int i = 0; i < 50; i++) {
				full[0] = last[rd.nextInt(5)];
				full[1] = first[rd.nextInt(5)];
				full[2] = mid[rd.nextInt(5)];
				name += full[0] + full[1] + full[2] + "/";
			}

			String fileName = "D:/Name.txt";
		

			switch (menu) {
			case 1:
				System.out.println("데이터 쓰기 작업 처리");
				BufferedOutputStream bs;

				try {
					bs = new BufferedOutputStream(new FileOutputStream(fileName));
					bs.write(name.getBytes());
					bs.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				System.out.println("파일명 : " + fileName);
				System.out.println("파일 내용 : " + name);
				System.out.println("파일 생성이 성공하였습니다. ");
				break;
				
				
			case 2:
				System.out.println("데이터 읽기 작업 처리");

				BufferedReader br;
				try {
					br = new BufferedReader(new FileReader(new File("D:/Name.txt")));
					String str = br.readLine();
					System.out.println("---파일에서 내용 읽어오기---");
					System.out.println(str);
					br.close();
					StringTokenizer stk = new StringTokenizer(str, "/");
					while (stk.hasMoreTokens()) {
						System.out.println(stk.nextToken());
					}

					System.out.println("파일명 : " + fileName);
					System.out.println("파일 읽기가 성공하였습니다. ");
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				break;
				
				
			case 3:
				System.out.println("프로그램 종료 작업 처리");
				sc.close();
				System.exit(0);

				break;

			}
		}
	}

}
