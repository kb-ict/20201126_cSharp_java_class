import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		String input = s.next();
		String result = "";
		char ps[] = input.toCharArray();
		int countleft = 0;
		int countright = 0;
				
		for (int i = 0; i < ps.length; i++) {
			if(ps[i] == '(') {
				countleft++;
			}
			else if(ps[i] == ')') {
				countright++;
			}
		}
		if(countleft != countright) {
			result = "NO";
		}
		else {
			for (int i = 0; i < ps.length; i++) {
				
			}
		}
	}
}
