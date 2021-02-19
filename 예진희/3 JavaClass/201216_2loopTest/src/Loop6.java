
public class Loop6 {

	public static void main(String[] args) {
		int hap = 0;
		int i = 0;
		
		while (i<10) {
			hap = hap + (i+1); // hap += (i+1)
			i++;
			
		}
		System.out.println("while문");
		System.out.println("1~10까지의 합: "+hap);
		System.out.println();
		
		System.out.println("do while문");
		hap = 0;
		i = 0;
		
		do {
			hap += (i+1);
			i++;
		} while (i<10);
		System.out.println("1~10까지의 합: "+hap);
		}
	}


