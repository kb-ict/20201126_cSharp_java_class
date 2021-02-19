import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int x = s.nextInt();
		int y = s.nextInt();
		switch(x) {
		
		case 1:
		case 10:
			if(y%7 == 1)
				System.out.println("MON");
			else if(y%7 == 2)
				System.out.println("TUE");
			else if(y%7 == 3)
				System.out.println("WED");
			else if(y%7 == 4)
				System.out.println("THU");
			else if(y%7 == 5)
				System.out.println("FRI");
			else if(y%7 == 6)
				System.out.println("SAT");
			else if(y%7 == 0)
				System.out.println("SUN");
			break;
		
		case 2:
		case 3:
		case 11:
			if(y%7 == 1)
				System.out.println("THU");
			else if(y%7 == 2)
				System.out.println("FRI");
			else if(y%7 == 3)
				System.out.println("SAT");
			else if(y%7 == 4)
				System.out.println("SUN");
			else if(y%7 == 5)
				System.out.println("MON");
			else if(y%7 == 6)
				System.out.println("TUE");
			else if(y%7 == 0)
				System.out.println("WED");
			break;
		
		case 4:
		case 7:
			if(y%7 == 1)
				System.out.println("SUN");
			else if(y%7 == 2)
				System.out.println("MON");
			else if(y%7 == 3)
				System.out.println("TUE");
			else if(y%7 == 4)
				System.out.println("WED");
			else if(y%7 == 5)
				System.out.println("THU");
			else if(y%7 == 6)
				System.out.println("FRI");
			else if(y%7 == 0)
				System.out.println("SAT");
			break;
		case 5:
			if(y%7 == 1)
				System.out.println("TUE");
			else if(y%7 == 2)
				System.out.println("WED");
			else if(y%7 == 3)
				System.out.println("THU");
			else if(y%7 == 4)
				System.out.println("FRI");
			else if(y%7 == 5)
				System.out.println("SAT");
			else if(y%7 == 6)
				System.out.println("SUN");
			else if(y%7 == 0)
				System.out.println("MON");
			break;
		case 6:
			if(y%7 == 1)
				System.out.println("FRI");
			else if(y%7 == 2)
				System.out.println("SAT");
			else if(y%7 == 3)
				System.out.println("SUN");
			else if(y%7 == 4)
				System.out.println("MON");
			else if(y%7 == 5)
				System.out.println("TUE");
			else if(y%7 == 6)
				System.out.println("WED");
			else if(y%7 == 0)
				System.out.println("THU");
			break;
		case 8:
			if(y%7 == 1)
				System.out.println("WED");
			else if(y%7 == 2)
				System.out.println("THU");
			else if(y%7 == 3)
				System.out.println("FRI");
			else if(y%7 == 4)
				System.out.println("SAT");
			else if(y%7 == 5)
				System.out.println("SUN");
			else if(y%7 == 6)
				System.out.println("MON");
			else if(y%7 == 0)
				System.out.println("TUE");
			break;
		case 9:
		case 12:
			if(y%7 == 1)
				System.out.println("SAT");
			else if(y%7 == 2)
				System.out.println("SUN");
			else if(y%7 == 3)
				System.out.println("MON");
			else if(y%7 == 4)
				System.out.println("TUE");
			else if(y%7 == 5)
				System.out.println("WED");
			else if(y%7 == 6)
				System.out.println("THU");
			else if(y%7 == 0)
				System.out.println("FRI");
			break;
		
		}

	}

}
