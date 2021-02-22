import java.util.Scanner;

public class Text {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("문자 입력 : ");
		String text = s.next();
		for (int i = 0; i < text.length(); i++) {
			
			
			if (text.charAt(i)=='a') {
				System.out.println("ㄱ");
			}
			else if (text.equals("b")) {
				System.out.println("ㄴ");
			}
			else if (text.equals("c")) {
				System.out.println("ㄷ");
			}
			else if (text.equals("d")) {
				System.out.println("ㄹ");
			}
			else if (text.equals("e")) {
				System.out.println("ㅁ");
			}
			else if (text.equals("f")) {
				System.out.println("ㅂ");
			}
			else if (text.equals("g")) {
				System.out.println("ㅅ");
			}
			else if (text.equals("h")) {
				System.out.println("ㅇ");
			}
			else if (text.equals("i")) {
				System.out.println("ㅈ");
			}
			else if (text.equals("j")) {
				System.out.println("ㅊ");
			}
			else if (text.equals("k")) {
				System.out.println("ㅋ");
			}
			else if (text.equals("l")) {
				System.out.println("ㅌ");
			}
			else if (text.equals("m")) {
				System.out.println("ㅍ");
			}
			else if (text.equals("n")) {
				System.out.println("ㅎ");
			}
			else if (text.equals("o")) {
				System.out.println("ㅏ");
			}
			else if (text.equals("p")) {
				System.out.println("ㅑ");
			}
			else if (text.equals("q")) {
				System.out.println("ㅓ");
			}
			else if (text.equals("r")) {
				System.out.println("ㅕ");
			}
			else if (text.equals("s")) {
				System.out.println("ㅗ");
			}
			else if (text.equals("t")) {
				System.out.println("ㅛ");
			}
			else if (text.equals("u")) {
				System.out.println("ㅜ");
			}
			else if (text.equals("v")) {
				System.out.println("ㅠ");
			}
			else if (text.equals("w")) {
				System.out.println("ㅡ");
			}
			else if (text.equals("x")) {
				System.out.println("ㅣ");
			}
		}	
		s.close();
		
		
	}

}
