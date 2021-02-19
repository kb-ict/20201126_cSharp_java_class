package silsupMunje.com.yjhcar.carApp2.customer;

import silsupMunje.com.yjhcar.carApp2.car.Car;

public class Customer {
	private String name;
	private String tell;
	private String address;
	
	private Car car;
	

	
	public void printCustomerInfo() {
		System.out.println("이름: "+name);
		System.out.println("폰번: "+tell);
		System.out.println("주소: "+address);
		car.printCarInfo();
//		System.out.println("-------------------------");
	}
	
	public Customer(String name, String tell, String address, Car car) {
	super();
	this.name = name;
	this.tell = tell;
	this.address = address;
	this.car = car;
	printCustomerInfo();
	
}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getTell() {
		return tell;
	}

	public void setTell(String tell) {
		this.tell = tell;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public Car getCar() {
		return car;
	}

	public void setCar(Car car) {
		this.car = car;
	}

	
	
	
}
