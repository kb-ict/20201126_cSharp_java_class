import java.util.Scanner;
public class Loop4 {

	public static void main(String[] args) {
	Scanner cs = new Scanner(System.in);
		int hap = 0;
		System.out.print("숫자 입력: ");
		int num = cs.nextInt();
		
		for (int i=0 ; i<num+1 ; i++) {
			hap = hap + i;
		}

		System.out.println("1부터 입력한 숫자까지의 합: " + hap);
		System.out.printf("1~%d까지의 합: %d\n", num, hap);
		cs.close();
	}

}
