import java.io.File;
import java.io.IOException;

public class ThreadMain6 {

	public static void main(String[] args) {
		FileDir file = new FileDir();
		file.start();
	}

}

class FileDir extends Thread {

	public void run() {
		subDirList("c:\\Program Files");
	}
	
	public void subDirList(String source) {
		File dir = new File(source);
		File[] fileList = dir.listFiles();
		
		for (int i = 0; i<fileList.length; i++) {
			File file = fileList[i];
			if (file.isFile()) {
				String name = file.getName();
				System.out.println("\t파일: "+ name);
			}
			else if (file.isDirectory()) {
				try {
					String name = file.getCanonicalPath().toString();
					System.out.println("폴더: "+ name);
					subDirList(name);
					Thread.sleep(10);
				} catch (IOException e) {
					e.printStackTrace();
				} catch (InterruptedException e) {
					e.printStackTrace();
					// Exception 하위에 InterruptedException이 포함되어있기 때문에 IOException 사용
				}
				  catch (NullPointerException e) {
					System.err.println("시스템 폴더 제한");
				}
			}
		}
	}
}