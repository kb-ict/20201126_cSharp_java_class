import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Main {
	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
		String input = br.readLine();
		String[] inputs = input.split(" ");
		br.close();
		long a = Long.parseLong(inputs[0]);
		long b = Long.parseLong(inputs[1]);
		long v = Long.parseLong(inputs[2]);
		
		long count = v/(a-b);
		if(v == count * (a-b)) {
			bw.write(String.valueOf(count-1));
		}
		
		
		
		bw.flush();
		bw.close();
		
		
	}
}
