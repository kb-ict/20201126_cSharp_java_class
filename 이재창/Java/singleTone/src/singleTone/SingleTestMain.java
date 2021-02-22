package singleTone;

public class SingleTestMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 인스턴스 객체 사용
		SingleTest si1 = new SingleTest();
		si1.getData();
		
		for (int i = 0; i < 5; i++) {
			System.out.println(new SingleTest().getData());
		}
		
		System.out.println("------------------------------");
		
		// singletone 사용
		for (int i = 0; i < 5; i++) {
			System.out.println(SingleTest.getInstance().getData());
		}
	}

}
