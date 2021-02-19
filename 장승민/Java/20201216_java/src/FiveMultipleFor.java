
public class FiveMultipleFor {

	public static void main(String[] args) {

		
		String line = "-------------------------";
		System.out.println(line);
		System.out.println("5의 배수 출력 프로그램 v1.0");
		System.out.println(line);
		
	
		for (int i = 0; i < 100; i++) {
			if ((i+1)%5==0) {
				System.out.printf("%d ",i+1);
			}
		}
		
	}

}
