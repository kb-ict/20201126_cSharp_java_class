import java.util.Scanner;

public class Problem4 {

	public static void grade(int arr[]) { //총점, 평균값 출력 메소드
		int sum = arr[0] + arr[1] + arr[2];
		float avr = sum/3;
		System.out.println("총점: " + sum);
		System.out.println("평균: " + avr);
	}
	
	
	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		int arr[] = new int[3];
		for(int i = 0 ; i<3 ; i++) {
			arr[i] = sc.nextInt();
		}
		for(int i = 0 ; i<3 ; i++) {
			if(arr[i] > 100 || arr[i] <0) {
				System.out.println("점수를 잘못 입력");
				System.exit(0);
			}
		}
		grade(arr);
		sc.close();
	}

}
