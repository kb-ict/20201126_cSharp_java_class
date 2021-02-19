package helloJava4;

public class Hello4 {

	public static void main(String[] args) {
		// "이름" -> 1. 문자열 (텍스트)
		//	+ = 산술, 문자를 연결 가능
		
		System.out.println("이름: " + "홍길동");
		
		
		// 100 = 2. 숫자 : 정수 값	// -> 문자열로 바뀜, 실수형
		System.out.println("나이: "+100);
		System.out.println("100 + 200 = " + (100+200));
		
		int age = 10;
		System.out.println("나이: "+age+"살");
		
		//10.nnnn -> 실수, 정수형
		System.out.println("몸무게: "+99+"kg");
		
		// 'a', 'ㄱ' = 3. 문자
		System.out.println();
	
	}

}