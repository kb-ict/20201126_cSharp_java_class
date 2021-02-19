package university_lessen_info;

public class Student {
	private String name;
	private String gender;
	private int age;
	private String job;
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getGender() {
		return gender;
	}
	public void setGender(String gender) {
		this.gender = gender;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getJob() {
		return job;
	}
	public void setJob(String job) {
		this.job = job;
	}
	
	public Student(String name, String gender, int age, String job) {
		super();
		this.name = name;
		this.gender = gender;
		this.age = age;
		this.job = job;
	}
	
	public void showStuInfo(int num) {
		System.out.println(0 + "" + num + "\t" + getName() + "\t" + getGender() + "\t" + getAge() + "\t" + getJob());
	}
	
}
