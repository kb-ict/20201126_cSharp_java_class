package thread0127;

public class Thread5 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		AutoThread th = new AutoThread();
		// 데몬 쓰레드는 메인쓰레드의 종속적인 부분이므로
		// 메인쓰레드가 종료되면 자동으로 종료됨
		th.setDaemon(true);
		th.start();
		
		for (int i = 0; i < 5; i++) {
			System.out.println("메인쓰레드" + i);
			Thread.sleep(500);
		}
		System.out.println("메인종료");
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
				// TODO Auto-generated catch block
				e.printStackTrace();
				break;
			}
			
			save();
		}
		System.out.println("작업 쓰레드 종료");
	}
	
}
