package thread_20210127;

public class Thread5 {
	public static void main(String[] args) {
		AutoThread th = new AutoThread();
		// 데몬 쓰레드 : 메인 쓰레드의 종속적인 부분이므로
		// 메인 쓰레드가 종료되면 자동으로 종료됨
		th.setDaemon(true);
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
	}
}

class AutoThread extends Thread {
	public void save() {
		System.out.println("작업 내용 저장");
	}

	@Override
	public void run() {
		while(true) {
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
				break;
			}
			save();
		}
		System.out.println("작업 쓰레드 종료");
	}
}