public class P1 {

	public static void main(String[] args) {
		var car1 = new Car();
		car1.show();
		var car2 = new Car("����", "�Ķ�", "��õ����", "Ÿ��");
		car1.show();
		car2.show();
	}

}

class Car {
	final static String agency = "���뱸 ������";
	private String make;
	private String color;
	private String money;
	private String model;
	
	public Car() {
		make = "���";
		color = "��";
		money = "��õ����";
		model = "K7";
	}	
	public Car(String make, String color, String money, String model) {
		this.make = make;
		this.color = color;
		this.money = money;
		this.model = model;
	}
	
	public String getMoney() {
		return money;
	}
	public void setMoney(String money) {
		this.money = money;
	}
	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	
	public void show() {
		System.out.println("�븮�� : " + agency);
		System.out.println("������ : " + make);
		System.out.println("���� : " + color);
		System.out.println("���� : " + money);
		System.out.println("�𵨸� : " + model);
	}
}
