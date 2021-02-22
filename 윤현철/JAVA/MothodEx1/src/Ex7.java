
public class Ex7 {

	public static void main(String[] args) {
		int[] sum = func();
		System.out.printf("1~100까지의 홀수합은 %d이고 짝수합은 %d이다",sum[1],sum[0]);
	}
	public static int[] func() {
		int[] sum = new int[2];
		for (int i = 0; i < 100; i++) {
			if ((i+1)%2==0) {
				sum[0]=sum[0]+(i+1);
			}
			else {
				sum[1]=sum[1]+(i+1);
			}
		}
		return sum;
	}

}
