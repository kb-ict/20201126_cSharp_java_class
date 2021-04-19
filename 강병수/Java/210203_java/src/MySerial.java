import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

public class MySerial {
	void connect(String portName) {
		
	}
	// inner class
	public static class SerialReader implements Runnable {
		InputStream in;

		public SerialReader() {
			this.in = in;
		}

		@Override
		public void run() {
			byte[] buf = new byte[1024];
			int len = -1;
			try {
				while ((len = in.read(buf)) > -1) {
					System.out.print(new String(buf, 0, len));
				}
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}
	
	public static class SerialWriter implements Runnable {
		OutputStream out;
		
		public SerialWriter(OutputStream out) {
			this.out=out;
		}
		@Override
		public void run() {
			int c = 0;
			try {
				while ((c=System.in.read()) > -1) {
					out.write(c);
				}
			} catch (IOException e) {
				e.printStackTrace();
			}
			
		}
		
	}
}
