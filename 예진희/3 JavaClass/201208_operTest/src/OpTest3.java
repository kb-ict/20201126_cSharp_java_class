
public class OpTest3 {

	public static void main(String[] args) {
		// 논리 연산자
		// 제어문 if에서 많이 활용.
		int num1 = 100, num2 = 200;
		
		// == 같다
		System.out.println("[== 연산자] "+num1+"은 "+num2+"과 같다: " + (num1 == num2));
		
		// != 다르다
		System.out.println("[!= 연산자] "+num1+"은 "+num2+"과 다르다: " + (num1 != num2));
		
		// == 대, 소 비교
		System.out.println("[> 연산자] " +num1+"은 "+num2+"보다 크다: "+ (num1 > num2));
		System.out.println("[< 연산자] " +num1+"은 "+num2+"보다 작다: "+ (num1 < num2));	
		
		// == 크거나 같다, 작거나 같다
		System.out.println("[>= 연산자] " +num1+"은 "+num2+"보다 크거나 같다: "+ (num1 >= num2));
		System.out.println("[<= 연산자] " +num1+"은 "+num2+"보다 작거나 같다: "+ (num1 <= num2));

	}

}
