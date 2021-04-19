import java.util.Scanner;

public class If2 {

	public static void main(String[] args) {
		Scanner cs = new Scanner(System.in);
		System.out.print("숫자를 입력하십시오: ");
		int a = cs.nextInt();
		
		if(a%2==1) {
			System.out.println("홀수입니다.");
		}
		else {
			System.out.println("짝수입니다.");
		}
		cs.close();
	}
	
}
