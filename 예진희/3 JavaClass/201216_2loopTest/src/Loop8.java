
public class Loop8 {

	public static void main(String[] args) {
		int hap = 0;
		for (int i=1; i<=10; i++) {
			
			// 3으로 나눈 나머지가 0
			// =>3의 배수
			if(i % 3 == 0) {
				// 반복문 처음 for로 이동
				continue; 
			}
			System.out.println("i: " + i);
			hap += i;
			
			if (i==5) {
				System.out.println("탈출");
				break; 
				// 5회만 반복수행
			}
			
		}
		System.out.println("1~10까지 3의 배수 제외합: "+hap);
	}
}
