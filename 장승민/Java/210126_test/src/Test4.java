import java.util.Scanner;

public class Test4 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String st = sc.next();
		sc.close();
		
		char[] ch =new char[st.length()];
		
		for (int i = 0; i < ch.length; i++) {
			ch[i]=st.charAt(i);
		};
		
		for (int i = 0; i < ch.length; i++) {
			switch (ch[i]) {
			case 'a': ch[i]='ㄱ'; break;
			case 'b': ch[i]='ㄴ'; break;
			case 'c': ch[i]='ㄷ'; break;
			case 'd': ch[i]='ㄹ'; break;
			case 'e': ch[i]='ㅁ'; break;
			case 'f': ch[i]='ㅂ'; break;
			case 'g': ch[i]='ㅅ'; break;
			case 'h': ch[i]='ㅇ'; break;
			case 'i': ch[i]='ㅈ'; break;
			case 'j': ch[i]='ㅊ'; break;
			case 'k': ch[i]='ㅋ'; break;
			case 'l': ch[i]='ㅌ'; break;
			case 'm': ch[i]='ㅍ'; break;
			case 'n': ch[i]='ㅎ'; break;
			case 'o': ch[i]='ㅏ'; break;
			case 'p': ch[i]='ㅑ'; break;
			case 'q': ch[i]='ㅓ'; break;
			case 'r': ch[i]='ㅕ'; break;
			case 's': ch[i]='ㅗ'; break;
			case 't': ch[i]='ㅛ'; break;
			case 'u': ch[i]='ㅜ'; break;
			case 'v': ch[i]='ㅠ'; break;
			case 'w': ch[i]='ㅡ'; break;
			case 'x': ch[i]='ㅣ'; break;
			}
		};
		
		for (int i = 0; i < ch.length; i++) {
			System.out.print(ch[i]);
		}

	}
		
}
