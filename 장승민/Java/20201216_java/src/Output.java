import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class Output {

	public static void main(String[] args) {

		BufferedOutputStream bs;
		try {
			bs = new BufferedOutputStream(new FileOutputStream("D:/test1.txt"));
			String str = "파일 생성 및 쓰기 예제입니다.";
			bs.write(str.getBytes());
			bs.close();
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}

	}

}
