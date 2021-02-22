package serial3;

import jssc.SerialPort;
import jssc.SerialPortException;

public class MySerial {
	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}
}

class ReadThread extends Thread {
	SerialPort serial;
	
	public ReadThread(SerialPort serial) {
		this.serial = serial;
	}

	@Override
	public void run() {
		while (true) {
			try {
				byte[] read = serial.readBytes();
				if (read != null && read.length > 0) {
					System.out.println(new String(read));
				}
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			
		}
	}
	
}





