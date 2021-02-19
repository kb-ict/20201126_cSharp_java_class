import java.util.Scanner;

public class IfExam5 {

	public static void main(String[] args) {
		/*
		 * 5. 국, 영, 수 점수 입력받아 
		 * 합, 평균 구하여 학점을 출력하는 프로그램
		 */
		Scanner sc = new Scanner(System.in);
		String line = "---------------------";
		System.out.println("[입력형식]");
		System.out.print("1. 국어 점수 입력 => ");
		int kr = sc.nextInt();
		System.out.print("2. 영어 점수 입력 => ");
		int eng = sc.nextInt();
		System.out.print("3. 수학 점수 입력 => ");
		int math = sc.nextInt();
		
		int total = 0;
		total = kr+eng+math;
		int ave = 0;
		ave = (kr+eng+math)/3;
		
		System.out.println();
		System.out.println(line);
		System.out.println("[출력형식]");
		System.out.println("- 총점: "+total);
		System.out.println("- 평균: "+ave);
		
		if (ave<101&&ave>89) {
			System.out.println("- 학점: A입니다.");
		}
		else if (ave<90&&ave>79) {
			System.out.println("- 학점: B입니다.");
		}
		else if (ave<80&&ave>69) {
			System.out.println("- 학점: C입니다.");
		}
		else if (ave<70&&ave>59) {
			System.out.println("- 학점: D입니다.");
		}
		else if (ave<60&&ave>49) {
			System.out.println("- 학점: E입니다.");
		}
		else {
			System.out.println("- 학점: F입니다.");
		}
		sc.close();
	}

}
