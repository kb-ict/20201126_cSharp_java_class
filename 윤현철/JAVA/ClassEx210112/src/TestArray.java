
public class TestArray { 
	private int sum;
	private int ave;
	
	public TestArray(int[] arr) {
		sum=0;
		ave=0;
		for (int i = 0; i < arr.length; i++) {
			sum=sum+arr[i];
		}
		ave=sum/arr.length;
	}
	public int getSum() {
		return sum;
	}
	public void setSum(int sum) {
		this.sum = sum;
	}
	public int getAve() {
		return ave;
	}
	public void setAve(int ave) {
		this.ave = ave;
	}
	public void Show() {
		System.out.printf("이 배열의 합은 %d이고 평균은 %d이다.",sum,ave);
	}
	
}
