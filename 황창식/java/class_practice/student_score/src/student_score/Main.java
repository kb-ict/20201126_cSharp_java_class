package student_score;

public class Main {

	public static void main(String[] args) {
		SumAveHak[] stu = new SumAveHak[5];
		for (int i = 0; i < stu.length; i++) {
			stu[i] = new SumAveHak();
			stu[i].showResult(i+1);
		}
		
	}

}
