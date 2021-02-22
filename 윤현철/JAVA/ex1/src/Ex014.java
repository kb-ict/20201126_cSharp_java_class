import java.util.Scanner;

public class Ex014 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		for (int n = 0; n < 5; n++) {
			
			System.out.print("숫자를 입력 하세요 : ");
			int a =sc.nextInt();
			int b = a % 2; 
			if (b == 0) {
				System.out.println((n + 1) + ". " + a + "는 짝수입니다.");
			}
			else {
				System.out.println((n + 1) + ". " + a + "는 홀수입니다.");
			}
		}
		sc.close();
	}

}
