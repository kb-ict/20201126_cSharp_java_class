package array;



public class Array2 {

	public static void main(String[] args) {
	
		Box[] ar = new Box[3];
		
		// 배열에 인스턴스 저장
		ar[0] = new Box("First");
		ar[1] = new Box("Second");
		ar[2] = new Box("Third");
		
		// 저장된 인스턴스 참조
		System.out.println(ar[0]);
		System.out.println(ar[1]);
		System.out.println(ar[2]);
		
		System.out.println("----------------------------");
		
		// 저장된 문자열을 참조하여 총 문자수를 계산
		String[] sr = new String[7];
		sr[0] = new String("Java");
		sr[1] = new String("System");
		sr[2] = new String("Compiler");
		sr[3] = new String("Park");
		sr[4] = new String("Tree");
		sr[5] = new String("Dinner");
		sr[6] = new String("Brunch Cafe");
		
		int cnum = 0;
		
		for(int i=0; i<sr.length;i++) {
			cnum += sr[i].length(); // String 인스턴스의 length 메소드 순차적 호출!
		}
		System.out.println("총 문자의 수 : " + cnum);
	}

}
