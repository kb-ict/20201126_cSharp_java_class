import java.util.Scanner;
public class Loop5 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("원하는 구구단 입력: ");
		int num = sc.nextInt();
		
		for (int i=1; i<10; i++) {
			System.out.printf("%d * %d = %d\n", num ,i, num*i);
		}
		sc.close();
	}

}
