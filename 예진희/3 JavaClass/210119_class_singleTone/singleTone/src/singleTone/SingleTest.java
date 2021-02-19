package singleTone;

public class SingleTest {
	private static SingleTest inst; // 자기 자신의 타입
	private int data;

	public SingleTest() {
		data = (int) (Math.random() * 100);

	}
	
	
	//class method, 클래스 메소드
	public static SingleTest getInstance() { //리턴 타입이 SingleTest
		if (inst == null) {					 //처음에 null, 만들어진 객체를 ~ 계속 재사용 ~(계속 return), 
			inst = new SingleTest();
		}
		return inst;
	}
	
	public int getData() {
		return data;
	}
}
