
public class Switch4 {

	public static void main(String[] args) {
		// Math 수학을 담당하는 클래스, random() 메소드
		// 0 ~ 3
		int time = (int) (Math.random()*4);
		System.out.println("현재 시간: " + time);
		// (0 ~ 3) + 8
		int time2 = (int) (Math.random()*4)+8;
		System.out.println("현재 시간: " + time2);
		switch (time2) {
		case 8:
			System.out.println("출근");
		case 9:
			System.out.println("회의");
		case 10:
			System.out.println("업무");
		default:
			System.out.println("출장");
		}
	}

}
