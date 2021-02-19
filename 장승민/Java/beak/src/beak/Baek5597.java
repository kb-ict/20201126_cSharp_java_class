package beak;

import java.util.Arrays;
import java.util.Scanner;

public class Baek5597 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[] student = new int[30];
		int[] submit = new int[28];
		for (int i = 0; i < student.length; i++) {
			student[i] = i + 1;
		}
		for (int i = 0; i < submit.length; i++) {
			submit[i] = sc.nextInt();
		}
		for (int i = 0; i < student.length; i++) {
			for (int j = 0; j < submit.length; j++) {
				if(student[i]==submit[j]) student[i] =0;
			}
		}
		sc.close();
		Arrays.sort(student);
		System.out.println(student[28]);
		System.out.println(student[29]);

	}

}
