import java.util.Scanner;

public class Array2 {

	public static void main(String[] args) {
		//반복문을 활용
		Scanner sc = new Scanner(System.in);
		int [] arr = new int[3];
		int hap = 0;
		
		for (int i = 0; i<3; i++) {
			System.out.printf("%d번째 숫자 입력: ", i);
			arr[i] = sc.nextInt();
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("배열의 합: " + hap);
		sc.close();
	}

}
