package singleTone;

public class SingleTestMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// �ν��Ͻ� ��ü ���
		SingleTest si1 = new SingleTest();
		si1.getData();
		
		for (int i = 0; i < 5; i++) {
			System.out.println(new SingleTest().getData());
		}
		
		System.out.println("------------------------------");
		
		// singletone ���
		for (int i = 0; i < 5; i++) {
			System.out.println(SingleTest.getInstance().getData());
		}
	}

}
