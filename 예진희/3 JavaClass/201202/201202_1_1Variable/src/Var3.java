
public class Var3 {

	public static void main(String[] args) {
		/*--참고--*/
		
		byte num = 'A'; // 정보표시 최소단위 oO0l1
		// bit (0,1) < byte (8bit) 1000바이트 = 1메가 (바이트) / 1000메가 = 1기가 (바이트)
		// 100바이트 =1024... 2의 n승....
		short char1 = 'B'; // 인트의 1/2
		char char2 = 66;
		long num2 = 9876543210L; // 관례: 대문자 표기
		
		System.out.println("num : " + num); 	//아스키코드 A
		System.out.println("char1 : " + char1);	//아스키코드 B
		System.out.println("char2 : " + char2);
		System.out.println("num2 : " + num2);
		
		int result = num + 32; 
		System.out.printf("num + 30 = %d\n",result);	//A의 아스키코드 65+30 = 95 (괄호 안 복잡시 사용), 데시말, 10진수, C:캐릭터
		System.out.printf("result : %c\n", result);
	}

}
