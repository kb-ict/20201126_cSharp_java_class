package com.jsj.serialApp.handler;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.HashMap;

import javax.swing.JOptionPane;

import com.jsj.serialApp.SerialMain;
import com.jsj.serialApp.util.LoginWindow;

public class Login {

	private HashMap<String, String> loginInfo = new HashMap<>();
	static public final String ADMIN_ID = "admin";
	private boolean isAdmin = false;
	private LoginWindow window;

	public Login() {
		putLoginInfo("admin", "1234");
	}
	public LoginWindow getLoginWindow() {
		if(window == null)
			window = new LoginWindow();
		return window;
	}
	public void putLoginInfo(String id, String pw) {
		loginInfo.put(id, encryptSHA256(pw));
	}
	private String encryptSHA256(String str) {

		String sha;
		try {
			MessageDigest sh = MessageDigest.getInstance("SHA-256");
			sh.update(str.getBytes());
			byte byteData[] = sh.digest();
			StringBuffer sb = new StringBuffer();
			for(int i = 0 ; i < byteData.length ; i++){
				sb.append(Integer.toString((byteData[i]&0xff) + 0x100, 16).substring(1));
			}

			sha = sb.toString();

		} catch(NoSuchAlgorithmException e){
			//e.printStackTrace();
			System.out.println("Encrypt Error - NoSuchAlgorithmException");
			sha = null;
		}

		return sha;
	}





	public boolean isAdmin() {
		return isAdmin;
	}
	private boolean isCorrectLoginInfo(String id, String pw) {
		if(!loginInfo.containsKey(id))
			return false;

		if(encryptSHA256(pw).equals(loginInfo.get(id)))
			return true;
		else
			return false;
	}
	public void runLogin() throws IOException {

		window.addActionListenerInBtnSubmit(new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent e) {

				String id = null;
				String pw = null;

				id = window.getId();
				pw = window.getPw();

				if(isCorrectLoginInfo(id, pw)) {
					if(Login.ADMIN_ID.equals(id))
						isAdmin = true;
					else
						isAdmin = false;
					JOptionPane.showMessageDialog(null, "환영합니다 !!");
					window.clearInputField();
					fireLoginEvent(new LoginEvent("올바른 입력정보입니다. 아두이노를 실행해야해 !!"));
				}
				else {
					window.clearInputField();
					window.writeLabelConsole("잘못입력하셨습니다 !!");
				}
			}
		});
	}

	private void fireLoginEvent(LoginEvent event) {
		Object[] listeners = SerialMain.loginListenerList.getListenerList();

		for (int i = listeners.length - 2; i >= 0; i -= 2) {
			if (listeners[i] == LoginEventListener.class) {
				((LoginEventListener)listeners[i + 1]).loginEvent(event);
			}
		}
	}
}