
public class ArrYeje2 {

	public static void main(String[] args) {
		int arr[][]= new int[4][3]; // ����� ����(�߰�ȣ{})�ȿ��� ���� ��밡�� 
		int value = 1; //break point, 7�������� ���� �� �ߴ�
		
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 3; j++) {
				arr[i][j] = value++; //���� 100�̶�� ��
				System.out.println("�����: "+arr[i][j]);
			}
		}
		
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 3; j++) {
				System.out.print(arr[i][j]+"\t");
			}
			System.out.println();
		}
	}
}
