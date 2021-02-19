
public class Car2 {
	private String modelName;
	private String price;
	
	public Car2() {
		modelName = "기본값";
		price = "00원";
		printFunc();
	}
	
	public Car2(String modelName, String price) {
		super();
		this.modelName = modelName;
		this.price = price;
	}
	
	

	public String getModelName() {
		return modelName;
	}

	public void setModelName(String modelName) {
		this.modelName = modelName;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	public void printFunc() {
		System.out.println("-----------------------");
		System.out.println("자동차 이름\t: "+modelName);
		System.out.println("가격\t: "+price);
	}
}
