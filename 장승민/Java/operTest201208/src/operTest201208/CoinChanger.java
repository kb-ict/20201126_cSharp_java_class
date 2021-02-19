package operTest201208;

import java.util.Scanner;

public class CoinChanger {

	public static void main(String[] args) {
		
		int ohbeak,beak, ohsip, sip, nochange = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("지폐의 금액을 입력하시오. : ");
		int cash = sc.nextInt();
		
		ohbeak = cash / 500;
		beak = (cash % 500)/100;
		ohsip = (cash % 100)/50;
		sip = (cash % 50)/10;
		nochange = cash % 10;
		
		String line ="--------------------";
		
		System.out.println(line);
		System.out.println("동전 교환 프로그램 1.0");
		System.out.println(line);
		System.out.println("오백원 갯수 : " + ohbeak + "개");
		System.out.println("백원 갯수 : " + beak+ "개");
		System.out.println("오십원 갯수 : " + ohsip+ "개");
		System.out.println("십원 갯수 : " + sip+ "개");
		System.out.println("바꾸지 못한 잔돈 : "+nochange+ "개");
		System.out.println(line);
		
	}

}
