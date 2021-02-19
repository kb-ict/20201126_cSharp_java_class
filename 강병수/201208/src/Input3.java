import java.util.Scanner;

public class Input3 {

	public static void main(String[] args) {
	Scanner ca = new Scanner(System.in);
	System.out.print("주행거리 입력: ");
	double distance=ca.nextDouble();
	System.out.print("사용한 휘발유 양 입력: ");
	double fuels=ca.nextDouble();
	double yeonbi=distance/fuels;
	System.out.println("연비: " + yeonbi);
	ca.close();
	}

}
