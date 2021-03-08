package com.jsj.serialApp.network;

import jssc.SerialPort;
import jssc.SerialPortException;

public class ArduinoSerialReadRunnable implements Runnable {
	SerialPort serial;
	public ArduinoSerialReadRunnable(SerialPort serial) {
		this.serial = serial;
	}

	@Override
	public void run() {
		while (true) {
			try {
				byte[] read = serial.readBytes();
				if (read != null && read.length > 0) {
					System.out.print(new String(read));
				}
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
		}

	}
}
