import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class Ex7 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		while(true) {
			System.out.println("--------------------------");
			System.out.println(" 간단한 파일 관리 프로그램 v1.0");
			System.out.println("--------------------------");
			System.out.println("1. 파일 생성 및 쓰기");
			System.out.println("2. 파일 읽기");
			System.out.println("3. 종료");
			System.out.println("----------------------");
			System.out.print("메뉴 선택 : ");
			int menu = s.nextInt();
			if (menu == 1) {
				BufferedOutputStream bs;
				try {
					bs = new BufferedOutputStream(new FileOutputStream("d:/test1.txt"));
					String str ="파일 생성 및 쓰기 예제입니다.";
					bs.write(str.getBytes());
					bs.close();
				}
				catch(FileNotFoundException e) {
					e.printStackTrace();
				}
				catch(IOException e) {
					e.printStackTrace();
				}
			}
			else if(menu ==2) {
				BufferedReader br;
				try {
					br = new BufferedReader(new FileReader(new File("d:/test1.txt")));
					String str = br.readLine();
					System.out.println("---파일에서 내용 읽어오기---");
					System.out.println(str);
					br.close();
				}
				catch(FileNotFoundException e) {
					e.printStackTrace();
				}
				catch(IOException e) {
					e.printStackTrace();
				}
			}
			else if (menu ==3) {
				System.out.println("프로그램을 종료합니다.");
				s.close();
				break;
			}
			else {
				System.out.println("잘못 입력 하셧습니다.");
			}
		}
	}
}