package enhanced;

public class Enhanced1 {

	public static void main(String[] args) {

		int[] ar = {1, 2, 3, 4, 5};
		// for문
		for(int i = 0; i < ar.length; i++) {
			System.out.println(ar[i]);
		}
		System.out.println("----------------");
		// enhanced for문
		for(int e : ar) {
			System.out.println(e);
		}
		// for(요소 : 배열) {
		//     반복할 문장들
		// }
		
		System.out.println("----------------");
		
		int[] arr1 = {1, 2, 3, 4, 5};
		for(int e : arr1) {
			System.out.print(e + " ");
		}
		System.out.println();
		
		int sum = 0;
		for(int e : arr1) {
			sum += e;
		}
		System.out.println("총합 : " + sum);

	}

}
