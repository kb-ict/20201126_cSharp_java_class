package com.KBS.serialApp.network;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class Serial_Network {
	static SerialPort serialPort;
	
	public Serial_Network() {
		initSerial();
		openSerial();
	}
	
	public SerialPort getSerial() {
		return serialPort;
	}

	public void initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		serialPort = new SerialPort(portNames[0]);
	}

	public void closeSerial(SerialPort serial) {
		try {
			serial.closePort();
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}

	public static void openSerial() {
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}
}
