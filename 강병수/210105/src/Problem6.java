
public class Problem6 {

	public static int[] array() {
		int arr[] = new int[6];
		for (int i = 0; i < 6; i++) {
			arr[i] = (int) (Math.random() * 45) + 1;

			for (int j = 0; j < i; j++) {
				if (arr[i] == arr[j]) {
					i--;
					break;
				}
			}
		}
		return arr;
	}

	public static void main(String[] args) {
		int arr[] = array();
		for (int i = 0; i < arr.length; i++) {
			System.out.printf(arr[i] + "\t");
		}
	}

}
