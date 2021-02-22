import java.util.Scanner;

public class Ex9 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] a= new int[3];
		for (int i = 0; i < 3; i++) {
			System.out.printf("%d번째 숫자를 입력하세요 : ",i+1);
			a[i] = s.nextInt();	
		}
		
		int[] b = func(a);
		System.out.printf("세 숫자의 최대값은 %d이고 최소값은 %d이다",b[1],b[0]);
		s.close();
	}
	public static int[] func(int[] a) {
		int[] b = new int [2];
		b[0]= a[0];
		b[1]= a[0];
		for (int i = 0; i < 3; i++) {
			if (b[0]>a[i]) {
				b[0]=a[i];
			}
			else if (b[1]<a[i]) {
				b[1]=a[i];
			}
		}
		return b;
	}
}
