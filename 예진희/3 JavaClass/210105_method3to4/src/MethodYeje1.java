
public class MethodYeje1 {//메소드 3번

	static int func() {
		System.out.println("값을 리턴하는 메쏘드");
		return 100; 
		// static (int) == return (100) 형을 맞춰주기
	}

	public static void main(String[] args) {
		int num = func();
		System.out.println("num: "+num);
		
		//변수와 메소드 호출, 반드시 리턴값이 있어야함
		System.out.println("num: "+func());
	}
}
