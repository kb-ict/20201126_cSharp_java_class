
public class ArrPractice3 {

	public static void main(String[] args) {
		int arr[] = new int[] {10,20,30,40,50,60,70,80,90,100};
		int arr2[] = new int[arr.length];
	
		for (int i = 0; i < arr2.length; i++) {
			arr2[i]= arr[(arr2.length-1)-i];
			System.out.println(arr2[i]);
		}

	}

}
