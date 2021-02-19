import java.util.Scanner;

public class IF4 {

	public static void main(String[] args) {
			Scanner s = new Scanner(System.in);
			System.out.print("숫자를 입력: ");
			int num = s.nextInt();
			
			if (100 >= num && num >= 90) {
				System.out.println("A학점");
			}
			else if (89 >= num && 80<= num) {
				System.out.println("B학점");
			}
			else {
				System.out.println("A, B제외 학점");
			}
			s.close();
	}
}
	
