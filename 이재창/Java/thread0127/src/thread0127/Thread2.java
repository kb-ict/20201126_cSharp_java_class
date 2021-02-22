package thread0127;

import java.awt.Toolkit;

public class Thread2 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		BeepThread beep = new BeepThread();
		// 작업 쓰레드 시작
		beep.start();
		
		// 메인 쓰레드 시작
		for (int i = 0 ; i < 5; i++) {
			System.out.println("메인쓰레드 동작: " + i);
			Thread.sleep(500);
		}
	}

}

// 쓰레드를 사용하기 위해서는 run()을 오버라이딩 해야함
class BeepThread extends Thread {

	@Override
	public void run() {
		Toolkit  toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("작업쓰레드: " + i);
			try {
				Thread.sleep(2000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
	
}
