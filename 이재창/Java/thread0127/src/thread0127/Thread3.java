package thread0127;

import java.awt.Toolkit;

public class Thread3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		BeepTask task = new BeepTask();
		Thread th = new Thread(task);
		th.start();
	}

}

class BeepTask implements Runnable {

	@Override
	public void run() {
		// TODO Auto-generated method stub
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