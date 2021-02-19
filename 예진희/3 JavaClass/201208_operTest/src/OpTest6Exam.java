import java.util.Scanner;

public class OpTest6Exam {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String line = "----------------------";
		int money500 = 0;
		int money100 = 0;
		int money50 = 0;
		int b = 0;
		
		System.out.println(line);
		System.out.println("   동전 교환기 프로그램");
		System.out.println(line);
		System.out.print("* 교환할 금액 입력: ");
		int money = sc.nextInt();
		System.out.println(line);
		
		money500 = money/500;
		money100 = (money%500)/100;
		money50 = ((money%500)%100)/50;
		b = ((money%500)%100)%50;
		System.out.println("1. 오백원 갯수: "+money500+"개");
		System.out.println("2. 백원 갯수  : "+money100+"개");
		System.out.println("3. 오십원 갯수: "+money50+"개");
		System.out.println("4. 바꾸지 못한 잔돈: "+b+"원");
		System.out.println(line);
		sc.close();

	}

}
