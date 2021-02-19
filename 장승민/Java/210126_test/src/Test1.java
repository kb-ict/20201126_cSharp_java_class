import java.util.Scanner;

public class Test1 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);	// Scanner 클래스 호출
		double rad = sc.nextDouble();			// rad 변수에 반지름 값 입력
		sc.close();								// Scanner 클래스 종료
		Circle cc = new Circle(rad);			// cc라는 이름의 Circle클래스 호출 -> 매개변수로 rad 삽입
		System.out.println(cc.getArea());		// 원 넓이 출력

	}

}

class Circle {
	
	double rad = 0;
	final double PI = 3.14;

	public void setRad(double rad) {		// 매개변수로 double타입을 받는 setter 생성
		if (rad > 0)						// 매개변수가 양수일때는 그대로 진행
			this.rad = rad;
		else {								// 매개변수가 음수일때 예외처리		
			System.out.println("입력하신 수는 0또는 음수입니다.");
			System.exit(0);					//위의 줄 출력하고 시스템 종료
		}
	}

	public Circle(double r) {				
		setRad(r);
	}

	public double getArea() {
		return (rad * rad) * PI;
	}

}