
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerialMain2 {
	public static void main(String[] args) {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = new SerialPort(portNames[0]);
		
		try {
			serialPort.openPort();
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

class ReadThread extends Thread {
	SerialPort serial;

	ReadThread(SerialPort serial) {
		this.serial = serial;
	}

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
