package many_alphabet;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int[] spell = makeAscii(s.next());
		int[] alpha = new int[26];
		for (int i = 0; i < alpha.length; i++) {
			alpha[i] = i + 65;
		}
		int[] countnum = new int[26];
		for (int i = 0; i < alpha.length; i++) {
			int count = 0;
			for (int j = 0; j < spell.length; j++) {
				if(alpha[i] == spell[j])
					count++;
			}
			countnum[i] = count;
		}
		for (int i = 0; i < countnum.length; i++) {
			System.out.println(countnum[i]);
		}

		
	}
	
	public static int[] makeAscii(String str) {
		char[] ch = str.toCharArray();
		int arr[] = new int[ch.length];
		for (int i = 0; i < arr.length; i++) {
			if((int)(ch[i]) > 90) {
				arr[i] = (int)(ch[i]) - 32;
			}
			else {
				arr[i] = (int)(ch[i]);
			}
		}
		return arr;
	}
	
	public static int maxnum(int arr[]) {
		Arrays.sort(arr);
		return arr[(arr.length)-1];
		
	}

}
