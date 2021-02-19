package beak;

import java.util.Scanner;

public class Baek10797 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int date = sc.nextInt();
		int car [] = new int [5];
		int cnt = 0;
		for (int i = 0; i < car.length; i++) {
			car[i] = sc.nextInt();
			if(date == car[i]) cnt++;
		}
		sc.close();
		System.out.println(cnt);
		
	}

}
