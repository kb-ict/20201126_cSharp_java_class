import java.util.Scanner;

public class Ex005_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("원의 반지름을 입력하시오 : ");
		Scanner sc = new Scanner(System.in);
		double r = sc.nextInt();
		double PI = 3.14;
		double sum = r * r * PI;
		System.out.println("원의 면적 : " + sum);
		sc.close();
	}

}
