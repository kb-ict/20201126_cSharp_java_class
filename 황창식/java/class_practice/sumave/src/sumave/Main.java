package sumave;

public class Main {

	public static void main(String[] args) {

		int arr[] = {20, 34, 22, 14, 36, 23, 67, 25, 99, 88};
//		SumAve result = new SumAve(arr);
//		result.showResult();
		
		ArrayHap hap = new ArrayHap(arr);
		System.out.println("배열의 합 : " + hap.getSum());
		System.out.println("배열의 평균 : " + hap.getAvg());
		
		
	}
}

class ArrayHap{
	private int sum;
	private int avg;
	
	public ArrayHap(int arr[]) {
		for(int i : arr) {
			sum += i;
		}
		avg = sum / arr.length;
//		System.out.println("배열의 합 : " + sum);
//		System.out.println("배열의 평균 : " + avg);
	}
	
	public int getSum() {
		return sum;
	}
	
	public int getAvg() {
		return avg;
	}
	
}