import java.util.Scanner;

public class Pulee_mine6 {

	public static void main(String[] args) {
		String line = "---------------------------------------------------";
		Scanner sc = new Scanner(System.in);
		/*6.	1~N까지 M의 배수를 제외한 합을 구하는 함수를 작성하고, 
		 *		해당 결과 값이 출력되는 프로그램을 작성하시오.(N과 M은 사용자에게 입력 받음.
		 */
		System.out.println("1부터 (num1)까지의 합산하는 프로그램, ※단 (num2)의 배수제외\n"+line);
		System.out.print("(num1)을 입력하세요 => ");
		int num1 = sc.nextInt();
		System.out.print("(num2)을 입력하세요 => ");
		int num2 = sc.nextInt();
		
		int hap = 0;
		for (int i = 0; i < num1; i++) {
			
			if ((i+1)%num2!=0) {
				hap += (i+1);
			}
			
		}
		System.out.println(line);
		System.out.printf("1부터 %d까지 %d를 제외한 총합은 : %d", num1,num2,hap);
		
		sc.close();
		
	}

}
