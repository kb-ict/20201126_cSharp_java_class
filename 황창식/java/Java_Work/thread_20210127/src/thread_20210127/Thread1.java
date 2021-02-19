package thread_20210127;

import thread_20210127.MyThread;

public class Thread1 {
	public static void main(String[] args) throws InterruptedException {
		MyThread task1 = new MyThread("T1");
		MyThread task2 = new MyThread("T2");
		task1.start(); // 쓰레드 객체의 동작 시작
		task2.start();
		for (int i = 0; i < 10; i++) {
			System.out.println("main 쓰레드 동작 중");
			Thread.sleep(1000);
		}
		System.out.println("메인 쓰레드 종료");
	}
}

class MyThread extends Thread {
	String str;
	
	public MyThread(String str) {
		this.str = str;
	}
	
	// 오버 로딩 : 중복정의
	// 오버 라이딩 : 부모의 것을 재정의
	// work(작업) 쓰레드로 동작하는 부분
	@Override
	public void run() {
		for (int i = 0; i < 10; i++) {
			System.out.println(str);
			// 1000ms : 1초
			try {
				Thread.sleep(1000); // ms단위(0.1초)
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		System.out.println("작업 쓰레드 종료");
	}
}