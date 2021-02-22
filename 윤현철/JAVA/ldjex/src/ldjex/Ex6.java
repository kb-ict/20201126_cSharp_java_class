package ldjex;

import java.util.Scanner;

public class Ex6 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		while(true) {
			int a = s.nextInt();
			int b = s.nextInt();
		
			if (a>0) {
				if (b>0) {
					System.out.println("1");
				}
				else if (b<0) {
					System.out.println("4");
				}
			}
			else if (a<0) {
				if (b>0) {
					System.out.println("2");
				}
				else if (b<0) {
					System.out.println("3");
				}
			}
			else if (a==0||b==0) {
				System.out.println("0이외의 숫자를 입력하세요");
				continue;
			}
			s.close();
			break;
		}
			}
		
}	


