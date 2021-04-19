
public class ThreadMain1 {

	public static void main(String[] args) throws InterruptedException {
		MyThread t1 = new MyThread("T1");
		MyThread t2 = new MyThread("T2");
		t1.start(); // t1 스레드 객체 시작
		t2.start(); // t2 스레드 객체 시작
		for (int i = 0; i < 10; i++) {
			System.out.println("main 스레드 동작중");
			Thread.sleep(1000);
		}
		System.out.println("메인 스레드 종료");
	}

}

class MyThread extends Thread {
	String str;

	public MyThread(String str) {
		this.str = str;
	}

	// 오버로딩: 중복정의
	// 오버라이딩: 부모의 것을 재정의
	// work(작업) 스레드로 동작하는 부분
	@Override
	public void run() {
		for (int i = 0; i < 10; i++) {
			System.out.println(str);
			// 1000ms = 1초
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업 스레드 종료");
	}

}
