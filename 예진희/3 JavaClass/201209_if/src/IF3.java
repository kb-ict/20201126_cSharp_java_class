import java.util.Scanner;

public class IF3 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("���ڸ� �Է�: ");
		int num = s.nextInt();
		
		if (num%2!=0) {
			//if (num%2!=0) == if (num%2==1)
			System.out.println("Ȧ���Դϴ�.");
		}
		
		if (num%2==0) {
			System.out.println("¦���Դϴ�.");
		}
		s.close();
	}

}
