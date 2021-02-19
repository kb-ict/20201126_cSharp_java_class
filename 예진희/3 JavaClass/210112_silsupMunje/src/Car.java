
public class Car {

	static final String storeName = "저푸른 초원위에";
	
	private String jejosa;
	private String color;
	private String price;
	private String modelName;
	
	
	// 기본생성자
	public Car() {
		super();
	}



	// 생성자 추가
	public Car(String jejosa, String color, String modelName, String price) {
		super();
		this.jejosa = jejosa;
		this.color = color;
		this.price = price;
		this.modelName = modelName;
	}
	
	
	
	public String getJejosa() {
		return jejosa;
	}



	public void setJejosa(String jejosa) {
		this.jejosa = jejosa;
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



	public String getModelName() {
		return modelName;
	}



	public void setModelName(String modelName) {
		this.modelName = modelName;
	}



	public void showCarInfo() {
		System.out.printf("제조사 - %s / 색상 - %s / 이름 - %s \n",jejosa,color,modelName);
		System.out.printf("가격 - %s / 대리점명 - %s \n",price,storeName);
	}
	
}
