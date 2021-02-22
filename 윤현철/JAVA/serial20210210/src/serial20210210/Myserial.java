package serial20210210;

import java.io.IOException;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class Myserial {
	public static void main(String[] args) {
		String[] portName = SerialPortList.getPortNames();
		for (int i = 0; i < portName.length; i++) {
			System.out.println("사용가능 포트: " + portName[i]);
		}
		SerialPort serialPort = new SerialPort("COM4");
		
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			
			e.printStackTrace();
		}
		
//		ReadThread rt = new ReadThread(serialPort);
//		rt.start();
//		WriteThread wt = new WriteThread(serialPort);
//		wt.start();
		try {
			serialPort.closePort();
		} catch (SerialPortException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println("포트종료!");
		
	}
}

class ReadThread extends Thread{
	SerialPort serial;
	
	public ReadThread(SerialPort serial) {
		this.serial=serial;
	}
	
	@Override
	public void run() {
		while (true ) {
			
			try {
				byte[] read = serial.readBytes();
				if(read != null && read.length > 0) {
					System.out.println(new String(read));
				}
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			
		}
	}
	
	
}
class WriteThread extends Thread{
	SerialPort serial;
	
	public WriteThread(SerialPort serial) {
		this.serial =serial;
	}

	@Override
	public void run() {
		int c =0;
		try {
			while((c=System.in.read()) >-1) {
				serial.writeInt(c);
			}
		} catch (IOException e) {
			e.printStackTrace();
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}
	
	
}