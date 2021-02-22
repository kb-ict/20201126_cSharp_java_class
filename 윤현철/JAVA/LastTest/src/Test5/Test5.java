package Test5;

import java.util.Scanner;

public class Test5 {

	public static void main(String[] args) {
		Scanner s= new Scanner(System.in);
		System.out.print("알파벳을 입력하세요 : ");
		String alpa=s.next();
		int count=0;
		for (int j = 0; j < 26; j++) {
			for (int i = 0; i < alpa.length(); i++) {
				if (alpa.charAt(i)==(char)(j+97)) {
					count++;
				}
			}
			if(count!=0) {
				System.out.printf("'%c'는 %d글자입니다.",(char)(j+97),count);
				System.out.println();
			}
			count=0;
		}
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='a') {
//				count++;
//			}
//		}
//			if(count!=0) {
//			System.out.printf("'a'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='b') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'b'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='c') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'c'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='d') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'d'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='e') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'e'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='f') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'f'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='g') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'g'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='h') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'h'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='i') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'i'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='j') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'j'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='k') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'k'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='l') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'l'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='m') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'m'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='n') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'n'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='o') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'o'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='p') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'p'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='q') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'q'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='r') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'r'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='s') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'s'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='t') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'t'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='u') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'u'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='v') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'v'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='w') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'w'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='x') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'x'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='y') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'y'는 %d글자입니다.",count);
//			System.out.println();
//		}
//		count=0;
//		for (int i = 0; i < alpa.length(); i++) {
//			if (alpa.charAt(i)=='z') {
//				count++;
//			}
//		}
//		if(count!=0) {
//			System.out.printf("'z'는 %d글자입니다.",count);
//			System.out.println();
//		}
		s.close();
		
	}

}
