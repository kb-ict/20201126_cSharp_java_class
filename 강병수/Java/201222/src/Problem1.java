import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class Problem1 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		while (true) {
			System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
			System.out.println("간단한 파일 관리 프로그램 1.0");
			System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
			System.out.println("1. 파일 생성 및 쓰기");
			System.out.println("2. 파일 읽기");
			System.out.println("3. 프로그램 종료");
			System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
			System.out.print("메뉴를 선택하세요: ");
			int menu = sc.nextInt();
			switch (menu) {
			case 1:
				BufferedOutputStream bs;
				try {
					bs = new BufferedOutputStream(new FileOutputStream("d:/test1.txt"));
					String str = "파일 생성 및 쓰기 예제입니다.";
					bs.write(str.getBytes());
					;
					bs.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				break;
			case 2:
				BufferedReader br;
				try {
					br = new BufferedReader(new FileReader(new File("d:/test1.txt")));
					String str = br.readLine();
					System.out.println("--- 파일에서 내용 읽어오기 ---");
					System.out.println(str);
					br.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
				break;
			case 3:
				System.out.println("프로그램 종료");
				sc.close();
				System.exit(0);
				break;
			default:
				System.out.println("잘못된 입력!");
			}
		}
	}
}