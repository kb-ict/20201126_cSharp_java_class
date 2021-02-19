
public class OpTest5 {

	public static void main(String[] args) {
		// 3항 연산자 / A + B = 이항.. 항이 2개 / 단항 = ! or 루트...
		// 메서드 안에서 선언된 변수에 초기값이 없으면 더미(쓰레기)값이 들어감
		int num1 = 10;
		int num2 = 15;
		String str = ""; // ""; = 빈 공백
		str = (++num1 >= num2) ? "num1이 크다" : "num2가 크다";
		// 11>=15 = False ? 앞조건 참이면 (참:거짓) 참값 동작
		
		System.out.println(str);
	}

}
