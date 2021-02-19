
public class Problem2 {

	public static void main(String[] args) {
		int arr1[] = new int[100];
		for (int i = 0;i<arr1.length; i++) {
			arr1[i] = (i+1);
			if ((i+1)%5 == 0) {
			System.out.println(arr1[i]);
			}
			if (arr1[i]>89) {
				System.exit(0);
			}
		}

	}

}
