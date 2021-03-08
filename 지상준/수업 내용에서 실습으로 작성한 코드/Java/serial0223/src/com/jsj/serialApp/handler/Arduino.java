package com.jsj.serialApp.handler;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JOptionPane;

import com.jsj.serialApp.SerialMain;
import com.jsj.serialApp.network.ArduinoSerialPortSingleton;
import com.jsj.serialApp.network.ArduinoSerialReadRunnable;
import com.jsj.serialApp.util.ArduinoWindow;

import jssc.SerialPort;
import jssc.SerialPortException;

public class Arduino {
	public static final int CMD_NUM = 7;
	public static final String[] CMD_NAME = {
			"1. TV 켜기",
			"2. TV 끄기",
			"3. 스피커 동작",
			"4. 세탁기 동작",
			"5. 로그아웃 >_< ~!!",
			"6. 프로그램 종료", "7. 관리자 특별 모드 >_< ~!!"};
	public static final char TV_ON = '1';
	public static final char TV_OFF = '2';
	public static final char SPEAKER_ON = '3';
	public static final char CLEANER_ON = '4';
	public static final char LOGOUT = '5';
	public static final char PROGRAM_EXIT = '6';
	public static final char ADMIN_SETTING = '7';
	private boolean isAdmin;
	private ArduinoWindow window = null;
	public ArduinoWindow getArduinoWindow() {
		if(window == null)
			window = new ArduinoWindow();
		return window;
	}
	public Arduino(boolean isAdmin) {
		this.isAdmin = isAdmin;
	}
	public void setAdminAndApplyToWindow(boolean isAdmin) {
		this.isAdmin = isAdmin;
		window.setEnabledAdminSetting(this.isAdmin);
	}





	public void runArduino() {

		SerialPort serialPort = ArduinoSerialPortSingleton.getSerialPortInstance();
		// 아두이노가 보내는 디버그 메세지를 받을려고 한당 !!
		new Thread(new ArduinoSerialReadRunnable(serialPort)).start();

		window.addActionListenerInBtnCmd(Arduino.TV_ON, new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e) {
				try {
					serialPort.writeInt(Arduino.TV_ON);
				} catch (SerialPortException exce) {
					exce.printStackTrace();
				}
			}
		});
		window.addActionListenerInBtnCmd(Arduino.TV_OFF, new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e) {
				try {
					serialPort.writeInt(Arduino.TV_OFF);
				} catch (SerialPortException exce) {
					exce.printStackTrace();
				}
			}
		});
		window.addActionListenerInBtnCmd(Arduino.SPEAKER_ON, new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e) {
				try {
					serialPort.writeInt(Arduino.SPEAKER_ON);
				} catch (SerialPortException exce) {
					exce.printStackTrace();
				}
			}
		});
		window.addActionListenerInBtnCmd(Arduino.CLEANER_ON, new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e) {
				try {
					serialPort.writeInt(Arduino.CLEANER_ON);
				} catch (SerialPortException exce) {
					exce.printStackTrace();
				}
			}
		});
		window.addActionListenerInBtnCmd(Arduino.LOGOUT, new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e) {
				fireArduinoEvent(new ArduinoEvent("로그아웃"));
			}
		});
		window.addActionListenerInBtnCmd(Arduino.PROGRAM_EXIT, new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "프로그램 종료");
				System.exit(0);
			}
		});
		window.addActionListenerInBtnCmd(Arduino.ADMIN_SETTING, new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null, "관리자권한 세팅들을 구현해주세요 :)");
			}
		});
	}


	private void fireArduinoEvent(ArduinoEvent event) {
		Object[] listeners = SerialMain.arduinoListenerList.getListenerList();

		for (int i = listeners.length - 2; i >= 0; i -= 2) {
			if (listeners[i] == ArduinoEventListener.class) {
				((ArduinoEventListener)listeners[i + 1]).arduinoEvent(event);
			}
		}
	}
}