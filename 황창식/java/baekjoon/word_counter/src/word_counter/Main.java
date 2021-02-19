package word_counter;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) throws IOException {

		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String str =  br.readLine();
		String[] tokens = str.split(" ");
		int count = 0;
		for (int i = 0; i < tokens.length; i++) {
			if(tokens[i].equals(""))
				continue;
			else
				count++;
		}
		System.out.println(count);
		
		
		
	}

}
