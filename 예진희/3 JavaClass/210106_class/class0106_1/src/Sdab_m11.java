import java.util.Random;

public class Sdab_m11 {
	public static void main(String[] args) {
		/*11. 학점을 출력하는 프로그램.
		 * 조건1) 5명의 국, 영, 수 점수는 Random 클래스를 사용하여 랜덤하게 생성.
		 * 조건2) 2차원배열을 생성하여 1번째 학생의 국,영,수 점수를 1행1열, 1행2열, 1행3열에 저장.
		 * 조건3) 2번째 학생의 점수는 2행 ~ 5번째 학생의 점수는 5행에 각각 저장.
		 * 조건4) 5명학생의 점수들을 저장한 배열을 리턴하기.
		 * 조건5) main()에서 배열값을 받아 학생1명씩 대한 총점, 평균, 학점을 출력하기.
		 *       --> 출력 형식은 자유롭게 생각해서 하되 깔끔하게 처리.
		 * 조건6) 학점 기준 점수
		 *	100	~ 90 -> A학점 출력
		 *	89	~ 80 -> B학점 출력
		 *	79	~ 70 -> C학점 출력
		 *	69	~ 60 -> D학점 출력
		 *	59	~ 50 -> E학점 출력
		 *	49	~  0 -> F학점
		 */
		
		//getScore();
		int arr[][] = getScore();
		int hap = 0;
		int avg = 0;
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j]+"\t");
				hap += arr[i][j];
			}
			System.out.print("총점: "+hap);
			avg = hap/3;
			System.out.print("\t  평균: "+avg);
			
			if(avg<=100 && avg>=90) {
				System.out.print("  A학점");
			}
			else if(avg<=89 && avg>=80) {
				System.out.print("  B학점");
			}
			else if(avg<=79 && avg>=70) {
				System.out.print("  C학점");
			}
			else if(avg<=69 && avg>=60) {
				System.out.print("  D학점");
			}
			else {
				System.out.print("  F학점");
			}
			
			hap = avg = 0; //초기화
			System.out.println();
		}
	}

	public static int[][] getScore() {
		Random r = new Random();
		int arr[][] = new int[5][3]; // int값만 가지는 배열

		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = r.nextInt(91)+10;		//최소 10점까지
				//arr[i][j] = r.nextInt(101);		// 0~100까지
				//System.out.print(arr[i][j]+"\t");	//디버깅코드
			}
			//System.out.println();
		}
		return arr;
		//return null; //리턴하지 않는다.
	}
}
