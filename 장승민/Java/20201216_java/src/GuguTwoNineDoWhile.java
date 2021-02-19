
public class GuguTwoNineDoWhile {

	public static void main(String[] args) {

		String line = "----------------------";
		System.out.println(line);
		System.out.println("구구단 프로그램 v1.0");
		System.out.println(line);
		
		int i=0,j=1;
		int res=0;
		do {
			do {
				res=(j+1)*(i+1);
				System.out.printf("%dX%d=%d\t",(j+1),(i+1),res);
				j++;
			} while (j<9);
			System.out.println(" ");
			i++;
			j=1;
		} while (i<9);
		
	}

}
