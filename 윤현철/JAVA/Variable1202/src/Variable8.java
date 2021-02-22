import java.util.Scanner;

public class Variable8 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int a = 0;
		int b = 0;
		int c = 0;
		int d = 0;
		
		System.out.println("교환할 금액을 입력하세요");
		Scanner sc = new Scanner(System.in);
		int m = sc.nextInt();
		a = m / 500;
		int e = m % 500;
		b = e / 100;
		e = e % 100;
		c = e / 50;
		e = e % 50;
		d = e / 10;
		e = e % 10;
		String line =      "---------------------";
		System.out.println(line);
		System.out.println(" 동전 교환기 프로그램 1.0");
		System.out.println(line);
		System.out.println("오백원 갯수 :" + a + "개");
		System.out.println("백원 갯수  :" + b + "개");
		System.out.println("오십원 갯수 :" + c + "개");
		System.out.println("십원 갯수  :" + d + "개");
		System.out.println("바꾸지 못한 잔돈 :" + e + "원");
		System.out.println(line);
		sc.close();
	}

}



