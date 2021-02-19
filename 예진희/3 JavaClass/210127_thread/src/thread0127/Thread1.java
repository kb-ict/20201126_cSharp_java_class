package thread0127;

public class Thread1 {
	public static void main(String[] args) throws InterruptedException {
		MyThread t1 = new MyThread("T1");
		MyThread t2 = new MyThread("T2");
		t1.start(); // t1 쓰레드 객체 동작시작
		t2.start(); // 멀티쓰레드 // 단일쓰레드 : 한번에 한동작 
		for(int i = 0; i<10; i++) {
			System.out.println("main 쓰레드 동작중");
			Thread.sleep(1000);
		}
		
		System.out.println("메인 쓰레드 종료");
	}
}
// 대기 사용 - hold array.. etc
// pc앱은 thread 필수

//------받음**------- 상속받을 부모클래스 이름* / *> **로
class MyThread extends Thread {
	String str;

	public MyThread(String str) {
		this.str = str;
	}

	// 오버로딩 : 중복정의
	// 오버라이딩 : 부모의 것을 재정의, 다중상속 X
	// work(작업) thread (run 메소드 안) : 쓰레드로 동작하는 부분
	@Override
	public void run() {
		for (int i = 0; i < 10; i++) {
			System.out.println(str);
			// 1000ms = 1초
			try {
				Thread.sleep(1000); // 쓰려면 예외처리 필요, 대기시간, 단위 : ms
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업 쓰레드 종료");
		// super.run(); //생략가능, 자동생성
		// 실행시 독자적으로 돌아감, 일시정지 불가능 
	}

}
