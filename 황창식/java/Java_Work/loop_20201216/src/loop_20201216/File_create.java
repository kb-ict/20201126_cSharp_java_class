package loop_20201216;

import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class File_create {

	public static void main(String[] args) {

		BufferedOutputStream bs;
		try {
			bs = new BufferedOutputStream(
					new FileOutputStream("d:/test1.txt"));
			String str = "파일 생성 및 쓰기 예제입니다.";
			bs.write(str.getBytes());
			bs.close();
		}
		catch(FileNotFoundException e) {
			e.printStackTrace();
		}
		catch(IOException e) {
			e.printStackTrace();
		}

	}

}
