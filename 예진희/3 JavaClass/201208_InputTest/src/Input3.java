import java.util.Scanner;

public class Input3 {

	public static void main(String[] args) {
		Scanner ss = new Scanner(System.in);
		System.out.print("주행거리 입력: ");
		
		double juhang = ss.nextDouble();
		System.out.print("사용한 휘발유 양 입력: ");
		
		double fuels = ss.nextDouble();
		double yeonbi = juhang / fuels;
		//연비 구함
		System.out.print("차량 연비: "+yeonbi);
		ss.close();

	}

}
