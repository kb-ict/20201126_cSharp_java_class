package class0113;

public class Main {

	public static void main(String[] args) {
		
		//1번
		Car car = new Car(); // 동일패키지 = 임포트 X
		car.showCarInfo();

		//2번		
		Car car2 = new Car("그랜저","현대","흰색","3천만원");
		car2.showCarInfo();
		
		new Car().showCarInfo();
		// 스택 오버플로우 | JVM | HEAP ↓ | STACK ↑ | 메모리쓰다가 충돌나면 종료
	}
}
