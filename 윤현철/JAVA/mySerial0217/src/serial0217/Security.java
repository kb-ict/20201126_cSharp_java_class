package serial0217;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.HashMap;

public class Security {

	private HashMap<String, String> loginInfo = new HashMap<>();
	static public final String ADMIN_ID = "admin";
	private boolean isAdmin = false;
	
	public Security() {
		putLoginInfo("admin", "1234");
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
	public void login() throws IOException {
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String id = null;
		String pw = null;

		System.out.println("------------------------------");
		System.out.println(" 스마트 홈 제어 로그인");
		System.out.println("------------------------------");

		while(true) {
			System.out.print("ID : ");
			id = br.readLine();
			System.out.print("PW: ");
			pw = br.readLine();

			if(isCorrectLoginInfo(id, pw)) {
				System.out.println("환영합니다 !!");
				break;
			}
			System.out.println("잘못입력하셨습니다 !!");
		}

		if(Security.ADMIN_ID.equals(id))
			isAdmin = true;
		else
			isAdmin = false;
	}
}