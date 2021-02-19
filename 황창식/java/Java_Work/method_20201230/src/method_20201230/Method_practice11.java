package method_20201230;

public class Method_practice11 {
	public static void main(String[] args) {
		int arr[][] = getScore();
		int hap = 0;
		int ave = 0;
		for (int i = 0; i < arr.length; i++) {
			System.out.print(i + 1 + "번 학생 점수 : ");
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j] + " ");
				hap += arr[i][j];
			}
			System.out.println();
			System.out.println(i+1 + "번 학생 총점 : " + hap);
			ave = hap/3;
			System.out.print(i+1 + "번 학생 평균 : " + ave);
			if(ave <= 100 && ave >= 90)
				System.out.println(" A학점");
			else if(ave <= 89 && ave >= 80)
				System.out.println(" B학점");
			else if(ave <= 79 && ave >= 70)
				System.out.println(" C학점");
			else if(ave <= 69 && ave >= 60)
				System.out.println(" D학점");
			else
				System.out.println(" F학점");
			System.out.println("-------------------");
			hap = 0;
			ave = 0;
			
		}
		
	}
	
	public static int[][] getScore(){
		int arr[][] = new int[5][3];
		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = (int)(Math.random() * 51) + 50;
			}
		}
		
		return arr;
	}
}
