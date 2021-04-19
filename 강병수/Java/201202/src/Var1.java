
public class Var1 {

	public static void main(String[] args) {
		//자바 변수명 스타일 = Camel 방식
		//문자열 저장 변수
		// str - 변수 (이름은 마은대로 작성)
		String str = "홍길동"; //변수 이름
		// 대소문자 구분
		String STR = "홍길동";
		// 변수명을 직관적으로 작성하는 것이 편하다.
		String name = "홍길동";
		
		String name1, name2, name3, name4; //문자열 변수 선언
		name1 = "고길동";
		name2 = "도우너";
		name3 = "마이콜";
		name4 = "둘리";
		System.out.println(name1);
		System.out.println(name2);
		System.out.println(name3);
		System.out.println(name4);
		
		String name5;
		//변수 재사용
		name5 = "또치";
		System.out.println("name5: " + name5);
		name5 = "희동이";
		System.out.println("name5: " + name5);
		char ch = '홍';
		System.out.println(ch);
		
		float num2 = 10.1f;
	}
}
