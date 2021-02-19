
public class ArrayMain {
	public static void main(String[] args) {
		int arr[] = { 10, 20, 30, 40, 50, 60, 70, 80, 100 };
		ArrayHap hap = new ArrayHap(arr);
		System.out.println("배열의 합 :" +hap.getSum());
		System.out.println("배열의 평균 :" + hap.getAvg());
	}

}

class ArrayHap {
	private int sum;
	private int avg;
	
	public ArrayHap(int arr[]) {
		for (int i : arr) {
			sum +=i;
		}
		avg = sum / arr.length;
//		System.out.println("배열의 합 :" +sum);
//		System.out.println("배열의 평균 :" + avg);
	}
	
	public int getSum() {
		return sum;
	}
	public int getAvg() {
		return avg;
	}

	
}