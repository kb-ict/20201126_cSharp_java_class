
public class Pulee_mine1 {

	public static void main(String[] args) {
		/*1. Short 타입의 변수를 아래와 같이 덧셈하였더니, 
		 * 컴파일 에러가 발생하였다. 이를 해결하시오.
		 * class OperatePromotion {
		 *		public static void main(String[] args) {
		 *			short num1 = 22;
		 *			short num2 = 11;
		 *			short result = num1+num2;
		 *			System.out.println(result);
		 *  	}
		 *  }--------------------------------------------------
		 */		
	}
}
class OperatePromotion {
    public static void main(String[] args) {
      short num1 = 22;
      short num2 = 11;
      short result = (short)(num1+num2);
      System.out.println(result);
 }
}