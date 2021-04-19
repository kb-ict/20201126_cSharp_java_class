import java.util.Scanner;

public class Problem4 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		char Arr1[] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'w', 'x' }; // 24자
		char Arr2[] = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ',
				'ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ' };
		char Arr3[] = new char[1000];
		String pass = sc.next();

		for (int i = 0; i < Arr1.length; i++) {
			for (int k = 0; k < pass.length(); k++) {

				if (pass.charAt(k) == Arr1[i]) {
					Arr3[k] = Arr2[i];
				}
			}
		}
		for (int j = 0; j < pass.length(); j++) {
			System.out.print(Arr3[j]);
		}

		sc.close();
	}

}
