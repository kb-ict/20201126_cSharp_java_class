import java.util.Scanner;

public class If_Dab2_yunNyon {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String line = "---------------------";
		
		System.out.print("������ �Է��ϼ���: ");
		int year = sc.nextInt();
		
		if ((year % 4 == 0 && year % 100 != 0)||(year % 400 == 0)) {
			System.out.println(line);
			System.out.println("�����Դϴ�.");
		}
		else {
			System.out.println(line);
			System.out.println("������ �ƴմϴ�.");
		}
		
		/*	
		if (year % 4 == 0 && year % 100 != 0) {
			System.out.println(line);
			System.out.println("�����Դϴ�.");
		}
		if (year % 400 == 0) {
			System.out.println("�����Դϴ�.");
		}
		*/
		
		sc.close();

	}

}
