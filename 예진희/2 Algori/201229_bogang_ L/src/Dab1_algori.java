import java.util.Scanner;

public class Dab1_algori {

	public static void main(String[] args) {
		String line = "--------------------------";
		/*
		 * ���Ѽ� ���� �Է¹ޱ� �ּ�, �ִ밪 ���
		 * 
		 * 1. �� �Է¹��� �� ���ϱ� 2. �Է¼��� ũ���� �迭���� 3. �迭�� ���� ���� 4. �迭 �ȿ��� �ִ�, �ּҰ� ���
		 * 
		 * index : ����, �迭���� ��ġ(�ּ�)
		 */

		// 1. �� �Է¹��� �� ���ϱ�
		System.out.print("�迭�� ũ�⸦ ���ϼ���: ");
		int countNum = 0;
		Scanner s = new Scanner(System.in);
		countNum = s.nextInt();
		System.out.println(line);

		// 2. �Է¼��� ũ���� �迭����
		int[] input = new int[countNum];
//		int max = input[0]; //���⿡ ������ xx
//		int min = input[0];

		// 3. �迭�� ���� ����
		for (int i = 0; i < input.length; i++) {
			System.out.print((i + 1) + "��° �� �Է�: ");
			input[i] = s.nextInt();
		}
		// �ִ�, �ּҰ� ������ ���� ����
		int max = input[0];
		int min = input[0];

		// 4. �迭�ȿ��� �ִ�, �ּҰ� ���
		for (int i = 0; i < input.length; i++) {
			//----- �� -----------------------
//			if (max < input[i])
//				max = input[i];
//			if (min > input[i])
//				min = input[i];
			
			//-------------------------------
			if (max < input[i])
				max = input[i];
			else if (min > input[i])
				min = input[i];
			
			if (max < input[i])
				max = input[i];
			else min = input[i];
			//-------------------------------
			
		}
		System.out.println(line+"\n�ִ밪�� " + max + ", �ּڰ��� " + min);

		// -------- �� Ǯ�� ---
//		for (int i = 0; i < input.length; i++) {
//			if (max < input[i]) {
//				max = input[i];
//			}
//
//			if (min > input[i]) {
//				min = input[i];
//			}
//		}
//		System.out.println(line+"\n�ִ밪�� " + max + ", �ּڰ��� " + min);

		s.close();

	}

}
