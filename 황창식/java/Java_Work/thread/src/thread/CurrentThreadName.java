package thread;
public class CurrentThreadName {
	public static void main(String[] args) {
		Thread ct = Thread.currentThread();
		String name = ct.getName(); // 쓰레드의 이름을 반환
		System.out.println(name);
	}
}
