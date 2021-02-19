
public class Loop3 {

	public static void main(String[] args) {
		int hap = 0;
		for (int i = 0; i<10 ; i = i+2) {
			hap = hap + (i+1);
		}
		System.out.println(hap); //1~10 홀수합
		
		hap = 0;
			
		for (int j = 0; j<10 ; j++) {
			if((j+1)%2 == 1) {
			hap = hap + (j+1);
			}
		}
		System.out.println(hap); //1~10 홀수합2
		
	}

}
