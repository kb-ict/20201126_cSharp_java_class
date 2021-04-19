
public class Practice6 {

	public static void main(String[] args) {
		System.out.println(math.add(200l, 100l));
		System.out.println(math.subtract(200l, 100l));
		System.out.println(math.multiply(100l, 200l));
		System.out.println(math.divide(150, 38));
		
		//객체 생성
		math mm = new math();
		mm.a = 200l;
		mm.b = 100l;
		
		//인스턴스 메소드는 객체생성 후에만 호출이 가능
		
		System.out.println(mm.add());
		System.out.println(mm.subtract());
		System.out.println(mm.multiply());
		System.out.println(mm.divide());

	}

}

class math {
	long a, b;
	//인스턴스 변수 a,b를 이용한 작업, 매개변수가 불필요
	long add() {return a+b;}
	long subtract() {return a-b;}
	long multiply() {return a*b;}
	double divide() {return a/b;} 
	//매개변수만으로 작업이 가능
	static long add(long a, long b) {return a+b;}
	static long subtract(long a, long b) {return a-b;}
	static long multiply(long a, long b) {return a*b;}
	static double divide(double a, double b) {return a/b;}
}
