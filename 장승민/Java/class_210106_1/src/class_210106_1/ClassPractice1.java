package class_210106_1;

public class ClassPractice1 {

	public static void main(String[] args) {
		Car c = new Car();
		System.out.println(Car.store);
		c.setMaker("현대");
		c.setColor("흰색");
		c.setModel("코나");
		c.showCarInfo();

		System.out.println();
		
		Car c1 = new Car();
		System.out.println(Car.store);
		c1.setMaker("대우");
		c1.setColor("황금");
		c1.setModel("마티즈");
		c1.showCarInfo();
	}

}
