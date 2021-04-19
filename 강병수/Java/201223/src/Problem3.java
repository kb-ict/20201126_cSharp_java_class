
public class Problem3 {

	public static void main(String[] args) {
		int arr[] = new int[] {10,20,30,40,50,60,70,80,90,100};
		int arr1[] = new int[10];
		for (int i=0;i<arr.length;i++) {
			arr1[i] = arr[9-i];
			System.out.println(arr1[i]);
		}
	}

}
