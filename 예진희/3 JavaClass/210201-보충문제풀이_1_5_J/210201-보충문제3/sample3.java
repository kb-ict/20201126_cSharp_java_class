package kb311;

public class sample3 {
	
	public static void main(String[] args) {
		//���� 3-2
		Student s1 = new Student("�̵���", 2009038033, "��");
		Student s2 = new Student("������", 2007012034, "��");
		
		//���� 3-3
		Student[] students = new Student[2];
		students[0] = s1;
		students[1] = s2;
	
		//���� 3-4
		for( int i=0; i<students.length; i++ ) {
			if( students[i].name.equals("�̵���") ) {
				students[i].number = 2019038033;
			}
		}
		
		//���� 3-5
		for( int i=0; i<students.length; i++ ) {
			System.out.println(
					"�̸� :" + students[i].name 
					+ ", �й� : " + students[i].number
					+ ", ���� : " + students[i].gender);
		}
	}
	

}
