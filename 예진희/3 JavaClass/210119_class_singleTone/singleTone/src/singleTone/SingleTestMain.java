package singleTone;

public class SingleTestMain {

	public static void main(String[] args) {

//		SingleTest si1 = new SingleTest();
//		si1.getData();
//		new SingleTest().getData();

		// 인스턴스 객체 사용
		// 디자인패턴 = 설계도(설계방법 참조)

		System.out.println("-----------------------");
		System.out.println("인스턴스 객체 생성");
		System.out.println("-----------------------");
		for (int i = 0; i < 5; i++) {
			System.out.println(new SingleTest().getData());
		}

		System.out.println("\n-----------------------");
		System.out.println("싱글톤 객체 생성");
		System.out.println("-----------------------");
		for (int i = 0; i < 5; i++) {
			System.out.println(SingleTest.getInstance().getData()); //리턴값이 객체여서 .찍어도 됨
		}

		// singletone 사용

	}
}
