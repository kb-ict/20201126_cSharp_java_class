import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int arr[] = new int[3];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
		}
		
		int max = arr[0];
		int min = arr[0];
		
		for (int i = 0; i < arr.length; i++) {
			if(max < arr[i])
				max = arr[i];
			if(min > arr[i])
				min = arr[i];
		}
		int maxcount = 0;
		int mincount = 0;
		for (int i = 0; i < arr.length; i++) {
			if(arr[i] == max)
				maxcount++;
			if(arr[i] == min)
				mincount++;
		}
		if(maxcount == 1 && mincount == 1) {
			for (int i = 0; i < arr.length; i++) {
				if(arr[i] != max && arr[i] != min)
					System.out.println(arr[i]);
			}
		}
		else if(maxcount > mincount)
			System.out.println(max);
		else if(maxcount < mincount)
			System.out.println(min);
		else
			System.out.println(arr[0]);
	}

}
