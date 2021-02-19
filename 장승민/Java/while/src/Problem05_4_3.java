
public class Problem05_4_3 {

	public static void main(String[] args) {
		int i =1000;
		int sum =0;
		while (i>1) {
			i--;
			if (i%2==0 && i%7==0) {
				sum = sum+i;
				System.out.println(i);
			}
		
		}
		System.out.println(sum);
		
		
		
		
		
	}

}
