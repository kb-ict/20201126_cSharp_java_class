import java.util.Scanner;

public class Test7 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("몇월인지 입력하세요 : ");
		int mon = s.nextInt();
		switch(mon) {
		case 12: case 1 : case 2:
			System.out.println("겨울");
			break;
		case 3: case 4 : case 5:
			System.out.println("봄");
			break;
		case 6: case 7 : case 8:
			System.out.println("여름");
			break;
		case 9: case 10 : case 11:
			System.out.println("가을");
			break;
		}
		s.close();
		

	}

}
