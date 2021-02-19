package thread_20210127;
import java.awt.Toolkit;
public class Thread2 {
	public static void main(String[] args) {
		BeepThread beep = new BeepThread();
		// 작업 쓰레드 시작
		beep.start();
		
		// 메인 쓰레드 시작
		for (int i = 0; i < 5; i++) {
			System.out.println("메인 쓰레드 : " + i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("메인 쓰레드 종료");
	}
}

// 쓰레드를 사용하기 위해서는 run을 반드시 오버라이딩 필요
// 부모 클래스인 Thread 상속
class BeepThread extends Thread{
	
	@Override
	public void run() {
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("작업 쓰레드 : " + i);
			try {
				Thread.sleep(2000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업 쓰레드 종료");
	}
}