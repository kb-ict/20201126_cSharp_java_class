
public class Loop1 {

	public static void main(String[] args) {
		for(int i=0; i<2; i++) {
			for(int j=0; j<3; j++) {
				// i가 0일때, j= 0, 1, 2
				// i가 1일때, j= 0, 1, 2
				
			}
		}
		for(int i=0; i<3; i++) {
			for(int j=0; j<4; j++) {
				// i가 0일때, j= 0, 1, 2, 3
				// i가 1일때, j= 0, 1, 2, 3
				// i가 2일때, j= 0, 1, 2, 3
			}
		}
		for(int i=0; i<4; i++) {
			for(int j=0; j<2; j++) {
				// i가 0일때, j= 0 , 1
				// i가 1일때, j= 0 , 1
				// i가 2일때, j= 0 , 1
				// i가 3일때, j= 0 , 1
				System.out.printf("i:%d, j:%d\n", i, j);
			}
		}
	}

}
