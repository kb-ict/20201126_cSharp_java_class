
public class Myp3_TestArray {
	private int arr[];
	private int ave;
	private int total;


	public Myp3_TestArray(int[] arr) {
		calcTotal(arr);
		calcAve(arr);
		printFunc();
	}

	public int calcTotal(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			total += arr[i];
		}
		return total;
	}
	
	public int calcAve(int arr[]) {
		ave = total / arr.length;
		return ave;
	}

	public void printFunc() {
		System.out.println("합\t: "+total);
		System.out.println("평균\t: "+ave);
	}

	public int[] getArr() {
		return arr;
	}

	public void setArr(int[] arr) {
		this.arr = arr;
	}
	
	

	
}
