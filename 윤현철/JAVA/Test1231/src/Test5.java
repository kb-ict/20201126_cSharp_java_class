
public class Test5 {

	public static void main(String[] args) {
		int sum =0;
		for (int i = 0; i < 100; i++) {
			if((i+1)%2!=0) {
				sum= sum + i + 1;
			}
		}
		System.out.printf("짝수를 제외한 합은 %d이다.",sum);
	}

}
