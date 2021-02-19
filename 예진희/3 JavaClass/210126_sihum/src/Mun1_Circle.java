import java.util.Scanner;

public class Mun1_Circle {
	double rad = 0;
	final double PI = 3.14;
	Scanner s = new Scanner(System.in);

	public Mun1_Circle() {
		setRad();
	}

	private double setRad() {

		System.out.print("원의 반지름 입력 : ");
		rad = s.nextDouble();

		if (rad <= 0) {
			System.out.println("프로그램을 종료합니다. \n원의 반지름을 0보다 큰 실수로 정의하십시오.");
			System.exit(0);
		}

		return rad;
	}

	public double getArea() {
		return (rad * rad * PI);
	}
}
