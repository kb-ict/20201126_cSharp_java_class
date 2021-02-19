package kakao_array;
import java.util.Arrays;
import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		int arr1[] = new int[n];
		for (int i = 0; i < arr1.length; i++) {
			arr1[i] = s.nextInt();
		}
		
		int arr2[] = new int[n];
		for (int i = 0; i < arr2.length; i++) {
			arr2[i] = s.nextInt();
		}
		
		String str1[] = getString(arr1);
		String str2[] = getString(arr2);
		String[] result = getResult(str1, str2);
		for (int i = 0; i < result.length; i++) {
			System.out.println(result[i]);
		}
		
	}
	
	public static int[] two(int n, int num) {
		int arr[] = new int[n];
		for (int i = arr.length-1; i >= 0; i--) {
			arr[i] = num%2;
			num = num/2;
		}
		return arr;
	}
	
	public static String[] getString(int[] arr) {
		String str[] = new String[arr.length];
		for (int i = 0; i < str.length; i++) {
			int arr1[] = two(arr.length, arr[i]);
			String str1 = Arrays.toString(arr1).replaceAll("[^0-9]", "");
			str[i] = str1;
		}
		return str;
	}
	
	public static String[] getResult(String[] str1, String[] str2) {
		String[] result = new String[str1.length];
		for (int i = 0; i < result.length; i++) {
			char[] ch1 = str1[i].toCharArray();
			char[] ch2 = str2[i].toCharArray();
			char[] chResult = new char[ch1.length];
			String hap = "";
			for (int j = 0; j < chResult.length; j++) {
				if(ch1[j] == '0' && ch2[j] == '0')
					chResult[j] = ' ';
				else
					chResult[j] = '#';
				hap += chResult[j];
			}
			result[i] = hap;
		}
		return result;
	}
}
