import java.util.Scanner;

public class Ex1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("입력 받을 정수의 갯수를 입력하세요 : ");
		int N = s.nextInt();
		int[] input= new int[N];
		for (int i = 0; i < input.length; i++) {
			input[i]=s.nextInt();
		}
		int max = input[0];
		int min = input[0];
		for (int i = 0; i < input.length; i++) {
			if (max<input[i]) {
				max=input[i];
			}
			else if (min>input[i]) {
				min=input[i];
			}
		}
		System.out.printf("최대값은 %d이고 최소값은 %d이다.",max,min);
		s.close();
	}

}
