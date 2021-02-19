
public class Car {
	static final String JIJUM="동대구 영업소";
	private String model;
	private String company;
	private String color;
	private String price;
	
	public Car() {
		model = "K7";
		company = "기아";
		color = "블랙";
		price = "4천만원";
	}
	
	public Car(String model, String company, String color, String price) {
		this.model = model;
		this.company = company;
		this.color = color;
		this.price = price;
	}
	
	public void showCarInfo() {
		System.out.println("차량 영업소 :"+JIJUM);
		System.out.println("제조사 : "+ company);
		System.out.println("모델 : "+ model);
		System.out.println("가격 : "+ price);
		System.out.println("색상 : "+ color);
	}
	
}
