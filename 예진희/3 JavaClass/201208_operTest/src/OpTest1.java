public class OpTest1 {
	public static void main(String[] args) {
		// �޸��� ���� �ѹ��� �Է�
		int num1 = 2, num2 =3, num3 = 4;
		
		// �ڹ� = ���п� ���� ����, ������ �켱���� ����Ǿ� ����
		// ������ �켱���� : () > *, / > +, -
		// �켱������ ������ �� > �� ����
		int result = num1 + num2 - num3;
		System.out.println("result: "+result);	//����� : 1

		// ��ȣ�� ���� ó��
		int result2 = num1 + (num2 - num3);
		System.out.println("result2: "+result2);	//����� : 1
		
		// * > +
		result = num1 + num2 * num3;
		System.out.println("result: "+result);	//����� : 14
		
		// (+) > *
		result = (num1 + num2) * num3;
		System.out.println("result: "+result);	//����� : 20
		
		result = num1 * num2 / num3;	
		System.out.println("result: "+result);	//����� : 1
				// ������ ������ 4%3
		// X % 2 --> 0, 1 (������ = �� ���� -1�� ��)
		
		/* result = num3 % num2; */
		result = 10 % 3;
		System.out.println("result: " + result);	//����� : 1
	}

}
