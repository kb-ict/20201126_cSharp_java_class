import java.util.Scanner;

public class Exam1 {

	public static void main(String[] args) {
		String line = "--------------------------";
		System.out.println(line);
		System.out.println("  짝수,홀수 구분 프로그램 v1.0");
		System.out.println(line);
		Scanner s = new Scanner(System.in);
		
		//선생님 답
		// Scanner 클래스 객체 생성 (s 변수 생성)
//		System.out.println("  for문을 이용\n---------------");
//		for (int i = 0; i<5; i++) {
//			System.out.print((i+1)+". Num"+(i+1)+" => ");
//			int num = s.nextInt();
//			if (num % 2 ==0) {
//				System.out.println("짝수입니다.");
//			}
//			else {
//				System.out.println("홀수입니다.");
//			}
//		}
		System.out.println();
		System.out.println("  while문을 이용\n---------------");
		int i = 0;
		while(i<5) {
			System.out.print((i+1)+". Num"+(i+1)+" => ");
			int num = s.nextInt();
			if(num%2==0) {
				System.out.println("짝수입니다.");
			}
			else {
				System.out.println("홀수입니다.");
			}
			i++;
		}
		
		
//		System.out.println();
//		System.out.println("  do while문을 이용\n---------------");
//		int i = 0;
//		do {
//			System.out.print((i+1)+". Num"+(i+1)+" => ");
//			int num = s.nextInt();
//			if(num%2==0) {
//				System.out.println("짝수입니다.");
//			}
//			else {
//				System.out.println("홀수입니다.");
//			}
//			i++;
//		} while (i<5);
		s.close();	
		
		

	}

}
