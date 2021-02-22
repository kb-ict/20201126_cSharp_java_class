import java.util.Random;

public class NameData {
	private String[] first;
	private String[] mid;
	private String[] last;
	private String[] names;	
	
	public String[] getNames() {
		return names;
	}

	public NameData() {
		first = new String[] {"김", "박", "이", "최", "장"};
		mid = new String[] {"가", "나", "다", "라", "마"};
		last = new String[] {"바", "사", "아", "자", "차"};
		names = new String[50];
		makeName();
	}
	
	public void makeName() {
		Random rand = new Random();
		
		for (int i = 0; i < names.length; i++) {
			names[i] = first[rand.nextInt(5)];
			names[i] += mid[rand.nextInt(5)];
			names[i] += last[rand.nextInt(5)];
		}
	}
	
	public void show() {
		for (var name : names) {
			System.out.println(name);
		}
	}

}
