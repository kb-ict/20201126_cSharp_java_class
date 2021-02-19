package thread;
public class MakeThreadDemo {
	public static void main(String[] args) {
		Runnable task = () -> { // 쓰레드가 실행하게 할 내용
			int n1 = 10;
			int n2 = 20;
			String name = Thread.currentThread().getName();
			System.out.println(name + " : " + (n1 + n2));
		};
		
		Thread t = new Thread(task); // 인스턴스 생성 시 run 메소드의 구현 내용 전달
		t.start(); // 쓰레드의 생성 및 실행
		System.out.println("End " + Thread.currentThread().getName());
	}

}
