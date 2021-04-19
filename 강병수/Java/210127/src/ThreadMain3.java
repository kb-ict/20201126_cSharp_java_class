import java.awt.Toolkit;

public class ThreadMain3 {

	public static void main(String[] args) throws InterruptedException {
		BeepTask task = new BeepTask();
		Thread th = new Thread(task);
		th.start();
		for (int i=0 ; i<5 ; i++) {
			System.out.println("메인 스레드 동작: " + i);
			Thread.sleep(500);
		}
		System.out.println("메인 스레드 종료");
	}

}

// Runnable 인터페이스를 사용
// Interface는 반드시 오버라이딩 필요
class BeepTask implements Runnable{

	@Override
	public void run() {
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i<5; i++) {
			toolkit.beep();
			System.out.println("작업스레드: " + i);
			try {
				Thread.sleep(2000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업 스레드 종료");
	}
	
}