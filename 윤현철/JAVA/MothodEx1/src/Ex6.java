
public class Ex6 {

	public static void main(String[] args) {
		int[] lot = lotto();
		for (int i = 0; i < 6; i++) {
			System.out.print(lot[i]+" ");
		}
	}
	public static int[] lotto() {
		int[] lotto = new int[6];
		for (int i = 0; i < lotto.length; i++) {
			lotto[i]=(int)((Math.random())*45)+1;
			for (int j = 0; j < i; j++) {
				if (lotto[j]==lotto[i]) {
					 i--;
					break;
				}
			}
		}
		return lotto;
	}
}
