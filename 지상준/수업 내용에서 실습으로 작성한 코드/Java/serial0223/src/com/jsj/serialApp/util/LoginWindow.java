package com.jsj.serialApp.util;

import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

public class LoginWindow {
	private JFrame frame;
	private JLabel labelConsole;
	private JTextField idField;
	private JPasswordField pwField;
	private JButton btnSubmit;

	public String getId() {
		return idField.getText();
	}
	public String getPw() {
		return new String(pwField.getPassword());
	}
	public void setVisible(boolean b) {
		frame.setVisible(b);
	}
	public void addActionListenerInBtnSubmit(ActionListener l) {
		btnSubmit.addActionListener(l);
	}
	public void writeLabelConsole(String msg) {
		labelConsole.setText(msg);
	}
	public void clearInputField() {
		idField.setText("admin");
		pwField.setText("1234");
		writeLabelConsole("ID와 패스워드를 입력 후 제출해주세요 :)");
	}



	public LoginWindow() {
		frame = new JFrame();
		JPanel panel = new JPanel();

		// 디버그 및 알림 창
		labelConsole = new JLabel("ID와 패스워드를 입력 후 제출해주세요 :)");
		// 입력 양식
		JPanel inputPanel = new JPanel();
		idField = new JTextField("admin", 10); 
		pwField = new JPasswordField("1234", 10);
		inputPanel.setLayout(new GridLayout(2, 1));
		inputPanel.add(idField);
		inputPanel.add(pwField);
		// 제출 버튼
		btnSubmit = new JButton("제출");
		// 입력 양식, 제출 버튼
		JPanel loginPanel = new JPanel();
		loginPanel.setLayout(new GridLayout(1, 2));
		loginPanel.add(inputPanel);
		loginPanel.add(btnSubmit);
		// 적절하게 배치하기
		panel.setLayout(new GridLayout(2, 1));
		panel.add(loginPanel);
		panel.add(labelConsole);

		frame.add(panel);
		frame.setTitle("스마트 홈 제어 v1.0 로그인");
		//		frame.setVisible(true);
		frame.setSize(new Dimension(350,200));
		// terminating the program.
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		// centering.
		frame.setLocationRelativeTo(null);
		frame.setResizable(true);
	}
}
