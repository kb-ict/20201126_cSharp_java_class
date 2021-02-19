
public class ClassYeje2 {
	public static void main(String[] args) {
		// 객체지향 설계
		// 1. 캡슐화 (변수를 노출x : 정보은닉, overloading, override)
		// 정보 바로접근 안맞음
		
		
		Student2 s = new Student2();
		s.setName("홍길동");
		s.setEmail("idid@example.com");
		s.setTel("000-0000-0000");
		
		System.out.println("이름\t: "		+s.getName());
		System.out.println("이메일\t: "	+s.getEmail());
		System.out.println("전화\t: "		+s.getTel());		
		System.out.println("과정\t: "		+Student2.category+"\n");	
		
		Student2 ss = new Student2();
		
		ss.setName("최길동");
		ss.setEmail("Chidid@example.com");
		ss.setTel("000-0000-0001");
		
		System.out.println("이름\t: "		+ss.getName());
		System.out.println("이메일\t: "	+ss.getEmail());
		System.out.println("전화\t: "		+ss.getTel());
		System.out.println("과정\t: "		+Student2.category);
		//_메인 메소드 안에서 객체 2개 생성됨
		
		
		//익명객체
		new Student2().setName("이길동");
		System.out.println(new Student2().getName());
		
		
		//_ 재사용 불가능 한번 생성하고 버림, 매개변수 전달용 (나중)
		//_ Student2* ss = new Student2();
		//_ 사용자 정의 타입*
		
		
	}
}

