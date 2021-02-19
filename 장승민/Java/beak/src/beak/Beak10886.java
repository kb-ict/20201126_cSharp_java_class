package beak;

import java.util.Scanner;

public class Beak10886 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int cnt = sc.nextInt();
		int zero =0;
		int one =0;
		int servey = 0;
		for (int i = 0; i < cnt; i++) {
			 servey = sc.nextInt();
			 if (servey==0) {
				zero++;
			 }else if(servey==1) {
				 one++;
			 }
		}
		if (one>zero) {
			System.out.println("Junhee is cute!");
		}else if(one<zero) {
			System.out.println("Junhee is not cute!");
		}
	}

}
