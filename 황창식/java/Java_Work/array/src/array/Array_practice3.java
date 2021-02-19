package array;

import java.util.Scanner;

public class Array_practice3 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("수를 3개 입력하세요 : ");
		int result = s.nextInt() * s.nextInt() * s.nextInt();
		
		String number = Integer.toString(result);
		char[] numarr = new char[number.length()];
		
		for (int i = 0; i < 10; i++) {
			int count = 0;
			for(int j = 0; j < numarr.length; j++) {
				numarr[j] = (number.charAt(j));
				int num = Character.getNumericValue(numarr[j]);
				if(num == i) {
					count++;
				}
			}
			System.out.println(i + "의 갯수 : " + count);
			
		}

	}

}
