
public class Method5 {
	public static void divide(int num1, int num2) {
		//num1: 분자 , num2:분모
		if (num2==0) {// if(!num2)
			System.out.println("0으로 나눌수 없습니다.");
			return;//void method에서 return을 사용하면 메쏘드 종료
		}
		System.out.println("나눗셈 결과: " +(num1/num2));
	}
	public static void main(String[] args) {
		divide(4,2);
		divide(4,0);
		System.out.println("메인() 종료");
	}

}
