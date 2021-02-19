import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		String t[] = new String[s.nextInt()];
		for (int i = 0; i < t.length; i++) {
			int h = s.nextInt(), w = s.nextInt();
			int n = s.nextInt();
			String arr[][] = getRoomnum(h, w);
			String result = null;
			int roomnum = 0;
			for (int j = 0; j < arr.length; j++) {
				for (int k = 0; k < arr[j].length; k++) {
					roomnum++;
					if(roomnum == n) {
						result = arr[j][k];
					}
				}
			}
			t[i] = result;
		}
		
		for (int i = 0; i < t.length; i++) {
			System.out.println(t[i]);
		}
		
				
	}
	
	public static String[][] getRoomnum(int h, int w) {
		String[][] arr = new String[w][h];
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				if(i < 9) {
					arr[i][j] = Integer.toString(j+1) + "0" + Integer.toString(i+1);
				}
				else {
					arr[i][j] = Integer.toString(j+1) + Integer.toString(i+1);
				}
			}
		}
		return arr;
	}

}
