package name_maker;

import java.io.IOException;

public class Main {

	public static void main(String[] args) throws IOException {

		NameData newNames = new NameData();
		newNames.saveNames();
//		newNames.showNames();
		new MyFileWrite().fileWrite(newNames.getNames());
		new MyFileRead().fileRead();
	}

}
