package thread0127;

public class Thread1 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		MyThread t1 = new MyThread("T1");
		MyThread t2 = new MyThread("T2");
		
		t1.start();
		t2.start();
		for (int i = 0; i < 10; i++) {
			System.out.println("main ������ ������");
			Thread.sleep(100);
		}
		System.out.println("���� ������ ����");
	}

}

class MyThread extends Thread {
	String str;
	
	public MyThread(String str) {
		this.str = str;
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		for (int i = 0; i < 10; i++) {
			System.out.println(str);
			try {
				Thread.sleep(100);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("�۾� ������ ����");
	}
}