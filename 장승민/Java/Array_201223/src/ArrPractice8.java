import java.util.Random;

public class ArrPractice8 {

	public static void main(String[] args) {
		
		Random rd = new Random();
		
		String line = "---------------------";
		System.out.println(line);
		System.out.println("간단한 로또 프로그램 v1.1");
		System.out.println(line);

		int [] lotto=new int [6];

		for (int i = 0; i < 6; i++) {
			lotto[i]=(rd.nextInt(45)+1);
			for (int j = 0; j < i; j++) {
				if (lotto[i]==lotto[j]) {
					i--;
				}
			}
		}
		for (int i = 0; i < 6; i++) {
			System.out.print(lotto[i]+" ");
		}






	}

}
