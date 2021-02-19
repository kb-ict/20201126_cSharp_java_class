import java.util.Scanner;

public class SamDab1_1 {

	@SuppressWarnings("unused")
	public static void main(String[] args) {
		
		char eng[] = { 'a', 'b', 'c', 'd', 'e', 
					   'f', 'g', 'h', 'i', 'j', 
					   'k', 'l', 'm', 'n', 'o', 
					   'p', 'q', 'r', 's', 't', 
					   'u', 'v', 'w', 'x' };
		int chCount[] = new int[eng.length];
		
		Scanner s = new Scanner(System.in);
		System.out.print("알파벳 입력 : ");
		String str = s.next();
		String[] charArray = str.split("");
		
		s.close();
		
		// 배열 안쓰고.
		for( int i=0; i < str.length(); i++){
		System.out.print(getKor(str.charAt(i)));
		}
		
		for (int i = 0; i < str.length(); i++) {
			for (int j = 0; j < eng.length; j++) {
				if (str.charAt(i) == eng[j]) {
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

	public static char getKor(char eng) {
		char ch = 0;
		switch (eng) {
		case 'a': ch = 'ㄱ'; break;
		case 'b': ch = 'ㄴ'; break;
		case 'c': ch = 'ㄷ'; break;
		case 'd': ch = 'ㄹ'; break;
		case 'e': ch = 'ㅁ'; break;
		
		case 'f': ch = 'ㅂ'; break;
		case 'g': ch = 'ㅅ'; break;
		case 'h': ch = 'ㅇ'; break;
		case 'i': ch = 'ㅈ'; break;
		case 'j': ch = 'ㅊ'; break;
		
		case 'k': ch = 'ㅋ'; break;
		case 'l': ch = 'ㅌ'; break;
		case 'm': ch = 'ㅍ'; break;
		case 'n': ch = 'ㅎ'; break;
		case 'o': ch = 'ㅏ'; break;
		
		case 'p': ch = 'ㅑ'; break;
		case 'q': ch = 'ㅓ'; break;
		case 'r': ch = 'ㅕ'; break;
		case 's': ch = 'ㅗ'; break;
		case 't': ch = 'ㅛ'; break;
		
		case 'u': ch = 'ㅜ'; break;
		case 'v': ch = 'ㅠ'; break;
		case 'w': ch = 'ㅡ'; break;
		case 'x': ch = 'ㅣ'; break;
		}
		return ch;
	}
	
}
