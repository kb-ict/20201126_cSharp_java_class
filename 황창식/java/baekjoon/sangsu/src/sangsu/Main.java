package sangsu;


import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		String a = s.next();
		String b = s.next();
		int num1 = Integer.parseInt(new StringBuffer(a).reverse().toString());
		int num2 = Integer.parseInt(new StringBuffer(b).reverse().toString());
		if (num1 > num2) {
			System.out.println(num1);
		}
		else {
			System.out.println(num2);
		}
	}
}
