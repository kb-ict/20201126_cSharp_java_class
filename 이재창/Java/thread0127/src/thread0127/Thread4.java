package thread0127;

public class Thread4 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		Thread th = new MovieThread();
		th.start();
		
		for (int i = 0; i < 5; i++) {
			System.out.println("메인쓰레드" + i);
			Thread.sleep(500);
		}
		System.out.println("메인종료");
		th.interrupt();
	}

}

class MovieThread extends Thread {

	@Override
	public void run() {
		// TODO Auto-generated method stub
		while (true) {
			System.err.println("동영상 재생");
			if (isInterrupted()) {
				System.out.println("인터럽트 신호 받음1");
				break;
			}
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				System.out.println("인터럽트 신호 받음2");
				e.printStackTrace();
				break;
			}
		}
		System.out.println("작업 쓰레드 종료");
	}
	
}
