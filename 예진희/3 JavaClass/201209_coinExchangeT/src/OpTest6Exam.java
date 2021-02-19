import java.util.Scanner;

public class OpTest6Exam {

	public static void main(String[] args) {
		String line = "---------------------------------";
		int coin500 = 0;
		int coin100 = 0;
		int coin50 = 0;
		int jandon = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println(line);
		System.out.println("       동전 교환기 프로그램 1.0");
		System.out.println(line);
		System.out.print(" * 금액을 입력하세요: ");
		int input = sc.nextInt();
		System.out.println(line);
		
		coin500 = input/500;
		int namg = input%500;
		//System.out.println("500원 나머지		: "+namg);
		
		coin100 = namg / 100;
		//System.out.println("100원 나머지		: "+namg);
		
		namg = namg % 100; // namg %= 100; 같은표기
		coin50 = namg / 50;
		
		namg = namg % 50;
		jandon = namg;
		/*
		 * coin100 = (input%500)/100; coin50 = ((input%500)%100)/50; jandon =
		 * ((input%500)%100)%50;
		 */
		
		System.out.println(" 1. 오백원 갯수		: "+coin500+"개");
		System.out.println(" 2. 백원 갯수		: "+coin100+"개");
		System.out.println(" 3. 오십원 갯수		: "+coin50+"개");
		System.out.println(" 4. 바꾸지 못한 잔돈	: "+jandon+"원");
		System.out.println(line);
		sc.close();

	}

}