package variable_20201202;

public class LocalVariable {

	public static void main(String[] args) {

		boolean ste = true;
		int num1 = 11;
		
		if(ste) {
			// int num1 = 22  // 주석 해제하면 컴파일 오류 발생
			num1++;
			System.out.println(num1);
		}
		
		{
			int num2 = 33;
			num2++;
			System.out.println(num2);
		}
		
		// System.out.println(num2);  // 주석 해제하면 컴파일 오류 발생

	}

}
