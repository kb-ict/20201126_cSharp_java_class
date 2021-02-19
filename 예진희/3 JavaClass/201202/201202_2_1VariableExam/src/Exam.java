
public class Exam {

	public static void main(String[] args) {
		
		// 변수선언 시작
		String line = "-----------------------------";
		String title = "         개인 신상 정보";	// ◆
		String name = "홍길동";					//1. 이름
		int age = 100;							//2. 나이
		char gender = '남';						//3. 성별
		double weight = 60.5;					//4. 몸무게 + kg
		double tall = 178.6;					//5. 키 + cm
		String address = "조선 한양 홍대감댁";		//6. 주소
		
		// 변수출력 시작
		System.out.println(line);
		System.out.println(title); // ◆
		System.out.println(line);
		System.out.println("  1. 이 름 : "+name);
		System.out.println("  2. 나 이 : "+age);
		System.out.println("  3. 성 별 : "+gender);
		System.out.println("  4. 몸무게 : "+weight+"kg");
		System.out.println("  5. 키    : "+tall+"cm");
		System.out.println("  6. 주 소 : "+address);
		System.out.println(line);
	
		
		//	출력형식
		//	-----------------------
		//	      개인 신상 정보
		//	-----------------------
		//	1. 이름: 홍길동
		//	2. 나이: 100
		//	3. 성별: 남
		//	4. 몸무게: 60.5kg
		//	5. 키: 178.6cm
		//	6. 주소: 조선 한양 홍대감댁
		//	-----------------------

	}

}
