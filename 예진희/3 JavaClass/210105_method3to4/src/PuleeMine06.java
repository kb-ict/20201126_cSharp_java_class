
public class PuleeMine06 {

	public static void main(String[] args) {
		/*6. 간단한 로또 프로그램.
		 * 조건1) 동일한 숫자가 발생하지 않도록 처리 바람.
		 * (할수있는데까지 꼭 고민해보시고 힘들면 중복처리 무시!)
		 * 조건2) 메쏘드에서 로또 번호를 만들고 배열에 6개의 번호를 저장하여 리턴
		 * 조건3) main()에서 로또 번호가 들어있는 배열를 리턴받아서 출력하기
		 * - 메쏘드에서 로또 배열 출력하는것이 아님!
		*/

		int arr[] = lotto();

		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + "  ");
		}

	}

	public static int[] lotto() {
		int arr[] = new int[6];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (int) (Math.random() * 45) + 1;

			for (int j = 0; j < i; j++) {
				if (arr[j] == arr[i]) {
					// System.out.println("중복발생 : "+arr[i]);
					i--;
					break;
				}
			}
		}
		return arr;
	}

}
