
public class GuguTwoNineWhile {

	public static void main(String[] args) {
		
		String line = "----------------------";
		System.out.println(line);
		System.out.println("구구단 프로그램 v1.0");
		System.out.println(line);
		int i=0 ,j=1;
		int res = 0;

		while (i<9) {

			while (j<9) {
				res = (j+1)*(i+1);
				System.out.printf("%dx%d=%d\t",(j+1),(i+1),res);
				j++;
				// 2x1 3x1 4x1 ''''
			}
			
			System.out.println(" ");
			i++;
			j=1;
			
		}
		
		
	}

}
