import java.util.Scanner;

public class Input2 {

	public static void main(String[] args) {
		Scanner c = new Scanner(System.in);
		
		System.out.print("ù��° ������ �Է�: ");
		int num1=c.nextInt();
		System.out.print("�ι�° ������ �Է�: ");
		int num2=c.nextInt();
		System.out.print("����° ������ �Է�: ");
		int num3=c.nextInt();
		
		int sum = num1+num2+num3;
		int avr = sum/3;
		
		System.out.println("����: " + sum);
		System.out.println("��հ�: " + avr);
		c.close();

	}

}
