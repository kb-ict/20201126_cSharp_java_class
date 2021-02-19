package loop_20201216;

import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class Loop_practice6 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("-------------------------");
		System.out.println("간단 파일 관리 프로그램 v1.0");
		System.out.println("-------------------------");
		System.out.println("1. 파일 생성 및 쓰기");
		System.out.println("2. 파일 읽기");
		System.out.println("3. 종료");

		while (true) {

			System.out.println("-------------------------");
			System.out.print("메뉴를 선택하세요 : ");
			int num1 = s.nextInt();
			System.out.println("-------------------------");

			if (num1 == 1) {
				System.out.println("1. 파일 생성 및 쓰기");
				System.out.println("파일명 : test1.txt");
				System.out.println("파일 내용 : 파일 생성 및 쓰기 예제입니다.");
				System.out.println("파일 생성이 성공하였습니다.");
				BufferedOutputStream bs;
				try {
					bs = new BufferedOutputStream(new FileOutputStream("d:/test1.txt"));
					String str = "파일 생성 및 쓰기 예제입니다.";
					bs.write(str.getBytes());
					bs.close();
				} catch (FileNotFoundException e) {
					e.printStackTrace();
				} catch (IOException e) {
					e.printStackTrace();
				}
			} else if (num1 == 2) {
				System.out.println("2. 파일 읽기");
				System.out.println("파일명 : test1.txt");
				System.out.println("읽은 내용 : 파일 생성 및 쓰기 예제입니다.");
				System.out.println("파일읽기가 성공하였습니다");
				System.out.println("-------------------------");
				BufferedReader br;
				try {
					br = new BufferedReader(new FileReader(new File("d:/test1.txt")));
					String str = br.readLine();
					System.out.println("---파일에서 내용 읽어오기---");
					System.out.println(str);
					br.close();
				} 
				catch (FileNotFoundException e) {
					e.printStackTrace();
				} 
				catch (IOException e) {
					e.printStackTrace();
				}
			} 
			else if (num1 == 3) {
				System.out.println("시스템을 종료합니다.");
				s.close();
				System.exit(0);
			} 
			else {
				System.out.println("잘못 선택하였습니다.");
				continue;
			}
		}
	}

}
