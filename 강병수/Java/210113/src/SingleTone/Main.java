package SingleTone;

public class Main {

	public static void main(String[] args) {
		SingleTest a1 = new SingleTest();
		System.out.println(a1.getData());

		SingleTest a2 = new SingleTest();
		System.out.println(a2.getData());

		for (int i = 0; i < 2; i++) {
			System.out.println(SingleTest.getInstance().getData());
			System.out.println(SingleTest.getInstance().getData());
		}
	}
}

class SingleTest {
	private static SingleTest inst;
	private int data;

	SingleTest() {
		data = (int) (Math.random() * 100);
	}

	public static SingleTest getInstance() {
		if (inst == null) {
			inst = new SingleTest();
		}
		return inst;
	}

	public int getData() {
		return data;
	}

}