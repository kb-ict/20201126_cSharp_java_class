package com.yjh.serialApp;

import java.util.Scanner;

import com.yjh.serialApp.handler.SerialCtrl;
import com.yjh.serialApp.network.MySerial;
import com.yjh.serialApp.util.Menu;

import jssc.SerialPort;

public class SerialMain {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		MySerial sctrl = new MySerial(); // 시리얼포트 연결
		SerialPort serial2 = sctrl.getSerial();
		SerialCtrl st2 = new SerialCtrl(s);
		Menu menu = new Menu(s);
		while (true) {
			String mode = menu.login();
			if (mode.equals(Menu.ADMIN_MODE)) {
				while (true) {
					if (st2.adminWork(serial2,menu,sctrl) == false) {
						break;
					}
				}
			} else if (mode.equals(Menu.GUEST_MODE)) {
				while (true) {
					if (!st2.guestWork(serial2,menu)) {
						break;
					}
				}
			} else {
				System.out.println("ID 또는 비번이 잘못되었습니다.");
				System.out.println("다시 입력하세요.");
			}
		}
	}

}
