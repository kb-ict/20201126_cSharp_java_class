import java.util.Scanner;

public class HolJJackFor {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String line = "-------------------------";
		System.out.println(line);
		System.out.println("짝수, 홀수 구분 프로그램 v1.0");
		System.out.println(line);
		int num=0;
		for (int i = 0; i < 5; i++) {
			System.out.printf("Num"+(i+1)+" =>" );
			num=sc.nextInt();
			
			if (num%2==0) {
				System.out.println("짝수입니다.");
			}
			else {
				System.out.println("홀수입니다.");
			}
		}
		sc.close();
		
		
		
		

	}

}
