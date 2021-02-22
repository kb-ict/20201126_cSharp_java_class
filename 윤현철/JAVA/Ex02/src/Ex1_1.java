import java.util.Scanner;

public class Ex1_1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("-------------------------");
		System.out.println(" 짝수, 홀수 구분 프로그램 v1.0");
		System.out.println("-------------------------");
		for (int i = 0; i<5; i++) {
			System.out.printf("%d. Num%d => ",(i+1),(i+1));
			int a = s.nextInt();
			if(a%2==0) {
				System.out.println("짝수입니다.");
			}
			else {
				System.out.println("홀수입니다.");
			}
		}
		s.close();
	}

}
