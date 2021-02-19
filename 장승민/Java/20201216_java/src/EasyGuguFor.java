import java.util.Iterator;
import java.util.Scanner;

public class EasyGuguFor {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);
		String line = "----------------------";
		System.out.println(line);
		System.out.println("간단 구구단 프로그램 v1.0");
		System.out.println(line);
		
		System.out.printf("구구단 입력 =>");
		int num = sc.nextInt();
		sc.close();
		for (int i = 0; i < 9; i++) {
			int res = num*(i+1);
			System.out.printf("%d X %d = %d\n",num,(i+1),res);
		}
	}

}
