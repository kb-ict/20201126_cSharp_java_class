
public class Switch04 {

	public static void main(String[] args) {
		// Math 수학 클래스 ,random() 메쏘드
		// 1~4 사이의 난수 뽑아줌
//		0~3
		int time=(int) (Math.random()*4)+8; 
		// math.random 은 원래 double형이라 강제로 int 변환
		System.out.println("현재시간: "+time);
	switch (time) {
	case 8:
		System.out.println("출근");
		break;
	case 9:
		System.out.println("회의");
		break;
	case 10:
		System.out.println("업무");
		break;
		
		
		
	default:
		System.out.println("출장");
		break;
	}





	}

}
