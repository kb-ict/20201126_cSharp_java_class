package scanner_20201208;

import java.util.Scanner;

public class Scanner1 {

	public static void main(String[] args) {

		// Scanner 객체(s) 생성
		Scanner s = new Scanner(System.in);
		System.out.print("이름 입력 : ");
		// 키보드로 문자열 입력 받음
		String name = s.nextLine();
		// 정수 입력 받음
		System.out.print("나이 입력 : ");
		int age = s.nextInt();

		System.out.println("\n이름 정보 : " + name);
		System.out.println("나이 정보 : " + age + "살");
		s.close();

	}

}
