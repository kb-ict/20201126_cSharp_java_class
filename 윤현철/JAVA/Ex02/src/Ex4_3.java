import java.util.Scanner;

public class Ex4_3 {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("--------------------------------");
		System.out.println(" 입력받은수의 합을 구하는 프로그램 v1.0");
		System.out.println("--------------------------------");
		int sum = 0;
		int i = 0;
		while(true) {
			System.out.print("1. 첫번째 숫자를 입력하세요 => ");
			int a = s.nextInt();
			System.out.print("2. 두번째 숫자를 입력하세요 => ");
			int b = s.nextInt();
			if (a<b) {
				i = a;
				do {
					sum = sum + i;
					i++;
				}while(i<=b);
			}
			
			else{
				System.out.println("잘못 입력하셧습니다. 다시 입력하십시오.");
				continue;
			}
			System.out.printf("%d ~ %d까지의 합 : %d",a,b,sum);
			s.close();
			break;
		}
	}

}

