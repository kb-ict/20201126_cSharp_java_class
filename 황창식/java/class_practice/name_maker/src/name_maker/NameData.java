package name_maker;

public class NameData {
	private String names[] = new String[50];
	private String first[] = {"김", "박", "이", "최", "장"};
	private String mid[] = {"가", "나", "다", "라", "마"};
	private String last[] = {"바", "사", "아", "자", "차"};
		
	public void saveNames() {
		for (int i = 0; i < names.length; i++) {
			names[i] = first[(int)(Math.random()*5)] + mid[(int)(Math.random()*5)] + last[(int)(Math.random()*5)];
		}
	}
	
	public void showNames() {
		for (int i = 0; i < names.length; i++) {
			System.out.println(names[i]);
		}
	}
	
	public String[] getNames() {
		return names;
	}
	
}
