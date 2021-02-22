import java.util.Random;

public class Ex3_3 {

	public static void main(String[] args) {
		Random rand = new Random();
		System.out.println("----------------------");
		System.out.println(" 간단한 로또 프로그램 v1.0");
		System.out.println("----------------------");
		int i = 0;
		do {
			int num = rand.nextInt(45);
			System.out.printf("%d  ",num);
			i++;
		}while(i<6);
	}

}
