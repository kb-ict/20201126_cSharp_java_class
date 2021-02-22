package Test1;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("반지름을 입력하시요 : ");
		double r = s.nextDouble();
		new Circle(r);
		s.close();
	}

}
