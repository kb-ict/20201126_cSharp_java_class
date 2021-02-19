package method_210105;

public class MethodPractice7 {

	public static void main(String[] args) {
		int jjaksum = 0;
		int holesum=0;
		int jjak[]=jjak();
		for (int i = 0; i < jjak.length; i++) {
			if (jjak[i]!=0) {
				jjaksum +=jjak[i];
			}
		}System.out.println("1~100까지 짝수의 합 : "+jjaksum);

		int hole[]=hole();
		for (int i = 0; i < hole.length; i++) {
			if (hole[i]!=0) {
				holesum +=hole[i];
			}
		}System.out.println("1~100까지 홀수의 합 : "+holesum);
	}

	public static int[] jjak() {
		int[] num=new int[100];
		int[] jjak = new int [100];
		for (int i = 0; i < 100; i++) {
			num[i]=i+1;
		}
		for (int i = 0; i < 100; i++) {
			if (num[i]%2==0) {
				jjak[i]=num[i];
			}
		}
		
		return jjak;
	}
	public static int[] hole() {
		int[] num=new int[100];
		int[] hole = new int [100];
		for (int i = 0; i < 100; i++) {
			num[i]=i+1;
		}
		for (int i = 0; i < 100; i++) {
			if (num[i]%2!=0) {
				hole[i]=num[i];
			}
		}
		
		return hole;
	}
	
	
}
