package thread_20210127;

public class Thread4 {
	public static void main(String[] args) {
		// 다형성
		Thread th = new MovieThread();
		th.start();
		
		for (int i = 0; i < 5; i++) {
			System.out.println("메인 쓰레드 : " + i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("메인 쓰레드 종료");
		th.interrupt();
	}
}

class MovieThread extends Thread{
	@Override
	public void run() {
		while(true) {
			System.err.println("동영상 재생");
//			if(isInterrupted()) {
//				System.out.println("방해 신호 받음");
//				break;
//			}
			
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				System.out.println("방해 신호 받음2");
//				e.printStackTrace();
				break;
			}
		}
		System.out.println("작업 쓰레드 종료");
	}
	
}