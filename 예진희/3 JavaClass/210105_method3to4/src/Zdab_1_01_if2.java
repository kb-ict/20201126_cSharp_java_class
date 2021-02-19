import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class Zdab_1_01_if2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		Integer arr[] = new Integer[3];
		
		for (int i = 0; i < arr.length; i++) {
			System.out.print("수 입력: ");
			arr[i] = s.nextInt();
		}
		
		mySort(arr);
		s.close();
	}

	public static void mySort(Integer arr[]) {
		Arrays.sort(arr,Collections.reverseOrder());
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i]+"\t");
		}
	}
}
