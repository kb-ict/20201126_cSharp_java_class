package bee_house;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		int count = 0;
		int hexmax = 1;
		while(true) {
			hexmax = hexmax + (count * 6);
			if(n > hexmax) {
				count++;
				continue;
			}
			else {
				System.out.println(count + 1);
				break;
			}
		}
		

	}

}
