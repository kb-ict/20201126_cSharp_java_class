import java.util.Scanner;

public class Test4_review {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String st = sc.next();
		sc.close();
		char[] ch = new char[st.length()];

		for (int i = 0; i < ch.length; i++) {
			ch[i] = st.charAt(i);
		}
		;
		
		char[] kor = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ',
				'ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ' };

		for (int i = 0; i < ch.length; i++) {	// 입력한 값 중 한개씩 비교하기 위해 반복문 i
			for (int j = 97; j < 121; j++) {	// 비교할 값(아스키코드) j
				if ( ch[i] == ((char) j))		// 아스키코드로 97이 a 예를들어 입력값이
												// b이면 j반복문이 두번 돈다 j=98 => 아스키코드 98이 'b'랑같음										
					System.out.print(kor[j - 97] + " "); // j=98 -97하면 배열 kor[1]('ㄴ') 문자가 출력됨
			}

		}

	}

}
