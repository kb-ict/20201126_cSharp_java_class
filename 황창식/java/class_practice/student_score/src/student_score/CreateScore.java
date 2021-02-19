package student_score;

public class CreateScore {
	private int kor;
	private int eng;
	private int math;
	
	public int getKor() {
		return kor;
	}
	public void setKor(int kor) {
		this.kor = kor;
	}
	public int getEng() {
		return eng;
	}
	public void setEng(int eng) {
		this.eng = eng;
	}
	public int getMath() {
		return math;
	}
	public void setMath(int math) {
		this.math = math;
	}
	
	public CreateScore() {
		kor = (int)(Math.random()*51)+50;
		eng = (int)(Math.random()*51)+50;
		math = (int)(Math.random()*51)+50;
	}
	 
}
