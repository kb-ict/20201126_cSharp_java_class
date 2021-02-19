package serial210203;

public class SerialMain {
	public static void main(String[] args) {
		new MySerial().connect("COM5");
		System.out.println("포트 사용 가능!");
	}
}

//ln 찍어서 나오는데까지 확인 -> 디버깅