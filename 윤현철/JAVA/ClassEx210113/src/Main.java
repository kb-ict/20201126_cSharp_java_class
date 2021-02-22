
public class Main {

	public static void main(String[] args) {
		System.out.println(SingleTest.getInstance().getData());
	}

}
class SingleTest{
	private static SingleTest inst;
	private int data;
	SingleTest(){
		data = (int)(Math.random()*100);
	}
	public static SingleTest getInstance() {
		if(inst==null) {
			inst = new SingleTest();
		}
		return inst;
		
	}
	public int getData() {
		return data;
	}
}