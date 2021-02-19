package beak;

import java.util.Scanner;

public class Beak10103 {

	public static void main(String[] args) {
		int changYoung = 100;
		int sangDuk = 100;
		Scanner sc = new Scanner(System.in);
//		게임 라운드 입력
		int round = sc.nextInt();
		int score[] = new int[2];
//		[0]: 창영 [1]: 상덕
		for (int i = 0; i < round; i++) {
			score[0] = sc.nextInt();
			score[1] = sc.nextInt();
			if (score[0]<score[1]) {
				changYoung =changYoung-score[1];
			} else if(score[0]>score[1]) {
				sangDuk =sangDuk-score[0];
			} else {
				continue;
			}
		}
		sc.close();
		System.out.println(changYoung);
		System.out.println(sangDuk);

	}

}
