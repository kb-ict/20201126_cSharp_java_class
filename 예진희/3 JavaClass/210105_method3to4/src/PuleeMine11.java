
public class PuleeMine11 {

	public static void main(String[] args) {

		/*11. 학점을 출력하는 프로그램.
		 * 조건1) 5명의 국, 영, 수 점수는 Random 클래스를 사용하여 랜덤하게 생성.
		 * 조건2) 2차원배열을 생성하여 1번째 학생의 국,영,수 점수를 1행1열, 1행2열, 1행3열에 저장.
		 * 조건3) 2번째 학생의 점수는 2행 ~ 5번째 학생의 점수는 5행에 각각 저장.
		 * 조건4) 5명학생의 점수들을 저장한 배열을 리턴하기.
		 * 조건5) main()에서 배열값을 받아 학생1명씩 대한 총점, 평균, 학점을 출력하기.
		 *       --> 출력 형식은 자유롭게 생각해서 하되 깔끔하게 처리.
		 * 조건6) 학점 기준 점수
		 * 100	~ 90	-> A학점 출력
		 * 89	~ 80	-> B학점 출력
		 * 79	~ 70	-> C학점 출력
		 * 69	~ 60	-> D학점 출력
		 * 59	~ 50	-> E학점 출력
		 * 49	~  0	-> F학점
		 */

		int[][] arr = score(); // 학생 5명 각각의 국, 영, 수 점수
		int[] total = new int[5]; // 각 학생 총점을 저장할 1차원 배열
		int ave = 0;
		String hakjum = "";

		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				total[i] += arr[i][j];
			}
		}
		
		for (int i = 0; i < total.length; i++) {
			
			ave = total[i]/3;
			if (ave >= 90 && ave <= 100) {
				hakjum = "A학점";
			} else if (ave >= 80 && ave <= 89) {
				hakjum = "B학점";
			} else if (ave >= 70 && ave <= 79) {
				hakjum = "C학점";
			} else if (ave >= 60 && ave <= 69) {
				hakjum = "D학점";
			} else if (ave >= 50 && ave <= 59) {
				hakjum = "E학점";
			} else {
				hakjum = "F학점";
			}
			System.out.println((i+1)+"번째 학생의 \t총점:"+total[i]+"\t평균:"+ave+"\t학점:"+hakjum);
		}
	}

	static int[][] score() {

		int arr[][] = new int[5][3];

		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = (int) (Math.random() * 100) + 1;
				System.out.print(arr[i][j] + "\t");
			}
			System.out.println();
		}
		System.out.println("-------------------------------------------");
		return (arr);

	}

}