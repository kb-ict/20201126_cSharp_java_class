import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Dab_array7_201223 {
	public static void main(String[] args) throws IOException {
		Scanner sc = new Scanner(System.in);
		final String last[] = { "김", "박", "이", "최", "장" };
		final String first[] = { "바", "사", "아", "자", "차" };
		final String mid[] = { "가", "나", "다", "라", "마" };
		String[] fullName = new String[50];
		final String fileName = "d:/text.txt";
		
		while (true) {
			System.out.println("------------------------");
			System.out.println(" 파일 제어 프로그램 v1.1");
			System.out.println("------------------------");
			System.out.println("1. 이름 생성하여 파일에 저장하기");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println("------------------------");
			System.out.print("메뉴를 선택하세요: ");
			int menu = sc.nextInt();

			switch (menu) {
			case 1:
				BufferedOutputStream bs = null;
				bs = new BufferedOutputStream(new FileOutputStream(fileName));

				for (int i = 0; i < fullName.length; i++) {
//					int rand = (int)(Math.random()*5);
					//fullName[i] = last[rand]+mid[rand]+first[rand];
					
					fullName[i] = last[(int) (Math.random() * 5)] 
							  + mid[(int) (Math.random() * 5)]
					          + first[(int) (Math.random() * 5)];
					bs.write(fullName[i].getBytes());
					bs.write("/".getBytes());
					
					//System.out.println(fullName[i]);
				}
				bs.close();
				System.out.println("파일쓰기 정상실행 완료");
				break;
			case 2:
				BufferedReader br;
				br = new BufferedReader(new FileReader("d:/text.txt"));
				String str = br.readLine();
				StringTokenizer stk = new StringTokenizer(str,"d:/text.txt");
				while(stk.hasMoreTokens()) {
					System.out.println(stk.nextToken());
				}br.close();
				break;
			case 3:
				sc.close(); 	// 강제 프로세스(=프로그램) 종료,
				System.exit(0); // 프로세스 = 실행중인 프로그램, 프로세셔 : CPU
				break;
			default:
				System.out.println("잘못된 메뉴 선택!");
				// break;
			}
		}
	}
}