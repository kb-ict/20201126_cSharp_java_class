public class Var2 {
	public static void main(String[] args) {
	//변수 선언	
	String line;
	String title;
	String name;
	int age;
	char sex;
	float weight;
	double height;
	String Address;
	
	//변수 할당
	line = "───────────────────────";
	title = "  개인 신상 정보  ";
	name = "홍길동";
	age = 100;
	sex = '남';
	weight = 60.5f;
	height = 178.6;
	Address = "조선 한양 홍대감댁";
	
	//변수 출력
	System.out.println(line);
	System.out.println(title);
	System.out.println(line);
	System.out.println("1.이름: " + name);
	System.out.println("2.연령: " + age + "세");
	System.out.println("3.성별: " + sex);
	System.out.println("4.몸무게: " + weight + "Kg");
	System.out.println("5.키: " + height + "cm");
	System.out.println("6.주소: " + Address);
	System.out.println(line);
	}
}
