package array;

class Box{
	private String conts;
	
	Box(String cont){
		this.conts = cont;
	}
	public String toString() {
		return conts;
	}
}

public class Array1 {

	public static void main(String[] args) {

		// 길이가 5인 int형 1차원 배열의 생성
		int [] ar1 = new int[5];
		
		// 길이가 7인 double형 1차원 배열의 생성
		double[] ar2 = new double[7];
		
		// 배열의 참조변수와 인스턴스 생성 분리
		float[] ar3;
		ar3 = new float[9];
		
		// 배열의 인스턴스 변수 접근
		System.out.println("배열 ar1 길이 : " + ar1.length);
		System.out.println("배열 ar2 길이 : " + ar2.length);
		System.out.println("배열 ar3 길이 : " + ar3.length);
		
		int[] ar4 = new int[50];
		System.out.println("length : " + ar4.length);
		
		ar4 = new int[100];
		System.out.println("length : " + ar4.length);
		
		System.out.println("----------------------------");
		
		
		Box[] ar5 = new Box[5]; //길이가 5인 Box형 1차원 배열의 생성
		System.out.println("length : " + ar5.length); // length = 5
		
		
	}

}
