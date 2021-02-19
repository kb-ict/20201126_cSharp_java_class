import java.util.Random;

public class Exam3 {

	public static void main(String[] args) {
		// 3번 로또
		String line = "-------------------------";
		System.out.println(line);
		System.out.println("   간단한 로또 프로그램 v1.0");
		System.out.println(line);
		Random rand = new Random();
		
		for (int i = 0; i < 6; i++) {
			int num = rand.nextInt(45)+1; 
			System.out.print(num+"  ");
		}
		
		
		}
	}