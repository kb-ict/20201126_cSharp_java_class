
public class Problem2_Main {

	public static void main(String[] args) {
		Problem1_Car auto = new Problem1_Car(); //조건 1 기본 생성자를 사용하여 객체 생성

		auto.showCarInfo(); //조건 7
		
		Problem1_Car vehicle = new Problem1_Car("그랜저", "2800만원", "현대", "흰색"); //조건 6 매개변수 사용하여 객체 생성
		vehicle.showCarInfo(); //조건 8
	}

}
