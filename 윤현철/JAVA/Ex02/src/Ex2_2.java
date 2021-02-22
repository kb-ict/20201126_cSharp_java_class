
public class Ex2_2 {

	public static void main(String[] args) {
		System.out.println("------------------------");
		System.out.println(" 5의 배수 출력 프로그램 v1.0");
		System.out.println("------------------------");
		int i = 0;
		while(i<100) {
			if (i+1==100) {
				System.out.print(100);
			}
			else if((i+1)%5==0) {
				System.out.printf("%d, ",(i+1));
			}
			i++;
		}
	}

}
