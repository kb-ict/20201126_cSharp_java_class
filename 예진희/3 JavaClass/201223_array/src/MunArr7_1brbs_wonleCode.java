import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

//7. 다음 메뉴를 가지는 프로그램 작성하기.

//-----------------------------
//메뉴 선택 :
//
//조건1) 1차원 배열 초기값
//String last[]	=	{"김", "박", "이", "최", "장"};
//String first[]	=	{"바", "사", "아", "자", "차"};
//String mid[]	=	{"가", "나", "다", "라", "마"};

public class MunArr7_1brbs_wonleCode {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String str = null;
		String fileName = "d:/test1.txt";
		
		while (true) {
			System.out.println("------------------------");
			System.out.println(" 간단한 파일 관리 프로그램 v1.0");
			System.out.println("------------------------");
			System.out.println("1. 파일 생성 및 쓰기");
			System.out.println("2. 파일 읽기");
			System.out.println("3. 프로그램 종료");
			System.out.println("------------------------");
			System.out.print("메뉴를 선택하세요: ");
			int menu = sc.nextInt();
			switch (menu) {
			case 1:
				// System.out.println("1. 파일 생성 및 쓰기");
				BufferedOutputStream bs = null;
//				String str = null;
//				String fileName = "d:/test1.txt";
				try {
					bs = new BufferedOutputStream(new FileOutputStream(fileName));
					str = "내용변경임";
					bs.write(str.getBytes());
					bs.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				System.out.println("파일명 : " + fileName);
				System.out.println("파일내용: " + str);
				System.out.println("파일 생성이 성공하였습니다.");
				System.out.println("------------------------");
				break;

			case 2:
//				System.out.println("2. 파일 읽기");
				BufferedReader br;
				try {
					br = new BufferedReader(new FileReader("d:/test1.txt"));
					str = br.readLine();
					System.out.println("---파일에서 내용 읽어오기---");
					System.out.println(str);
					br.close();

				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}

				System.out.println("파일명 : " + fileName);
				System.out.println("읽은 내용: " + str);
				System.out.println("파일 읽기가 성공하였습니다.");
				System.out.println("------------------------");
				break;


			case 3:
				System.out.println("3. 종료");
				sc.close();
				System.exit(0);
				// break;
				// 종료 시 재실행 ctrl + F5
			default:
				System.out.println("잘못된 입력입니다.");
				// break;
			} // swich문 끝남
		} // while로 감쌈
	}
}

