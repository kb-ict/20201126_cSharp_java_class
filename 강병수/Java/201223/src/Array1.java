import java.util.Scanner;

public class Array1 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int [] arr = new int[3];
		int hap = 0;
		
		System.out.print("1번째 숫자 입력: ");
		arr[0] = sc.nextInt();
		System.out.print("2번째 숫자 입력: ");
		arr[1] = sc.nextInt();
		System.out.print("3번째 숫자 입력: ");
		arr[2] = sc.nextInt();
		
		hap = arr[0] + arr[1] + arr[2];
		System.out.println("배열의 합: " + hap);
		
		hap = 0;
		for (int i=0 ; i<3; i++) {
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("배열의 합: " + hap);
		sc.close();
	}

}
