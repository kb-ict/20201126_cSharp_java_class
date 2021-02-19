package student_score;

public class SumAveHak extends CreateScore {
	
	private int sum;
	private int ave;
	private String hakjeom;
	
	public int getSum() {
		return sum;
	}

	public void setSum(int sum) {
		this.sum = sum;
	}

	public int getAve() {
		return ave;
	}

	public void setAve(int ave) {
		this.ave = ave;
	}

	public String getHakjeom() {
		return hakjeom;
	}

	public void setHakjeom(String hakjeom) {
		this.hakjeom = hakjeom;
	}
	
	
	
	public SumAveHak() {
		super();
		sum = getKor() + getEng() + getMath();
		ave = sum/3;
		if(100 >= ave && ave >= 90) 
			hakjeom = "A학점";
		else if(89 >= ave && ave >= 80) 
			hakjeom = "B학점";
		else if(79 >= ave && ave >= 70) 
			hakjeom = "C학점";
		else if(69 >= ave && ave >= 60) 
			hakjeom = "D학점";
		else 
			hakjeom = "F학점";
	}

	public void showResult(int stunum) {
		System.out.println(stunum + "번 학생 점수");
		System.out.println("국어점수 : " + getKor());
		System.out.println("영어점수 : " + getEng());
		System.out.println("수학점수 : " + getMath());
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + ave);
		System.out.println("학점 : " + hakjeom);
		System.out.println("------------------------");
	}
}
