package silsupMunje.com.yjh.student1;

import java.util.Random;

public class Main_munje1 {

	public static void main(String[] args) {
		String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
		int age[] = { 20, 25, 30, 35, 40 };
		char gender[] = { '남', '여' };
		String address[] = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
		Random r = new Random();
		
		Student[] s = new Student[10];
//		s[0] = new Student(name,age,gender,address);
		
		for (int i = 0; i < s.length; i++) {
			s[i] = new Student(name[r.nextInt(name.length)],age[r.nextInt(age.length)],
					gender[r.nextInt(gender.length)],address[r.nextInt(address.length)]);
			System.out.println((i+1)+"번째 -----------");
			s[i].showStudent();
		}
		
		System.out.println("10번째 -----------");
		s[9] = new Student("전우치",24,'남',"조선 한양인근 두메산골");
		s[9].showStudent();
		
		
		
	
	}
	

}
