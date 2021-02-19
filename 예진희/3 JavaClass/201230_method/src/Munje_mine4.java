import java.util.Scanner;
//패키지 없다.

public class Munje_mine4 {
	/*
	 * 4. 국,영,수 점수를 입력받아서 총점, 평균값을 구하는 프로그램.
	 * 조건1) 점수 입력은 main() 에서 입력 받음.
	 * 조건2) 입력받는 점수는 0 ~ 100 사이의 숫자만 입력받도록 조건 체크하기.
	 * 		--> 간단하게 한번만 체크하면 됨 (사용자가 실수로 잘못입력하면 에러메시지 출력하고 종료 처리)
	 * 조건3) 국,영,수 점수를 각각의 매개변수로 전달하여 총점, 평균값을 출력하는 메쏘드 작성.
	 * 조건4) 조건3까지 테스트완료 이후에 잘못입력값 체크를 확장하기(실수로 입력하면 재입력 받을수 있도록 처리)
	 *  	--> 시간적인 여유가 있으면 해보고 그렇지 않으면 패스하기 바람.
	 */
	public static void gyesan(int arr[], int error) {
		int total = 0;
		for (int i = 0; i < arr.length; i++) {
			total += arr[i];
		}
		System.out.printf("1. 세 과목의 총점은 : %d\n", total);
		System.out.printf("2. 세 과목의 평균은 : %d\n", total / arr.length);
		if (error != 0) {
			System.out.printf("3. 오류 입력 횟수: %d\n", error);
		}
	}

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int error = 0;
		String line = "--------------------------------";
		int[] score = new int[3]; // 점수값 저장할 배열 3개 할당
		String[] subject = { "국어", "영어", "수학" };

		System.out.println("국, 영, 수 세 과목의 점수를 입력합니다.\n" + line);
		for (int i = 0; i < score.length; i++) {
			System.out.printf("%d. (%s) 점수 입력 => ", (i + 1), subject[i]);
			score[i] = s.nextInt();
			if (score[i] < 0 || score[i] > 100) {
				System.out.println("잘못된 값입니다. 0~100사이의 수를 입력하세요.\n" + line);
				error++;
				i--;
				continue;
			}
		}
		s.close();
		System.out.println("입력이 완료되었습니다.\n" + line);
		gyesan(score, error);
	}
}

/*검증 -------------------------------------------------------
 * for (int i = 0; i < score.length; i++) {
 * 			System.out.printf("%d. (%s) 점수 = %d\n",(i+1),subject[i], score[i]);
 * 		}
 */
