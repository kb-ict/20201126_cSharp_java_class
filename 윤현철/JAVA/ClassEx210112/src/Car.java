
public class Car {
	private String manufacturer;
	private String color;
	private String money;
	private String model;
	public static final String JIJUM = "동대구 영업소";
	
	public Car() {
		manufacturer = "기아";
		color = "블랙";
		money = "사천만원";
		model = "K7";
	}
	public Car(String model, String manufacturer, String color, String money) {
		this.manufacturer=manufacturer;
		this.color=color;
		this.money=money;
		this.model=model;
	}

	public String getManufacturer() {
		return manufacturer;
	}

	public void setManufacturer(String manufacturer) {
		this.manufacturer = manufacturer;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
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
	public void showCarInfo() {
		System.out.println("제조사	: " + manufacturer);
		System.out.println("색상	: " + color);
		System.out.println("가격	: " + money);
		System.out.println("모델명	: " + model);
		System.out.println("대리점명	: " + JIJUM);
		System.out.println("-----------------------------");
	}
}
