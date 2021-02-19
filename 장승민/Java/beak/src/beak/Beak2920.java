package beak;

import java.util.Scanner;

public class Beak2920 {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		int[]arr= new int[8];
		for (int i = 0; i < arr.length; i++) {
			arr[i]=sc.nextInt();
		}
		sc.close();
		String outPut="";
		
		for (int i = 0; i < arr.length-1; i++) {
			if (arr[i]==(arr[i+1])-1) {
				outPut="ascending";
			}else if(arr[i]==arr[i+1]+1) {
				outPut="descending";
			}else {
				outPut="mixed";
				break;
			}
		}
		System.out.println(outPut);

	}

}
