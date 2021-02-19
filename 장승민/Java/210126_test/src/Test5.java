import java.util.Scanner;

public class Test5 {

	public static void main(String[] args) {
//		Scanner 클래스 호출
		Scanner sc = new Scanner(System.in);
		String st = sc.next();		// st라는 이름의 변수에 문자열 입력값 저장
		sc.close();
		
		char[] ch =new char[st.length()];		//ch이라는 배열변수에 st변수의 길이만큼 공간 생성
		
		for (int i = 0; i < ch.length; i++) {	//ch배열 각 칸에 st각 자리수 마다 문자 저장
			ch[i]=st.charAt(i);
		};
		
		for (int i = 97; i < 123; i++) {		//num 메쏘드 호출
			num(ch,(char)i);
		}


	}
	public static void num(char[] ch, char c) {	//num 메쏘드 생성(매개변수 배열, 문자)
	
		int cnt=0;								//카운트를 위한 변수 생성 및 초기화
		for (int i = 0; i < ch.length; i++) {	//
			if(ch[i]==c) cnt++;
		};
		if (cnt>0) {
			System.out.println("'"+c+"'는"+cnt+"글자입니다.");
		}
		
	}
}

