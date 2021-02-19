import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.Stack;

public class Main {
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
		int n = Integer.parseInt(br.readLine());
		Stack<Integer> result = new Stack<>();
		for (int i = 0; i < n; i++) {
			String input = br.readLine();
			String[] str = input.split(" ");
			if(str[0].equals("push")) {
				result.push(Integer.parseInt(str[1]));
			}
			else if(str[0].equals("pop")) {
				bw.write(Integer.toString(result.pop()));
				bw.newLine();
			}
			else if(str[0].equals("size")) {
				bw.write(Integer.toString(result.size()));
				bw.newLine();
			}
			else if(str[0].equals("empty")) {
				if(result.isEmpty() == true) {
					bw.write(Integer.toString(1));
					bw.newLine();
				}
				else {
					bw.write(Integer.toString(0));
					bw.newLine();
				}
			}
			else if(str[0].equals("top")) {
				if(result.isEmpty() == true) {
					bw.write(Integer.toString(-1));
					bw.newLine();
				}
				else {
					bw.write(Integer.toString(result.peek()));
					bw.newLine();
				}
			}
		}
		bw.close();
		bw.flush();
		bw.close();
		
		
	}

}
