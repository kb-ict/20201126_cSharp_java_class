import java.util.Scanner;

//패키지 없다.

public class Munje_mine5 {
	/*
	 * 5. 1개의 숫자를 입력받아서 구구단 출력하는 프로그램.
	 * 조건1) 숫자 입력은 main() 에서 입력 받음.
	 * 조건2) 3을 입력받으면 3단 출력, 5를 입력받으면 5단을 출력.
	 * 조건3) 숫자를 매개변수로 전달하여 구구단을 출력하는 메쏘드 작성.
	*/
	
	public static void gob (int su) {
		for (int i = 0; i < 9; i++) {
			System.out.printf("%d x %d = %d\n",su,(i+1),(su*(i+1)));
		}
	}
	
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		while(true) {
		System.out.print("구구단 출력할 수(2~9) 입력 => ");
		int su = s.nextInt();
		System.out.println("----------------------");
		if(su>1&&su<10) {
			gob(su);
			s.close();
			return;
		}else {
			System.out.println("2~9사이의 수를 다시 입력하세요\n----------------------");
			}
		
		}
	}

}
