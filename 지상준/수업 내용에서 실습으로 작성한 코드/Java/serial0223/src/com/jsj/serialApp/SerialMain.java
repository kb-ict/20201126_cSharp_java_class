package com.jsj.serialApp;

import java.io.IOException;

import javax.swing.event.EventListenerList;

import com.jsj.serialApp.handler.Arduino;
import com.jsj.serialApp.handler.ArduinoEvent;
import com.jsj.serialApp.handler.ArduinoEventListener;
import com.jsj.serialApp.handler.Login;
import com.jsj.serialApp.handler.LoginEvent;
import com.jsj.serialApp.handler.LoginEventListener;
import com.jsj.serialApp.util.ArduinoWindow;
import com.jsj.serialApp.util.LoginWindow;

public class SerialMain {

	public static EventListenerList loginListenerList = new EventListenerList();
	public static EventListenerList arduinoListenerList = new EventListenerList();
	private static Login login = new Login(){{putLoginInfo("guest1", "1111");putLoginInfo("guest2", "2222");}};
	private static Arduino arduino = new Arduino(false);
	private static LoginWindow loginWindow;
	private static ArduinoWindow arduinoWindow;

	public static void main(String[] args) throws IOException, InterruptedException {

		addEventListener();
		arduinoWindow = arduino.getArduinoWindow();
		arduinoWindow.setVisible(false);
		loginWindow = login.getLoginWindow();
		loginWindow.setVisible(true);

		login.runLogin();
		arduino.runArduino();
	}

	public static void addEventListener() {

		addLoginEventListener(new LoginEventListener() {
			@Override
			public void loginEvent(LoginEvent event) {
				loginWindow.setVisible(false);
				arduinoWindow.setEnabledAdminSetting(login.isAdmin());
				arduinoWindow.setVisible(true);
			}
		});

		addArduinoEventListener(new ArduinoEventListener() {
			@Override
			public void arduinoEvent(ArduinoEvent event) {
				loginWindow.setVisible(true);
				arduinoWindow.setVisible(false);
			}
		});

	}

	public static void addLoginEventListener(LoginEventListener listener) {
		loginListenerList.add(LoginEventListener.class, listener);
	}

	public static void addArduinoEventListener(ArduinoEventListener listener) {
		arduinoListenerList.add(ArduinoEventListener.class, listener);
	}

	//	public void removeLoginEventListener(LoginEventListener listener) {
	//		loginListenerList.remove(LoginEventListener.class, listener);
	//	}
	//
	//	public void removeArduinoEventListener(LoginEventListener listener) {
	//		loginListenerList.remove(LoginEventListener.class, listener);
	//	}
}