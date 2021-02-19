package thread_20210127;
import java.awt.Toolkit;
public class Thread3 {
	public static void main(String[] args) {
		Runnable task = new BeepTask();
		Thread th = new Thread(task);
		th.start();
	}

}

// Runnable 인터페이스 사용
// Interface는 반드시 오버라이딩 필요
class BeepTask implements Runnable{

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