import java.util.Scanner;

public class IfExam4 {

	public static void main(String[] args) {
		/*
		 * 순서1) 입력한 년도를 4로 나누면 * 나머지가 0이고 
		 * 100으로 나누면 0이 아니어야 함.
		 * 
		 * 순서2) 입력한 년도를 400으로 나누면 나머지가 0 이어야 함.
		 * 
		 * 순서3) 조건1에서는 AND 논리연산자를 사용.
		 * 
		 * 순서4) 조건1과 조건2는 OR 논리연산자를 사용.
		 * --------------------------------------------------
		 * 4로 나누어 떨어지고 100으로 나누어 떨어지나,
		 * 400으로 나누어 떨어지면 윤년입니다.
		 * 2000년 같은 경우 400으로 나누어 떨어지기 때문에 윤년입니다.
		 * --------------------------------------------------
		 */
		Scanner sc = new Scanner(System.in);
		String line = "-----------------------------";
		System.out.println(line);
		System.out.println("  년도별 윤년 구분 프로그램 v1.0");
		System.out.println(line);
		System.out.print(" 년도 입력 => ");
		int year = sc.nextInt();
		System.out.println(line);
		
		if (year%4==0 && year%100!=0 || year%400==0) {
			System.out.println(year+"년은 윤년입니다.");
		}
		else {
			System.out.println(year+"년은 윤년이 아닙니다.");
		}
		sc.close();
	}

}
