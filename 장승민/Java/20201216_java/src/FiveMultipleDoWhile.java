
public class FiveMultipleDoWhile {

	public static void main(String[] args) {

		String line = "-------------------------";
		System.out.println(line);
		System.out.println("5의 배수 출력 프로그램 v1.0");
		System.out.println(line);
		int cnt=0;
		
		do {
			if ((cnt+1)%5==0) {
				System.out.printf("%d ",cnt+1);
			}
			cnt++;
		} while (cnt<100);
	}

}
