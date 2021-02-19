
public class testResult {

	public static void main(String[] args) {
		
		/* 2. 성적표를 구하는 프로그램 */
		
		String line = "----------------------";
		int scoreKr = 0;
		int scoreEng = 0;
		int scoreMath = 0;
		int scoreScience = 0;
		
		scoreKr = 90;
		scoreEng = 80;
		scoreMath = 70;
		scoreScience = 60;
		
		System.out.println("국어점수: "+scoreKr);
		System.out.println("영어점수: "+scoreEng);
		System.out.println("수학점수: "+scoreMath);
		System.out.println("과학점수: "+scoreScience);
	
		int sumAverage = (scoreKr+scoreEng+scoreMath+scoreScience)/4;
		int totalScore = scoreKr+scoreEng+scoreMath+scoreScience;
		
		
		System.out.println(line);
		System.out.println("1. 평균값: "+sumAverage);
		System.out.println("2. 총점: "+totalScore);
		

	}

}
