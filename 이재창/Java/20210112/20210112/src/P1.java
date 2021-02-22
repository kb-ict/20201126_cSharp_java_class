public class P1 {

	public static void main(String[] args) {
		var car1 = new Car();
		car1.show();
		var car2 = new Car("현대", "파랑", "이천만원", "타요");
		car1.show();
		car2.show();
	}

}

class Car {
	final static String agency = "동대구 영업소";
	private String make;
	private String color;
	private String money;
	private String model;
	
	public Car() {
		make = "기아";
		color = "블랙";
		money = "사천만원";
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
		System.out.println("대리점 : " + agency);
		System.out.println("제조사 : " + make);
		System.out.println("색상 : " + color);
		System.out.println("가격 : " + money);
		System.out.println("모델명 : " + model);
	}
}
