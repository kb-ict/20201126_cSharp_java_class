package thread0127;

import java.awt.Toolkit;

public class Thread2 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		BeepThread beep = new BeepThread();
		// �۾� ������ ����
		beep.start();
		
		// ���� ������ ����
		for (int i = 0 ; i < 5; i++) {
			System.out.println("���ξ����� ����: " + i);
			Thread.sleep(500);
		}
	}

}

// �����带 ����ϱ� ���ؼ��� run()�� �������̵� �ؾ���
class BeepThread extends Thread {

	@Override
	public void run() {
		Toolkit  toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep();
			System.out.println("�۾�������: " + i);
			try {
				Thread.sleep(2000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
	
}
