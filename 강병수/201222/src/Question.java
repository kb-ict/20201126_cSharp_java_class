import java.util.Scanner;

public class Question {
//백준 온라인 저지 - 달팽이는 올라가고 싶다 이해 안가는 문제
	public static void main(String[] args) {
		Scanner cs = new Scanner(System.in);
		int A = cs.nextInt(); //낮에 올라가는 시간 입력
		int B = cs.nextInt(); //밤에 미끄러지는 시간 입력
		int V = cs.nextInt(); //올라가야하는 막대의 높이 입력
		int day = ((V - B)/ (A - B)); //정상에 도착할때의 날인데 이 식이 왜 튀어나오는가??
		
		if ((V - B)%(A - B) != 0) { //밤에 미끄러지고 다음 날 낮이 되었을 때 정상에 도달할 경우
			day++;
		}
		 
		 System.out.println(day);
		 cs.close();
	}

}