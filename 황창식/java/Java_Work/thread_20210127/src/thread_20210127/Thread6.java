package thread_20210127;
import java.io.File;
import java.io.IOException;
public class Thread6 {
	public static void main(String[] args) {
		FileDir fileDir = new FileDir();
		fileDir.start();
	}
}

class FileDir extends Thread{
	@Override
	public void run() {
		subDirList("C:\\Users\\KB\\Desktop\\SW_Lesson\\html");
	}
	
	public void subDirList (String source) {
		File dir = new File(source);
		File[] fileList = dir.listFiles();
		
		for (int i = 0; i < fileList.length; i++) {
			File file = fileList[i];
			if(file.isFile()) {
				String name = file.getName();
				System.out.println("\t파일 : " + name);
			}
			else if(file.isDirectory()) {
				try {
					String name = file.getCanonicalPath().toString();
					System.out.println("폴더 : " + name);
					subDirList(name);
					Thread.sleep(10);
				} catch (IOException e) {
					e.printStackTrace();
				} catch (InterruptedException e) {
					e.printStackTrace();
				} catch (NullPointerException e) {
					System.out.println("시스템 폴더");
				}
			}
		}
	}
}