
public class Loop3 {

	public static void main(String[] args) {
		int hap = 0;
		for(int i=0; i<10; i+=2) {
			hap += (i+1);
		}
		System.out.println("1~10까지 홀수합:1 " + hap);
		
		hap = 0;
		for (int j=0; j<10; j++) {
			if((j+1)%2!=0) {
				hap += (j+1);
			}
		}
		System.out.println("1~10까지 홀수합2: " + hap);
	}

}
