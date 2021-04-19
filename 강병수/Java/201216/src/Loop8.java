
public class Loop8 {

	public static void main(String[] args) {
		int hap = 0;
		for (int i=1; i<11; i++) {
			// 3으로 나눈 나머지가 0
			// --> 3의 배수 
			if(i%3 != 0) {
				hap = hap + i;
				
			}
		}
		System.out.println("3의 배수를 제외한 1부터 10까지의 합: " + hap);
		
		hap = 0;
		for (int i=0; i<10; i++) {
			// 3으로 나눈 나머지가 0
			// --> 3의 배수 
			if((i+1)%3 == 0) {
				//반복문 처음으로 이동
				continue;
			}
				System.out.println("i: " + (i+1));
				hap = hap + (i+1);
				
				if (i<=5) {
					System.out.println("5까지 더한 뒤 탈출");
					break;
				}
			}
		System.out.println("1부터 10까지 3의 배수를 제외한 합: " + hap);
	}

}
