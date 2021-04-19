
public class Problem1_Car {

	public static final String STORE = "동대구 영업소"; //상수 클래스변수 선언
	private String model;
	private String price;
	private String company;
	private String color; //인스턴스 변수 선언
	
	//Source 탭에서 Generate Constructor using fields 클릭 후 모든 요소 체크 해제 후 확인
	//기본 생성자 만든거
	public Problem1_Car() {
		model = "K7";
		price = "3000만원";
		company = "기아";
		color = "블랙"; //이상 속성값 초기화
	}

	public Problem1_Car(String model, String price, String company, String color) {
		this.model = model;
		this.price = price;
		this.company = company;
		this.color = color; //모든 속성들을 매개변수로 전달, 객체 생성할 수 있는 생성자 추가
	}
	
	//문제 2번 조건 2,3,4,5 인스턴스 메소드 추가
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

	public void showCarInfo() {
		System.out.println("--------------------------");
		System.out.println(Problem1_Car.STORE);
		System.out.println("--------------------------");
		System.out.println("모델: " + model);
		System.out.println("제조사: " + company);
		System.out.println("색상: " + color);
		System.out.println("가격: " + price);
	}
	
}
