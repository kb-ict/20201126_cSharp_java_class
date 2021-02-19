import java.util.Random;

public class LottoFor {

	public static void main(String[] args) {

		String line = "-------------------------";
		System.out.println(line);
		System.out.println("간단한 로또 프로그램 v1.0");
		System.out.println(line);
		Random rand = new Random();
		for (int i = 0; i < 6; i++) {
			int num = rand.nextInt(45)+1;
			System.out.printf("%d ",num);
		}
		
		
	}

}
