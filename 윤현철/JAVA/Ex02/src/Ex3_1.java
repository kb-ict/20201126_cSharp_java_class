import java.util.Random;

public class Ex3_1 {

	public static void main(String[] args) {
		Random rand = new Random();
		System.out.println("----------------------");
		System.out.println(" 간단한 로또 프로그램 v1.0");
		System.out.println("----------------------");
		for (int i = 0; i<6; i++) {
			int num = rand.nextInt(45);
			System.out.printf("%d  ",num);
		}
		
	}

}
