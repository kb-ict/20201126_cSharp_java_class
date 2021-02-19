import java.util.Scanner;

public class Mun5_Main {

	public static void main(String[] args) {
		// 2. 자바 문자열 > 문자로 한자씩 끊기 모르겠어서 이거만 찾아봄..
		Scanner s = new Scanner(System.in);
		System.out.print("문자열 입력(a~x): ");
		String str = s.next();
		String[] strArray = str.split("");
		
		s.close();
		int countApb[] = new int[24];
		// 3. 문자열 배열에 각 글자 대입하여 한글로 반환

		// 4번 풀이
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

//			int num1 = (int) 'a'; 
//			int num2 = (int) 'x';
			// a = 92, x = 120
//			System.out.println(num1+", "+num2);

			// 5번 풀이, 배열 24개 선언, count

		}System.out.println();


		// 5번 삽질
		for (String i : strArray) {
			switch (i) {
			case "a":
				countApb[0]++;
				System.out.printf("%s : %d / ", "a", countApb[0]);
				break;
			case "b":
				countApb[1]++;
				System.out.printf("%s : %d / ", "b", countApb[1]);
				break;
			case "c":
				countApb[2]++;
				System.out.printf("%s : %d / ", "c", countApb[2]);
				break;
			case "d":
				countApb[3]++;
				System.out.printf("%s : %d / ", "d", countApb[3]);
				break;
			case "e":
				countApb[4]++;
				System.out.printf("%s : %d / ", "e", countApb[4]);
				break;


			case "f":
				countApb[5]++;
				System.out.printf("%s : %d / ", "f", countApb[5]);
				break;
			case "g":
				countApb[6]++;
				System.out.printf("%s : %d / ", "g", countApb[6]);
				break;
			case "h":
				countApb[7]++;
				System.out.printf("%s : %d / ", "h", countApb[7]);
				break;
			case "i":
				countApb[8]++;
				System.out.printf("%s : %d / ", "i", countApb[8]);
				break;
			case "j":
				countApb[9]++;
				System.out.printf("%s : %d / ", "j", countApb[9]);
				break;
				
			case "k":
				countApb[10]++;
				System.out.printf("%s : %d / ", "k", countApb[10]);
				break;
			case "l":
				countApb[11]++;
				System.out.printf("%s : %d / ", "l", countApb[11]);
				break;
			case "m":
				countApb[12]++;
				System.out.printf("%s : %d / ", "m", countApb[12]);
				break;
			case "n":
				countApb[13]++;
				System.out.printf("%s : %d / ", "n", countApb[13]);
				break;
			case "o":
				countApb[14]++;
				System.out.printf("%s : %d / ", "o", countApb[14]);
				break;
				
			case "p":
				countApb[15]++;
				System.out.printf("%s : %d / ", "p", countApb[15]);
				break;
			case "q":
				countApb[16]++;
				System.out.printf("%s : %d / ", "q", countApb[16]);
				break;
			case "r":
				countApb[17]++;
				System.out.printf("%s : %d / ", "r", countApb[17]);
				break;
			case "s":
				countApb[18]++;
				System.out.printf("%s : %d / ", "s", countApb[18]);
				break;
			case "t":
				countApb[19]++;
				System.out.printf("%s : %d / ", "t", countApb[19]);
				break;
				
			case "u":
				countApb[20]++;
				System.out.printf("%s : %d / ", "u", countApb[20]);
				break;
			case "v":
				countApb[21]++;
				System.out.printf("%s : %d / ", "v", countApb[21]);
				break;
			case "w":
				countApb[22]++;
				System.out.printf("%s : %d / ", "w", countApb[22]);
				break;
			case "x":
				countApb[23]++;
				System.out.printf("%s : %d / ", "x", countApb[23]);
				break;
			}
		}

	}

}
