
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerialMain2 {
	public static void main(String[] args) {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = new SerialPort("COM6");
		
		try {
			serialPort.openPort();
			// 아두이노쪽 시리얼 속도 맞춰야함 BAUDRATE_9600
			// 8비트씩 전송 / - / 오류체크
			serialPort.setParams(SerialPort.BAUDRATE_9600, 
					SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
				
		ReadThread rt = new ReadThread(serialPort);
		rt.start();
		WriteThread wt = new WriteThread(serialPort);
		wt.start();
	}
}

// 읽기전용 작업 쓰레드
class ReadThread extends Thread {
	SerialPort serial;

	ReadThread(SerialPort serial) {
		this.serial = serial;
	}
	
	// 아두이노 -> PC들어오는 데이터 계속 읽음
	public void run() {
		try {
			while (true) {
				byte[] read = serial.readBytes(); {
				if (read != null && read.length > 0)
					System.out.print(new String(read));
				}
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}

// 데이터 전송 전용 작업 쓰레드(숫자 쓴거 아두이노로 전송)
class WriteThread extends Thread {
	SerialPort serial;

	WriteThread(SerialPort serial) {
		this.serial = serial;
	}

	public void run() {
		try {
			int c = 0;
			while ((c = System.in.read()) > -1) {
				serial.writeInt(c);
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}

// _ 아두이노는 OSx, 쓰레드 X, 별도처리
// _ java <-> c 통신/ JNI 
