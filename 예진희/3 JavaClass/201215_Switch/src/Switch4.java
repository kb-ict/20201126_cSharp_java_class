
public class Switch4 {

	public static void main(String[] args) {
		// Math : ���� Ŭ����, random() �޽��
		// 0 ~ 3������ �� �������� > 0~n-1�� ��
		// (0 ~ 3)+1 = 1 ~ 4
		int time = (int)(Math.random()*4)+8;
		System.out.println("���� �ð�: "+time);
		
		switch (time) {
		case 8:
			System.out.println("���");
		case 9:
			System.out.println("ȸ��");
		case 10:
			System.out.println("����");
		default:
			System.out.println("����");
		}
	}

}
