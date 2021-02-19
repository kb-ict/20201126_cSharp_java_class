import java.util.Random;

public class LottoDoWhile {

	public static void main(String[] args) {

		Random rand = new Random();
		String line = "-------------------------";
		System.out.println(line);
		System.out.println("간단한 로또 프로그램 v1.0");
		System.out.println(line);
		
		int cnt=0;
		do {
			int num = rand.nextInt(45)+1;
			System.out.printf("%d ",num);
			cnt++;
		} while (cnt<6);
		
		
		
	}

}
