import java.util.Scanner;

public class If_Dab2_yunNyon {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String line = "---------------------";
		
		System.out.print("연도를 입력하세요: ");
		int year = sc.nextInt();
		
		if ((year % 4 == 0 && year % 100 != 0)||(year % 400 == 0)) {
			System.out.println(line);
			System.out.println("윤년입니다.");
		}
		else {
			System.out.println(line);
			System.out.println("윤년이 아닙니다.");
		}
		
		/*	
		if (year % 4 == 0 && year % 100 != 0) {
			System.out.println(line);
			System.out.println("윤년입니다.");
		}
		if (year % 400 == 0) {
			System.out.println("윤년입니다.");
		}
		*/
		
		sc.close();

	}

}
