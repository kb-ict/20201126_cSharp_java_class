import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		// Scanner 객체(s) 생성 
		// in = 입력, out = 출력
		Scanner s = new Scanner(System.in);
		System.out.print("이름을 입력: ");
		
		// 키보드로 문자열 입력받음
		String name = s.nextLine();
		// 정수 입력 받음
		System.out.print("나이 입력: ");
		int age = s.nextInt();
		
		System.out.println("");
		System.out.println("-------------------");
		System.out.println("이름: "+name);
		System.out.print("나이: "+age);
		
		s.close();
		// 주황 = 잠재버그, 경고
	}

}
