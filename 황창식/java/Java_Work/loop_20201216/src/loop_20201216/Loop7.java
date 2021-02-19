package loop_20201216;

public class Loop7 {

	public static void main(String[] args) {

		int hap = 0;
		for (int i = 0; i < 10; i++) {
			if ((i + 1) % 3 == 0) {
				continue; // => 반복문 처음으로 이동 (하위 단계들 실행 x)
			}

			if (i + 1 == 5) {
				System.out.println("탈출");
				break; // => 반복문 탈출
			}
			hap += i + 1;
			System.out.println("i + 1 = " + (i + 1));
		}
		System.out.println("1 ~ 10중 3의 배수를 제외한 모든 수의 합 : " + hap);

	}

}
