import java.util.Random;

public class Myp4 {
	Random r = new Random();
	//private int arr[] = new int[3];
	private int kr = (int)(r.nextInt(70))+31;
	private int eng = (int)(r.nextInt(70))+31;
	private int math = (int)(r.nextInt(70))+31;
	String hakjum = "";


	public Myp4() {
		printFunc();
	}


	public void printFunc() {
		System.out.println("국어: "+kr+", 영어: "+eng+", 수학: "+math);
		System.out.println("----------------------------------");
		int total = kr+eng+math;
		int ave = total/3;
		
		if(ave<=100&&90<=ave) {
			hakjum = "A학점";
		}else if(ave<=89&&80<=ave) {
			hakjum = "B학점";
		}else if(ave<=79&&70<=ave) {
			hakjum = "C학점";
		}else if(ave<=69&&60<=ave) {
			hakjum = "D학점";
		}else {
			hakjum = "F학점";
		}
		
		System.out.println("총점: "+total+", 평균: "+ave+", 학점: "+hakjum+"\n");
		
	}
}
