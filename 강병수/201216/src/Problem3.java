import java.util.Random;

public class Problem3 {

	public static void main(String[] args) {

		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("     간단한 로또 프로그램 v1.0    ");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		Random rd = new Random();
		
		int i = 1;
		while (i <= 6) {
			System.out.print((rd.nextInt(45)+1) + " ");
			i++;
		}

	}

}
