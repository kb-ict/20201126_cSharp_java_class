
public class Switch4 {

	public static void main(String[] args) {
		// Math : 수학 클래스, random() 메쏘드
		// 0 ~ 3 사이의 숫자 랜덤으로 pick
		int time = (int) (Math.random() * 4) + 8;
		System.out.println("현재시간 : " + time + "시");
		switch (time) {
		case 8:
			System.out.println("8시 : 출근");
		case 9:
			System.out.println("9시 : 회의");
		case 10:
			System.out.println("10시 : 업무");
		default:
			System.out.println("11시 : 출장");
		}

	}

}
