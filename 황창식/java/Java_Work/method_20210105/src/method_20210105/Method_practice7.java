package method_20210105;

public class Method_practice7 {

	public static void main(String[] args) {

		int arr[] = sum();
		System.out.println("1 ~ 100 홀수의 합 : " + arr[0]);
		System.out.println("1 ~ 100 홀수의 합 : " + arr[1]);

	}
	
	public static int[] sum() {
		int holsum = 0;
		int jjacksum = 0;
		for (int i = 1; i <= 100; i++) {
			if(i%2 == 0) 
				jjacksum += i;
			else
				holsum += i;
		}
		int arr[] = {holsum, jjacksum};
		return arr;
	}

}
