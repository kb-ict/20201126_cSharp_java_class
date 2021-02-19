package beak;

import java.util.Scanner;

public class Baek6778 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int antena = sc.nextInt();
		int eyes = sc.nextInt();
		if (antena>=3&&eyes<=4) {
			System.out.println("TroyMartian");
		} if(antena<=6&&eyes>=2) {
			System.out.println("VladSaturnian");
		} if(antena<=2&&eyes<=3) {
			System.out.println("GraemeMercurian");
		}

	}

}
