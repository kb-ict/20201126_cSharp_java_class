import java.util.Scanner;

public class SamDab1_2 {

	public static void main(String[] args) {
	char kor[] = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 
			       'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 
			       'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 
			       'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ', 'ㅛ', 
			       'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ' };
	char eng[] = { 'a', 'b', 'c', 'd', 'e', 
				   'f', 'g', 'h', 'i', 'j', 
				   'k', 'l', 'm', 'n', 'o', 
				   'p', 'q', 'r', 's', 't', 
				   'u', 'v', 'w', 'x' };
		
		int chCount[] = new int[24];
		
		Scanner s = new Scanner(System.in);
		System.out.print("알파벳 입력: ");
		String str = s.next();
		
		s.close();
		for (int i = 0; i < str.length(); i++) {
			for (int j = 0; j < eng.length; j++) {
				if (str.charAt(i) == eng[j]) {
					System.out.print(kor[j]);
					chCount[j]+=1; //chCount[j]++;
					break;
				}
			}
		}
		System.out.println();
		for(int i = 0; i<eng.length; i++) {
			if(chCount[i]!=0) {
				System.out.println(eng[i]+" : "+chCount[i]);				
			}

		}
	}

}
