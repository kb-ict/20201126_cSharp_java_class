package Problem1_2.Car;

public class Car {

	private final static String store = ("동대구 영업소");
	private String company;
	private String model;
	private String color;
	private String price;

	public String getCompany() {
		return company;
	}

	public void setCompany(String company) {
		this.company = company;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	
	public void showCarInfo() {
		System.out.println("모델: " + model);
		System.out.println("제조사: " + company);
		System.out.println("색상: " + color);
		System.out.println("가격: " + price);
		System.out.println("대리점: " + store);
	}
}
