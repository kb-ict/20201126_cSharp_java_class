package thread0127;

public class Thread4 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		Thread th = new MovieThread();
		th.start();
		
		for (int i = 0; i < 5; i++) {
			System.out.println("���ξ�����" + i);
			Thread.sleep(500);
		}
		System.out.println("��������");
		th.interrupt();
	}

}

class MovieThread extends Thread {

	@Override
	public void run() {
		// TODO Auto-generated method stub
		while (true) {
			System.err.println("������ ���");
			if (isInterrupted()) {
				System.out.println("���ͷ�Ʈ ��ȣ ����1");
				break;
			}
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				System.out.println("���ͷ�Ʈ ��ȣ ����2");
				e.printStackTrace();
				break;
			}
		}
		System.out.println("�۾� ������ ����");
	}
	
}
