
public class Loop7 {

	public static void main(String[] args) {
		int hap = 0;
		for (int i=0;i<10;i++) {
			if ((i+1) % 3 == 0) {
				continue;
			}
			hap += (i+1);
		}
		System.out.println("1~10까지 3의 배수를 제외한 합 : " + hap);
	}

}
