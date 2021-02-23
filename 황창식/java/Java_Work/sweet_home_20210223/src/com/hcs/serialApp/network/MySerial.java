package com.hcs.serialApp.network;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerial {
	private SerialPort serialPort;
	
	// 시리얼 정보 불러오기 및 출력
	public SerialPort getSerial() {
		// 포트 이름 가져오기
		String[] portNames = SerialPortList.getPortNames();
		// 연결된 포트가 없을 때
		if(portNames.length < 1) {
			return null;
		}
		else {
			for (int i = 0; i < portNames.length; i++) {
				System.out.println(portNames[i] + " 연결 완료!");
			}
			serialPort = new SerialPort(portNames[0]);
			// 포트 연결
			try {
				serialPort.openPort();
				serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			return serialPort;
		}
	}
}
