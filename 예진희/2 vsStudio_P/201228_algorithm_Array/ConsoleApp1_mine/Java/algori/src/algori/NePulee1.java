package algori;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class NePulee1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("�迭�� ũ�� �Է�: ");
		int[] arr1 = new int [s.nextInt()];
		//System.out.printf("�迭�� ũ��: %d", arr1.length);
		int max = 0;
		int min = arr1[0];
		
		for (int i = 0; i < arr1.length; i++) {
			System.out.printf("%d��° ��: ",(i+1));
			arr1[i] = s.nextInt();
			if (max<arr1[i]) {
				max = arr1[i];
			}
			if (min>arr1[i]) {
				min = arr1[i];
			}
		}System.out.printf("�ִ밪�� %d", max);


		
	}

}
