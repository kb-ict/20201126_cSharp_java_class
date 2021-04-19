
class Card {

	String kind;
	int number;
	static int width = 100;
	static int height = 80;
	
}

public class Practice5{
	public static void main(String args[]) {
		System.out.println("Card.width = " + Card.width);
		System.out.println("CArd.height = " + Card.height);
		
		Card c1 = new Card();
		c1.kind = "heart";
		c1.number = 6;
		
		Card c2 = new Card();
		c2.kind = "spade";
		c2.number = 10;
		
		System.out.println("c1은 " + c1.kind + ", " + c1.number + "이며, 크기는 (" + c1.width + ", " + c1.height + ")" );
        System.out.println("c2는 " + c2.kind + ", " + c2.number + "이며, 크기는 (" + c2.width + ", " + c2.height + ")" ); 
        System.out.println("c1,c2의 너비와 높이를 각각 10, 20으로 변경");
        
        c1.width =  10;
        c1.height = 20;
        
        System.out.println("c1은 " + c1.kind + ", " + c1.number + "이며, 크기는 (" + c1.width + ", " + c1.height + ")" );
        System.out.println("c2는 " + c2.kind + ", " + c2.number + "이며, 크기는 (" + c2.width + ", " + c2.height + ")" );
	}
}
