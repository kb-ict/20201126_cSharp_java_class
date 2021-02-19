package inputTest;

import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		
		// Scanner 객체 생성
		Scanner s = new Scanner(System.in);
		
		System.out.print("이릅 입력 : ");
		
		//키보드로 문자열 입력받음
		String name = s.nextLine();
		
		System.out.print("나이 입력 : ");
		
		//키보드로 정수 입력 받음
		int age = s.nextInt();
		
		System.out.println("이름 정보 : "+ name);
		System.out.println("나이 정보 : "+ age);
		s.close();
	}

}
