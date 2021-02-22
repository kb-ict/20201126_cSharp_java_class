package Test4;

import java.util.Scanner;

public class Test4 {

	public static void main(String[] args) {
		Scanner s= new Scanner(System.in);
		System.out.print("알파벳을 입력하세요 : ");
		String alpa=s.next();
		for (int i = 0; i < alpa.length(); i++) {
			if(alpa.charAt(i)=='a') {
				System.out.print("ㄱ");
			}
			else if (alpa.charAt(i)=='b') {
				System.out.print("ㄴ");
			}
			else if (alpa.charAt(i)=='c') {
				System.out.print("ㄷ");
			}
			else if (alpa.charAt(i)=='d') {
				System.out.print("ㄹ");
			}
			else if (alpa.charAt(i)=='e') {
				System.out.print("ㅁ");
			}
			else if (alpa.charAt(i)=='f') {
				System.out.print("ㅂ");
			}
			else if (alpa.charAt(i)=='g') {
				System.out.print("ㅅ");
			}
			else if (alpa.charAt(i)=='h') {
				System.out.print("ㅇ");
			}
			else if (alpa.charAt(i)=='i') {
				System.out.print("ㅈ");
			}
			else if (alpa.charAt(i)=='j') {
				System.out.print("ㅊ");
			}
			else if (alpa.charAt(i)=='k') {
				System.out.print("ㅋ");
			}
			else if (alpa.charAt(i)=='l') {
				System.out.print("ㅌ");
			}
			else if (alpa.charAt(i)=='m') {
				System.out.print("ㅍ");
			}
			else if (alpa.charAt(i)=='n') {
				System.out.print("ㅎ");
			}
			else if (alpa.charAt(i)=='o') {
				System.out.print("ㅏ");
			}
			else if (alpa.charAt(i)=='p') {
				System.out.print("ㅑ");
			}
			else if (alpa.charAt(i)=='q') {
				System.out.print("ㅓ");
			}
			else if (alpa.charAt(i)=='r') {
				System.out.print("ㅕ");
			}
			else if (alpa.charAt(i)=='s') {
				System.out.print("ㅗ");
			}
			else if (alpa.charAt(i)=='t') {
				System.out.print("ㅛ");
			}
			else if (alpa.charAt(i)=='u') {
				System.out.print("ㅜ");
			}
			else if (alpa.charAt(i)=='v') {
				System.out.print("ㅠ");
			}
			else if (alpa.charAt(i)=='w') {
				System.out.print("ㅡ");
			}
			else if (alpa.charAt(i)=='x') {
				System.out.print("ㅣ");
			}
		}
		s.close();
	}

}
