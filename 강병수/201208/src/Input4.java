import java.util.Scanner;

public class Input4 {

	public static void main(String[] args) {
		Scanner cs=new Scanner(System.in);
		
		double pi = 3.141592;
		System.out.print("�������� �Է��Ͻÿ�: ");
		double rad = cs.nextDouble();
		System.out.println("���� ����: " + rad*rad*pi);
		
		System.out.print("���� ������ �Է��Ͻÿ�: ");
		double kor = cs.nextInt();
		System.out.print("���� ������ �Է��Ͻÿ�: ");
		double math = cs.nextInt();
		System.out.print("���� ������ �Է��Ͻÿ�: ");
		double eng = cs.nextInt();
		System.out.print("���� ������ �Է��Ͻÿ�: ");
		double sci = cs.nextInt();
		
		double total = kor + sci + math + eng;
		double avr = (kor + sci + math + eng)/4;
		
		System.out.println("���� ����: " + total);
		System.out.println("��� ����: " + avr);
		cs.close();
		
	}

}
