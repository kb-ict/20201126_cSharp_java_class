
public class Switch01 {

	public static void main(String[] args) {
		
	/*	int n= 4;
		if (n>=0 &&n<10)
		{
			System.out.println("0이상 10 미만의 수");
		}
		else if (n>=10 &&n<20)
		{
			System.out.println("10이상 20 미만의 수");
		}
		else if (n>=20 &&n<30)
		{
			System.out.println("20이상 30 미만의 수");
		}
		else 
		{
			System.out.println("음수 혹은 30 이상의 수");
		}
	 */
		int n2=24;
		switch(n2/10){
		case  0 :
			System.out.println("0이상 10 미만의 수");
			break;
		case 1: 
			System.out.println("10이상 20 미만의 수");
			break;
		case 2: 
			System.out.println("20이상 30 미만의 수");
			break;
		}
	}

}
