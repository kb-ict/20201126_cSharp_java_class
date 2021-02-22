package thread0127;

public class Thread4 {
	public static void main(String[] args) {
		Thread th = new MovieThread();
		th.start();
		for (int i = 0; i < 5; i++) {
			System.out.println("메인 쓰레드 동작: "+i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("메인쓰레드 종료");
		th.interrupt();
	}
}

class MovieThread extends Thread{
	public void run() {
		while(true) {
			System.err.println("동영상 재생");
//			if(isInterrupted()) {
//				System.out.println("인터럽트 신호 받음");
//				break;
//			}
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
				break;
			}
		}
	}
}