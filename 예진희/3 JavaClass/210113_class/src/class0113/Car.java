package class0113;

public class Car {
	// 문제 1번
	// 속성 or 변수 같은의미.., 상수변수는 대문자로, static = 클래스 변수 (하나만 생성됨 여러객체에서 공동사용, 메모리 영역 별개)
	// static = 클래스 메소드, 변수 / private = 인스턴스 메소드, 변수
	// 객체 생성시 사용하는 특수한 메소드();  생성자 = 정보 초기화
	public static final String JIJUM = "동대구 영업소";
	private String model;
	private String company;
	private String color;
	private String price;

	// void 없음. 여러번 호출 X, 생성시만 한번호출 가능
	// 오버로딩, 중복정의 (조건) 변수 개수, 변수 타입/Car()==Car(매개변수)
	public Car() {
		super(); // 상속개념. 오브젝트로 상속받는 Super = 부모클래스 / 부모의 위치값 == 최상위 Object
		model = "K7";
		company = "기아";
		color = "블랙";
		price = "사천만원";
	} // 기본생성자 사용시 초기값 결정.

	public Car(String model, String company, String color, String price) {
		super();
		this.model = model;
		this.company = company;
		this.color = color;
		this.price = price;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	// 인스턴스 메소드에서 클래스 변수 메소드 호출가능. 반대 불가능
	public void showCarInfo() {
//		System.out.println("차량 영업소: " + JIJUM); // ==Car.JIJUM
		//클래스.스태틱.메소드
		System.out.println("-------------------");
		System.out.println(Car.JIJUM);
		System.out.println("-------------------");
		System.out.println("제조사: " + company);
		System.out.println("모델: " + model);
		System.out.println("가격: " + price);
		System.out.println("색상: " + color);
		System.out.println("-------------------");

	}
}
