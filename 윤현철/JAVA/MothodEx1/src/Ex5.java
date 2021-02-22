import java.util.Scanner;

public class Ex5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("보고 싶은 구구단 단수: ");
		int a = s.nextInt();
		fonc(a);
		s.close();
	}
	
	public static void fonc(int a) {
		for (int i = 0; i < 9; i++) {
			System.out.printf("%d x %d = %d\n",a,i+1,a*(i+1));
		}
	}
}
