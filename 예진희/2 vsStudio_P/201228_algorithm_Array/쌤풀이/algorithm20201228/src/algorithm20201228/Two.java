package algorithm20201228;

import java.util.Arrays;
import java.util.Iterator;
import java.util.Scanner;

public class Two {

	public static void main(String[] args) {
		System.out.println("2�� ����");
		Scanner s = new Scanner(System.in);
		System.out.println("�� ��� ���ڸ� �Է¹����ǰ���?");
		int countNum = s.nextInt();
		System.out.println("���� ���ڵ��� �Է¹޾� ����.");
		int[] numberList = new int[countNum];
		for (int i = 0; i < countNum; i++) {
			numberList[i] = s.nextInt();
		}
		
		//Sol1.
		int max = numberList[0];
		int min = numberList[0];
        int maxTh = 1;
        int minTh = 1;

        for (int i = 0; i < countNum; i++)
        {
            if (numberList[i] > max)
            {
                max = numberList[i];
                maxTh = i+1;
            }

            if (numberList[i] < min)
            {
                min = numberList[i];
                minTh = i+1;
            }
        }
        System.out.println("�ּڰ��� " + minTh + "��° �̰�, ");
		System.out.println("�ִ��� " + maxTh + "��° �̴�. ");
	}

}
