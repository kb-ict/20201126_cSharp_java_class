package com.yjh.serialApp.network;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerial {

	private SerialPort serial;

	public MySerial() {
		SerialPort serial = initSerial();
		this.serial = serial;
		openSerial(serial);
	}

	public static SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serial = new SerialPort(portNames[0]);
		return serial;
	}

	public void openSerial(SerialPort serial) {
		try {
			serial.openPort();
			serial.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}

	public SerialPort getSerial() {
		return serial;
	}

	public void setSerial(SerialPort serial) {
		this.serial = serial;
	}


}
