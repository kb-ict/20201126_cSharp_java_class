import java.util.Scanner;

public class If3 {

	public static void main(String[] args) {
	Scanner CA = new Scanner(System.in);
	System.out.print("점수를 입력: ");
	int num = CA.nextInt();
	
		if(100 >= num && num >= 90) {
		System.out.println("A학점");
		}
		else if(90> num && num >= 80) {
			System.out.println("B학점");
		}
		else if(80> num && num >= 70) {
			System.out.println("C학점");
		}
		else if(70> num && num >= 60) {
			System.out.println("D학점");
		}
		else {
			System.out.println("F학점");
		}
	CA.close();
	}

}
