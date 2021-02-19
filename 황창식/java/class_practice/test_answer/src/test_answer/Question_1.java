package test_answer;
public class Question_1 {
	public static void main(String[] args) {
		Circle circle = new Circle(10);
		System.out.println("rad : " + circle.getRad());
		System.out.println("area : " + circle.getArea());
	}
}

class Circle{
	private double rad = 0;
	final double PI = 3.14;
	
	public Circle(double r) {
		setRad(r);
	}
	
	public double getArea() {
		return (rad*rad)*PI;
	}
	
	public void setRad(double r) {
		if (r < 0) {
			rad = 0;
			return;
		}
		rad = r;
	}
	
	public double getRad() {
		return rad;
	}
}

