import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		// Scanner 객체(s) 생성
		Scanner s = new Scanner(System.in);
		System.out.print("이름을 입력하시오: ");
		//키보드로 문자열 입력받음
		String name = s.nextLine();
		
		System.out.print("나이를 입력하시오: ");
		//키보드로 정수 입력받음
		int age = s.nextInt();
		
		System.out.println("이름: " + name);
		System.out.println("나이: " + age);
		s.close();
	
	}

}
