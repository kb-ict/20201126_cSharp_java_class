
public class Switch1 {

	public static void main(String[] args) {
		char grade = 'A'; //학점
		switch (grade) {
		case 'A':
			System.out.println("A학점");
			break;
		case 'B':
			System.out.println("B학점");
			break;
		case 'C':
			System.out.println("C학점");
			break;
		default:
			System.out.println("F학점");
			break;
		}
	}

}
