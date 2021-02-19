package method_20210105;

public class Method_practice6 {

	public static void main(String[] args) {

		int lotto[] = lotto();
		for (int i = 0; i < lotto.length; i++) {
			System.out.print(lotto[i] + " ");
		}

	}
	
	public static int[] lotto() {
		int arr[] = new int[6];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (int)(Math.random()*45)+1;
			for (int j = 0; j < i; j++) {
				if(arr[i] == arr[j])
					i--;
			}
		}
		return arr;
	}

}
