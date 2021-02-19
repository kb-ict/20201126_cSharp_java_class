package method_20201230;

public class Method_practice6 {

	public static void main(String[] args) {

		System.out.println("---------------");
		System.out.println("로또 생성 프로그램");
		System.out.println("---------------");
		int lottonum[];
		lottonum = lotto();
		for (int i = 0; i < lottonum.length; i++) {
			System.out.print(lottonum[i] + " ");
		}

	}
	
	public static int[] lotto() {
		int arr[] = new int[6];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (int)(Math.random()*45)+1;
			for (int j = 0; j < i; j++) {
				if(arr[i] == arr[j]) {
					i--;
				}
			}
		}
		return arr;
		
	}

}
