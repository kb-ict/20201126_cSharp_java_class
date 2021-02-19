public class Exam2 {

	public static void main(String[] args) {
		String line = "-------------------------";
		System.out.println(line);
		System.out.println("  5의 배수 출력 프로그램 v1.0");
		System.out.println(line);
		int i = 0;
		
		System.out.println("for이용\n------------------");
		for (i = 0; i <= 100; i++) {
			if((i+1)%5==0) {
				System.out.print((i+1)+", ");
			}
		}
		
		System.out.println();
		System.out.println();
		System.out.println("while이용\n------------------");
		i = 0;
		while (i<100) {
			i++;
			if(i%5==0) {
				System.out.print(i+", ");	
			}
			
		}
		
		
		System.out.println();
		System.out.println();
		System.out.println("do while이용\n------------------");
		i = 0;
		do {
			if((i+1)%5==0) {
				System.out.print((i+1)+", ");
			}
			
			i++;
		} while (i<100);

	}

}
