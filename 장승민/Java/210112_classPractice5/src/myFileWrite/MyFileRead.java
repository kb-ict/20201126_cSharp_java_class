package myFileWrite;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;


public class MyFileRead {

	public void myFileRead() {
		try {
			BufferedReader br = new BufferedReader(new FileReader(new File("D:/data/name.txt")));
			String str = br.readLine();
			br.close();

			ArrayList<MyFileRead> arrList = new ArrayList<>();
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
