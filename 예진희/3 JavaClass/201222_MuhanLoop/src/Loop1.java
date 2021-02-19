
public class Loop1 {

	public static void main(String[] args) {
		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < 3; j++) {
				// i = 0일 때, j = 0, 1, 2
				// i = 1일 때, j = 0, 1, 2

			}
		}
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 4; j++) {
				// i = 0일 때, j = 0, 1, 2, 3
				// i = 1일 때, j = 0, 1, 2, 3
				// i = 2일 때, j = 0, 1, 2, 3
				
				//12번 반복, 이중반복까지는 많이 씀

			}
		}
		
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 2; j++) {
				// i = 0일 때, j = 0, 1
				// i = 1일 때, j = 0, 1
				// i = 2일 때, j = 0, 1
				// i = 3일 때, j = 0, 1
				// ↑ 실제 동작횟수: i*j = 8
				System.out.printf("i%d, j: %d\n", i,j);

			}
		}
		
	}
}
