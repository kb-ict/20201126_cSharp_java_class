import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("태어난 해를 입력하시오");
		int year = sc.nextInt();
		sc.close();

		switch (year % 12) {
		case 1:
			System.out.println(year + "년생은 닭띠 입니다");
			break;
		case 2:
			System.out.println(year + "년생은 개띠 입니다");
			break;
		case 3:
			System.out.println(year + "년생은 돼지띠 입니다");
			break;
		case 4:
			System.out.println(year + "년생은 쥐띠 입니다");
			break;
		case 5:
			System.out.println(year + "년생은 소띠 입니다");
			break;
		case 6:
			System.out.println(year + "년생은 호랑이띠 입니다");
			break;
		case 7:
			System.out.println(year + "년생은 토끼띠 입니다");
			break;
		case 8:
			System.out.println(year + "년생은 용띠 입니다");
			break;
		case 9:
			System.out.println(year + "년생은 뱀띠 입니다");
			break;
		case 10:
			System.out.println(year + "년생은 말띠 입니다");
			break;
		case 11:
			System.out.println(year + "년생은 양띠 입니다");
			break;
		case 0:
			System.out.println(year + "년생은 원숭이띠 입니다");
			break;
		}

	}

}
