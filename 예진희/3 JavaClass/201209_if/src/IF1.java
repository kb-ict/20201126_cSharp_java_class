
public class IF1 {

	public static void main(String[] args) {
		int num = 99;
		
		if (num < 100) {
			System.out.println("num가 100보다 작다.");
		}
	}

}


/*
 * 제어문 if
 * 
 * 1) if (조건) { 중괄호 안 = 조건이 참이면 실행 
 * 실행문; 
 * }
 * 
 * 2) if (조건) {
 * 실행문 1;
 * } else {
 * 실행문 2;
 * }
 * 
 * 3) if (조건 n개) {
 * 실행문 1;
 * } else if (조건) {
 * 실행문 2;
 * }...else if n개...{
 * else {생략가능. else if만 반복가능, 충족하는 조건 실행 후 빠져나감
 * 실행문 0;
 * } 
 * 
 * 4) if (조건) {
 * 		if(조건 {
 * 		}
 * 	  }
 * 
 * 
 */