import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int x = s.nextInt();
		int y = s.nextInt();
		int w = s.nextInt();
		int h = s.nextInt();
		int result = 0;
		
		if (x < w / 2 && y < h / 2) {
			if (x > y)
				result = y;
			else
				result = x;
		}
		
		else if (x < w / 2 && y > h / 2) {
			if (x > h - y)
				result = h - y;
			else
				result = x;
		}
		
		else if (x > w / 2 && y < h / 2) {
			if (w - x > y)
				result = y;
			else
				result = w - x;
		}
		
		else if (x > w / 2 && y > h / 2) {
			if (w - x < h - y)
				result = w - x;
			else
				result = h - y;
		}
		
		System.out.println(result);

	}
}