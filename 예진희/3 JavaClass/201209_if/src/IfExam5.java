import java.util.Scanner;

public class IfExam5 {

	public static void main(String[] args) {
		/*
		 * 5. ��, ��, �� ���� �Է¹޾� 
		 * ��, ��� ���Ͽ� ������ ����ϴ� ���α׷�
		 */
		Scanner sc = new Scanner(System.in);
		String line = "---------------------";
		System.out.println("[�Է�����]");
		System.out.print("1. ���� ���� �Է� => ");
		int kr = sc.nextInt();
		System.out.print("2. ���� ���� �Է� => ");
		int eng = sc.nextInt();
		System.out.print("3. ���� ���� �Է� => ");
		int math = sc.nextInt();
		
		int total = 0;
		total = kr+eng+math;
		int ave = 0;
		ave = (kr+eng+math)/3;
		
		System.out.println();
		System.out.println(line);
		System.out.println("[�������]");
		System.out.println("- ����: "+total);
		System.out.println("- ���: "+ave);
		
		if (ave<101&&ave>89) {
			System.out.println("- ����: A�Դϴ�.");
		}
		else if (ave<90&&ave>79) {
			System.out.println("- ����: B�Դϴ�.");
		}
		else if (ave<80&&ave>69) {
			System.out.println("- ����: C�Դϴ�.");
		}
		else if (ave<70&&ave>59) {
			System.out.println("- ����: D�Դϴ�.");
		}
		else if (ave<60&&ave>49) {
			System.out.println("- ����: E�Դϴ�.");
		}
		else {
			System.out.println("- ����: F�Դϴ�.");
		}
		sc.close();
	}

}
