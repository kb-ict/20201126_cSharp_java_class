import java.util.Scanner;

public class Mun4_Main {

	public static void main(String[] args) {
		// 2. 자바 문자열 > 문자로 한자씩 끊기 모르겠어서 이거만 찾아봄..
		Scanner s = new Scanner(System.in);
		System.out.print("문자열 입력(a~x): ");
		String str = s.next();
		String[] strArray = str.split("");
		s.close();
		// 3. 문자열 배열에 각 글자 대입하여 한글로 반환
		// 5번 모르겠음 끝.
		for (String ss : strArray) {
			
			switch (ss) {
			case "a":
				System.out.print("ㄱ");
				break;
			case "b":
				System.out.print("ㄴ");
				break;
			case "c":
				System.out.print("ㄷ");
				break;
			case "d":
				System.out.print("ㄹ");
				break;
			case "e":
				System.out.print("ㅁ");
				break;

			case "f":
				System.out.print("ㅂ");
				break;
			case "g":
				System.out.print("ㅅ");
				break;
			case "h":
				System.out.print("ㅇ");
				break;
			case "i":
				System.out.print("ㅈ");
				break;
			case "j":
				System.out.print("ㅊ");
				break;

			case "k":
				System.out.print("ㅋ");
				break;
			case "l":
				System.out.print("ㅌ");
				break;
			case "m":
				System.out.print("ㅍ");
				break;
			case "n":
				System.out.print("ㅎ");
				break;
			case "o":
				System.out.print("ㅏ");
				break;

			case "p":
				System.out.print("ㅑ");
				break;
			case "q":
				System.out.print("ㅓ");
				break;
			case "r":
				System.out.print("ㅕ");
				break;
			case "s":
				System.out.print("ㅗ");
				break;
			case "t":
				System.out.print("ㅛ");
				break;

			case "u":
				System.out.print("ㅜ");
				break;
			case "v":
				System.out.print("ㅠ");
				break;
			case "w":
				System.out.print("ㅡ");
				break;
			case "x":
				System.out.print("ㅣ");
				break;

			default:
				System.out.println("\na~x까지만 한글로 반환입니다.");
				return;

			}
		}

	}

}
