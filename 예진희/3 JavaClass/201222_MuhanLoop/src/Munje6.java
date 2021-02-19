
public class Munje6 {

	public static void main(String[] args) {
		// 6. 구구단 2 ~ 9단까지 출력

		String line = "-----------------------";
		System.out.println(line);
		System.out.println("    구구단 프로그램 v1.0");
		System.out.println(line);
		
		for (int j=0; j<9; j++) {
			for (int i = 0; (i+2) < 10; i++) { //9번 수행
				System.out.print((i+2)+"x"+(j+1)+"="+(i+2)*(j+1)+"	");
			
			}
			System.out.println();
		}
		
// 안에거 먼저 만들었음.. !
//		for (int i = 0; (i+2) < 10; i++) { //9번 수행
//			System.out.print((i+2)+"*"+(j+1)+"="+(i+2)*(j+1)+"  ");
//		}
	}
}
