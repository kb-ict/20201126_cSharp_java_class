package silsupMunje.com.yjhcar.carApp2;

import java.util.Random;

import silsupMunje.com.yjhcar.carApp2.car.Car;
import silsupMunje.com.yjhcar.carApp2.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
		String tel[] = { "010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978", "010-7890-2134" };
		String address[] = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
		String model[] = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
		String color[] = { "블랙", "은색", "흰색", "회색", "빨강" };
		int year[] = { 2016, 2017, 2016, 2017, 2016 };
		String company[] = { "삼성르노", "현대", "현대", "기아", "현대" };

		Random r = new Random();

		
		
		Customer[] cs = new Customer[10];

		for (int i = 0; i < cs.length; i++) {
			System.out.println((i+1)+"번째------------------");
		cs[i] = new Customer(name[r.nextInt(name.length)], tel[r.nextInt(tel.length)], address[r.nextInt(address.length)],
				new Car(model[r.nextInt(model.length)], color[r.nextInt(color.length)], year[r.nextInt(year.length)],company[r.nextInt(company.length)]));
		
		System.out.println();
		}
		
		
	}

}
