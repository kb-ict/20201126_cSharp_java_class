
public class OpTest5 {

	public static void main(String[] args) {
		// 3�� ������ / A + B = ����.. ���� 2�� / ���� = ! or ��Ʈ...
		// �޼��� �ȿ��� ����� ������ �ʱⰪ�� ������ ����(������)���� ��
		int num1 = 10;
		int num2 = 15;
		String str = ""; // ""; = �� ����
		str = (++num1 >= num2) ? "num1�� ũ��" : "num2�� ũ��";
		// 11>=15 = False ? ������ ���̸� (��:����) ���� ����
		
		System.out.println(str);
	}

}
