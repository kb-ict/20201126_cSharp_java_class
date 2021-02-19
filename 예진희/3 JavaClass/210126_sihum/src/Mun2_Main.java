import java.util.Scanner;

public class Mun2_Main {

	public static void main(String[] args) {
		// 쥐	- 소 - 호랑이	- 토끼
		// 용 	- 뱀 - 말		- 양
		// 원숭이 - 닭 - 개		- 돼지
		
		Scanner s = new Scanner(System.in);
		System.out.print("n년 입력 : ");
		int year = s.nextInt();
		int misin = year%12;
		switch(misin) {
		case 9:
			System.out.println("뱀의 해");
			break;
		case 10:
			System.out.println("말의 해");
			break;
		case 11:
			System.out.println("양의 해");
			break;
		case 0:
			System.out.println("원숭이의 해");
			break;
			
		case 1:
			System.out.println("닭의 해");
			break;
		case 2:
			System.out.println("개의 해");
			break;
		case 3:
			System.out.println("돼지의 해");
			break;
			
		case 4:
			System.out.println("쥐의 해");
			break;
		case 5:
			System.out.println("소의 해");
			break;
		case 6:
			System.out.println("호랑이의 해");
			break;
			
		case 7:
			System.out.println("토끼의 해");
			break;
		case 8:
			System.out.println("용의 해");
			break;
			
		}
		
		s.close();
	}

}
