package sumave;

public class SumAve {
	private int sum;
	private int ave;
	private int arr[];
	
	public int[] getArr() {
		return arr;
	}

	public void setArr(int[] arr) {
		this.arr = arr;
	}
	
	public SumAve(int[] arr) {
		super();
		this.arr = arr;
	}
	
	public int getSum() {
		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];
		}
		return sum;
	}
	
	public int getAve() {
		ave = sum/arr.length;
		return ave;
	}
	
	public void showResult() {
		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
		System.out.println("총점 : " + getSum());
		System.out.println("평균 : " + getAve());
	}
}
