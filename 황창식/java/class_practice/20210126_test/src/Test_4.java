import java.util.Scanner;
public class Test_4 {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String input = s.next();
		
		// 내 풀이
		char ch[] = input.toCharArray();
		char kor[] = {'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 
				'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 
				'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 
				'ㅕ', 'ㅗ', 'ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ'};
		for (int i = 0; i < ch.length; i++) {
			ch[i] = kor[(int)(ch[i]-97)];
		}
		String result = "";
		for (int i = 0; i < ch.length; i++) {
			result += ch[i];
		}
		System.out.println(result);
		
		// 선생님 풀이
//		char kor[] = {'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 
//				'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 
//				'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 
//				'ㅕ', 'ㅗ', 'ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ'};
//		char alpha[] = new char[24];
//		for (int i = 0; i < alpha.length; i++) {
//			alpha[i] = (char)(i+97);
//		}
//		for (int i = 0; i < input.length(); i++) {
//			for (int j = 0; j < alpha.length; j++) {
//				if(input.charAt(i) == alpha[j]) {
//					System.out.print(kor[j]);
//					break;
//				}
//			}
//		}
		s.close();
	}
}