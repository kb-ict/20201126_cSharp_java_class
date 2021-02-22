import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;

public class MyFileWrite {
	
	public void write(String[] names) {
		String path = "name.txt";
			try {
				BufferedWriter bw = new BufferedWriter(new FileWriter(path));
				for (int i = 0; i < names.length; i++) {
					bw.write(names[i] + "/");
				}
				bw.close();
				
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
	}
}