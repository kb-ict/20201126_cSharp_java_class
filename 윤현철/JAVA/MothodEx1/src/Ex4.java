import java.util.Scanner;

public class Ex4 {

	public static void main(String[] args) {
		Scanner s= new Scanner(System.in);
		int kor;
		int eng;
		int mat;
		while(true) {
			System.out.println("국어 점수: ");
			kor = s.nextInt();
			if(kor<0 || kor>100) {
				System.out.println("잘못입력 하셧습니다. 다시 입력하세요");
				continue;
			}
			break;
		}
		while(true) {
			System.out.println("영어 점수: ");
			eng = s.nextInt();
			if(eng<0 || eng>100) {
				System.out.println("잘못입력 하셧습니다. 다시 입력하세요");
				continue;
			}
			break;
		}
		while(true) {
			System.out.println("수학 점수: ");
			mat = s.nextInt();
			if(mat<0 || mat>100) {
				System.out.println("잘못입력 하셧습니다. 다시 입력하세요");
				continue;
			}
			break;
		}
	
		fonc(kor, eng, mat);
		s.close();
	}
	public static void fonc(int kor, int eng, int mat) {
		int sum;
		int ave;
		sum = kor+eng+mat;
		ave = sum/3;
		System.out.printf("세과목의 총점은 %d점이고 평균은 %d점입니다.",sum,ave);
	}
}
