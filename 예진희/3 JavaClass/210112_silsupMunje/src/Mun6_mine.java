import java.io.BufferedOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class Mun6_mine {
	String str = "";
	public static String fileName = "D:/data/name.txt";


	public String myFileWrite(String irumJujang) throws IOException {
//		fileName = "D:/data/name.txt";
		BufferedOutputStream out = null;
		out = new BufferedOutputStream(new FileOutputStream(fileName));
		str = irumJujang;
		out.write(str.getBytes());
		out.close();
		return fileName;
	}


	public String getFileName() {
		return fileName;
	}
	
	
}
