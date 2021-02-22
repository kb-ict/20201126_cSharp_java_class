
public class Ex3 {

	public static void main(String[] args) {
		int[] a=new int [10];
		for (int i = 0; i < a.length; i++) {
			a[i]= (int)((Math.random()*100))+1;
		}
		fonc(a);
	}
	
	public static void fonc(int a[]) {
		for (int i = 0; i < a.length; i++) {
			if(a[i]%2==0) {
				System.out.printf("%d는 짝수입니다.\n",a[i]);
			}
			else {
				System.out.printf("%d는 홀수입니다.\n",a[i]);
			}
		}
	}
}
