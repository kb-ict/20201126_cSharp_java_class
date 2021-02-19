package huge_number;

import java.math.BigInteger;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		BigInteger bignumber1 = new BigInteger(s.next());
		BigInteger bignumber2 = new BigInteger(s.next());
		
		System.out.println(bignumber1.add(bignumber2));
		

	}

}
