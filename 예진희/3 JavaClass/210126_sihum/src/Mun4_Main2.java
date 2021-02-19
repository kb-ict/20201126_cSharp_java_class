
import java.util.Scanner;

public class Mun4_Main2 {

	@SuppressWarnings("unused")
	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("문자열 입력(a~x): ");
		String str = s.next();
		String[] strArray = str.split("");
		
		s.close();
		// a~x까지

		int count[] = new int[24];
		// System.out.println((char)alpha[i]);
		char kr[] = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ',
				'ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ' };
		char eng[] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'w', 'x' };

		// 2. 한글로 반환, 입력값
		for (int i = 0; i < str.length(); i++) {
			// 입력값이 a이면 1번째 b면 2번째...
			// a면 ㄱ, b면 ㄴ 반환
			for (int j = 0; j < eng.length; j++) {
				if (str.charAt(i) == eng[j]) {
					System.out.print(kr[j]);
					count[j] += 1;
					break;
				}
			}
		}
		System.out.println();
		for(int i =0; i<eng.length; i++) {
			if(count[i]!=0) {
				System.out.println(eng[i]+" : "+count[i]);
			}
		}
	}

	// 3. a, b, c... 카운트

}
