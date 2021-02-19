
public class Temperature {

	public static void main(String[] args) {
		// 4. 온도 구하는 프로그램 
		int tempF;
		tempF = 40;
		
		String tempC;
		
		tempC = (String.format("%.2f",(tempF-32)/1.8));
		System.out.println("화씨"+tempF+"℉는 섭씨 "+tempC+"℃입니다.");
	}

}
