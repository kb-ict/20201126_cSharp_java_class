import java.util.Arrays;

public class P1 {	
	public static void main(String[] args) {
		int[] arr = new int[] {4, 6, 2, 3, 1};
		
		Arrays.sort(arr);
		for (var a : arr) {
			System.out.print(a + " ");
		}
				
	}
}
