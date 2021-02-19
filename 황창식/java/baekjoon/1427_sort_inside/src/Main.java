import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		char[] ch = (""+n).toCharArray();
		int arr[] = new int[ch.length];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = Character.getNumericValue(ch[i]);
		}
		arr = getSortInside(arr);
		String result = "";
		for (int i = 0; i < arr.length; i++) {
			result += Integer.toString(arr[i]);
		}
		System.out.println(Integer.parseInt(result));
	}
	public static int[] getSortInside(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			for (int j = i+1; j < arr.length; j++) {
				int copy = arr[i];
				if(arr[i] < arr[j]) {
					arr[i] = arr[j];
					arr[j] = copy;
				}
			}
		}
		return arr;
	}
}
