package algorithm20201228;

import java.util.Arrays;
import java.util.Iterator;
import java.util.Scanner;

public class One {

	public static void main(String[] args) {
		System.out.println("1번 문제");
		Scanner s = new Scanner(System.in);
		System.out.println("총 몇개의 숫자를 입력받으실거죠?");
		int countNum = s.nextInt();
		System.out.println("이제 숫자들을 입력받아 보자.");
		int[] numberList = new int[countNum];
		for (int i = 0; i < countNum; i++) {
			numberList[i] = s.nextInt();
		}
		
		//Sol1.
		int max = numberList[0];
		int min = numberList[0];

        for (int i = 0; i < countNum; i++)
        {
            if (numberList[i] > max)
            {
                max = numberList[i];
            }

            if (numberList[i] < min)
            {
                min = numberList[i];
            }
        }
        System.out.println("최솟값은 " + min + "이고, ");
		System.out.println("최댓값은 " + max + "이다. ");
		
		//Sol2.
		Arrays.sort(numberList);
		System.out.println("최솟값은 " + numberList[0] + "이고, ");
		System.out.println("최댓값은 " + numberList[numberList.length-1] + "이다. ");
		
	}

}
