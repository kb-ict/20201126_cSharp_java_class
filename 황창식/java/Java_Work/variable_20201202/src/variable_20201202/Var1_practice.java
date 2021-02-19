package variable_20201202;

public class Var1_practice {

	public static void main(String[] args) {

		// 변수 정보들
		String line1 = "────────────────────────";
		String line2 = "------------------------";
		String title = "     ※개인 신상 정보※";
		String name = "홍길동";
		int age = 100;
		char se = '남';
		float weight = 65.5f; // 몸무게
		double height = 178.6; // 키
		String adr = "조선 한양 홍대감댁";

		// 출력
		System.out.println(line1);
		System.out.println(title);
		System.out.println(line1);
		System.out.println("1. 이름 : " + name);
		System.out.println(line2);
		System.out.println("2. 나이 : " + age + "살");
		System.out.println(line2);
		System.out.println("3. 성별 : " + se);
		System.out.println(line2);
		System.out.println("4. 체중 : " + weight + "kg");
		System.out.println(line2);
		System.out.println("5. 신장 : " + height + "cm");
		System.out.println(line2);
		System.out.println("6. 주소 : " + adr);
		System.out.println(line1);

	}

}
