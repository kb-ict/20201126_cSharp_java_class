
public class Ex019 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("---------------------");
		System.out.println(" 구구단 프로그램 v1.0");
		System.out.println("---------------------");
		int a = 1;
		for (int b = a; b < 10; b++) {
			for(int c = a + 1; c < 10; c++) {
				System.out.print(c + " * " + b + " = " + (b * c) + "	");
			}
			System.out.println();
		}
	}

}
