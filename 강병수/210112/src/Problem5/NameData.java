package Problem5;

public class NameData {

	private String first[] = {"김", "이", "박", "최", "장"};
	private String mid[] = {"가", "나", "다", "라", "마"};
	private String last[] = {"바", "사", "아", "자", "차"};
	private String fullName[] = new String[50];
	
	public void insertName() {
		String Name = "";
		for(int i = 0; i<fullName.length; i++) {
			Name = first[(int)(Math.random()*5)] + mid[(int)(Math.random()*5)] + last[(int)(Math.random()*5)];
			fullName[i] = Name;
		}
	}
	
	public void showName() {
		for(int i = 0; i<fullName.length; i++) {
			System.out.println(fullName[i]);
		}
	}
}
