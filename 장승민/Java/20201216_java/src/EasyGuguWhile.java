import java.util.Scanner;

public class EasyGuguWhile {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);
		String line = "----------------------";
		System.out.println(line);
		System.out.println("간단 구구단 프로그램 v1.0");
		System.out.println(line);
		
		System.out.printf("구구단 입력 =>");
		int num = sc.nextInt();
		sc.close();
		int cnt=0, res=0;
		while (cnt<9) {
			res = num*(cnt+1);
			System.out.printf("%d X %d = %d\n",num,(cnt+1),res);
		cnt++;
		}

		
		
	}

}
