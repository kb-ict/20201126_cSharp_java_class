package method_201230;

public class MethodPractice8 {

	public static void main(String[] args) {
		int arr[] = new int [8];
		func(arr);
	}
	public static void func(int arr[]) {
		for (int i = 0; i < 9; i++) {
			for (int j = 0; j < 8; j++) {
				if (j%2!=0) {
					System.out.printf("%dx%d=%d\t",(j+2),(i+1),((i+1)*(j+2)));
				}
			}System.out.println();
		}
	}

}
