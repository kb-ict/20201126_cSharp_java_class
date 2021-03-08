package com.jsj.serialApp.util;

import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

import com.jsj.serialApp.handler.Arduino;

public class ArduinoWindow {
	private JFrame frame;
	private JLabel labelConsole;
	private JButton[] btn = new JButton[Arduino.CMD_NUM];

	public void setVisible(boolean b) {
		frame.setVisible(b);
	}
	public void setEnabledAdminSetting(boolean b) {
		btn[Arduino.CMD_NUM - 1].setEnabled(b);;
	}
	public void addActionListenerInBtnCmd(int index, ActionListener l) {
		btn[index - '1'].addActionListener(l);
	}
	public void writeLabelConsole(String msg) {
		labelConsole.setText(msg);
	}



	public ArduinoWindow() {
		frame = new JFrame();

		JPanel panel = new JPanel();
		panel.setLayout(new GridLayout(3, 1));
		// 디버그 및 알림 창 생성하고 달기
		labelConsole = new JLabel("해당 버튼을 눌러서 제어해보세요 :)");
		panel.add(labelConsole);

		// 제어 버튼들 생성하고 달기
		JPanel btnPanel = new JPanel();
		// 기본 제어 버튼 6개
		btnPanel.setLayout(new GridLayout(3, 1));
		for(int i = 0; i < btn.length - 1; i++) {
			btn[i] = new JButton(Arduino.CMD_NAME[i]);
			btnPanel.add(btn[i]);
		}
		panel.add(btnPanel);
		// 관리자 세팅 버튼 1개
		btn[Arduino.CMD_NUM - 1] = new JButton(Arduino.CMD_NAME[Arduino.CMD_NUM - 1]);
		setEnabledAdminSetting(false);
		panel.add(btn[Arduino.CMD_NUM - 1]);

		frame.add(panel);
		frame.setTitle("스마트 홈 제어 v1.0 아두이노");
		//		frame.setVisible(true);
		frame.setSize(new Dimension(350,400));
		// terminating the program.
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		// centering.
		frame.setLocationRelativeTo(null);
		frame.setResizable(true);
	}
}
