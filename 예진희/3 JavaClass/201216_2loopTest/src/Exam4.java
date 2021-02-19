import java.util.Scanner;

public class Exam4 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String line = "-------------------------";
		System.out.println(line);
		System.out.println("   입력받는수의 합을 구하는 프로그램 v1.0");
		System.out.println(line);

		int i = 0;
		int hap = 0;
		System.out.print("num1 입력 => ");
		int num1 = s.nextInt();
		System.out.print("num2 입력 => ");
		int num2 = s.nextInt();
		s.close();
		for (i = num1; i <= num2; i++) {
			hap += i;

		}
		System.out.println(hap);
		
	} 
}