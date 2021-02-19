import java.awt.Toolkit;

public class Thread3 {

	public static void main(String[] args) {
		BeepTask task = new BeepTask();
		Thread th = new Thread(task);
		th.start();
		for(int i =0;i<5;i++) {
			System.out.println("메인 쓰레드 동작 : "+i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("메인 쓰레드 종료");
	}

}
// Runnable 인터페이스를 사용
// 인터페이스(Interface)는 반드시 오버라이딩 필요
class BeepTask implements Runnable{

	@Override
	public void run() {
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for(int i=0;i<5;i++) {
			toolkit.beep();
			System.out.println("작업쓰레드 : "+i);
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업 쓰레드 종료");
		
	}
	
}