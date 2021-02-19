import java.util.Scanner;
public class If5 {

	public static void main(String[] args) {
		Scanner ye = new Scanner(System.in);
		int year = 0;
		System.out.print("년도를 입력하십시오: ");
		year = ye.nextInt();
		if((year%4 == 0 && year%100 !=0) || (year%400 == 0)) {
			System.out.println("윤년입니다.");
		}
		else {
			System.out.println("윤년이 아닙니다.");
		}
		ye.close();
	}

}
