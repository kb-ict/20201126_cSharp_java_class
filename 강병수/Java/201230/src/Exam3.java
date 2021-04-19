import java.util.Arrays;

public class Exam3 {

	public static void main(String[] args) {
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("간단한 로또 프로그램 v1.1");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		int lotto[] = new int[6];
		for (int i = 0; i < 6; i++) {
			//로또 번호 생성
			lotto[i] = (int) (Math.random() * 45) + 1;

			//중복 확인 후 중복이면 다시 돌림
			for (int j = 0; j < i; j++) {
				if (lotto[i] == lotto[j]) {
					i--;
					break;
				}
			}
		}
		System.out.println("로또 번호: ");
		Arrays.sort(lotto);
		for (int i = 0; i < 6; i++) {
			System.out.print(lotto[i] + " ");
		}
	}

}
