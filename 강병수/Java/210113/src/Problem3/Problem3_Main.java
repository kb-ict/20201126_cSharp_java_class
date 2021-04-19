package Problem3;

public class Problem3_Main {

	public static void main(String[] args) {
		int arr[] = {10, 20, 30 ,40, 50, 60, 70, 80, 90, 100};
		
		ArrayHap hap = new ArrayHap(arr);
		System.out.println("배열의 합: " + hap.getSum());
		System.out.println("배열의 평균: " + hap.getAvr());//조건 5
	}

}

class ArrayHap {
	private int sum;
	private int avr; //조건 2
	
	public ArrayHap(int arr[]) {
		for (int i : arr) {
			sum += i; //향상된 반복문
		}
		avr = sum/arr.length;
//		System.out.println("배열의 합: " + sum);
//		System.out.println("배열의 평균: " + avr); 위의 조건 5 안쓰고 여기서 syso로 출력해도 가능
	}
	
	public int getSum() {
		return sum; //조건 3
	}
	public int getAvr() {
		return avr; //조건 4
	}
	
	
}