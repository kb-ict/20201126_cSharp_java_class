import java.util.Scanner;

public class Test6 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("최대수를 입력하시오 : ");
		int N = s.nextInt();
		System.out.println("제외할 배수를 입력하시오 : ");
		int M = s.nextInt();
		int sum = 0;
		for (int i = 0; i < N; i++) {
			if((i+1)%M!=0) {
				sum = sum +i+1;
			}
		}
		System.out.printf("%d의 배수를 제외한 합은 %d이다.",M,sum);
		s.close();
	}

}
