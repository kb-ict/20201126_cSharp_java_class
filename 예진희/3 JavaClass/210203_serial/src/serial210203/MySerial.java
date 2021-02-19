package serial210203;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

import gnu.io.CommPort;
import gnu.io.CommPortIdentifier;
import gnu.io.NoSuchPortException;
import gnu.io.PortInUseException;
import gnu.io.SerialPort;
import gnu.io.UnsupportedCommOperationException;

public class MySerial {
	void connect(String portName) {
		try {
			CommPortIdentifier portId = CommPortIdentifier.getPortIdentifier(portName);
			if (portId.isCurrentlyOwned()) {
				System.out.println("[에러] 포트 사용중");
			} else {
				// 클래스 이름을 식별자로 사용하여 포트 열기
				CommPort commPort = portId.open(getClass().getName(), 2000);
				if (commPort instanceof SerialPort) {
					SerialPort serialPort = (SerialPort) commPort;
					serialPort.setSerialPortParams(9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
							SerialPort.PARITY_NONE);

					InputStream in = serialPort.getInputStream();
					OutputStream out = serialPort.getOutputStream();

					new Thread(new SerialReader(in)).start();
					new Thread(new SerialWriter(out)).start();
				}
			}
		} catch (NoSuchPortException e) {
			System.out.println("NoSuchPortException");
			e.printStackTrace();
		} catch (PortInUseException e) {
			System.out.println("PortInUseException");
			e.printStackTrace();
		} catch (UnsupportedCommOperationException e) {
			System.out.println("UnsupportedCommOperationException");
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();

		}
	}

	// inner class, 변수값 받기 편함
	public static class SerialReader implements Runnable {
		InputStream in;

		public SerialReader(InputStream in) {
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
		}// 여러개 상속 받고 싶을 때 인터페이스로 당길 수 있음
	}

	// 추상메소드는 오버라이딩
	public static class SerialWriter implements Runnable {
		OutputStream out;

		public SerialWriter(OutputStream out) {
			this.out = out;
		}

		// 입출력 도와주는 클래스
		@Override
		public void run() {
			int c = 0;
			try {
				while ((c = System.in.read()) > -1) {
					out.write(c);
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
}
