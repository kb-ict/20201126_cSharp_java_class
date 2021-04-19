import java.util.Scanner;

public class Coin_Problem {

	public static void main(String[] args) {
		Scanner coin = new Scanner(System.in);
		System.out.print("현재 금액을 입력하시오: ");
		int cash = coin.nextInt();
		
		int A = cash/500;
		int B = (cash%500)/100;
		int C = (cash%100)/50;
		int D = (cash%50)/10;
		
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("동전 교환기 프로그램 1.0");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("오백원 갯수: " + A);
		System.out.println("백원 갯수: " + B);
		System.out.println("오십원 갯수: " + C);
		System.out.println("십원 갯수: " + D);
		System.out.println("바꾸지 못한 잔돈: " + cash%10);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		coin.close();
		
	}

}
