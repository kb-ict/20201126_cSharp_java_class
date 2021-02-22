package ldjex;

import java.util.Scanner;

public class Ex5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int a = s.nextInt();
		switch(a){
		case 12,1,2:
			System.out.println("겨울");
			break;
		case 3,4,5:
			System.out.println("봄");
			break;
		case 6,7,8:
			System.out.println("여름");
			break;
		case 9,10,11:
			System.out.println("가을");
			break;
		}
		s.close();
	}

}
