
public class Ex3 {

	public static void main(String[] args) {
		int arr[]= new int[] {10,20,30,40,50,60,70,80,90,100};
		int [] arr2 = new int[10];
		for (int i = 0; i < arr.length; i++) {
			arr2[9-i]=arr[i];
		}
		for (int i = 0; i < arr2.length; i++) {
			System.out.print(arr2[i]+" ");
		}
	}

}
