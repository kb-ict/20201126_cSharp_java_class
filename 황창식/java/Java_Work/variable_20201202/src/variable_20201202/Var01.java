package variable_20201202;

public class Var01 {

	public static void main(String[] args) {

		// 문자열(String) 저장 변수
		// str : 변수(이름은 마음대로 작성 가능)
		// 변수명은 대, 소문자 구분
		String str = "홍길동"; // 이름
		System.out.println("str : " + str);
		String STR = "홍길동";
		System.out.println("STR : " + STR + "\n");

		// 변수명을 직관적으로 작성
		String name = "홍길동";
		System.out.println("name : " + name + "\n");

		// 문자열 변수 선언
		String name1;
		// 변수 재사용 가능
		name1 = "김길동";
		System.out.println("name1 : " + name1);
		name1 = "박길동";
		System.out.println("name2 : " + name1);
		name1 = "최길동";
		System.out.println("name3 : " + name1 + "\n");

		System.out.println("--------------------------\n");

		// 문자
		char ch1 = '홍';
		char ch2 = '길';
		char ch3 = '동';
		System.out.print(ch1);
		System.out.print(ch2);
		System.out.print(ch3);

		System.out.println("--------------------------\n");

		// 숫자(정수)
		int num = 100;

		// 숫자(실수)
		float num1 = 10.1f;

	}

}
