
public class ArrPractice2 {

	public static void main(String[] args) {
		int arr[]=new int[100];

		for (int i = 0; i < arr.length; i++) {
			arr[i]=i+1;
		}
		for (int i = 0; i < arr.length; i++) {
			if (arr[i]%5==0) {
				System.out.println(arr[i]);
				
			}
			if (i==90) {
				break;
			}
		}
	}

}
