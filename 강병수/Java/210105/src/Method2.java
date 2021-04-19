
public class Method2 {

	public static int plus(int num1, int num2) {
		int result = 0;
		result = num1 + num2;
		return result;
	}
	
	public static void main(String[] args) {
		int sum = plus(100, 200);
		System.out.println("sum: " + sum);
		System.out.println("sum: " + plus(200, 300));

	}

}
