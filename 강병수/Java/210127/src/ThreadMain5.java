
public class ThreadMain5 {

	public static void main(String[] args) {
		AutoThread th = new AutoThread();
		// 데몬스레드는 메인스레드의 종속적인 부분이므로
		// 메인스레드가 종료되면 자동으로 종료됨
		th.setDaemon(true);
		th.start();

		for (int i = 0; i < 5; i++) {
			System.out.println("메인 스레드 동작: " + i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("메인 스레드 종료");

	}

}

class AutoThread extends Thread {
	public void save() {
		System.out.println("작업 내용 저장");
	}

	@Override
	public void run() {
		while (true) {
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
				break;
			}
			save();
		}
		System.out.println("작업 스레드 종료");
	}

}