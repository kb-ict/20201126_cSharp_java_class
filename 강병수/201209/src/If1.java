
public class If1 {

	public static void main(String[] args) {
		int num = 99;
		
		//현재 제어문이 거짓
		if(num>100) {
			System.out.println("num가 100보다 작다.");
		}
		else {
			System.out.println("num가 100보다 크다.");
			System.out.println("거짓");
		}
		
		if (num<100) {
			System.out.println("num가 100보다 작다.");
			System.out.println("참");
		}
	}

}
