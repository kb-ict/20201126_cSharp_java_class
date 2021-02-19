import java.util.Scanner;

public class SumDoWhile {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		String line = "---------------------------------";
		System.out.println(line);
		System.out.println("입력받는 수의 합을 구하는 프로그램 v1.0");
		System.out.println(line);

		int Fir, Sec = 0;
		System.out.printf("Num1 입력 => ");
		Fir = sc.nextInt();
		System.out.printf("Num2 입력 => ");
		Sec = sc.nextInt();

		int sum=0 ;
		int cnt = Fir;
		
		do {
			sum = sum + cnt;
			cnt++;
		} while (cnt<=Sec);
		
		sc.close();
		
		System.out.printf("%d ~ %d 까지의 합 : %d",Fir,Sec,sum);
	}

}
