package method_20201230;

public class Method4 {

	public static void main(String[] args) {
		int num = 10;
		// 매개변수로 10을 전달
		func(num);
		System.out.println("main() num : " + num);
	}
	
	public static void func(int a) {
		a = a + 1;
		System.out.println("func() num : " + a);
	}

}
