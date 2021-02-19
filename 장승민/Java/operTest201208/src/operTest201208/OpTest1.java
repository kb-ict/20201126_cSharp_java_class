package operTest201208;

public class OpTest1 {

	public static void main(String[] args) {
		
		int num1 =2, num2 = 3, num3 =4 ;
		
		
		//연산자 우선순위
		//() > *,/ > +,-
		int result = num1 + num2 - num3;
		System.out.println("result : "+ result);
		
		// 괄호를 먼저 처리
		int result2 = num1 + (num2 - num3);
		System.out.println("result2 : "+result2);
		
		//* > +
		result = num1 + num2 * num3 ;
		System.out.println("result : " + result);
		
		//(+) > *
		result = (num1 + num2) * num3 ;
		System.out.println("result : " + result);		
		
		//
		result = num1 * num2 / num3 ;
		System.out.println("result : " + result);	
		
		// % 나머지 연산자 : 4를 3으로 나눈 나머지
		result = num3 % num2 ;
		System.out.println("result : "+result);
		
		
		
		

	}

}
