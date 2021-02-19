import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		
		int x1 = s.nextInt(); // 첫번째 터렛의 x좌표
		int y1 = s.nextInt(); // 첫번째 터렛의 y좌표
		int r1 = s.nextInt();
		int x2 = s.nextInt(); // 두번째 터렛의 x좌표
		int y2 = s.nextInt(); // 두번째 터렛의 y좌표
		int r2 = s.nextInt();
		
		int r1x = 0;
		int r1y = 0;
		
		for (int i = 0; i < r1; i++) {
			for (int j = 0; j < r1; j++) {
				if((i*i) + (j*j) == (r1*r1)) {
					r1x = i;
					r1y = j;
				}
			}
		}
		
		int r2x = 0;
		int r2y = 0;
		
		for (int i = 0; i < r2; i++) {
			for (int j = 0; j < r2; j++) {
				if((i*i) + (j*j) == (r2*r2)) {
					r2x = i;
					r2y = j;
				}
			}
		}
		
		if(x1 == x2 && y1 == y2) {
			if(r1 == r2) 
				System.out.println(-1);
			else {
				System.out.println(0);
			}
		}
		else if(x1 == x2 && y1 != y2) {
			if(y1 + r1 == y2 + r2 || y1 - r1 == y2 + r2 || y1 + r1 == y2 - r2 || y1 - r1 == y2 - r2) {
				System.out.println(1);
			}
			else if(y1 + r1  < y2 + r2) {
				
			}
		}
		
		
		
		
		
		
	}
	

}
