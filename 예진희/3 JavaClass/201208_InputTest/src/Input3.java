import java.util.Scanner;

public class Input3 {

	public static void main(String[] args) {
		Scanner ss = new Scanner(System.in);
		System.out.print("����Ÿ� �Է�: ");
		
		double juhang = ss.nextDouble();
		System.out.print("����� �ֹ��� �� �Է�: ");
		
		double fuels = ss.nextDouble();
		double yeonbi = juhang / fuels;
		//���� ����
		System.out.print("���� ����: "+yeonbi);
		ss.close();

	}

}
