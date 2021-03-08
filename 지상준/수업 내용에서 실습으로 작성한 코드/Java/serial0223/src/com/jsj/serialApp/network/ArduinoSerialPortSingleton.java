package com.jsj.serialApp.network;

import javax.swing.JOptionPane;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class ArduinoSerialPortSingleton {
	private static SerialPort serialPort = null;

	public static SerialPort getSerialPortInstance() {
		if(serialPort == null) {
			// SerialPort 열기 !!
			String[] portName = SerialPortList.getPortNames();
			if(portName.length == 0) {
				JOptionPane.showMessageDialog(null, "아두이노가 연결되지 않았습니다. . .");
				System.exit(0);
			}
			serialPort = new SerialPort(portName[0]);
			try {
				serialPort.openPort();
				serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		}

		return serialPort;
	}
	
	public static void closeSerialPort() {
		try {
			serialPort.closePort();
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
		
		serialPort = null;
	}
		
}
