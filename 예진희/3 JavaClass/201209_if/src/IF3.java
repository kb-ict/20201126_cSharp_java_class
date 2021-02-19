import java.util.Scanner;

public class IF3 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("숫자를 입력: ");
		int num = s.nextInt();
		
		if (num%2!=0) {
			//if (num%2!=0) == if (num%2==1)
			System.out.println("홀수입니다.");
		}
		
		if (num%2==0) {
			System.out.println("짝수입니다.");
		}
		s.close();
	}

}
