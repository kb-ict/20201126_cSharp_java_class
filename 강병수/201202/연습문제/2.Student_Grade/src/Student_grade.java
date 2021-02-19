
public class Student_grade {

	public static void main(String[] args) {
	int kor, eng, math, sci, total;
	float avr;
	
	kor = 90;
	eng = 80;
	math = 70;
	sci = 60;
	avr = (kor+eng+math+sci)/4.0f;
	total = kor+eng+math+sci;
	
	System.out.println("국어점수: " + kor);
	System.out.println("영어점수: " + eng);
	System.out.println("수학점수: " + math);
	System.out.println("과학점수: " + sci);
	System.out.println("평균점수: " + avr);
	System.out.println("총점: " + total);
	}
}
