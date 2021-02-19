import java.util.Scanner;
public class Test_5 {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String input = s.next();
		char word[] = input.toCharArray();
		for (int i = 0; i < word.length; i++) {
			if((int)(word[i]) < 97) {
				word[i] = (char)((int)(word[i]+32));
			}
		}
		int count[] = new int[26];
		for (int i = 0; i < count.length; i++) {
			for (int j = 0; j < word.length; j++) {
				if((char)(i+97) == word[j])
					count[i]++;
			}
		}
		for (int i = 0; i < count.length; i++) {
			if(count[i] != 0) {
				System.out.println("'" + (char)(i+97)+ "' 는 " + count[i] + "글자 입니다.");
			}
		}
		s.close();
	}
}