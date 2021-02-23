package Problem4;
import Problem4.StudentScore;
import java.util.Random;

public class Main {

	public static void main(String[] args) {
		int arr[][] = new int[5][3];
		Random ran = new Random();

		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = ran.nextInt(101);
			}
		}

		StudentScore student = new StudentScore(arr);
	}

}
