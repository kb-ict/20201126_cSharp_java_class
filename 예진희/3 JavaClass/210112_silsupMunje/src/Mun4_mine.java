import java.io.IOException;

public class Mun4_mine {
	public static void main(String[] args) throws IOException {
		/*
		 * 11. 학점을 출력하는 프로그램.
		 * 조건1) 5명의 국, 영, 수 점수는 Random 클래스를 사용하여 랜덤하게 생성.
		 * 조건2) 2차원배열을 생성하여 1번째 학생의 국,영,수 점수를 1행1열, 1행2열, 1행3열에 저장.
		 * 조건3) 2번째 학생의 점수는 2행 ~ 5번째 학생의 점수는 5행에 각각 저장.
		 * 조건4) 5명학생의 점수들을 저장한 배열을 리턴하기.
		 * 조건5) main()에서 배열값을 받아 학생1명씩 대한 총점, 평균, 학점을 출력하기.
		 *       --> 출력 형식은 자유롭게 생각해서 하되 깔끔하게 처리.
		 *       조건6) 학점 기준 점수
		 *       100 ~ 90 -> A학점 출력	89 ~ 80 -> B학점 출력
		 *       79 ~ 70 -> C학점 출력		69 ~ 60 -> D학점 출력
		 *       59 ~ 50 -> E학점 출력		49 ~  0 -> F학점		
		 */
		
//		Myp4 arr[] = new Myp4[5];
//		
//		for (int i = 0; i < arr.length; i++) {
//			System.out.println("[ "+(i+1)+"번째 학생 ]");
//			arr[i] = new Myp4();
//		}
		
		//문제 5확인
		
		Mun5_mine m5 = new Mun5_mine();
		Mun6_mine m6 = new Mun6_mine();
		
		//m5.makeName();		//풀네임 저장
		//m5.printFunc();		//풀네임 출력
		m6.myFileWrite(m5.makeName());	//파일 생성
		new Mun7_mine(Mun6_mine.fileName);
		
	}

}
