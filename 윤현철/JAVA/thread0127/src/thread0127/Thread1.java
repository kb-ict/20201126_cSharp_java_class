package thread0127;

public class Thread1 {

	public static void main(String[] args) throws InterruptedException {
		myThread t1 = new myThread("T1");
		myThread t2 = new myThread("T2");
		t1.start();
		t2.start();
		for (int i = 0; i < 10; i++) {
			System.out.println("main 쓰레드 동작중");
			Thread.sleep(100);
		}
		System.out.println("메인 쓰레드 종료");
	}

}

class myThread extends Thread{
	String str;
	
	public myThread(String str) {
		this.str = str;
	}
	
	// 오버로딩 : 중복정의
	// 오버라이딩 : 부모의 것을 재정의
	// 쓰레드로 동작하는 부분
	@Override
	public void run() {
		for (int i = 0; i < 10; i++) {
			System.out.println(str);
			// 1000ms = 1초
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("작업 쓰레드 종료");
	}
	
}