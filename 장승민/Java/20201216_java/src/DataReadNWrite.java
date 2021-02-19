import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class DataReadNWrite {

	public static void main(String[] args) throws IOException {
		Scanner sc = new Scanner(System.in);
		while (true) {
			String line = "----------------------";
			System.out.println(line);
			System.out.println("메뉴 프로그램 테스트 v1.0");
			System.out.println(line);
			System.out.println("1. 데이터 쓰기");
			System.out.println("2. 데이터 읽기");
			System.out.println("3. 프로그램 종료");
			System.out.println(line);
			System.out.print("메뉴 선택 : ");
			int menu = sc.nextInt();
			String fileName = "D:/test1.txt";
			String str = "파일 생성 및 쓰기 예제입니다.";
			switch (menu) {
			case 1:
				System.out.println("데이터 쓰기 작업 처리");
				BufferedOutputStream bs;

				try {
					bs = new BufferedOutputStream(new FileOutputStream(fileName));

					bs.write(str.getBytes());
					bs.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				System.out.println("파일명 : " + fileName);
				System.out.println("파일 내용 : " + str);
				System.out.println("파일 생성이 성공하였습니다. ");
				break;
			case 2:
				System.out.println("데이터 읽기 작업 처리");

				BufferedReader br;
				try {
					br = new BufferedReader(new FileReader(new File("D:/test1.txt")));
					String str1 = br.readLine();
					System.out.println("---파일에서 내용 읽어오기---");
					System.out.println(str1);
					br.close();
					System.out.println("파일명 : " + fileName);
					System.out.println("읽은 내용 : " + str1);
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
			default:
				System.out.println("잘못된 메뉴 선택");
				break;
			}

		}

	}
}
