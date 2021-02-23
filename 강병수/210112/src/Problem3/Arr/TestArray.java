package Problem3.Arr;

public class TestArray {

	int sum;
	double avr;
	int[] arr;
	
	public TestArray(int[] arr)
	{
		this.arr = arr;
		Sum();
		Avr();
	}
	
	public void Sum()
	{
		for(int i = 0; i<arr.length; i++)
		{
			sum += arr[i];
		}
		System.out.println("합계: " + sum);
	}
	
	public void Avr()
	{
		avr = sum/10;
		System.out.println("평균: " + avr);
	}
}
