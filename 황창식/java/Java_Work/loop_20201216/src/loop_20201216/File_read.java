package loop_20201216;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class File_read {

	public static void main(String[] args) {

		BufferedReader br;
		try {
			br = new BufferedReader(
					new FileReader(new File("d:/test.txt")));
			String str = br.readLine();
			System.out.println("---파일에서 내용 읽어오기---");
			System.out.println(str);
			br.close();
		}
		catch (FileNotFoundException e) {
			e.printStackTrace();
		}
		catch (IOException e) {
			e.printStackTrace();
		}
		
	}

}
