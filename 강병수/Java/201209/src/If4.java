import java.util.Scanner;

public class If4 {

	public static void main(String[] args) {
		Scanner abc = new Scanner(System.in);
		System.out.print("가위, 바위, 보 입력: ");
		String game = abc.next();
		System.out.println(game);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("가위, 바위, 보 게임 1.0");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.print("고길동 입력: ");
		String swordmaster = abc.next();
		System.out.print("둘리 입력: ");
		String Byungsin = abc.next();
		
		// String 문자열 비교
		if (swordmaster.equals("가위")) {
			if (Byungsin.equals("가위")) {
				System.out.println("무승부");
			}
			else if (Byungsin.equals("바위")) {
				System.out.println("둘리의 승리");
			}
			else if (Byungsin.equals("보")) {
				System.out.println("고길동의 승리");
			}
		}
		if (swordmaster.equals("바위")) {
			if (Byungsin.equals("가위")) {
				System.out.println("고길동의 승리");
			}
			else if (Byungsin.equals("바위")) {
				System.out.println("무승부");
			}
			else if (Byungsin.equals("보")) {
				System.out.println("둘리의 승리");
			}
		}		
		if (swordmaster.equals("보")) {
			if (Byungsin.equals("가위")) {
				System.out.println("둘리의 승리");
			}
			else if (Byungsin.equals("바위")) {
				System.out.println("고길동의 승리");
			}
			else if (Byungsin.equals("보")) {
				System.out.println("무승부");
			}
		}
		abc.close();
	}

}
