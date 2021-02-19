package kb311;

public class sample3 {
	
	public static void main(String[] args) {
		//문제 3-2
		Student s1 = new Student("이동준", 2009038033, "남");
		Student s2 = new Student("이제영", 2007012034, "여");
		
		//문제 3-3
		Student[] students = new Student[2];
		students[0] = s1;
		students[1] = s2;
	
		//문제 3-4
		for( int i=0; i<students.length; i++ ) {
			if( students[i].name.equals("이동준") ) {
				students[i].number = 2019038033;
			}
		}
		
		//문제 3-5
		for( int i=0; i<students.length; i++ ) {
			System.out.println(
					"이름 :" + students[i].name 
					+ ", 학번 : " + students[i].number
					+ ", 성별 : " + students[i].gender);
		}
	}
	

}
