package name_maker;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.StringTokenizer;

public class MyFileRead {
	public void fileRead() throws IOException {
		BufferedReader br = new BufferedReader(new FileReader(new File("d:/names.txt")));
		 
		String line;
		while((line = br.readLine()) != null) {
			StringTokenizer st = new StringTokenizer(line, "/");
			while(st.hasMoreTokens()) {
				String result = st.nextToken();
				System.out.println(result);
			}
		}
		
		
	}
}
