package serial0217;

import java.io.IOException;

public class SerialMain {

	static Security security = new Security(){{putLoginInfo("guest1", "1111");putLoginInfo("guest2", "2222");}};

	public static void main(String[] args) throws IOException, InterruptedException {
		
		while(true) {
			security.login();
			Arduino arduino = new Arduino(security.isAdmin());
			arduino.start();
			arduino.join();
		}
	}
}