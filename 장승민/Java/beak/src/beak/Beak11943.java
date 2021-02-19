package beak;

import java.util.Scanner;

public class Beak11943 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String str1 = sc.nextLine();
		String str2 = sc.nextLine();
		sc.close();

		String[] str11 = str1.split("\\s");
		String[] str22 = str2.split("\\s");

		int[] num1 = new int[str11.length];
		int[] num2 = new int[str22.length];

		for (int i = 0; i < str11.length; i++) {
			num1[i] = Integer.parseInt(str11[i]);
		}
		for (int i = 0; i < str22.length; i++) {
			num2[i] = Integer.parseInt(str22[i]);
		}
		int cntA = 0;
		int cntO = 0;
		int result1 = 0;
		int result2 = 0;

		for (int i = 0; i < num2[0]; i++) {
			cntA++;
		}
		for (int i = 0; i < num1[1]; i++) {
			cntO++;
		}
		result1 = cntA + cntO;
		
		cntA = 0;
		cntO = 0;
		for (int i = 0; i < num1[0]; i++) {
			cntA++;
		}
		for (int i = 0; i < num2[1]; i++) {
			cntO++;
		}
		result2 = cntA + cntO;
		if(result1>result2) System.out.println(result2);
		else System.out.println(result1);
	}

}
