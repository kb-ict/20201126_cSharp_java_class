package ldjex;

import java.util.Scanner;

public class Ex8 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int a =s.nextInt();
		int sum = 1;
		int i=0;
		while(true) {
			sum=sum+(6*i);
			if (sum<a) {
				i++;
				continue;
			}
			else {
				System.out.printf("%d는 %d개 방을 지난다",a,i+1);
			}
			s.close();
			break;
		}

	}

}
