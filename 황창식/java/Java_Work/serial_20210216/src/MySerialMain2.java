import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerialMain2 {
	public static void main(String[] args) {
		// 포트 정보 읽기 및 출력
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}

		// 포트 통신 설정
		SerialPort serialPort = new SerialPort(portNames[0]);
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}

		// 쓰레드 실행
		ReadThread rt = new ReadThread(serialPort);
		rt.start();
		WriteThread wt = new WriteThread(serialPort);
		wt.start();
	}
}

// 읽기 전용 작업 쓰레드
class ReadThread extends Thread {
	SerialPort serial;

	ReadThread(SerialPort serial) {
		this.serial = serial;
	}

	public void run() {
		try {
			while (true) {
				byte[] read = serial.readBytes();
				{
					if (read != null && read.length > 0)
						System.out.print(new String(read));
				}
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}

// 전송 전용 작업 쓰레드
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
