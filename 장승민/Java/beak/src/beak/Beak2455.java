package beak;

import java.util.Arrays;
import java.util.Scanner;

public class Beak2455 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[] train = new int[2];
		int[] secTrain = new int[2];
		int[] sum = new int[4];
//		[0]: 내린사람 [1]: 탄사람
//		첫번째 역 입력
//		for (int i = 0; i < train.length; i++) {
//			train[i] = 0;
//			train[i] = sc.nextInt();
//			sum[0]=sum[0]-train[0]+train[1];
//		}
//		
// 
//		for (int i = 0; i < train.length; i++) {
//			train[i] = 0;
//			train[i] = sc.nextInt();;
//			sum[1]=sum[0]-train[0]+train[1];
//		}
//		
//		for (int i = 0; i < train.length; i++) {
//			train[i] = 0;
//			train[i] = sc.nextInt();
//			sum[2]=sum[1]-train[0]+train[1];
//		}
//		
//		for (int i = 0; i < train.length; i++) {
//			train[i] = 0;
//			train[i] = sc.nextInt();
//			sum[3]=sum[2]-train[0]+train[1];
//		}
		for (int i = 0; i < sum.length; i++) {
			for (int j = 0; j < train.length; j++) {
				train[j] = 0;
				train[j] = sc.nextInt();
				if (i == 0) {
					sum[i] = sum[i] - train[0] + train[1];
				} else {
					sum[i] = sum[i - 1] - train[0] + train[1];
				}

			}
		}
		Arrays.sort(sum);
		System.out.println(sum[3]);
	}

}
