
public class Arr3 {

	public static void main(String[] args) {
		int score[] = { 10, 20, 30, 40, 50 }; 	 	 // 초기화 불가능 int score[nnn] = { 10, 20, 30, 40, 50 };  ★
		System.out.println("배열 시작위치: "+score); 	 // 배열의 메모리 주소값
		System.out.println("배열 크기: "+score.length); // 배열의 크기 : 5

		for (int i = 0; i < score.length; i++) { // score.length : 배열의 길이, 크기, 사이즈 = 5
			System.out.println(score[i]);
		}
	}
}
