package thread0127;

import java.io.File;
import java.io.IOException;

public class Thread6 {
	public static void main(String[] args) {
		FileDir fileDir = new FileDir();
		fileDir.start();
	}
}

class FileDir extends Thread {
	// 오버라이딩
	public void run() {
		subDirList("C:\\Program Files\\IIS");
		// \\ 두개 써야함, 하나는 특문인식
	}

	public void subDirList(String source) {
		File dir = new File(source);

		File[] fileList = dir.listFiles(); // 하드디스크 탐색, 레지스트리 탐색

		for (int i = 0; i < fileList.length; i++) {
			File file = fileList[i];
			if (file.isFile()) {
				String name = file.getName();
				System.out.println("\t파일:" + name);
			} else if (file.isDirectory()) {

				try {
					String name = file.getCanonicalPath().toString();
					System.out.println("폴더:" + name);
					subDirList(name);
					Thread.sleep(100);
				//} catch (Exception e) { -> 상위개념, 여기서 다 걸림 / 예외처리는 작은거에서 큰걸로.. (상속개념)
				} catch (IOException e) { // 입, 출력
					e.printStackTrace();
				} catch (InterruptedException e) {
					e.printStackTrace();
				} // 런타임시점, 예측 불가능 오류 대응
				catch (NullPointerException e) {
					System.out.println("시스템 폴더 제한");
				}
			}
		}
	}
}
