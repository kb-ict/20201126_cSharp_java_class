import java.util.Scanner;

public class Input3 {

	public static void main(String[] args) {
	Scanner ca = new Scanner(System.in);
	System.out.print("����Ÿ� �Է�: ");
	double distance=ca.nextDouble();
	System.out.print("����� �ֹ��� �� �Է�: ");
	double fuels=ca.nextDouble();
	double yeonbi=distance/fuels;
	System.out.println("����: " + yeonbi);
	ca.close();
	}

}
