import java.util.ArrayList;

import com.lg.carapp.car.Car;

public class Cl {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Car car1 = new Car();
		car1.setModel("그랜져 개조");
		car1.setYear(2020);
		car1.setMoney("3천만원");
		
		Car car2 = new Car("그랜저", 2021, "3천만원");
		car2.showCarInfo();
		
		/*
		 * Car[] cars = new Car[10];
		 * 
		 * for (int i = 0; i < cars.length; i++) { cars[i] = new Car(); }
		 */
		
		ArrayList<Car> arrList = new ArrayList<Car>();
		arrList.add(new Car("소나타", 2020, "2천만원"));
		arrList.add(new Car("SM7", 2021, "3천만원"));
		
		for (int i = 0; i < arrList.size(); i++) {
			arrList.get(i).showCarInfo();
		}
	}

}
