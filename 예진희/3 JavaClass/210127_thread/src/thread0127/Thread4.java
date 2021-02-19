package thread0127;

public class Thread4 {
	public static void main(String[] args) {// 변수로 하는게 좀 더 정교
		// 다형성 개념, 부모 클래스에 자식 클래스 집어넣음
		// 여러 스레드 만들고 넣음..
		MovieThread th = new MovieThread();
		//Thread th = new MovieThread();
		th.start();
		
		// 메인 쓰레드 시작
		for (int i = 0; i < 5; i++) {
			System.out.println("메인 쓰레드 동작 : " + i);
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("메인쓰레드 종료"); // 메인쓰레드 = 메인 프로그램
		th.interrupt(); // 제어권 가로채기
	}
}

class MovieThread extends Thread {
	@Override // 좀 더 명확, annotation
	public void run() {
		while (true) {
			System.err.println("동영상 재생");
//			if(isInterrupted()) {
//				System.out.println("인터럽트 신호받음 1");
//				break;
//			}
			
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				System.out.println("인터럽트 신호받음 2");
//				e.printStackTrace(); //디버깅 용도 trace : 디버깅코드
				break;
			}
		}
		// System.out.println("작업 쓰레드 종료");
		// kakao talk.. 메시지 수신같은..
	}
}
