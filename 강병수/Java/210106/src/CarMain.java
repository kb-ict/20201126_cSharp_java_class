
public class CarMain {

	public static void main(String[] args) {
		
		CarDetail s = new CarDetail();
		s.setName("쏘나타 하이브리드 2020");
		s.setPrice("약 3000만원");
		s.setCountry("대한민국");
		s.showCarInfo();
		System.out.println("");
		
		CarDetail s2 = new CarDetail();
		s2.setName("벤틀리 컨티넬탈 3세대");
		s2.setPrice("약 2억 4000만원");
		s2.setCountry("영국");
		s2.showCarInfo();
		System.out.println("");
		
		CarDetail s3 = new CarDetail();
		s3.setName("포드 머스탱 6세대");
		s3.setPrice("약 5000만원");
		s3.setCountry("미국");
		s3.showCarInfo();
		System.out.println("");
		
		CarDetail s4 = new CarDetail();
		s4.setName("BMW Series3 7세대");
		s4.setPrice("약 8000만원");
		s4.setCountry("독일");
		s4.showCarInfo();
		System.out.println("");
	}

}
