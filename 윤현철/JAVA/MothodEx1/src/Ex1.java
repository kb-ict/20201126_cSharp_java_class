import java.util.Scanner;

public class Ex1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] a=new int[3];
		for (int i = 0; i < 3; i++) {
			a[i]=s.nextInt();
		}
		func(a);
		s.close();
	}
	public static void func(int a[]) {
		for (int i = 0; i < 3; i++) {
			for (int j = i+1; j < 3; j++) {
				if(a[i]>a[j]) {
					int b = a[i];
					a[i] = a[j];
					a[j]= b;
				}
			}
		}
		for (int i = 0; i < 3; i++) {
			System.out.print(a[i]+" ");
		}
	}
}
