import java.util.Scanner;

class Circle {
	private double rad;
	private final double PI = 3.14;
	private double area;

	public Circle(double rad) {
		this.rad = rad;
	}

	public double getRad() {
		return rad;
	}

	public void setRad(double rad) {
		this.rad = rad;
	}

	public double getArea() {
		return (rad * rad) * PI;
	}

	public void setArea(double area) {
		this.area = area;
	}

	public double getPI() {
		return PI;
	}

	public void showArea() {
		System.out.println("원의 넓이: " + getArea());
	}
}

public class Problem1 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		System.out.print("원의 반지름 입력: ");
		int r = sc.nextInt();

		if (r < 0) {
			r = r * (-1);
		}
		new Circle(r).showArea();

		sc.close();
	}
}
