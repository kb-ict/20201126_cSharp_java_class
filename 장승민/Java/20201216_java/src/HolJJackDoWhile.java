import java.util.Scanner;

public class HolJJackDoWhile {

	public static void main(String[] args) {

		Scanner sc=new Scanner(System.in);
		String line = "-------------------------";
		System.out.println(line);
		System.out.println("짝수, 홀수 구분 프로그램 v1.0");
		System.out.println(line);
		int num,cnt=0;
		do {
			System.out.printf("Num"+(cnt+1)+" =>" );
			num=sc.nextInt();
			
			if (num%2==0) {
				System.out.println("짝수입니다.");
			}
			else {
				System.out.println("홀수입니다.");
			}
			cnt++;
		} while (cnt<5);
		
		sc.close();
		
	}

}
