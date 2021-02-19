import java.util.Scanner;

public class Exam5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String line = "-------------------------";
		int i = 0;
		System.out.println(line);
		System.out.println("구구단 프로그램 v1.0");
		System.out.println(line);
		
//		System.out.println();
//		System.out.println(" * for문 이용\n----------------");
//		System.out.print("1. 구구단 입력 => ");
//		int gab = s.nextInt();
//		
//		for(i=0; i<9; i++) {
//			System.out.printf("%d %s %d = %d\n", gab, "X" ,(i+1), gab*(i+1));
//		}
		
		
		
//		System.out.println();
//		System.out.println(" * while문 이용\n----------------");
//		System.out.print("1. 구구단 입력 => ");
//		int gab = s.nextInt();
//		while (i<9) {
//			
//			System.out.printf("%d %s %d = %d\n", gab, "X", (i+1), gab*(i+1));
//			i++;
//
//		}
		
		
		
		
		System.out.println();
		System.out.println(" * do-while문 이용\n----------------");
		System.out.print("1. 구구단 입력 => ");
		int gab = s.nextInt();
		do {
			System.out.println(gab+" X "+(i+1)+" = "+gab*(i+1));
			i++;
			}while(i<9);
		
//		
//		
		
//		for(i=0; i<9; i++) {
//			System.out.printf("%d %s %d = %d\n", gab, "X" ,(i+1), gab*(i+1));
		
		
		s.close();

	}

}
