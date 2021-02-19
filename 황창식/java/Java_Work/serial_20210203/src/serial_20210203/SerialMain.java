package serial_20210203;
public class SerialMain {
	public static void main(String[] args) {
		new MySerial().connect("COM7");
		System.out.println("포트 사용 가능");
	}
}