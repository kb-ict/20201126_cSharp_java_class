
public class Method3 {

	
	public static int[] makeArray() {
		int arr[] = new int[3];
		for(int i= 0; i<arr.length; i++) {
			arr[i] = 100+i;
		}
		return arr;
	}
	
	
	public static void main(String[] args) {
		int arr[] = makeArray();
		for(int i = 0; i<arr.length; i++) {
		System.out.println(arr[i]);
		}
	}

}
