import java.util.Scanner;

public class If_Dab3_Score {

	public static void main(String[] args) {
		String line = "--------------------";
		System.out.println(line);
		System.out.println("���� ���� ���α׷� v1.0");
		System.out.println(line);
		
		System.out.println("100~90 : A����");
		System.out.println("89~80 : B����");
		System.out.println("79~70 : C����");
		System.out.println("69~50 : D����");
		System.out.println("59~0 : F����");
		System.out.println(line);
		Scanner sc = new Scanner(System.in);
		System.out.print("1. ���� ����? ");
		int kr = sc.nextInt();
		//if (kr>100||kr<1) {
		//	System.out.println("0~100������ ���� �Է��Ͻÿ�");
		//}
		//sc.close();
		//System.exit(0);
		System.out.print("2. ���� ����? ");
		int eng = sc.nextInt();
		System.out.print("3. ���� ����? ");
		int math = sc.nextInt();
		
		System.out.println(line);
		int hap = kr + eng + math;
		
		System.out.println("���� : "+hap);
		int ave = hap/3;
		System.out.println("��� : "+ave);
		
		if (ave<=100 && ave>=90) {
			System.out.println("���� : A����");
		}
		else if (ave<=89 && ave>=80) {
			System.out.println("���� : B����");
		}
		else if (ave<=79 && ave>=70) {
			System.out.println("���� : C����");
		}
		else if (ave<=69 && ave>=50) {
			System.out.println("���� : D����");
		}
		else {
			System.out.println("���� : F����");
		}
		sc.close();
	}
	

}
