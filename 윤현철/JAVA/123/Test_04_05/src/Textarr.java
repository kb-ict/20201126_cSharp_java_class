import java.util.Scanner;

public class Textarr {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("a ~ x까지 소문자 입력 : ");
		String text = s.next();
		
		// 각각 25개
		char text1[] = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
				'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'w','x'};
		char text2[] = {'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ',
				'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ',
				'ㅗ', 'ㅛ', 'ㅜ' , 'ㅠ', 'ㅡ', 'ㅣ'};
		
		// 모르겠어요...................... 선생님..........
		for (int i = 0; i < text.length(); i++) {
			for (int j = 0; j < text2.length; j++) {
				if(text.charAt(i)==text1[j]) {
					System.out.print(text2[j]);
				}
			}
		}
		
		char text3[] = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
				'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'w','x','y','z'};
		System.out.println();
		System.out.print("알파벳을 입력해 주세요 : ");
		text=s.next();
		int count=0;
		for (int i = 0; i < text3.length; i++) {
			for (int j = 0; j < text.length(); j++) {
				if(text.charAt(j)==text3[i]) {
					count++;
				}
			}
			if(count!=0) {
				System.out.printf("%c는 %d글자입니다.\n",text3[i],count);
			}
			count=0;
		}
		s.close();
	}
	

}
