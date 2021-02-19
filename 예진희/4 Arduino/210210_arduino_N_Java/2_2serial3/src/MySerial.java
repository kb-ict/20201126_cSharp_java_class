import java.io.IOException;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;
public class MySerial {
	public static void main(String[] args) {
		// 시리얼통신(블루투스) 벽있으면 간섭받음..
		// TCP/IP 카톡
		// HTTP 웹, RF통신
		// NFC 결제..
		// USB -> 시스템영역

		// 라이브러리, 모듈 (함수단위 뭉친거) -> 라이브러리 단위 : 프레임워크
		// C언어: 바이너리 == 헥사코드(16진수)
		// jar ; 클래스파일 뭉친거... 물리 신호주는거 java -> C .. JNI

		String[] portName = SerialPortList.getPortNames();

		for (int i = 0; i < portName.length; i++) {
			System.out.println("사용가능 포트: " + portName[i]);
		}
		SerialPort serialPort = new SerialPort(portName[0]); // (포트생성) 라이브러리에 있는거
		//SerialPort serialPort = new SerialPort("COM6"); // (포트생성) 라이브러리에 있는거 하드코딩
		
		
		try {
			serialPort.openPort(); // 포트열고 사용후 close

			// (초기화)
			// 클래스 변수, BAUDRATE_9600 bit per sec 1초 9600자,
			// 표준형식, 날리는거 (인자 4개, Params)
			serialPort.setParams(serialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
			
			System.out.println("포트 사용 가능");
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
		
		// (쓰레드 생성) 메인쓰레드, read, write -> 3개
		ReadThread rt = new ReadThread(serialPort);
		rt.start();
		WriteThread wt = new WriteThread(serialPort);
		wt.start();
		
	}
}

//*정보 읽어들임**
class ReadThread extends Thread {
	SerialPort serial;

	public ReadThread(SerialPort serial) {
		this.serial = serial;
	}

	@Override
	// annotation 컴파일러한테 알리는역할
	// @Override(재정의, 상속), 오버로딩(중복정의)
	public void run() {
		while (true) {
			try {
				byte[] read = serial.readBytes();
				if (read != null && read.length > 0) { // 읽은정보
					//String data  = new Swtring(read);
					System.out.print(new String(read)); // 바이트를 스트링단위로 바꿈
				} // 바이트를 스트링단위로 바꿈.. 스트림

			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		}
		// 부모클래스 위치값 정보(생략가능) : super.run();
	}
}

// thread가 2개
class WriteThread extends Thread {
	SerialPort serial;

	public WriteThread(SerialPort serial) {
		this.serial = serial;
	}

	public void run() {
		int c = 0;
		try {
			while ((c = System.in.read()) > -1) { // 아스키코드로 받는거
				serial.writeInt(c); // 아두이노 창에 쓰는거랑 같음*
			}
		} catch (IOException e) {
			e.printStackTrace();
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}
}