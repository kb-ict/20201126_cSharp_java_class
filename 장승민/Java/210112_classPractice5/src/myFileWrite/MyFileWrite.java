package myFileWrite;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class MyFileWrite {
	
	NameData nd = new NameData();
	
	public void myFileWrite() {
		try {
			FileOutputStream out = new FileOutputStream("D:/data/name.txt");
			out.write(nd.random().getBytes());
			out.close();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
