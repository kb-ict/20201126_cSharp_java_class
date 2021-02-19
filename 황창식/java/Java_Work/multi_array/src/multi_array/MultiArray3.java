package multi_array;

public class MultiArray3 {

	public static void main(String[] args) {

		int[][] ar1 = new int[][] { 
				{11, 22, 33}, // 1행 초기화
				{44, 55, 66}, // 2행 초기화
				{77, 88, 99}  // 3행 초기화
		};
		// 위와 아래는 같은 배열
		int[][] ar2 = { 
				{11, 22, 33}, 
				{44, 55, 66}, 
				{77, 88, 99} 
		};
		
		int[][] ar3 = {
				{11},
				{22, 33},
				{44, 55, 66}
		};

		for(int i = 0; i < ar3.length; i++) {
			for(int j = 0; j < ar3[i].length;j++) {
				System.out.print(ar3[i][j] + "\t");
			}
			System.out.println();
		}
		
		
		
	}

}
