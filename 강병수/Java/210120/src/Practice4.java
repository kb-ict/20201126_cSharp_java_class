
public class Practice4 {

	public static void main(String[] args) {
		int Arr[][] = new int[4][5];
		int value = 1;
		for(int i = 0; i<Arr.length; i++) {
			for(int j = 0; j<Arr[3].length; j++) {
				Arr[i][j] = value++;
			}
		}
		for(int i = 0; i<Arr.length; i++) {
			for(int j = 0; j<Arr[3].length; j++) {
				System.out.printf(Arr[i][j]+"\t");
			}
			System.out.println("");
		}
	}

}
