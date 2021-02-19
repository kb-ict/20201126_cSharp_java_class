import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		String input = s.next();
		char ch[] = input.toCharArray();
		
		System.out.println(count(ch));
	}
	
	public static int count(char ch[]) {
		int count = 0;
		for (int i = 0; i < ch.length; i++) {
			count++;
			if(i > 0) {
				if(ch[i] == '=') {
					if(ch[i-1] == 'c' || ch[i-1] == 's' || ch[i-1] == 'z')
						count--;
				}
				else if(ch[i] == '-') {
					if(ch[i-1] == 'c' || ch[i-1] == 'd')
						count--;
				}
				else if(ch[i] == 'j') {
					if(ch[i-1] == 'l' || ch[i-1] == 'n')
						count--;
				}
			}
			if(i > 1) {
				if (ch[i] == '=') {
					if (ch[i-1] == 'z' && ch[i-2] == 'd') { 
						count--;
					}
				}
			}
		}
		return count;
	}

}
