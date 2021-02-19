package class0106_3;

public class Main {

	public static void main(String[] args) {
		/*1. 자동차에 대한 클래스 작성하기.
		 * 조건1) 속성(멤버 변수) - 대리점명은 상수 클래스변수(static 변수)로 선언.
		 * 조건2) 속성(멤버 변수) - 제조사, 색상, 가격, 모델명은 인스턴스 변수로 선언.
		 * 조건3) 기본 생성자를 만들고 아래의 속성값들을 초기화 바람.
		 * 제조사 - "기아", 색상 - "블랙", 이름 - "K7"
		 * 가격 - "사천만원", 대리점명 - "동대구 영업소"
		 * 조건4) 모든 속성들을 매개변수로 전달하여 객체를 생성할수있는 생성자 추가.
		 * 조건5) 모든 속성 정보들을 출력하는 인스턴스 메쏘드(함수) 추가.
		*/
		
		Car c = new Car();
		c.setMade("기아");
		c.setColor("블랙");
		c.setModelName("K7");
		c.setPrice("사천만원");
		c.showCarInfo();

	}

}
