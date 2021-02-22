package thread0127;

public class Thread5 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		AutoThread th = new AutoThread();
		// ���� ������� ���ξ������� �������� �κ��̹Ƿ�
		// ���ξ����尡 ����Ǹ� �ڵ����� �����
		th.setDaemon(true);
		th.start();
		
		for (int i = 0; i < 5; i++) {
			System.out.println("���ξ�����" + i);
			Thread.sleep(500);
		}
		System.out.println("��������");
	}

}

class AutoThread extends Thread {
	public void save() {
		System.out.println("�۾� ���� ����");
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
		System.out.println("�۾� ������ ����");
	}
	
}
