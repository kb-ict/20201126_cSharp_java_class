import java.util.Scanner;

public class Variable7 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int a = 0;
		int b = 0;
		Scanner sc = new Scanner(System.in);
		System.out.println("첫번째 숫자를 입력하세요 : ");
		a = sc.nextInt();
		System.out.println("두번째 숫자를 입력하세요 : ");
		b = sc.nextInt();
		int c = (a>=b) ? a : b;
		int d = (a>=b) ? b : a;
		
		System.out.println("최대값은 " + c +" 입니다.");
		System.out.println("최소값은 " + d +" 입니다.");
		
		sc.close();
	}

}
