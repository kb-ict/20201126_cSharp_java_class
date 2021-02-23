package com.yhc.serialApp;

import java.util.Scanner;

import com.yhc.serialApp.handler.Serialctrl;
import com.yhc.serialApp.network.Myserial;

import jssc.SerialPort;

public class SerialMain {
	
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		Myserial my = new Myserial();
		SerialPort serial = my.initSerial();
		
		Myserial.openSerial(serial);
		
		while (true) {
			String mode = Serialctrl.login(s);
			if (mode.equals(Serialctrl.ADMIN_MODE)) {
				while (true) {
					if (Serialctrl.adminWork(s, serial)==false) {
						break;
					}
				}
			}
			else if (mode.equals(Serialctrl.GUEST_MODE)) {
				while (true) {
					if (!Serialctrl.guestWork(s, serial)) {
						break;
					}
				}
			}
			else {
				System.out.println("ID 또는 비번이 잘못되었습니다.");
				System.out.println("다시 입력하세요.");
			}

		}
	}
}


