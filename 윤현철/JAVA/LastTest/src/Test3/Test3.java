package Test3;

public class Test3 {

	public static void main(String[] args) {
		String name[] = {"이동준","이재영"};
		int hackbun[] = {2009038033,2007012034};
		char gender[] = {'남','여'};
		Student st[] = new Student[2];
		for (int i = 0; i < 2; i++) {
			st[i] = new Student(name[i],hackbun[i],gender[i]);
		}
		st[1].setHackbun(2019038033);
		
		for (int i = 0; i < st.length; i++) {
			st[i].showstudentInfo();
		}
	}

}
