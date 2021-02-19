import java.util.Scanner;
public class Test_1 {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		Circle c1 = new Circle(s.nextDouble());
		System.out.println(c1.getArea());
	}
}
class Circle{
	double rad = 0;
	final double PI = 3.14;
	public Circle(double r) {setRad(r);}
	public void setRad(double r) {
		if(r < 0) {
			rad = r*-1;
		}
	else {
			rad = r;
		}
	}
	public double getArea() {return (rad * rad)* PI;}
}