public class myPulee6 {// 5¹ø ¹®Á¦

	public static void main(String[] args) {
		int[][] arr = new int[9][8];
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				
				System.out.printf("%dx%d=%d\t",j+2,i+1,(j+2)*(i+1));
			}System.out.println();
		}
	}

}
