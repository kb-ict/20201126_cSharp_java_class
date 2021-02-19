package name_maker;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class MyFileWrite {
	public void fileWrite(String names[]) throws IOException {
		File file = new File("d:/names.txt");
		BufferedWriter bw = new BufferedWriter(new FileWriter(file));
		for (int i = 0; i < names.length; i++) {
			bw.write(names[i]);
			bw.write("/");
		}
		bw.close();
		
	}
}
