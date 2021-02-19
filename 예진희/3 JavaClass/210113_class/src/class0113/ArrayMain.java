package class0113;

public class ArrayMain {

	public static void main(String[] args) {
		// 문제 3
		int arr[] = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

		ArrayHap hap = new ArrayHap(arr);
		System.out.println("------------------------");
		System.out.println("배열의 합: " + hap.getSum());
		System.out.println("배열의 평균: " + hap.getAvg());
	}
}

// 1 메인안에 /2 파일별도 /3 이너클래스 = 한번쓰고 버림, 
class ArrayHap {
	private int sum;
	private int avg;

	public ArrayHap(int arr[]) {
		for (int i : arr) {
			sum += i;
		}
		avg = sum / arr.length;
		System.out.println("배열의 합: " + sum);
		System.out.println("배열의 평균: " + avg);
	}
	// 나중 활용될 수있으므로 보통 미리 만들어 놓음
	public int getSum() {
		return sum;
	}

	public int getAvg() {
		return avg;
	}
}