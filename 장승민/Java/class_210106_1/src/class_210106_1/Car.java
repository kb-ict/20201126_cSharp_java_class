package class_210106_1;

public class Car {							//클래스 정의
	static String store = "승민 대리점";		//클래스 변수
										
	private String maker;					//인스턴스 변수 
	private String color;					//인스턴스 변수 	
	private String model;					//인스턴스 변수 
	
	public String getMaker() {				//인스턴스 메쏘드 getter
		return maker;
	}
	public void setMaker(String maker) {	//setter
		this.maker = maker;
	}
	public String getColor() {				//getter
		return color;
	}
	public void setColor(String color) {	//setter
		this.color = color;
	}
	public String getModel() {				//getter
		return model;
	}
	public void setModel(String model) {	//setter
		this.model = model;
	}
	
	public void showCarInfo() {				//인스턴스 메쏘드
		System.out.println("제조사 : " + maker);
		System.out.println("색상 : "+color);
		System.out.println("모델명 : "+model);
	}

}
