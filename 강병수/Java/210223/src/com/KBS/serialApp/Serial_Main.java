package com.KBS.serialApp;

import java.util.Scanner;
import jssc.SerialPort;
import com.KBS.serialApp.control.*;
import com.KBS.serialApp.network.*;

public class Serial_Main {

	public static void main(String[] args) {
		
		Serial_Network net = new Serial_Network();
		Scanner sc = new Scanner(System.in);
		
		while (true) {
			String mode = Serial_Control.loginMenu(sc);
			if (mode.equals(Serial_Control.ADMIN_MODE)) {
				while (true) {
					if (Serial_Control.adminControl(sc, net.getSerial()) == false) {
						break;
					}
				}
			}
			else if (mode.equals(Serial_Control.GUEST_MODE)) {
				while (true) {
					if (Serial_Control.guestControl(sc, net.getSerial()) == false) {
						break;
					}
				}
			}else
			{
				System.out.println("ID와 비밀번호를 잘못 입력");
			}
		}
	}
}
