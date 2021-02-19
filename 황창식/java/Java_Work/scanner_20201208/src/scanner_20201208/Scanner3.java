package scanner_20201208;

import java.util.Scanner;

public class Scanner3 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("주행 거리 입력 : ");
		double juhang = s.nextDouble();
		System.out.print("사용한 휘발유 양 입력 : ");
		double fuels = s.nextDouble();
		
		// 연비 구하는 공식
		double yeonbi = juhang / fuels;
		System.out.println("차량 연비 : " + yeonbi);
		s.close();

	}

}
