
public class Operation4 {

	public static void main(String[] args) {
		int num = 99;
		// && (�� and������)
		// true && true --> true
		// true && false --> false
		// false && true --> false
		// false && false --> false
		System.out.println("and ����: " + ((num >= 100) && (num <= 200)));
		// || (�� or������)
		// true || true --> true
		// true || false --> true
		// false || true --> true
		// false || false --> false
		System.out.println("or ����: " + ((num >= 100) || (num <= 200)));
		// ! (�� not������)
		// ! (true) --> false
		// ! (false) --> true
		System.out.println("not ����: " + !(num == 100));
		// 3�� ������
		//�޽�� �ȿ��� ����� ������ �ʱⰪ�� ������ �����Ⱚ�� ����
		int num1 = 10, num2 = 15;
		String str = "";
		str = (++num1 >= num2) ? "num1 �� ũ��": "num2�� ũ��";
		System.out.println(str);
	}

}
