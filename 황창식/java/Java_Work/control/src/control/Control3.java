package control;

public class Control3 {

	public static void main(String[] args) {

		// break
		int num3 = 1;
		boolean search = false;

		while (num3 < 100) {
			if (((num3 % 5) == 0) && ((num3 % 7) == 0)) {
				search = true;
				break;
			}
			num3++;
		}

		if (search)
			System.out.println("찾는 정수 : " + num3);
		else
			System.out.println("5의 배수이자 7의 배수인 수를 찾지 못했습니다.");

		System.out.println("---------------------");

		// continue
		int num4 = 0;
		int count = 0;

		while ((num4++) < 100) {
			if (((num4 % 5) != 0) || ((num4 % 7) != 0)) {
				continue;

			}
			count++;
			System.out.println(num4);
		}
		System.out.println("count : " + count);

	}

}
