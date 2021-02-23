package com.hcs.serialApp;

import java.util.Scanner;
import com.hcs.serialApp.network.MySerial;
import com.hcs.serialApp.util.Menu;
import jssc.SerialPort;

public class SerialMain {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		MySerial mySerial = new MySerial();
		SerialPort serial1 = mySerial.getSerial();
		Menu menu = new Menu(serial1, s);

		if (serial1 == null) {
			System.out.println("Error!");
			System.out.println("연결된 포트 없음!");
			s.close();
		} 
		else {
			while (true) {
				String user = menu.login();
				if (user.equals(menu.getADMIN_MODE()))
					menu.adminMenu();
				else if (user.equals(menu.getGUEST_MODE()))
					menu.guestMenu();
			}
		}
	}
}