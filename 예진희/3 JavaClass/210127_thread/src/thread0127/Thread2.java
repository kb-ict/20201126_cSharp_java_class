package thread0127;

import java.awt.Toolkit;

public class Thread2 {
	public static void main(String[] args) {
		BeepThread beep = new BeepThread();
		beep.start(); // 작업 쓰레드 시작

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
	}
}

/*
 * 1.	자식이 --- 부모한테서 상속받음(extends) 
 * 		쓰레드 사용하기 위해서는 run()메소드 반드시 오버라이딩 필요
 *		부모 클래스인 Thread 상속
 * 2. 	인터페이스 이용 Thread3.java
 */
class BeepThread extends Thread {

	@Override
	public void run() {// -> 쓰레드의 동작(work 스레드로 동작함)
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("작업 쓰레드 : " + i);
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업 쓰레드 종료");
		// super.run(); <- 부모클래스의 run();
	}

}