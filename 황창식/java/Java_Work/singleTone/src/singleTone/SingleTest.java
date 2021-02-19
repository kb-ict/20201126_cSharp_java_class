package singleTone;
public class SingleTest {
	private static SingleTest inst;
	private int data;
	SingleTest(){
		data = (int)(Math.random()*100);
	}

	// class method
	public static SingleTest getInstance() {
		// 비어있는 객체면 새로운 객체 생성
		// 이미 생성된 객체면 객체 재사용
		if(inst == null) {
			inst = new SingleTest();
		}
		return inst;
	}
	
	public int getData() {
		return data;
	}
}
