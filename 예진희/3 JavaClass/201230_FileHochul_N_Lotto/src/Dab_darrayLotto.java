
public class Dab_darrayLotto {

	public static void main(String[] args) {
		// exam 3
		// lotto[i] = (int) (Math.random() * 45) + 1;

		System.out.println("------------------------");
		System.out.println("간단한 로또 프로그램 v1.1");
		System.out.println("------------------------");

		int[] lottoArr = new int[6];

		for (int i = 0; i < 6; i++) {
			int lotto = (int) (Math.random() * 45) + 1;
			System.out.println("로또 번호: " + lotto);
			if (i == 0) {
				lottoArr[i] = lotto;
				// 비어 있는 배열에 번호 저장
			} else {
				lottoArr[i] = lotto;
				for (int j = 0; j < i; j++) {
					if (lottoArr[j] == lottoArr[i]) {
						System.out.println("중복 발생");
						i--;
						break;
					}
				}
			}
		}
		
		for (int i = 0; i < 6; i++) {
			System.out.print(lottoArr[i] + "  ");

		}

	}
}

//---------------------------- 답 -------------------------------------
//			if (i == 0) {
//				lottoArr[i] = lotto;
//			} else {
//				lottoArr[i] = lotto;
//				for (int j = 0; j < i; j++) {
//					if (lottoArr[j] == lottoArr[i]) {
//						System.out.println("중복 발생"); 
//						
//						i--;
//						break;
//					}
//				}
//		}
//	}
//}
//		}
//		for (int i = 0; i < lottoArr.length; i++) {
//			System.out.print(lottoArr[i] + "  ");

//--------------------------------------------------------------------