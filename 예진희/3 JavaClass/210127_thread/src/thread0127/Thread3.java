package thread0127;

import java.awt.Toolkit;

public class Thread3 {
	public static void main(String[] args) {
		BeepTask task = new BeepTask();
		Thread th = new Thread(task);
		th.start();
		// Runnable task = new BeepTask(); //<- 다양성..?

		// 메인 쓰레드 시작
		for (int i = 0; i < 5; i++) {
			System.out.println("메인 쓰레드 동작 : " + i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("메인쓰레드 종료"); // 메인쓰레드 = 메인 프로그램
	}
}

// 2. Runnable 인터페이스 사용
// Interface는 반드시 오버라이딩 
class BeepTask implements Runnable {

	@Override
	public void run() {
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("작업 쓰레드 : " + i);
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업 쓰레드 종료");
		// super.run(); <- 부모클래스의 run();
	}
}
// 인터페이스 당겨씀
// tv리모컨인데 오디오 당기고 싶을 때
