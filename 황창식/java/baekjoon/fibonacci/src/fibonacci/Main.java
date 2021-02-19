package fibonacci;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Main {

	public static void main(String[] args) throws NumberFormatException, IOException {
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
		int fibonacci[] = new int[41];
		for (int i = 0; i < fibonacci.length; i++) {
			if(i == 0 || i == 1) {
				fibonacci[i] = i;
			}
			else {
				fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
			}
		}
		int arr[] = new int[Integer.parseInt(br.readLine())];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = Integer.parseInt(br.readLine());
		}
		br.close();
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] == 0) {
				bw.write("1 0");
				bw.newLine();
			} else {
				int count0 = fibonacci[arr[i] - 1];
				int count1 = fibonacci[arr[i]];
				bw.write(Integer.toString(count0) + " " + Integer.toString(count1));
				bw.newLine();
			}
		}
		bw.flush();
		bw.close();
	}
	
}
