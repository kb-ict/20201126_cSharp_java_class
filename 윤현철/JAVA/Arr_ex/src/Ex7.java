import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;

public class Ex7 {

	public static void main(String[] args) {
		Random r = new Random();
		Scanner s = new Scanner(System.in);
		String[] last = {"김","박","이","최","장"};
		String[] first= {"바","사","아","자","차"};
		String[] mid = {"가","나","다","라","마"};
		String[] full= new String[50];
		while(true) {
			System.out.println("-------------------");
			System.out.println("파일 제어 프로그램 v1.1");
			System.out.println("-------------------");
			System.out.println("1. 이름 생성하여 파일에 저장하기");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println("-------------------");
			System.out.print("메뉴 선택 : ");
			int d = s.nextInt();
			if (d==1) {
				for (int i = 0; i < full.length; i++) {
					int a = r.nextInt(5);
					int b = r.nextInt(5);
					int c = r.nextInt(5);
					full[i]=last[a]+mid[b]+first[c];
				}
				BufferedOutputStream bs;
				try {
					bs = new BufferedOutputStream(new FileOutputStream("d:/name.txt"));
					for (int i = 0; i < full.length; i++) {
						String str =full[i]+"?";
						bs.write(str.getBytes());
					}
					bs.close();
				}
				catch(FileNotFoundException e) {
					e.printStackTrace();
				}
				catch(IOException e) {
					e.printStackTrace();
				}
			}
			else if(d ==2) {
				BufferedReader br;
				try {
					br = new BufferedReader(new FileReader(new File("d:/name.txt")));
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
			else if (d ==3) {
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
