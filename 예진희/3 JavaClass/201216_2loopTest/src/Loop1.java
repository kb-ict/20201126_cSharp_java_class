
public class Loop1 {

	public static void main(String[] args) {
//		for (int i=0; i<5; i++) {
//			System.out.println("반복 횟수: "+ (i+1));
//		}
		/*
		 * 초깃값 변수 보통 i부터.. i~j, ijk~...
		 * i는 가급적 0부터시작 = 배열때문에 배열이 0부터 시작
		 * 디버깅 = 값 줄여서... 10만번 => 10번정도
		 */
		
		for (int j=5; j>0; j--) {
			System.out.println("반복 횟수: "+ j);
		}
	}

}
