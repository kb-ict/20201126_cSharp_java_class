import java.util.Scanner;

public class If5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("-------------------");
		System.out.println("가위 바위 보 게임 1.0 ");
		System.out.println("-------------------");
		System.out.print("홍길동 입력 : ");
		String hong = s.next();
		System.out.print("김길동 입력 : ");
		String kim = s.next();
		
		if (hong.equals("가위")) {
			if(kim.equals("가위")) {
				System.out.println("비겼습니다.");
			}
			else if (kim.equals("바위")) {
				System.out.println("김길동이 이겼습니다.");
			}
			else {
				System.out.println("홍길동이 이겼습니다.");
			}
		}
		else if (hong.equals("바위")) {
			if(kim.equals("가위")) {
				System.out.println("홍길동이 이겼습니다.");
			}
			else if (kim.equals("바위")) {
				System.out.println("비겼습니다.");
			}
			else {
				System.out.println("김길동이 이겼습니다.");
			}
		}
		else {
			if(kim.equals("가위")) {
				System.out.println("김길동이 이겼습니다.");
			}
			else if (kim.equals("바위")) {
				System.out.println("홍길동이 이겼습니다.");
			}
			else {
				System.out.println("비겼습니다.");
			}
		}
		s.close();
	}

}
