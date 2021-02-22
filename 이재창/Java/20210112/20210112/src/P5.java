public class P5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		NameData nd = new NameData();
		MyFileWrite mfw = new MyFileWrite();
		mfw.write(nd.getNames());
		MyFileRead mfr = new MyFileRead();
		mfr.readShow();		
	}

}
