
public class Func5 {	
	public static void main(String[] args) {
		divide(4, 0);	
		
	}
	
	public static void divide(int a, int b) {		
		if (b == 0) {
			System.out.println("0���� ���� �� �����ϴ�.");
			System.exit(0);
		}
		System.out.println("������ ���: " + (a + b));
	}
}
