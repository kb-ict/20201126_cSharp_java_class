import java.util.Random;

public class Lotto {

	public static void main(String[] args) {

	Random rd = new Random();
	
	for(int i=0;i<6;i++) {
		System.out.print("["+(rd.nextInt(45)+1)+"]");
	}

	}

}
