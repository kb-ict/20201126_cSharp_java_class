
public class Ex1 {

	public static void main(String[] args) {
		int arr[]= {20,34,22,14,36,23,67,25,99,88};
		int sum=0;
		int ave=0;
		for (int i = 0; i < arr.length; i++) {
			sum = sum +arr[i];
			ave = sum / (i+1);
		}
		System.out.printf("배열의 합은 %d이고, 평균은 %d이다",sum,ave);
	}

}
