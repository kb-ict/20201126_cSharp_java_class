package method_20210105;

public class Method_practice3 {

	public static void main(String[] args) {

		int arr[] = new int[10];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (int)((Math.random()*100)+1);
		}
		holjjack(arr);

	}
	
	public static void holjjack(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			if(arr[i]%2 == 0) {
				System.out.println(arr[i] + "는 짝수입니다.");
			}
			else {
				System.out.println(arr[i] + "는 홀수입니다.");
			}
		}
	}

}
