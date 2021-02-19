package method_20210105;

import java.util.Arrays;
import java.util.Scanner;

public class Method_practice9 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("숫자를 3개 입력하세요 : ");
		int minmax[] = minmax(s.nextInt(), s.nextInt(), s.nextInt());
		System.out.println("최대값 : " + minmax[1]);
		System.out.println("최소값 : " + minmax[0]);
		

	}
	
	public static int[] minmax(int num1, int num2, int num3) {
		int num[] = {num1, num2, num3};
		Arrays.sort(num);
		int minmax[] = {num[0], num[2]};
		return minmax;
	}
	
	

}
