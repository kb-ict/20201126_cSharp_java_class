import java.util.Scanner;

public class Pulee_mine7 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String line = "---------------------------";
		/*7.	사용자에게 현재 몇 월인지를 입력 받고 
		 * 		현재의 계절을 출력하는 프로그램을 작성하시오. 
		 * 		(단, 12~2월은 겨울, 3~5월은 봄, 6~8월은 여름, 9~11월은 가을이다.)
		 */
		while(true) {
			
		
		System.out.print("1~12월을 입력하세요 => ");
		int season = sc.nextInt();
		
		
		switch (season) {
		case 12: case 1: case 2:
			System.out.printf("%s\n%d월은 %s입니다.\n",line,season,"겨울");
			sc.close();
			System.exit(0);
			break;
			
		case 3: case 4: case 5:
			System.out.printf("%s\n%d월은 %s입니다.\n",line,season,"봄");
			sc.close();
			System.exit(0);
			break;
			
		case 6: case 7: case 8:
			System.out.printf("%s\n%d월은 %s입니다.\n",line,season,"여름");
			sc.close();
			System.exit(0);
			break;
		case 9: case 10: case 11:
			System.out.printf("%s\n%d월은 %s입니다.\n",line,season,"가을");
			sc.close();
			System.exit(0);
			break;
		default:
			System.out.printf("%s\n잘못된 값입니다.\n1~12사이의 수를 다시 입력하세요\n%s\n",line,line);
		
		}}
		
		
	}

}
