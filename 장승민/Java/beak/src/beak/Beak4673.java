package beak;

public class Beak4673 {

	public static void main(String[] args) {
		
		System.out.println(d(9902));

	}
	
	public static int d(int a) {
		if (a<10) {
			a=a+a;
		}
		else if(a>=10&&a<100) a = a + a/10 + a%10;
		else if(a>=100&&a<1000) a = a + a/100 + (a/100)/10 + a%10;
		else if(a>=1000&&a<10000) a = a +a/1000 + (a/1000)/100 + ((a/1000)/100)/10 + a%10;
		
		return a;
	}
}
