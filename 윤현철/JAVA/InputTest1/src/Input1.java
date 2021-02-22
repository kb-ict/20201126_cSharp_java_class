import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.printf("이름 입력 : ");
		String name = s.nextLine();
		System.out.printf("나이 입력 : ");
		int age = s.nextInt();
		System.out.println("이름 정보 : " + name);
		System.out.println("나이 정보 : " + age);
		s.close();
		
	}

}
