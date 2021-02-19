import java.util.Scanner;

public class IF5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		// s.next()= 엔터제외 / s.nextln()=엔터까지 받아들임
		
		String line = "----------------------";
		
		System.out.println(line);
		System.out.println("  가위 바위 보 게임 1.0");
		System.out.println(line);
		System.out.print("- 홍길동 입력: ");
		String hong = s.next();
		System.out.print("- 김길동 입력: ");
		String kim = s.next();
		
		// String 문자열 비교
		if (hong.equals("가위")) {
			if (kim.equals("가위")) {
				System.out.println("비겼습니다.");
			}
			else if (kim.equals("바위")) {
				System.out.println("김이 이겼습니다.");
			}
			else if(kim.equals("보")) {
				System.out.println("홍이 이겼습니다.");
				
			}
		}
		
		else if (hong.equals("바위")) {
			if (kim.equals("가위")) {
				System.out.println("홍이 이겼습니다.");
			}
			else if (kim.equals("바위")) {
				System.out.println("비겼습니다.");
			}
			else {
				System.out.println("김이 이겼습니다.");
				
			}
		}
		
		else {//홍길동 --> 보
			if (kim.equals("가위")) {
				System.out.println("김이 이겼습니다.");
			}
			else if (kim.equals("바위")) {
				System.out.println("홍이 이겼습니다.");
			}
			else{
				System.out.println("비겼습니다.");
				
				s.close();
			}
			
		}
	}
	
}
