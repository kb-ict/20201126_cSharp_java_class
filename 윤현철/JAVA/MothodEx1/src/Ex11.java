
public class Ex11 {

	public static void main(String[] args) {
		int[][] a=func();
		int[] b = new int [5];
		int[] c = new int [5];
		String d[] = new String[5];
		for (int i = 0; i < b.length; i++) {
			b[i]=a[i][0]+a[i][1]+a[i][2];
		}
		for (int i = 0; i < b.length; i++) {
			c[i]=b[i]/3;
		}
		for (int i = 0; i < d.length; i++) {
			if(c[i]>=90) {
				d[i]="A학점";
			}
			else if(c[i]>=80) {
				d[i]="B학점";
			}
			else if(c[i]>=70) {
				d[i]="C학점";
			}
			else if(c[i]>=60) {
				d[i]="D학점";
			}
			else if(c[i]>=50) {
				d[i]="E학점";
			}
			else if(c[i]<50){
				d[i]="F학점";
			}
		}
		for (int i = 0; i < b.length; i++) {
			System.out.printf("%d번째 학생의 총점은 %d점이고 평균은 %d점이고 학점은 %s이다.\n",i+1,b[i],c[i],d[i]);
		}
	}
	public static int[][] func(){
		int[][] a = new int[5][3];
		for (int i = 0; i < a.length; i++) {
			for (int j = 0; j < a[i].length; j++) {
				a[i][j]=(int)((Math.random())*101);
			}
		}
		return a;
	}
}
