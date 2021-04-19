
public class CarDetail {
	
	private String name;
	private String price;
	private String country;
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPrice() {
		return price;
	}
	public void setPrice(String price) {
		this.price = price;
	}
	public String getCountry() {
		return country;
	}
	public void setCountry(String country) {
		this.country = country;
	}
	
	public void showCarInfo() {
		System.out.println("이름: " + name);
		System.out.println("가격: " + price);
		System.out.println("판매국가: " + country);
	}
}
