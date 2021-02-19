package array;

import java.util.Scanner;

public class Array_practice4 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String que[] = {"1 + 2", "2 + 3", "3 + 5", "5 + 8", "8 + 13"};
		int que1[] = {1, 2, 3, 4, 5};
		int que2[] = {1, 2, 3, 4, 5};
		int que3[] = {6, 7, 8, 9, 10};
		int que4[] = {11, 12, 13, 14, 15};
		int que5[] = {21, 22, 23, 24, 25};
		String score[] = new String[que.length];
		
//		for (int i = 0; i < que.length; i++) {
//			System.out.println((i+1) + "번 문제");
//			System.out.println(que[i]);
//			for (int j = 0; j < que1.length; j++) {
//				System.out.println((j+1) + ") " + que1 [j]);
//			}
//			int input = s.nextInt();
//			
//		}
		
		System.out.println("1번 문제");
		System.out.println(que[0]);
		for (int i = 0; i < que1.length; i++) {
			System.out.println((i+1) + ") " + que1 [i]);
		}
		int input = s.nextInt();
		if (input == que1[2]) {
			score[0] = "O";
		}
		else {
			score[0] = "X";
		}
		
				
	}

}
