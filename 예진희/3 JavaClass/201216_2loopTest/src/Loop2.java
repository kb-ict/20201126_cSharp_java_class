
public class Loop2 {

	public static void main(String[] args) {
		int hap = 0;
		for (int i=0; i<10; i++) {
			hap = hap + (i+1);
			// hap = hap + (i+1); == hap += (i+1);
			// += 연산자 모두 적용가능
		}
		System.out.println("1~10까지 합: "+hap);

	}

}
