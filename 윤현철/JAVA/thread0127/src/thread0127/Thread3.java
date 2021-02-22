package thread0127;

import java.awt.Toolkit;

public class Thread3 {
	public static void main(String[] args) {
		Runnable task = new BeepTask();
		Thread th = new Thread(task);
		th.start();
		
		// 메인 쓰레드 시작
		for (int i = 0; i < 5; i++) {
			System.out.println("메인 쓰레드 동작: "+i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
	}
}

// Runnable 인터페이스를 사용
// Interface는 반드시 오버라이딩 필요.
class BeepTask implements Runnable{

	@Override
	public void run() {
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("작업쓰레드: "+i);
			try {
				Thread.sleep(2000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
	}
}
