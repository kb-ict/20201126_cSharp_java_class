package algori;

import java.util.Arrays;
import java.util.Scanner;

public class Mundab1 {

	public static void main(String[] args) {
		// ���� N�� �Է¹޾Ƽ� ������ ū�� ������ ���
		System.out.println("1�� ����");
		Scanner s = new Scanner(System.in);
		System.out.println("�� ��� ���� �Է�?");
		int countNum = s.nextInt();
		System.out.println("���� �Է¹ޱ�");
		int[] numberList = new int[countNum];
		/* int max = numberList[0]; 
		 * int min = numberList[0];
		 */
		for (int i = 0; i < countNum; i++) {
			numberList[i] = s.nextInt();
		}
		
		//�ִ� �ּ� ��
		//1��° ���
		int max = numberList[0];
		int min = numberList[0];
		
		for (int i = 0; i < numberList.length; i++) {
			if(numberList[i]>max)
				max = numberList[i];
			if(numberList[i]<min)
				min = numberList[i];
		}System.out.println("�ּڰ� : "+min);
		System.out.println("�ִ밪 : "+max);
		
		//2��° ���
		Arrays.sort(numberList);
		System.out.println("�ּڰ�: "+numberList[0]);
		System.out.println("�ִ밪: "+numberList[numberList.length-1]);
	}
}
