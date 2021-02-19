package practice;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Main {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter bw =  new BufferedWriter(new OutputStreamWriter(System.out));
		
		int n = Integer.parseInt(br.readLine());
		
		for (int i = 0; i < n; i++) {
			String str = br.readLine();
			String[] tokens = str.split(" ");
			int sum = 0;
			for (int j = 0; j < tokens.length; j++) {
				sum += Integer.parseInt(tokens[j]);
			}
			bw.write(String.valueOf(sum) + "\n");
		}
		bw.flush();
		bw.close();
	}
}
