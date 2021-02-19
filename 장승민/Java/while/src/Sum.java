
public class Sum {

	public static void main(String[] args) {
		int num = 0;
		int sum = 0;
		
		do {
			sum = num+sum;
			num++;
		} while (num<100);
		
		System.out.println("1부터 99까지의 합은"+sum);
	}

}
