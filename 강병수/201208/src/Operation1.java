
public class Operation1 {

	public static void main(String[] args) {
		int num1 = 2, num2 = 5, num3 = 6;
		int sum1 = num1 + num2 - num3;
		//������ �켱����
		//() > *,/ > +, -
		System.out.println("sum1: " + sum1);
		//��ȣ�� ���� ó��
		int sum2 = num1 * (num2 - num3);
		System.out.println("sum2: " + sum2);
		int sum3 = num1 + num2 * num3;
		System.out.println("sum3: " + sum3);
		//% ������ ������
		int sum4 = num3%num2;
		System.out.println("sum3: " + sum4);

	}

}
